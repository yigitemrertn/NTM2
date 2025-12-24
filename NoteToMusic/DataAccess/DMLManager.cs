using System;
using System.Data;
using System.Data.SqlClient;

namespace NoteToMusic.DataAccess
{
    /// <summary>
    /// Database DML (Data Manipulation Language) işlemlerini yöneten helper class
    /// </summary>
    public static class DMLManager
    {
        /// <summary>
        /// INSERT, UPDATE, DELETE gibi komutları çalıştırır
        /// </summary>
        /// <param name="query">SQL sorgusu</param>
        /// <param name="parameters">Parametreler (opsiyonel)</param>
        /// <returns>Etkilenen satır sayısı veya hata durumunda -1</returns>
        public static int ExecuteNonQuery(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = sMan.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null && parameters.Length > 0)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        conn.Open();
                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                return -1;
            }
        }

        /// <summary>
        /// SELECT sorgusu çalıştırır ve DataTable döndürür
        /// </summary>
        /// <param name="query">SQL sorgusu</param>
        /// <param name="parameters">Parametreler (opsiyonel)</param>
        /// <returns>Sonuç DataTable veya hata durumunda null</returns>
        public static DataTable ExecuteReader(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = sMan.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null && parameters.Length > 0)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Tek bir değer döndüren sorguları çalıştırır (COUNT, MAX, vb.)
        /// </summary>
        /// <param name="query">SQL sorgusu</param>
        /// <param name="parameters">Parametreler (opsiyonel)</param>
        /// <returns>Sonuç object veya hata durumunda null</returns>
        public static object ExecuteScalar(string query, params SqlParameter[] parameters)
        {
            try
            {
                using (SqlConnection conn = sMan.GetConnection())
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        if (parameters != null && parameters.Length > 0)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        conn.Open();
                        return cmd.ExecuteScalar();
                    }
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// SQL parametresi oluşturmak için helper method
        /// </summary>
        /// <param name="name">Parametre adı (@ile başlamalı)</param>
        /// <param name="value">Parametre değeri</param>
        /// <returns>SqlParameter nesnesi</returns>
        public static SqlParameter CreateParameter(string name, object value)
        {
            return new SqlParameter(name, value ?? DBNull.Value);
        }
    }
}
