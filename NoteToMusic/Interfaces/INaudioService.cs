using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NoteToMusic.Interfaces
{
    /// <summary>
    /// Naudio işlemleri için arayüz tanımı.
    /// </summary>
    public interface INaudioService
    {
        Task ConvertXmlToMidiAsync(string inputXmlPath, string outputMidiPath, int bpm);
        string GetMidPath(string currentImage);
    }
}
