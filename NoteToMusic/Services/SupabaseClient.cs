using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NoteToMusic.Entities;

namespace NoteToMusic.Services
{
    /// <summary>
    /// Supabase REST API client
    /// </summary>
    public static class SupabaseClient
    {
        private const string PROJECT_URL = "https://lockykgihtskuwktzefm.supabase.co";
        private const string API_KEY = "sb_secret_1pp4y9KWXVQ9Qdx4JEes8A_wB4mXG_D";
        private const string TABLE_NAME = "feedback";

        private static HttpClient GetClient()
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("apikey", API_KEY);
            client.DefaultRequestHeaders.Add("Authorization", $"Bearer {API_KEY}");
            client.DefaultRequestHeaders.Add("Prefer", "return=representation");
            return client;
        }

        /// <summary>
        /// Feedback'i Supabase'e gönderir
        /// </summary>
        /// <param name="feedback">Feedback entity</param>
        /// <returns>Başarılıysa boş string, hata varsa hata mesajı</returns>
        public static async Task<string> PostFeedback(Feedback feedback)
        {
            try
            {
                using (var client = GetClient())
                {
                    var payload = new
                    {
                        username = feedback.Username,
                        performance_rating = feedback.PerformanceRating,
                        accuracy_rating = feedback.AccuracyRating,
                        functionality_rating = feedback.FunctionalityRating,
                        overall_rating = feedback.OverallRating,
                        comments = feedback.Comments,
                        created_date = feedback.CreatedDate.ToString("o"), // ISO 8601 format
                        machine_name = Environment.MachineName,
                        synced_from_local = true
                    };

                    string json = JsonConvert.SerializeObject(payload);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    string url = $"{PROJECT_URL}/rest/v1/{TABLE_NAME}";
                    var response = await client.PostAsync(url, content);

                    if (response.IsSuccessStatusCode)
                    {
                        return "";
                    }
                    else
                    {
                        string errorContent = await response.Content.ReadAsStringAsync();
                        return $"HATA: Cloud sync başarısız. {response.StatusCode} - {errorContent}";
                    }
                }
            }
            catch (Exception ex)
            {
                return $"HATA: Cloud sync hatası. {ex.Message}";
            }
        }

        /// <summary>
        /// Supabase'den tüm feedback'leri getirir
        /// </summary>
        /// <returns>Feedback listesi veya null</returns>
        public static async Task<List<Feedback>> GetAllFeedback()
        {
            try
            {
                using (var client = GetClient())
                {
                    string url = $"{PROJECT_URL}/rest/v1/{TABLE_NAME}?select=*&order=created_date.desc";
                    var response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<List<Dictionary<string, object>>>(json);

                        List<Feedback> feedbackList = new List<Feedback>();
                        
                        if (data != null)
                        {
                            foreach (var item in data)
                            {
                                feedbackList.Add(new Feedback
                                {
                                    Id = Convert.ToInt32(item["id"]),
                                    Username = item["username"].ToString() ?? "",
                                    PerformanceRating = Convert.ToInt32(item["performance_rating"]),
                                    AccuracyRating = Convert.ToInt32(item["accuracy_rating"]),
                                    FunctionalityRating = Convert.ToInt32(item["functionality_rating"]),
                                    OverallRating = Convert.ToInt32(item["overall_rating"]),
                                    Comments = item["comments"]?.ToString() ?? "",
                                    CreatedDate = DateTime.Parse(item["created_date"].ToString() ?? DateTime.Now.ToString())
                                });
                            }
                        }

                        return feedbackList;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Supabase bağlantısını test eder
        /// </summary>
        /// <returns>Başarılıysa true</returns>
        public static async Task<bool> TestConnection()
        {
            try
            {
                using (var client = GetClient())
                {
                    string url = $"{PROJECT_URL}/rest/v1/{TABLE_NAME}?select=count";
                    var response = await client.GetAsync(url);
                    return response.IsSuccessStatusCode;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
