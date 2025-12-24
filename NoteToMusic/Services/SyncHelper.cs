using NoteToMusic.Entities;
using NoteToMusic.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace NoteToMusic.Services
{
    /// <summary>
    /// Cloud sync helper - SQL Server'dan Supabase'e toplu sync
    /// </summary>
    public static class SyncHelper
    {
        /// <summary>
        /// SQL Server'daki tüm feedback'leri Supabase'e gönderir
        /// </summary>
        /// <returns>Sonuç mesajı</returns>
        public static async Task<string> SyncAllToCloud()
        {
            try
            {
                // SQL Server'dan tüm feedback'leri al
                DataTable localFeedbacks = SFeedback.GetAllFeedback();

                if (localFeedbacks == null || localFeedbacks.Rows.Count == 0)
                {
                    return "UYARI: Yerel veritabanında henüz feedback yok.";
                }

                int successCount = 0;
                int errorCount = 0;
                List<string> errors = new List<string>();

                foreach (DataRow row in localFeedbacks.Rows)
                {
                    try
                    {
                        Feedback feedback = new Feedback
                        {
                            Id = Convert.ToInt32(row["Id"]),
                            Username = row["Username"].ToString() ?? "",
                            PerformanceRating = Convert.ToInt32(row["PerformanceRating"]),
                            AccuracyRating = Convert.ToInt32(row["AccuracyRating"]),
                            FunctionalityRating = Convert.ToInt32(row["FunctionalityRating"]),
                            OverallRating = Convert.ToInt32(row["OverallRating"]),
                            Comments = row["Comments"].ToString() ?? "",
                            CreatedDate = Convert.ToDateTime(row["CreatedDate"])
                        };

                        string result = await SCloudSync.SyncFeedbackToCloud(feedback);
                        
                        if (string.IsNullOrEmpty(result))
                        {
                            successCount++;
                        }
                        else
                        {
                            errorCount++;
                            errors.Add($"ID {feedback.Id}: {result}");
                        }
                    }
                    catch (Exception ex)
                    {
                        errorCount++;
                        errors.Add($"Row error: {ex.Message}");
                    }
                }

                if (errorCount == 0)
                {
                    return $"BAŞARILI: {successCount} feedback Supabase'e gönderildi!";
                }
                else
                {
                    string errorMsg = string.Join("\n", errors.ToArray());
                    return $"Kısmen başarılı: {successCount} başarılı, {errorCount} hatalı.\n\nHatalar:\n{errorMsg}";
                }
            }
            catch (Exception ex)
            {
                return $"HATA: Sync işlemi başarısız. {ex.Message}";
            }
        }
    }
}
