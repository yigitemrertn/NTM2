using System;
using System.Collections.Generic;

namespace NoteToMusic.Entities
{
    /// <summary>
    /// Created by: Yiğit Emre ERTEN
    /// Date: 25.12.2024
    /// Description: PDF sayfalarının işleme durumunu tutan model
    /// </summary>
    public class PdfPageInfo
    {
        /// <summary>
        /// PDF dosyasının tam yolu
        /// </summary>
        public string PdfFilePath { get; set; } = "";

        /// <summary>
        /// Sayfa numarası (1-indexed)
        /// </summary>
        public int PageNumber { get; set; }

        /// <summary>
        /// Sayfadan oluşturulan görsel dosyasının yolu
        /// </summary>
        public string ImagePath { get; set; } = "";

        /// <summary>
        /// Sayfadan oluşturulan MusicXML dosyasının yolu
        /// </summary>
        public string MusicXmlPath { get; set; } = "";

        /// <summary>
        /// Sayfanın işlenip işlenmediği
        /// </summary>
        public bool IsProcessed { get; set; } = false;

        /// <summary>
        /// Sayfa işlenirken oluşan hata mesajı (varsa)
        /// </summary>
        public string ErrorMessage { get; set; } = "";
    }
}
