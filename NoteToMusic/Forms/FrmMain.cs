using NAudio.Wave;
using NoteToMusic.Interfaces;
using NoteToMusic.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NoteToMusic.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // Service Objects
        private readonly ISAudiveris _audiverisService = new SAudiveris();
        private readonly ISNaudio _naudioService = new SNaudio();
        private readonly ISMeltySynth _meltySynthService = new SMeltySynth();

        // Variables
        string currentNote = "", currentSound = "", currentMusic = "";
        bool isPlaying;
        bool isUpdatingTrackBar = false;
        public static int bpm = 0;

        IWavePlayer? waveOutDevice;
        AudioFileReader? audioFileReader;
        private System.Windows.Forms.Timer? playbackTimer;
        private bool feedbackEnabled = false;

        private void MainForm_Load(object sender, EventArgs e)
        {
            SFile.CheckAndCreateDirectories();

            ListItems(lstNotes, SFile.GetFiles(SFile.notesDir));
            ListItems(lstSounds, SFile.GetFiles(SFile.soundsDir));
            ListItems(lstMusics, SFile.GetFiles(SFile.musicDir));
        }

        private void ListItems(ListBox target, List<string> list)
        {
            target.Items.Clear();

            if (list.Count == 0)
            {
                target.Items.Add("Dosya Yok");
                return;
            }

            foreach (var item in list)
            {
                target.Items.Add(item);
            }
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            #region DÖNÜŞÜM İŞLEMİ
            try
            {
                if (string.IsNullOrEmpty(currentNote) || string.IsNullOrEmpty(currentSound))
                {
                    this.Text = "Hata: Lütfen bir nota şemasını ve bir SoundFont dosyası seçiniz!";
                    return;
                }

                btnConvert.Enabled = false;
                btnConvert.Text = "Dönüştürülüyor... Lütfen Bekleyiniz";

                #region BPM FORMU
                bpm = 0;
                using (var frm = new FrmBpm())
                {
                    frm.ShowDialog();
                }
                #endregion

                #region AUDIVERIS: GÖRÜNTÜ -> MUSICXML
                this.Text = "Adım 1/3: Görüntü MusicXML'e dönüştürülüyor...";
                
                string xmlPath = await _audiverisService.ConvertImageToMusicXmlAsync(currentNote);
                
                if (xmlPath.StartsWith("HATA:"))
                {
                    this.Text = xmlPath;
                    return;
                }
                #endregion

                #region NAUDIO: MUSICXML -> MIDI
                this.Text = "Adım 2/3: MusicXML MIDI'ye dönüştürülüyor...";
                
                string midiPath = Path.Combine(SFile.tempDir, Path.GetFileNameWithoutExtension(currentNote) + ".mid");
                string midiResult = await _naudioService.ConvertXmlToMidiAsync(xmlPath, midiPath, bpm);
                
                if (midiResult.StartsWith("HATA:"))
                {
                    this.Text = midiResult;
                    return;
                }
                #endregion

                #region MELTYSYNTH: MIDI -> WAV
                this.Text = "Adım 3/3: MIDI WAV'a dönüştürülüyor...";
                
                string wavPath = await _meltySynthService.ConvertMidiToWav(midiPath, currentSound);
                
                if (wavPath.StartsWith("HATA:"))
                {
                    this.Text = wavPath;
                    return;
                }

                currentMusic = wavPath;
                this.Text = "Dönüştürme başarılı!";

                // Listbox'ı yenile ki yeni gelen müzik görünsün
                ListItems(lstMusics, SFile.GetFiles(SFile.musicDir));
                #endregion
            }
            catch (Exception ex)
            {
                this.Text = $"HATA: Render sırasında hata: {ex.Message}";
            }
            finally
            {
                btnConvert.Enabled = true;
                btnConvert.Text = "Dönüştür!";
            }
            #endregion
        }

        private void lstNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstNotes.SelectedIndex;

            if (index != -1)
            {
                string fileName = lstNotes.Items[index]?.ToString() ?? "";

                if (string.IsNullOrEmpty(fileName)) return;

                currentNote = Path.Combine(SFile.notesDir, fileName);

                if (picNote.Image != null)
                {
                    picNote.Image.Dispose();
                    picNote.Image = null;
                }

                if (File.Exists(currentNote))
                {
                    picNote.Image = Image.FromFile(currentNote);
                }
            }
        }

        private void lstSounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstSounds.SelectedIndex;

            if (index != -1)
            {
                string fileName = lstSounds.Items[index]?.ToString() ?? "";

                if (!string.IsNullOrEmpty(fileName))
                {
                    currentSound = Path.Combine(SFile.soundsDir, fileName);
                }
            }
        }

        private void lstMusics_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstMusics.SelectedIndex;

            if (index == -1) return;

            string fileName = lstMusics.Items[index]?.ToString() ?? "";

            if (!string.IsNullOrEmpty(fileName))
            {
                waveOutDevice?.Stop();
                DisposeWave();
                isPlaying = false;
                btnPlayStop.Text = "Oynat";

                currentMusic = Path.Combine(SFile.musicDir, fileName);

                string newMusic = fileName.Split('(')[0].Trim();

                foreach (var item in lstNotes.Items)
                {
                    string fullImageName = item.ToString() ?? "";
                    string imageNameOnly = Path.GetFileNameWithoutExtension(fullImageName);

                    if (imageNameOnly.Contains(newMusic))
                    {
                        picNote.Image = Image.FromFile(Path.Combine(SFile.notesDir, fullImageName));
                        break;
                    }
                }
            }
        }

        private void btnPlayStop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentMusic) || !File.Exists(currentMusic))
            {
                this.Text = "Uyarı: Lütfen geçerli bir müzik seçin.";
                return;
            }

            if (!isPlaying)
            {
                // OYNATMA BAŞLAT
                try
                {
                    if (waveOutDevice == null)
                    {
                        waveOutDevice = new WaveOutEvent();
                        audioFileReader = new AudioFileReader(currentMusic);
                        waveOutDevice.Init(audioFileReader);

                        // Ses seviyesini trackVolume'e göre ayarla
                        if (audioFileReader != null)
                        {
                            audioFileReader.Volume = trackVolume.Value / 100f;
                        }

                        // Şarkı bittiğinde butonu eski haline getirmek için event
                        waveOutDevice.PlaybackStopped += (s, a) =>
                        {
                            isPlaying = false;
                            btnPlayStop.Text = "Oynat";
                            trackTime.Value = 0;
                            playbackTimer?.Stop();
                            DisposeWave();
                        };

                        // Playback Timer'ı başlat (100ms interval ile güncelle)
                        if (playbackTimer == null)
                        {
                            playbackTimer = new System.Windows.Forms.Timer();
                            playbackTimer.Interval = 100;
                            playbackTimer.Tick += PlaybackTimer_Tick;
                        }
                        playbackTimer.Start();

                        trackTime.Enabled = true;
                        if (audioFileReader != null) trackTime.Maximum = (int)audioFileReader.TotalTime.TotalSeconds;
                    }

                    waveOutDevice.Play();
                    isPlaying = true;
                    btnPlayStop.Text = "Durdur";
                    
                    // Müzik çalmaya başladığında feedback butonunu aktif et (internet varsa)
                    if (!feedbackEnabled)
                    {
                        feedbackEnabled = true;
                        
                        // İnternet kontrolü
                        if (SCloudSync.IsOnline())
                        {
                            btnFeedback.Enabled = true;
                        }
                        else
                        {
                            btnFeedback.Enabled = false;
                            btnFeedback.Text = "Geri Bildirim (İnternet Yok)";
                        }
                    }
                }
                catch (Exception ex)
                {
                    this.Text = $"HATA: Oynatma hatası: {ex.Message}";
                }
            }
            else
            {
                // DURDURMA
                if (waveOutDevice != null)
                {
                    waveOutDevice.Pause();
                    isPlaying = false;
                    btnPlayStop.Text = "Devam";
                    playbackTimer?.Stop();
                }
            }
        }

        private void PlaybackTimer_Tick(object? sender, EventArgs e)
        {
            if (audioFileReader != null && !isUpdatingTrackBar)
            {
                isUpdatingTrackBar = true;

                // Mevcut pozisyon (saniye cinsinden)
                int currentSeconds = (int)audioFileReader.CurrentTime.TotalSeconds;
                int totalSeconds = (int)audioFileReader.TotalTime.TotalSeconds;

                // TrackBar'ı güncelle
                trackTime.Value = Math.Min(currentSeconds, trackTime.Maximum);

                // Zaman etiketi güncelle (MM:SS / MM:SS formatında)
                int currentMinutes = currentSeconds / 60;
                int currentSecs = currentSeconds % 60;
                int totalMinutes = totalSeconds / 60;
                int totalSecs = totalSeconds % 60;

                lblTime.Text = $"{currentMinutes:D2}:{currentSecs:D2} / {totalMinutes:D2}:{totalSecs:D2}";

                isUpdatingTrackBar = false;
            }
        }

        private void trackTime_Scroll(object sender, EventArgs e)
        {
            // Kullanıcı TrackBar'ı kaydırdığında, müzik pozisyonunu değiştir
            if (audioFileReader != null && waveOutDevice != null && waveOutDevice.PlaybackState != PlaybackState.Stopped)
            {
                audioFileReader.CurrentTime = TimeSpan.FromSeconds(trackTime.Value);
            }
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            // Ses seviyesini 0-100 arasında ayarla
            if (audioFileReader != null)
            {
                audioFileReader.Volume = trackVolume.Value / 100f;
            }
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Görsel Dosyalar|*.png;*.jpg;*.jpeg;*.bmp";
                ofd.Multiselect = false;
                ofd.Title = "Nota Dosyası Seçiniz...";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = ofd.FileName;
                    string fileName = Path.GetFileName(selectedFile);
                    string destinationPath = Path.Combine(SFile.notesDir, fileName);

                    File.Copy(selectedFile, destinationPath, true);
                    ListItems(lstNotes, SFile.GetFiles(SFile.notesDir));
                }
            }
        }

        private void btnSounds_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "SoundFont Dosyaları|*.sf2";
                ofd.Multiselect = false;
                ofd.Title = "SoundFont Dosyası Seçiniz...";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string selectedFile = ofd.FileName;
                    string fileName = Path.GetFileName(selectedFile);
                    string destinationPath = Path.Combine(SFile.soundsDir, fileName);

                    File.Copy(selectedFile, destinationPath, true);
                    ListItems(lstSounds, SFile.GetFiles(SFile.soundsDir));
                }
            }
        }

        /// <summary>
        /// Geri bildirim dialog'unu aç
        /// </summary>
        private void btnFeedback_Click(object sender, EventArgs e)
        {
            // İnternet kontrolü
            if (!SCloudSync.IsOnline())
            {
                MessageBox.Show("Geri bildirim göndermek için internete bağlanmanız gerekiyor!", "İnternet Gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (FrmFeedback frm = new FrmFeedback())
            {
                frm.ShowDialog();
            }
        }

        /// <summary>
        /// Keyboard shortcut handler: Ctrl + Shift + A → Admin Panel
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.A))
            {
                OpenAdminPanel();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        /// <summary>
        /// Admin panel'i aç (şifre ile)
        /// </summary>
        private void OpenAdminPanel()
        {
            using (FrmLogin loginForm = new FrmLogin())
            {
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    FrmAdmin adminPanel = new FrmAdmin();
                    adminPanel.Show(); // Modal değil, arka planda çalışabilsin
                }
            }
        }

        /// <summary>
        /// Bellek temizliği için yardımcı metod (Memory Leak olmasın)
        /// </summary>
        private void DisposeWave()
        {
            playbackTimer?.Stop();
            playbackTimer?.Dispose();
            playbackTimer = null;

            waveOutDevice?.Dispose();
            waveOutDevice = null;

            audioFileReader?.Dispose();
            audioFileReader = null;
        }

        /// <summary>
        /// Form kapanırken sesi kapatmayı unutma
        /// </summary>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();
        }
    }
}

