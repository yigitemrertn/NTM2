using NAudio;
using NAudio.Midi;
using NoteToMusic.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NoteToMusic.Services
{
    /*
     * Created by: Yiðit Emre ERTEN
     * Date: 20.12.2025
     * Description: MIDI iþlemlerini yöneten servis.
     */

    public class NaudioService : INaudioService
    {
        /// <summary>
        /// XML dosyasýný MIDI dosyasýna dönüþtürür
        /// </summary>
        /// <param name="inputXmlPath">XML dosyasýnýn yolu</param>
        /// <param name="outputMidiPath">MIDI dosyasýnýn yazýlcaðý konum</param>
        /// <param name="bpm">Tempo</param>
        

        public async Task ConvertXmlToMidiAsync(string inputXmlPath, string outputMidiPath, int bpm)
        {
            await Task.Run(() => {
                var doc = XDocument.Load(inputXmlPath);
                int ticksPerQuarter = 480;
                var midiEvents = new MidiEventCollection(1, ticksPerQuarter);

                // Tempo
                if (bpm == 0)
                {
                    midiEvents.AddEvent(new TempoEvent(60000000 / 90, 0), 0);
                }
                else
                {
                    midiEvents.AddEvent(new TempoEvent(60000000 / bpm, 0), 0);
                }

                foreach (var part in doc.Descendants("part"))
                {
                    int divisions = 24;
                    var divNode = part.Descendants("divisions").FirstOrDefault();
                    if (divNode != null) int.TryParse(divNode.Value, out divisions);

                    long currentTick = 0;

                    foreach (var measure in part.Elements("measure"))
                    {
                        long measureStartTick = currentTick;
                        long cursor = 0; 
                        long lastNoteStart = 0;

                        foreach (var element in measure.Elements())
                        {
                            string name = element.Name.LocalName;

                            if (name == "note")
                            {
                                bool isRest = element.Element("rest") != null;
                                bool isChord = element.Element("chord") != null;
                             
                                int durVal = int.Parse(element.Element("duration")?.Value ?? "0");
                                long midiDur = (long)((double)durVal / divisions * ticksPerQuarter);
                      
                                long noteOnTime;
                                if (isChord)
                                {
                                    noteOnTime = measureStartTick + lastNoteStart;
                                }
                                else
                                {
                                    noteOnTime = measureStartTick + cursor;
                                    lastNoteStart = cursor;
                                    cursor += midiDur;
                                }

                                if (!isRest)
                                {
                                    var pitch = element.Element("pitch");
                                    if (pitch != null)
                                    {
                                        int noteNum = GetMidiNote(pitch);
                                        int staff = element.Element("staff") != null ? int.Parse(element.Element("staff")?.Value ?? "") : 1;
                                        int velocity = (staff == 1) ? 95 : 85;

                                        midiEvents.AddEvent(new NoteOnEvent(noteOnTime, 1, noteNum, velocity, (int)midiDur), 0);
                                        midiEvents.AddEvent(new NoteEvent(noteOnTime + midiDur, 1, MidiCommandCode.NoteOff, noteNum, 0), 0);
                                    }
                                }
                                else
                                {
                                }
                            }
                            else if (name == "backup")
                            {
                                // Geri Sarma
                                int durVal = int.Parse(element.Element("duration")?.Value ?? "0");
                                long backMidi = (long)((double)durVal / divisions * ticksPerQuarter);
                                cursor -= backMidi;
                            }
                            else if (name == "forward")
                            {
                                // Ýleri Sarma
                                int durVal = int.Parse(element.Element("duration")?.Value ?? "0");
                                long fwdMidi = (long)((double)durVal / divisions * ticksPerQuarter);
                                cursor += fwdMidi;
                            }
                        }

                        currentTick = measureStartTick + cursor;
                    }
                }

                midiEvents.PrepareForExport();
                MidiFile.Export(outputMidiPath, midiEvents);
            });
            
        }

        /// <summary>
        /// Nota harfini MIDI numarasýna çeviren yardýmcý fonksiyon
        /// </summary>
        /// <param name="pitch"></param>
        /// <returns>Güncel okunan bölüm.</returns>
        private int GetMidiNote(XElement pitch)
        {
            string step = pitch.Element("step")?.Value ?? "";
            int octave = int.Parse(pitch.Element("octave")?.Value ?? "");
            int alter = pitch.Element("alter") != null ? int.Parse(pitch.Element("alter")?.Value ?? "") : 0;

            int baseN = 0;
            switch (step) { case "C": baseN = 0; break; case "D": baseN = 2; break; case "E": baseN = 4; break; case "F": baseN = 5; break; case "G": baseN = 7; break; case "A": baseN = 9; break; case "B": baseN = 11; break; }
            return ((octave + 1) * 12) + baseN + alter;
        }

        /// <summary>
        /// Midi dosyasýnýn geçici yolunu döner
        /// </summary>
        /// <param name="currentImage"></param>
        /// <returns>Midi dosyasýnýn yolu</returns>
        public string GetMidPath(string currentImage)
        {
            return Path.Combine(FileService.tempDir, Path.GetFileNameWithoutExtension(currentImage) + ".mid");
        }
    }
}
