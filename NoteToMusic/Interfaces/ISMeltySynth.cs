using System.Threading.Tasks;

namespace NoteToMusic.Interfaces
{
    /// <summary>
    /// MeltySynth işlemleri için arayüz tanımı.
    /// </summary>
    public interface ISMeltySynth
    {
        /// <summary>
        /// MIDI dosyasını verilen SoundFont ile WAV formatına dönüştürür.
        /// </summary>
        /// <param name="midiPath">MIDI dosyasının yolu</param>
        /// <param name="soundFontPath">SF2 dosyasının yolu</param>
        /// <returns>Oluşturulan WAV dosyasının yolu veya hata mesajı</returns>
        Task<string> ConvertMidiToWav(string midiPath, string soundFontPath);
    }
}
