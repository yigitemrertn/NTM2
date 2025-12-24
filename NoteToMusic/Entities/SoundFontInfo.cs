namespace NoteToMusic.Entities
{
    /// <summary>
    /// CDN'den alınan SoundFont bilgilerini temsil eder
    /// </summary>
    public class SoundFontInfo
    {
        public string Name { get; set; } = "";
        public string DisplayName { get; set; } = "";
        public long SizeInBytes { get; set; }
        public string Quality { get; set; } = "Medium"; // High, Medium, Low
        public string DownloadUrl { get; set; } = "";
        public int Stars { get; set; } = 0;
        public string Category { get; set; } = ""; // Piano, Orchestra, Drums, etc.
        public string Format { get; set; } = "SF2";
        
        public string SizeDisplay => $"{SizeInBytes / 1024.0 / 1024.0:F1} MB";
        
        public override string ToString()
        {
            return $"{DisplayName} - {Quality} ({SizeDisplay})";
        }
    }
}
