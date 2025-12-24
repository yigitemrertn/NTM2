using MeltySynth;
using NAudio.Wave;
using NoteToMusic.Interfaces;
using NoteToMusic.Services;
using System;
using System.IO;
using System.Threading.Tasks;

namespace NoteToMusic.Services
{
    /// <summary>
    /// Created by: Yiğit Emre ERTEN
    /// Date: 20.12.2025
    /// Description: MeltySynth işlemlerini yöneten servis. MIDI + SF2 dosyalarını WAV formatına dönüştürür.
    /// </summary>
    public class SMeltySynth : ISMeltySynth
    {
        /// <summary>
        /// MIDI dosyasını verilen SoundFont ile WAV formatına dönüştürür.
        /// </summary>
        /// <param name="midiPath">MIDI dosyasının yolu</param>
        /// <param name="soundFontPath">SF2 dosyasının yolu</param>
        /// <returns>Oluşturulan WAV dosyasının yolu veya hata mesajı</returns>
        public async Task<string> ConvertMidiToWav(string midiPath, string soundFontPath)
        {
            try
            {
                return await Task.Run(() =>
                {
                    string fileName = Path.GetFileNameWithoutExtension(midiPath);
                    string sfName = Path.GetFileNameWithoutExtension(soundFontPath);
                    string outputWavPath = Path.Combine(SFile.musicDir, $"{fileName}({sfName}).wav");
                    int sampleRate = 44100;

                    var synthesizer = new Synthesizer(soundFontPath, sampleRate);
                    var midiFile = new MeltySynth.MidiFile(midiPath);
                    var sequencer = new MidiFileSequencer(synthesizer);
                    sequencer.Play(midiFile, false);

                    TimeSpan duration = midiFile.Length;
                    long totalSamplesToRender = (long)(duration.TotalSeconds * sampleRate) + sampleRate;
                    long samplesRendered = 0;

                    using (var writer = new WaveFileWriter(outputWavPath, new WaveFormat(sampleRate, 16, 2)))
                    {
                        float[] leftBuffer = new float[sampleRate];
                        float[] rightBuffer = new float[sampleRate];

                        while (samplesRendered < totalSamplesToRender)
                        {
                            sequencer.Render(leftBuffer, rightBuffer);

                            for (int i = 0; i < leftBuffer.Length; i++)
                            {
                                writer.WriteSample(leftBuffer[i]);
                                writer.WriteSample(rightBuffer[i]);
                            }

                            samplesRendered += leftBuffer.Length;
                        }
                    }

                    return outputWavPath;
                });
            }
            catch (Exception ex)
            {
                return $"HATA: MIDI -> WAV dönüştürme sırasında hata oluştu. {ex.Message}";
            }
        }
    }
}
