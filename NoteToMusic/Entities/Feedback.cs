using System;

namespace NoteToMusic.Entities
{
    /// <summary>
    /// Kullanıcı geri bildirim verilerini tutan entity sınıfı
    /// </summary>
    public class Feedback
    {
        public int Id { get; set; }
        public string Username { get; set; } = "";
        public int PerformanceRating { get; set; }
        public int AccuracyRating { get; set; }
        public int FunctionalityRating { get; set; }
        public int OverallRating { get; set; }
        public string Comments { get; set; } = "";
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Feedback verilerinin geçerliliğini kontrol eder
        /// </summary>
        /// <returns>Geçerliyse boş string, değilse hata mesajı</returns>
        public string Validate()
        {
            if (string.IsNullOrWhiteSpace(Username))
                return "HATA: Kullanıcı adı boş olamaz.";

            if (PerformanceRating < 0 || PerformanceRating > 5)
                return "HATA: Performans puanı 0-5 arasında olmalıdır.";

            if (AccuracyRating < 0 || AccuracyRating > 5)
                return "HATA: Doğruluk puanı 0-5 arasında olmalıdır.";

            if (FunctionalityRating < 0 || FunctionalityRating > 5)
                return "HATA: İşlev puanı 0-5 arasında olmalıdır.";

            if (OverallRating < 0 || OverallRating > 5)
                return "HATA: Genel puan 0-5 arasında olmalıdır.";

            return "";
        }
    }
}
