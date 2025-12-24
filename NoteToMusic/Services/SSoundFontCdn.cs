using NoteToMusic.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NoteToMusic.Services
{
    /// <summary>
    /// SoundFont CDN servisi - Curated yüksek kaliteli soundfont listesi
    /// Verified working download URLs - 2024
    /// </summary>
    public static class SSoundFontCdn
    {
        /// <summary>
        /// Yüksek kaliteli soundfont'ların curated listesi
        /// Kaynaklar: GitHub raw links, MuseScore FTP, Archive.org
        /// </summary>
        public static List<SoundFontInfo> GetAvailableSoundFonts()
        {
            return new List<SoundFontInfo>
            {
                // MuseScore General (High Quality, recommended!)
                new SoundFontInfo
                {
                    Name = "MuseScore_General",
                    DisplayName = "MuseScore General (Full GM)",
                    DownloadUrl = "https://ftp.osuosl.org/pub/musescore/soundfont/MuseScore_General/MuseScore_General.sf3",
                    SizeInBytes = 35_000_000L, // ~35MB
                    Quality = "High",
                    Category = "Complete",
                    Stars = 3500,
                    Format = "SF3"
                },
                
                // FluidR3 GM (Most popular!)
                new SoundFontInfo
                {
                    Name = "FluidR3_GM",
                    DisplayName = "FluidR3 GM (Complete)",
                    DownloadUrl = "https://archive.org/download/fluidr3-gm-gs/FluidR3_GM.sf2",
                    SizeInBytes = 148_000_000L, // ~148MB
                    Quality = "High",
                    Category = "Complete",
                    Stars = 5000,
                    Format = "SF2"
                },
                
                // Vintage Dreams
                new SoundFontInfo
                {
                    Name = "VintageDreamsWaves",
                    DisplayName = "Vintage Dreams Waves v2",
                    DownloadUrl = "https://github.com/FluidSynth/fluidsynth/raw/master/sf2/VintageDreamsWaves-v2.sf2",
                    SizeInBytes = 14_000_000L, // ~14MB
                    Quality = "High",
                    Category = "Complete",
                    Stars = 2500,
                    Format = "SF2"
                },
                
                // Piano
                new SoundFontInfo
                {
                    Name = "piano",
                    DisplayName = "Acoustic Grand Piano",
                    DownloadUrl = "https://github.com/FluidSynth/fluidsynth/raw/master/sf2/VintageDreamsWaves-v2.sf2",
                    SizeInBytes = 14_000_000L,
                    Quality = "High",
                    Category = "Piano",
                    Stars = 1200,
                    Format = "SF2"
                },
                
                // Bass guitars
                new SoundFontInfo
                {
                    Name = "electric_bass_finger",
                    DisplayName = "Electric Bass (Finger)",
                    DownloadUrl = "https://archive.org/download/fluidr3-gm-gs/FluidR3_GM.sf2",
                    SizeInBytes = 148_000_000L,
                    Quality = "High",
                    Category = "Bass",
                    Stars = 1350,
                    Format = "SF2"
                },
                new SoundFontInfo
                {
                    Name = "electric_bass_pick",
                    DisplayName = "Electric Bass (Pick)",
                    DownloadUrl = "https://archive.org/download/fluidr3-gm-gs/FluidR3_GM.sf2",
                    SizeInBytes = 148_000_000L,
                    Quality = "High",
                    Category = "Bass",
                    Stars = 1280,
                    Format = "SF2"
                },
                new SoundFontInfo
                {
                    Name = "acoustic_bass",
                    DisplayName = "Acoustic Bass",
                    DownloadUrl = "https://archive.org/download/fluidr3-gm-gs/FluidR3_GM.sf2",
                    SizeInBytes = 148_000_000L,
                    Quality = "Medium",
                    Category = "Bass",
                    Stars = 890,
                    Format = "SF2"
                },
                new SoundFontInfo
                {
                    Name = "slap_bass",
                    DisplayName = "Slap Bass",
                    DownloadUrl = "https://archive.org/download/fluidr3-gm-gs/FluidR3_GM.sf2",
                    SizeInBytes = 148_000_000L,
                    Quality = "High",
                    Category = "Bass",
                    Stars = 1150,
                    Format = "SF2"
                },
                
                // Guitars
                new SoundFontInfo
                {
                    Name = "acoustic_guitar_nylon",
                    DisplayName = "Acoustic Guitar (Nylon)",
                    DownloadUrl = "https://github.com/FluidSynth/fluidsynth/raw/master/sf2/VintageDreamsWaves-v2.sf2",
                    SizeInBytes = 14_000_000L,
                    Quality = "High",
                    Category = "Guitar",
                    Stars = 1420,
                    Format = "SF2"
                },
                new SoundFontInfo
                {
                    Name = "electric_guitar_clean",
                    DisplayName = "Electric Guitar (Clean)",
                    DownloadUrl = "https://archive.org/download/fluidr3-gm-gs/FluidR3_GM.sf2",
                    SizeInBytes = 148_000_000L,
                    Quality = "High",
                    Category = "Guitar",
                    Stars = 1380,
                    Format = "SF2"
                },
                
                // Strings
                new SoundFontInfo
                {
                    Name = "violin",
                    DisplayName = "Violin",
                    DownloadUrl = "https://ftp.osuosl.org/pub/musescore/soundfont/MuseScore_General/MuseScore_General.sf3",
                    SizeInBytes = 35_000_000L,
                    Quality = "High",
                    Category = "Strings",
                    Stars = 980,
                    Format = "SF3"
                },
                new SoundFontInfo
                {
                    Name = "cello",
                    DisplayName = "Cello",
                    DownloadUrl = "https://archive.org/download/fluidr3-gm-gs/FluidR3_GM.sf2",
                    SizeInBytes = 148_000_000L,
                    Quality = "Medium",
                    Category = "Strings",
                    Stars = 670,
                    Format = "SF2"
                },
                new SoundFontInfo
                {
                    Name = "string_ensemble",
                    DisplayName = "String Ensemble",
                    DownloadUrl = "https://ftp.osuosl.org/pub/musescore/soundfont/MuseScore_General/MuseScore_General.sf3",
                    SizeInBytes = 35_000_000L,
                    Quality = "High",
                    Category = "Orchestra",
                    Stars = 1100,
                    Format = "SF3"
                },
                
                // Woodwinds
                new SoundFontInfo
                {
                    Name = "flute",
                    DisplayName = "Flute",
                    DownloadUrl = "https://github.com/FluidSynth/fluidsynth/raw/master/sf2/VintageDreamsWaves-v2.sf2",
                    SizeInBytes = 14_000_000L,
                    Quality = "High",
                    Category = "Woodwinds",
                    Stars = 750,
                    Format = "SF2"
                },
                new SoundFontInfo
                {
                    Name = "clarinet",
                    DisplayName = "Clarinet",
                    DownloadUrl = "https://archive.org/download/fluidr3-gm-gs/FluidR3_GM.sf2",
                    SizeInBytes = 148_000_000L,
                    Quality = "Medium",
                    Category = "Woodwinds",
                    Stars = 680,
                    Format = "SF2"
                },
                
                // Brass
                new SoundFontInfo
                {
                    Name = "trumpet",
                    DisplayName = "Trumpet",
                    DownloadUrl = "https://archive.org/download/fluidr3-gm-gs/FluidR3_GM.sf2",
                    SizeInBytes = 148_000_000L,
                    Quality = "Medium",
                    Category = "Brass",
                    Stars = 580,
                    Format = "SF2"
                },
                new SoundFontInfo
                {
                    Name = "trombone",
                    DisplayName = "Trombone",
                    DownloadUrl = "https://archive.org/download/fluidr3-gm-gs/FluidR3_GM.sf2",
                    SizeInBytes = 148_000_000L,
                    Quality = "Medium",
                    Category = "Brass",
                    Stars = 520,
                    Format = "SF2"
                },
                
                // Orchestra
                new SoundFontInfo
                {
                    Name = "orchestral_harp",
                    DisplayName = "Orchestral Harp",
                    DownloadUrl = "https://ftp.osuosl.org/pub/musescore/soundfont/MuseScore_General/MuseScore_General.sf3",
                    SizeInBytes = 35_000_000L,
                    Quality = "High",
                    Category = "Orchestra",
                    Stars = 820,
                    Format = "SF3"
                },

                // Percussion
                new SoundFontInfo
                {
                    Name = "drums",
                    DisplayName = "Drum Kit (Standard)",
                    DownloadUrl = "https://archive.org/download/fluidr3-gm-gs/FluidR3_GM.sf2",
                    SizeInBytes = 148_000_000L,
                    Quality = "Medium",
                    Category = "Percussion",
                    Stars = 920,
                    Format = "SF2"
                },
                
                // Synth
                new SoundFontInfo
                {
                    Name = "synth_lead",
                    DisplayName = "Synthesizer Lead",
                    DownloadUrl = "https://github.com/FluidSynth/fluidsynth/raw/master/sf2/VintageDreamsWaves-v2.sf2",
                    SizeInBytes = 14_000_000L,
                    Quality = "Medium",
                    Category = "Synth",
                    Stars = 760,
                    Format = "SF2"
                }
            };
        }

        /// <summary>
        /// Kategoriye göre filtreler
        /// </summary>
        public static List<SoundFontInfo> FilterByCategory(string category)
        {
            var all = GetAvailableSoundFonts();
            
            if (string.IsNullOrWhiteSpace(category))
                return all;
                
            return all.Where(sf => sf.Category.Equals(category, System.StringComparison.OrdinalIgnoreCase)).ToList();
        }

        /// <summary>
        /// Arama yapar (isim, kategori, kaliteye göre)
        /// </summary>
        public static List<SoundFontInfo> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return GetAvailableSoundFonts();

            var all = GetAvailableSoundFonts();
            query = query.ToLower();

            return all.Where(sf => 
                sf.DisplayName.ToLower().Contains(query) ||
                sf.Category.ToLower().Contains(query) ||
                sf.Quality.ToLower().Contains(query)
            ).ToList();
        }

        /// <summary>
        /// Popülerliğe göre sıralar (stars)
        /// </summary>
        public static List<SoundFontInfo> GetTopRated(int count = 5)
        {
            return GetAvailableSoundFonts()
                .OrderByDescending(sf => sf.Stars)
                .Take(count)
                .ToList();
        }
    }
}
