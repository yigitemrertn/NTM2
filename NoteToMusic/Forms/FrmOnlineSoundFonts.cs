using NoteToMusic.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace NoteToMusic.Forms
{
    /// <summary>
    /// SoundFont kaynakları - Browser'da açma
    /// </summary>
    public partial class FrmOnlineSoundFonts : Form
    {
        private List<SoundFontInfo> allSoundFonts = new List<SoundFontInfo>();
        private List<SoundFontInfo> filteredSoundFonts = new List<SoundFontInfo>();

        public FrmOnlineSoundFonts()
        {
            InitializeComponent();
        }

        private void FrmOnlineSoundFonts_Load(object sender, EventArgs e)
        {
            // DataGridView setup
            dgvSoundFonts.AutoGenerateColumns = false;
            dgvSoundFonts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "DisplayName",
                HeaderText = "SoundFont Kaynağı",
                Width = 280
            });
            dgvSoundFonts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Kategori",
                Width = 100
            });
            dgvSoundFonts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quality",
                HeaderText = "Kalite",
                Width = 80
            });
            dgvSoundFonts.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Format",
                HeaderText = "Format",
                Width = 60
            });

            LoadSoundFonts();
        }

        private void LoadSoundFonts()
        {
            // Güvenilir SF2 kaynakları
            allSoundFonts = new List<SoundFontInfo>
            {
                new SoundFontInfo
                {
                    DisplayName = "MuseScore.org - General SoundFont",
                    DownloadUrl = "https://musescore.org/en/handbook/3/soundfonts-and-sfz-files",
                    Category = "Complete",
                    Quality = "High",
                    Format = "SF2/SF3"
                },
                new SoundFontInfo
                {
                    DisplayName = "IMSLP - Free Music Library",
                    DownloadUrl = "https://imslp.org/wiki/Main_Page",
                    Category = "Sheet Music",
                    Quality = "High",
                    Format = "PDF/PNG"
                },
                new SoundFontInfo
                {
                    DisplayName = "Musical Artifacts - SF2 Collection",
                    DownloadUrl = "https://musical-artifacts.com/artifacts?formats=sf2",
                    Category = "Complete",
                    Quality = "Varied",
                    Format = "SF2"
                },
                new SoundFontInfo
                {
                    DisplayName = "FluidSynth GitHub - Free SF2",
                    DownloadUrl = "https://github.com/FluidSynth/fluidsynth/tree/master/sf2",
                    Category = "Complete",
                    Quality = "High",
                    Format = "SF2"
                },
                new SoundFontInfo
                {
                    DisplayName = "Soundfonts 4U - Bass Collection",
                    DownloadUrl = "https://sites.google.com/site/soundfonts4u/",
                    Category = "Bass",
                    Quality = "Varied",
                    Format = "SF2"
                },
                new SoundFontInfo
                {
                    DisplayName = "Archive.org - SoundFont Archive",
                    DownloadUrl = "https://archive.org/search.php?query=soundfont",
                    Category = "Complete",
                    Quality = "Varied",
                    Format = "SF2"
                },
                new SoundFontInfo
                {
                    DisplayName = "Polyphone - SF2 Editor + Samples",
                    DownloadUrl = "https://www.polyphone-soundfonts.com/en/soundfonts",
                    Category = "Complete",
                    Quality = "High",
                    Format = "SF2"
                },
                new SoundFontInfo
                {
                    DisplayName = "Hammersound - Free Soundfonts",
                    DownloadUrl = "http://www.hammersound.net/",
                    Category = "Complete",
                    Quality = "Varied",
                    Format = "SF2"
                }
            };

            filteredSoundFonts = allSoundFonts;
            dgvSoundFonts.DataSource = filteredSoundFonts;
            lblStatus.Text = $"{allSoundFonts.Count} kaynak mevcut. Siteden manuel indirme yapabilirsiniz.";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim().ToLower();
            
            if (string.IsNullOrWhiteSpace(query))
            {
                filteredSoundFonts = allSoundFonts;
            }
            else
            {
                filteredSoundFonts = allSoundFonts.Where(sf =>
                    sf.DisplayName.ToLower().Contains(query) ||
                    sf.Category.ToLower().Contains(query)
                ).ToList();
            }

            dgvSoundFonts.DataSource = null;
            dgvSoundFonts.DataSource = filteredSoundFonts;
            lblStatus.Text = $"{filteredSoundFonts.Count} sonuç gösteriliyor.";
        }

        private void dgvSoundFonts_SelectionChanged(object sender, EventArgs e)
        {
            btnOpenSite.Enabled = dgvSoundFonts.SelectedRows.Count > 0;
        }

        private void btnOpenSite_Click(object sender, EventArgs e)
        {
            if (dgvSoundFonts.SelectedRows.Count == 0)
                return;

            var selected = dgvSoundFonts.SelectedRows[0].DataBoundItem as SoundFontInfo;
            if (selected == null)
                return;

            try
            {
                // Browser'da aç
                Process.Start(new ProcessStartInfo
                {
                    FileName = selected.DownloadUrl,
                    UseShellExecute = true
                });

                lblStatus.Text = "Site browser'da açıldı. Manuel olarak indirebilirsiniz.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Site açılırken hata:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            LoadSoundFonts();
        }
    }
}
