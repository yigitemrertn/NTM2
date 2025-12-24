using System.Threading.Tasks;

namespace NoteToMusic.Interfaces
{
    /// <summary>
    /// Naudio işlemleri için arayüz tanımı.
    /// </summary>
    public interface ISNaudio
    {
        /// <summary>
        /// XML dosyasını MIDI formatına dönüştürür.
        /// </summary>
        /// <param name="inputXmlPath">Giriş XML dosyasının yolu</param>
        /// <param name="outputMidiPath">Çıkış MIDI dosyasının yolu</param>
        /// <param name="bpm">BPM değeri</param>
        /// <returns>Oluşturulan MIDI dosyasının yolu veya hata mesajı</returns>
        Task<string> ConvertXmlToMidiAsync(string inputXmlPath, string outputMidiPath, int bpm);
    }
}
