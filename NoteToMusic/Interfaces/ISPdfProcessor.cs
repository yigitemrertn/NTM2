using System.Collections.Generic;
using System.Threading.Tasks;

namespace NoteToMusic.Interfaces
{
    /// <summary>
    /// Created by: Yiğit Emre ERTEN
    /// Date: 25.12.2024
    /// Description: PDF işleme operasyonları için interface
    /// </summary>
    public interface ISPdfProcessor
    {
        /// <summary>
        /// PDF dosyasındaki toplam sayfa sayısını döner
        /// </summary>
        /// <param name="pdfPath">PDF dosyasının tam yolu</param>
        /// <returns>Sayfa sayısı</returns>
        int GetPageCount(string pdfPath);

        /// <summary>
        /// PDF'in belirtilen sayfasını PNG görsel dosyasına dönüştürür
        /// </summary>
        /// <param name="pdfPath">PDF dosyasının tam yolu</param>
        /// <param name="pageNumber">Sayfa numarası (1-indexed)</param>
        /// <returns>Oluşturulan PNG dosyasının yolu</returns>
        Task<string> ConvertPageToImageAsync(string pdfPath, int pageNumber);

        /// <summary>
        /// PDF'in tüm sayfalarını PNG görsel dosyalarına dönüştürür
        /// </summary>
        /// <param name="pdfPath">PDF dosyasının tam yolu</param>
        /// <returns>Oluşturulan PNG dosyalarının yol listesi</returns>
        Task<List<string>> ConvertAllPagesToImagesAsync(string pdfPath);

        /// <summary>
        /// PDF'in seçilen sayfalarını PNG görsel dosyalarına dönüştürür
        /// </summary>
        /// <param name="pdfPath">PDF dosyasının tam yolu</param>
        /// <param name="pageNumbers">Dönüştürülecek sayfa numaraları (1-indexed)</param>
        /// <returns>Oluşturulan PNG dosyalarının yol listesi</returns>
        Task<List<string>> ConvertSelectedPagesToImagesAsync(string pdfPath, List<int> pageNumbers);
    }
}
