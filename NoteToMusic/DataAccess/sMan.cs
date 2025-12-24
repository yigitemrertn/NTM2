using System.Configuration;
using System.Data.SqlClient;

namespace NoteToMusic.DataAccess
{
    /// <summary>
    /// Database bağlantı yöneticisi
    /// LocalDB için connection string ve bağlantı nesnesi sağlar
    /// </summary>
    public static class sMan
    {
        /// <summary>
        /// LocalDB connection string'i döndürür
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                // App.config'den connection string al, yoksa default kullan
                string connStr = ConfigurationManager.ConnectionStrings["NTM2DB"]?.ConnectionString;
                
                if (string.IsNullOrEmpty(connStr))
                {
                    // Default SQL Server Express connection string
                    string appDataPath = System.IO.Path.Combine(
                        System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData),
                        "NoteToMusic"
                    );
                    
                    System.IO.Directory.CreateDirectory(appDataPath);
                    
                    connStr = $@"Server=localhost\SQLEXPRESS;Database=NTM2;Integrated Security=True;TrustServerCertificate=True";
                }
                
                return connStr;
            }
        }

        /// <summary>
        /// Yeni bir SqlConnection nesnesi oluşturur ve döndürür
        /// </summary>
        /// <returns>Yapılandırılmış SqlConnection nesnesi</returns>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
