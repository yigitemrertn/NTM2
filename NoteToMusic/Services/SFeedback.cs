using NoteToMusic.DataAccess;
using NoteToMusic.Entities;
using System;
using System.Data;
using System.Data.SqlClient;

namespace NoteToMusic.Services
{
    /// <summary>
    /// Feedback işlemlerini yöneten servis
    /// </summary>
    public static class SFeedback
    {
        /// <summary>
        /// Yeni bir feedback kaydı ekler
        /// </summary>
        /// <param name="feedback">Feedback entity</param>
        /// <returns>Başarılıysa boş string, hata varsa hata mesajı</returns>
        public static string InsertFeedback(Feedback feedback)
        {
            try
            {
                // Validation
                string validationError = feedback.Validate();
                if (!string.IsNullOrEmpty(validationError))
                {
                    return validationError;
                }

                // CreatedDate otomatik set et
                feedback.CreatedDate = DateTime.Now;

                // INSERT sorgusu
                string query = @"
                    INSERT INTO Feedback 
                    (Username, PerformanceRating, AccuracyRating, FunctionalityRating, OverallRating, Comments, CreatedDate)
                    VALUES 
                    (@Username, @PerformanceRating, @AccuracyRating, @FunctionalityRating, @OverallRating, @Comments, @CreatedDate)";

                // Parametreler
                SqlParameter[] parameters = new SqlParameter[]
                {
                    DMLManager.CreateParameter("@Username", feedback.Username),
                    DMLManager.CreateParameter("@PerformanceRating", feedback.PerformanceRating),
                    DMLManager.CreateParameter("@AccuracyRating", feedback.AccuracyRating),
                    DMLManager.CreateParameter("@FunctionalityRating", feedback.FunctionalityRating),
                    DMLManager.CreateParameter("@OverallRating", feedback.OverallRating),
                    DMLManager.CreateParameter("@Comments", feedback.Comments),
                    DMLManager.CreateParameter("@CreatedDate", feedback.CreatedDate)
                };

                int result = DMLManager.ExecuteNonQuery(query, parameters);

                if (result <= 0)
                {
                    return "HATA: Feedback kaydedilemedi.";
                }

                return "";
            }
            catch (Exception ex)
            {
                return $"HATA: Feedback kaydetme sırasında hata oluştu. {ex.Message}";
            }
        }

        /// <summary>
        /// Tüm feedbackleri getirir (opsiyonel - raporlama için)
        /// </summary>
        /// <returns>DataTable veya hata durumunda null</returns>
        public static DataTable GetAllFeedback()
        {
            try
            {
                string query = "SELECT * FROM Feedback ORDER BY CreatedDate DESC";
                return DMLManager.ExecuteReader(query);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
