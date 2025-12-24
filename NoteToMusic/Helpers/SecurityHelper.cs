using System;
using System.Security.Cryptography;
using System.Text;

namespace NoteToMusic.Helpers
{
    /// <summary>
    /// Güvenlik helper sınıfı
    /// </summary>
    public static class SecurityHelper
    {
        // Admin şifresi (hashed)
        private const string ADMIN_PASSWORD_HASH = "ba6817c2a498db6c7faeb185e7e68345d373ff79a9e915ee6c98b12f156ca7cd"; // "admin123"

        /// <summary>
        /// Şifreyi hash'ler (SHA256)
        /// </summary>
        /// <param name="password">Plain text şifre</param>
        /// <returns>Hash string</returns>
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        /// <summary>
        /// Şifreyi doğrular
        /// </summary>
        /// <param name="password">Girilen şifre</param>
        /// <returns>Doğruysa true</returns>
        public static bool VerifyAdminPassword(string password)
        {
            string hash = HashPassword(password);
            return hash.Equals(ADMIN_PASSWORD_HASH, StringComparison.OrdinalIgnoreCase);
        }
    }
}
