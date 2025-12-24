namespace NoteToMusic.Entities
{
    /// <summary>
    /// IMSLP'den alınan nota bilgilerini temsil eder
    /// </summary>
    public class SheetMusicInfo
    {
        public string Id { get; set; } = "";
        public string Title { get; set; } = "";
        public string Composer { get; set; } = "";
        public string ImageUrl { get; set; } = "";
        public string PdfUrl { get; set; } = "";
        public int Dpi { get; set; } = 300;
        public string Instrument { get; set; } = "";
        public int Downloads { get; set; } = 0;
        public string PageCount { get; set; } = "";
        
        public override string ToString()
        {
            return $"{Composer} - {Title} ({Dpi} DPI)";
        }
    }
}
