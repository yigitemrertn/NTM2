using System;
using System.Data.SqlClient;
using System.IO;

namespace NoteToMusic.DataAccess
{
    /// <summary>
    /// Database ve tabloları initialize eden sınıf
    /// </summary>
    public static class DatabaseInitializer
    {

        /// <summary>
        /// Database'i initialize eder, yoksa oluşturur
        /// </summary>
        /// <returns>Başarılıysa boş string, hata varsa hata mesajı</returns>
        public static string Initialize()
        {
            try
            {
                // Database yoksa oluştur, varsa skip
                CreateDatabaseIfNotExists();

                // Tablo yoksa oluştur
                CreateTables();

                return "";
            }
            catch (Exception ex)
            {
                return $"HATA: Database initialization hatası: {ex.Message}";
            }
        }

        /// <summary>
        /// Database'in var olup olmadığını kontrol eder ve yoksa oluşturur
        /// </summary>
        private static void CreateDatabaseIfNotExists()
        {
            string masterConnStr = @"Server=localhost\SQLEXPRESS;Database=master;Integrated Security=True;TrustServerCertificate=True";
            
            using (SqlConnection conn = new SqlConnection(masterConnStr))
            {
                conn.Open();
                
                // Database var mı kontrol et
                string checkDbQuery = "SELECT database_id FROM sys.databases WHERE Name = 'NTM2'";
                using (SqlCommand cmd = new SqlCommand(checkDbQuery, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        // Database zaten var
                        return;
                    }
                }
                
                // Database oluştur
                string createDbQuery = "CREATE DATABASE NTM2";
                using (SqlCommand cmd = new SqlCommand(createDbQuery, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Gerekli tabloları oluşturur
        /// </summary>
        private static void CreateTables()
        {
            // Feedback tablosunun varlığını kontrol et
            string checkTableQuery = @"
                SELECT COUNT(*) 
                FROM INFORMATION_SCHEMA.TABLES 
                WHERE TABLE_NAME = 'Feedback'";

            object result = DMLManager.ExecuteScalar(checkTableQuery);
            
            if (result != null && Convert.ToInt32(result) > 0)
            {
                // Tablo zaten var
                return;
            }

            // Feedback tablosunu oluştur
            string createTableQuery = @"
                CREATE TABLE Feedback (
                    Id INT PRIMARY KEY IDENTITY(1,1),
                    Username NVARCHAR(100) NOT NULL,
                    PerformanceRating INT NOT NULL CHECK (PerformanceRating BETWEEN 0 AND 5),
                    AccuracyRating INT NOT NULL CHECK (AccuracyRating BETWEEN 0 AND 5),
                    FunctionalityRating INT NOT NULL CHECK (FunctionalityRating BETWEEN 0 AND 5),
                    OverallRating INT NOT NULL CHECK (OverallRating BETWEEN 0 AND 5),
                    Comments NVARCHAR(MAX),
                    CreatedDate DATETIME NOT NULL DEFAULT GETDATE()
                )";

            DMLManager.ExecuteNonQuery(createTableQuery);
        }
    }
}
