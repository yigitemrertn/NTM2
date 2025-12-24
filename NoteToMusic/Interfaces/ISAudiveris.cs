using System.Threading.Tasks;

namespace NoteToMusic.Interfaces
{
    /// <summary>
    /// Audiveris işlemleri için arayüz tanımı.
    /// </summary>
    public interface ISAudiveris
    {
        /// <summary>
        /// Görüntü dosyasını MusicXML formatına dönüştürür.
        /// </summary>
        /// <param name="imagePath">Görüntü dosyasının yolu</param>
        /// <returns>Oluşturulan XML dosyasının yolu veya hata mesajı</returns>
        Task<string> ConvertImageToMusicXmlAsync(string imagePath);
    }
}
