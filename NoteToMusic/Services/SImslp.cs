using NoteToMusic.Entities;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace NoteToMusic.Services
{
    /// <summary>
    /// IMSLP (International Music Score Library Project) API client
    /// Public domain klasik müzik notalarına erişim
    /// </summary>
    public static class SImslp
    {
        private const string API_BASE = "https://imslp.org/api.php";
        private static readonly HttpClient httpClient = new HttpClient();

        /// <summary>
        /// IMSLP'de nota araması yapar
        /// </summary>
        /// <param name="query">Arama terimi (besteci, eser adı vb.)</param>
        /// <returns>Bulunan notalar listesi</returns>
        public static async Task<List<SheetMusicInfo>> SearchSheetMusic(string query)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(query))
                    return new List<SheetMusicInfo>();

                // OpenSearch API kullan
                string url = $"{API_BASE}?action=opensearch&search={HttpUtility.UrlEncode(query)}&limit=50&format=json";
                
                var response = await httpClient.GetStringAsync(url);
                var json = JArray.Parse(response);

                List<SheetMusicInfo> results = new List<SheetMusicInfo>();

                // OpenSearch formatı: [query, [titles], [descriptions], [urls]]
                if (json.Count >= 4)
                {
                    var titles = json[1] as JArray;
                    var descriptions = json[2] as JArray;
                    var urls = json[3] as JArray;

                    if (titles != null && urls != null)
                    {
                        for (int i = 0; i < titles.Count; i++)
                        {
                            string title = titles[i]?.ToString() ?? "";
                            string url_link = urls[i]?.ToString() ?? "";
                            string desc = descriptions?[i]?.ToString() ?? "";

                            // Composer'ı title'dan çıkar (genelde "Composer - Title" formatında)
                            string composer = "Unknown";
                            string workTitle = title;
                            
                            if (title.Contains("-"))
                            {
                                var parts = title.Split(new[] { '-' }, 2);
                                composer = parts[0].Trim();
                                workTitle = parts[1].Trim();
                            }

                            results.Add(new SheetMusicInfo
                            {
                                Id = i.ToString(),
                                Title = workTitle,
                                Composer = composer,
                                ImageUrl = url_link, // IMSLP sayfası
                                PdfUrl = url_link,
                                Dpi = 300, // IMSLP genelde yüksek çözünürlük
                                Instrument = ExtractInstrument(desc),
                                Downloads = ExtractPopularity(desc)
                            });
                        }
                    }
                }

                return results;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"IMSLP Search Error: {ex.Message}");
                return new List<SheetMusicInfo>();
            }
        }

        /// <summary>
        /// Description'dan enstrüman bilgisini çıkarmaya çalışır
        /// </summary>
        private static string ExtractInstrument(string description)
        {
            string[] instruments = { "Piano", "Violin", "Cello", "Flute", "Orchestra", "Voice", "Guitar" };
            
            foreach (var instrument in instruments)
            {
                if (description.IndexOf(instrument, StringComparison.OrdinalIgnoreCase) >= 0)
                    return instrument;
            }
            
            return "Various";
        }

        /// <summary>
        /// Popülerlik skorunu tahmin eder (gerçek API'de desteklenirse kullanılabilir)
        /// </summary>
        private static int ExtractPopularity(string description)
        {
            // Şu an mock data, gerçek API'de downloads bilgisi varsa buradan alınabilir
            return new Random().Next(100, 10000);
        }

        /// <summary>
        /// IMSLP sayfasından direkt PDF linkini almaya çalışır
        /// Not: Bu scraping gerektirir, alternatif olarak kullanıcıyı IMSLP'ye yönlendirebiliriz
        /// </summary>
        public static async Task<string> GetDirectDownloadLink(string imslpPageUrl)
        {
            // Bu fonksiyon şu an placeholder
            // Gerçek implementasyonda IMSLP sayfasını parse edip PDF linkini bulmalıyız
            // Veya kullanıcıyı browser'a yönlendiririz
            return imslpPageUrl;
        }
    }
}
