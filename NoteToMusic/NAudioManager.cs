using NAudio;
using NAudio.Midi;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NoteToMusic
{
    public class NAudioManager
    {
        public async Task ConvertXmlToMidi(string inputXmlPath, string outputMidiPath, int bpm)
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
                    int divisions = 24; // Default
                    var divNode = part.Descendants("divisions").FirstOrDefault();
                    if (divNode != null) int.TryParse(divNode.Value, out divisions);

                    long currentTick = 0; // Şarkının başından beri geçen süre

                    foreach (var measure in part.Elements("measure"))
                    {
                        long measureStartTick = currentTick; // Ölçü başlangıç noktası
                        long cursor = 0; // Ölçü içindeki bağıl süre
                        long lastNoteStart = 0; // Akorlar için hafıza

                        foreach (var element in measure.Elements())
                        {
                            string name = element.Name.LocalName;

                            if (name == "note")
                            {
                                bool isRest = element.Element("rest") != null;
                                bool isChord = element.Element("chord") != null;

                                // Süre Hesaplama
                                int durVal = int.Parse(element.Element("duration")?.Value ?? "0");
                                long midiDur = (long)((double)durVal / divisions * ticksPerQuarter);

                                // Nota Zamanlaması
                                long noteOnTime;
                                if (isChord)
                                {
                                    // Akorsa, bir önceki notanın başladığı yerde başlar
                                    noteOnTime = measureStartTick + lastNoteStart;
                                    // Akorlar genelde cursor'u ilerletmez (ana nota ilerletmiştir)
                                    // Ama MusicXML'de bazen akor notalarının da duration'ı vardır.
                                    // En güvenli yöntem: Chord ise cursor'a dokunma.
                                }
                                else
                                {
                                    // Akor değilse, cursor'un olduğu yerde başlar
                                    noteOnTime = measureStartTick + cursor;
                                    lastNoteStart = cursor; // Hafızaya al
                                    cursor += midiDur; // Cursor'u ilerlet
                                }

                                if (!isRest)
                                {
                                    // Nota Değerleri
                                    var pitch = element.Element("pitch");
                                    if (pitch != null)
                                    {
                                        int noteNum = GetMidiNote(pitch);
                                        int staff = element.Element("staff") != null ? int.Parse(element.Element("staff").Value) : 1;
                                        int velocity = (staff == 1) ? 95 : 85;

                                        midiEvents.AddEvent(new NoteOnEvent(noteOnTime, 1, noteNum, velocity, (int)midiDur), 0);
                                        midiEvents.AddEvent(new NoteEvent(noteOnTime + midiDur, 1, MidiCommandCode.NoteOff, noteNum, 0), 0);
                                    }
                                }
                                else
                                {
                                    // Es (Rest) ise sadece cursor zaten ilerledi, extra işlem yok
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
                                // İleri Sarma
                                int durVal = int.Parse(element.Element("duration")?.Value ?? "0");
                                long fwdMidi = (long)((double)durVal / divisions * ticksPerQuarter);
                                cursor += fwdMidi;
                            }
                        }

                        // Ölçü bittiğinde, currentTick'i ölçü içinde gidilen EN SON noktaya taşı
                        // (Genelde cursor ölçü sonundadır ama backup varsa dikkat etmek lazım)
                        // MusicXML sıralı olduğu için, ölçü bittiğinde cursor nerede kaldıysa oradan devam etmeyiz.
                        // Genelde divisions * beats kadar artar.
                        // Ama pratik olarak: Cursor'un son hali o ölçünün bittiği yerdir (backup'lar sıfırlanmışsa).

                        // EĞER backup ile başa dönüp ikinci sesi yazdıysak cursor yine sonda olmalı.
                        // Basitçe: currentTick += (measure duration).
                        // Ama measure duration XML'de yazmaz.
                        // O yüzden en güvenlisi:
                        // cursor değeri ölçü sonunda neyse onu ekle.
                        currentTick = measureStartTick + cursor;
                    }
                }

                midiEvents.PrepareForExport();
                MidiFile.Export(outputMidiPath, midiEvents);
            });
            
        }

        // Nota harfini MIDI numarasına çeviren yardımcı fonksiyon
        private int GetMidiNote(XElement pitch)
        {
            string step = pitch.Element("step")?.Value;
            int octave = int.Parse(pitch.Element("octave")?.Value);
            int alter = pitch.Element("alter") != null ? int.Parse(pitch.Element("alter").Value) : 0;

            int baseN = 0;
            switch (step) { case "C": baseN = 0; break; case "D": baseN = 2; break; case "E": baseN = 4; break; case "F": baseN = 5; break; case "G": baseN = 7; break; case "A": baseN = 9; break; case "B": baseN = 11; break; }
            return ((octave + 1) * 12) + baseN + alter;
        }

        public string getMidPath(string currentImage)
        {
            return Path.Combine(FileManager.tempDir, Path.GetFileNameWithoutExtension(currentImage) + ".mid");
        }
    }
}
