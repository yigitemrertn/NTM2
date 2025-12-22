using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteToMusic.Interfaces
{
    /// <summary>
    /// MetlySynth işlemleri için arayüz tanımı.
    /// </summary>
    public interface IMeltySynthService
    {
        Task ConvertMidiToWav(string midiPath, string soundFontPath);
        string GetWavPath();
    }
}
