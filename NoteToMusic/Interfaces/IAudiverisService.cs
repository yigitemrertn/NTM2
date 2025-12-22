using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteToMusic.Interfaces
{
    /// <summary>
    /// Audiveris iþlemleri için arayüz tanýmý.
    /// </summary>
    public interface IAudiverisService
    {
        Task ConvertToMxlAsync(string imagePath);
        Task ConvertToXmlAsync(string mxlFile);
        string GetMxlPath(string imagePath);
        string GetXmlPath(string imagePath);
    }
}
