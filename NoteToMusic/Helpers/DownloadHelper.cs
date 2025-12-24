using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace NoteToMusic.Helpers
{
    /// <summary>
    /// Dosya indirme ve doğrulama yardımcı sınıfı
    /// </summary>
    public static class DownloadHelper
    {
        private static readonly HttpClient httpClient = new HttpClient();

        /// <summary>
        /// Progress tracking ile dosya indirir
        /// </summary>
        /// <param name="url">İndirilecek dosyanın URL'si</param>
        /// <param name="savePath">Kaydedilecek dosya yolu</param>
        /// <param name="progress">Progress callback (0-100 arası)</param>
        /// <returns>Hata varsa mesaj, başarılıysa boş string</returns>
        public static async Task<string> DownloadFileWithProgress(
            string url, 
            string savePath, 
            IProgress<int>? progress = null)
        {
            try
            {
                // Directory oluştur
                string? directory = Path.GetDirectoryName(savePath);
                if (!string.IsNullOrEmpty(directory) && !Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }

                using (var response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
                {
                    response.EnsureSuccessStatusCode();

                    var totalBytes = response.Content.Headers.ContentLength ?? -1L;
                    var canReportProgress = totalBytes != -1 && progress != null;

                    using (var contentStream = await response.Content.ReadAsStreamAsync())
                    using (var fileStream = new FileStream(savePath, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
                    {
                        var buffer = new byte[8192];
                        long totalBytesRead = 0;
                        int bytesRead;

                        while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                        {
                            await fileStream.WriteAsync(buffer, 0, bytesRead);
                            totalBytesRead += bytesRead;

                            if (canReportProgress)
                            {
                                var progressPercentage = (int)((totalBytesRead * 100) / totalBytes);
                                progress?.Report(progressPercentage);
                            }
                        }
                    }
                }

                return ""; // Başarılı
            }
            catch (HttpRequestException ex)
            {
                return $"İndirme hatası: {ex.Message}";
            }
            catch (IOException ex)
            {
                return $"Dosya yazma hatası: {ex.Message}";
            }
            catch (Exception ex)
            {
                return $"Beklenmeyen hata: {ex.Message}";
            }
        }

        /// <summary>
        /// Dosya boyutunu okunabilir formata çevirir
        /// </summary>
        public static string FormatFileSize(long bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB" };
            double len = bytes;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }
            return $"{len:0.##} {sizes[order]}";
        }

        /// <summary>
        /// Dosyanın var olup olmadığını kontrol eder
        /// </summary>
        public static bool FileExists(string path)
        {
            return File.Exists(path);
        }
    }
}
