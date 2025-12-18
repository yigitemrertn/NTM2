using MeltySynth;
using NAudio.Wave;
using System;
using System.IO;
using System.Threading.Tasks;

namespace NoteToMusic
{
    public class SoundRenderer
    {
        private string outputWavPath;
        public async Task ConvertMidiToWav(string midiPath, string soundFontPath)
        {
            await Task.Run(() =>
            {
                string fileName = Path.GetFileNameWithoutExtension(midiPath);
                string sfName = Path.GetFileNameWithoutExtension(soundFontPath);
                outputWavPath = Path.Combine(FileManager.musicDir, $"{fileName}({sfName})");
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
            });
        }

        public string GetWavPath(){
            return outputWavPath;
        }
    }
}