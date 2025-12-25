using NoteToMusic.Interfaces;
using NoteToMusic.Services;
using PDFtoImage;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace NoteToMusic.Services
{
    /// <summary>
    /// Created by: Yiğit Emre ERTEN
    /// Date: 25.12.2024
    /// Description: PDF sayfalarını görsel dosyalara dönüştürme servisi
    /// </summary>
    public class SPdfProcessor : ISPdfProcessor
    {
        private const int DPI = 300; // Yüksek kaliteli nota tanıma için 300 DPI

        /// <summary>
        /// PDF dosyasındaki toplam sayfa sayısını döner
        /// </summary>
        public int GetPageCount(string pdfPath)
        {
            try
            {
                if (!File.Exists(pdfPath))
                {
                    throw new FileNotFoundException("PDF dosyası bulunamadı.", pdfPath);
                }

                using (var stream = File.OpenRead(pdfPath))
                {
                    return Conversion.GetPageCount(stream);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"PDF sayfa sayısı alınırken hata oluştu: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// PDF'in belirtilen sayfasını PNG görsel dosyasına dönüştürür
        /// </summary>
        public async Task<string> ConvertPageToImageAsync(string pdfPath, int pageNumber)
        {
            return await Task.Run(() =>
            {
                try
                {
                    if (!File.Exists(pdfPath))
                    {
                        throw new FileNotFoundException("PDF dosyası bulunamadı.", pdfPath);
                    }

                    // Dosya adını temizle - geçersiz karakterleri kaldır
                    string pdfFileName = Path.GetFileNameWithoutExtension(pdfPath);
                    pdfFileName = string.Join("_", pdfFileName.Split(Path.GetInvalidFileNameChars()));
                    pdfFileName = pdfFileName.Replace(" ", "_"); // Boşlukları da temizle
                    
                    string outputPath = Path.Combine(SFile.tempDir, $"{pdfFileName}_page_{pageNumber}.png");

                    // Eğer dosya zaten varsa sil
                    if (File.Exists(outputPath))
                    {
                        File.Delete(outputPath);
                    }

                    // PDFtoImage kullanarak sayfayı PNG'ye dönüştür
                    // pageNumber - 1 çünkü kütüphane 0-indexed kullanıyor 
                    using (var bitmap = Conversion.ToImage(pdfPath, page: pageNumber - 1))
                    {
                        using (var image = SKImage.FromBitmap(bitmap))
                        using (var data = image.Encode(SKEncodedImageFormat.Png, 100))
                        using (var stream = File.OpenWrite(outputPath))
                        {
                            data.SaveTo(stream);
                        }
                    }

                    return outputPath;
                }
                catch (Exception ex)
                {
                    throw new Exception($"PDF sayfa {pageNumber} dönüştürülürken hata oluştu: {ex.Message}", ex);
                }
            });
        }

        /// <summary>
        /// PDF'in tüm sayfalarını PNG görsel dosyalarına dönüştürür
        /// </summary>
        public async Task<List<string>> ConvertAllPagesToImagesAsync(string pdfPath)
        {
            var imagePaths = new List<string>();

            try
            {
                if (!File.Exists(pdfPath))
                {
                    throw new FileNotFoundException("PDF dosyası bulunamadı.", pdfPath);
                }

                int pageCount = GetPageCount(pdfPath);

                for (int i = 1; i <= pageCount; i++)
                {
                    string imagePath = await ConvertPageToImageAsync(pdfPath, i);
                    imagePaths.Add(imagePath);
                }

                return imagePaths;
            }
            catch (Exception ex)
            {
                // Hata durumunda oluşturulmuş dosyaları temizle
                foreach (var path in imagePaths)
                {
                    try
                    {
                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                    }
                    catch { /* Temizlik hatası görmezden gel */ }
                }

                throw new Exception($"PDF sayfaları dönüştürülürken hata oluştu: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// PDF'in seçilen sayfalarını PNG görsel dosyalarına dönüştürür
        /// </summary>
        public async Task<List<string>> ConvertSelectedPagesToImagesAsync(string pdfPath, List<int> pageNumbers)
        {
            var imagePaths = new List<string>();

            try
            {
                if (!File.Exists(pdfPath))
                {
                    throw new FileNotFoundException("PDF dosyası bulunamadı.", pdfPath);
                }

                if (pageNumbers == null || pageNumbers.Count == 0)
                {
                    throw new ArgumentException("En az bir sayfa seçilmelidir.", nameof(pageNumbers));
                }

                int pageCount = GetPageCount(pdfPath);

                foreach (int pageNumber in pageNumbers)
                {
                    if (pageNumber < 1 || pageNumber > pageCount)
                    {
                        throw new ArgumentOutOfRangeException(nameof(pageNumbers), 
                            $"Sayfa numarası {pageNumber} geçersiz. 1-{pageCount} arasında olmalıdır.");
                    }

                    string imagePath = await ConvertPageToImageAsync(pdfPath, pageNumber);
                    imagePaths.Add(imagePath);
                }

                return imagePaths;
            }
            catch (Exception ex)
            {
                // Hata durumunda oluşturulmuş dosyaları temizle
                foreach (var path in imagePaths)
                {
                    try
                    {
                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                    }
                    catch { /* Temizlik hatası görmezden gel */ }
                }

                throw new Exception($"Seçili sayfalar dönüştürülürken hata oluştu: {ex.Message}", ex);
            }
        }
    }
}
