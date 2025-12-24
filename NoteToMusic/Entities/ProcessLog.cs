using System;

namespace NoteToMusic.Entities
{
    /// <summary>
    /// İşlem kayıtlarını tutan entity sınıfı
    /// </summary>
    public class ProcessLog
    {
        public int Id { get; set; }
        public string FileName { get; set; } = "";
        public DateTime ProcessDate { get; set; }
        public string Status { get; set; } = "";
    }
}
