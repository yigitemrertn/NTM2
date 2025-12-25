using System;
using System.Collections.Generic;
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

        /// <summary>
        /// Birden fazla görüntü dosyasını sırayla MusicXML formatına dönüştürür
        /// </summary>
        /// <param name="imagePaths">Görüntü dosyalarının yol listesi</param>
        /// <param name="progress">İlerleme raporlama için (opsiyonel)</param>
        /// <returns>Oluşturulan XML dosyalarının yol listesi</returns>
        Task<List<string>> ConvertMultipleImagesToMusicXmlAsync(List<string> imagePaths, IProgress<int> progress = null);
    }
}
