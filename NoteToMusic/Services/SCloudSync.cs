using NoteToMusic.Entities;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace NoteToMusic.Services
{
    /// <summary>
    /// Cloud senkronizasyon servisi
    /// </summary>
    public static class SCloudSync
    {
        /// <summary>
        /// Feedback'i cloud'a senkronize eder
        /// </summary>
        /// <param name="feedback">Feedback entity</param>
        /// <returns>Başarılıysa boş string, hata varsa hata mesajı</returns>
        public static async Task<string> SyncFeedbackToCloud(Feedback feedback)
        {
            // İnternet bağlantısı kontrolü
            if (!IsOnline())
            {
                return "UYARI: İnternet bağlantısı yok. Feedback LocalDB'ye kaydedildi ancak cloud'a sync edilemedi.";
            }

            try
            {
                string result = await SupabaseClient.PostFeedback(feedback);
                return result;
            }
            catch (Exception ex)
            {
                return $"HATA: Cloud sync işlemi başarısız. {ex.Message}";
            }
        }

        /// <summary>
        /// Admin panel için: Supabase'den tüm feedback'leri getirir
        /// </summary>
        /// <returns>Feedback listesi veya null</returns>
        public static async Task<List<Feedback>?> FetchAllFeedbackFromCloud()
        {
            if (!IsOnline())
            {
                return null;
            }

            try
            {
                return await SupabaseClient.GetAllFeedback();
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// İnternet bağlantısı kontrolü
        /// </summary>
        /// <returns>Online ise true</returns>
        public static bool IsOnline()
        {
            try
            {
                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send("8.8.8.8", 3000); // Google DNS
                    return reply.Status == IPStatus.Success;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Supabase bağlantısını test eder
        /// </summary>
        /// <returns>Başarılıysa true</returns>
        public static async Task<bool> TestCloudConnection()
        {
            if (!IsOnline())
            {
                return false;
            }

            try
            {
                return await SupabaseClient.TestConnection();
            }
            catch
            {
                return false;
            }
        }
    }
}
