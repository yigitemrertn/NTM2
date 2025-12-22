using NAudio.Wave;
using NoteToMusic.Interfaces;
using NoteToMusic.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteToMusic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //Objects
        private readonly IAudiverisService _audiverisService  = new AudiverisService();
        private readonly INaudioService _naudioService = new NaudioService();
        private readonly IMeltySynthService _meltySytnhService = new MeltySynthService();

        //Variables
        string currentNote = "", currentSound = "", currentMusic  = "";
        bool isPlaying;
        bool isUpdatingTrackBar = false;
        public static int bpm = 0;

        IWavePlayer? waveOutDevice;
        AudioFileReader? audioFileReader;
        private System.Windows.Forms.Timer? playbackTimer;

        private void ListItems(ListBox lstBox, List<string> files)
        {
            lstBox.Items.Clear();
            foreach (var item in files)
            {
                lstBox.Items.Add(item);
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            //Dosya oluþturma
            FileService.CheckAndCreateDirectories();
            //Listeleme
            ListItems(lstNotes, FileService.GetFiles(FileService.notesDir));
            ListItems(lstSounds, FileService.GetFiles(FileService.soundsDir));
            ListItems(lstMusics, FileService.GetFiles(FileService.musicDir));
            // TrackBar baþlangýç ayarlarý
            trackVolume.Value = 100;
            trackTime.Enabled = false;
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Resim Dosyalarý|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.RestoreDirectory = true;
                ofd.CheckFileExists = true;
                ofd.Title = "Nota Þemasyonu Seçiniz...";

                if (ofd.ShowDialog() != DialogResult.OK) return;
                else
                {
                    picNote.Image = Image.FromFile(ofd.FileName);
                    string destPath = Path.Combine(FileService.notesDir, Path.GetFileName(ofd.FileName));
                    File.Copy(ofd.FileName, destPath, true);
                    currentNote = ofd.FileName;
                    ListItems(lstNotes, FileService.GetFiles(FileService.notesDir));
                }
            }
        }
        private void btnSounds_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "SoundFont Dosyalarý|*.sf2";
                ofd.RestoreDirectory = true;
                ofd.CheckFileExists = true;
                ofd.Title = "SoundFont Dosyasý Seçiniz...";
                if (ofd.ShowDialog() != DialogResult.OK) return;
                else
                {
                    string destPath = Path.Combine(FileService.soundsDir, Path.GetFileName(ofd.FileName));
                    File.Copy(ofd.FileName, destPath, true);
                    currentSound = ofd.FileName;
                    ListItems(lstSounds, FileService.GetFiles(FileService.soundsDir));
                }
            }
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            if (currentNote == "" || currentSound == "")
            {
                MessageBox.Show("Lütfen bir nota þemasyonu ve bir SoundFont dosyasý seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            #region FIRSTSTEP
            //Png to MXL
            try
            {
                btnConvert.Enabled = false;
                btnConvert.Text = "XML Dönüþümü yapýlýyor...";
                await _audiverisService.ConvertToMxlAsync(currentNote);
            }
            catch (Exception ex)
            {
                MessageBox.Show("XML Dönüþtürme iþlemi sýrasýnda bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnConvert.Enabled = true;
                btnConvert.Text = "Dönüþtür!";
            }
            #endregion
            #region SECONDSTEP
            //MXL to XML
            try
            {
                btnConvert.Text = "XML Çýkarýlýyor...";
                await _audiverisService.ConvertToXmlAsync(_audiverisService.GetMxlPath(currentNote));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ayýklama iþlemi sýrasýnda bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnConvert.Enabled = true;
                btnConvert.Text = "Dönüþtür!";
            }
            #endregion
            #region THIRDSTEP
            //XML to MID
            try
            {
                BpmForm bpmform = new BpmForm();
                bpmform.ShowDialog();
                btnConvert.Text = "Midi Dönüþümü...";
                await _naudioService.ConvertXmlToMidiAsync(_audiverisService.GetXmlPath(currentNote), _naudioService.GetMidPath(currentNote), bpm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Midi Dönüþtürme iþlemi sýrasýnda bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                btnConvert.Enabled = true;
                btnConvert.Text = "Dönüþtür!";
            }

            #endregion
            #region FOURTHSTEP
            //MID + sf2 TO WAW
            try
            {
                btnConvert.Text = "WAV Render Alýnýyor...";
                btnConvert.Enabled = false;

                // SoundRenderer sýnýfýný çaðýr
                await _meltySytnhService.ConvertMidiToWav(_naudioService.GetMidPath(currentNote), currentSound);

                MessageBox.Show("Dönüþtürme Baþarýyla Tamamlandý!", "Baþarýlý", MessageBoxButtons.OK, MessageBoxIcon.Information);

                currentMusic = _meltySytnhService.GetWavPath();

                // Listbox'ý yenile ki yeni gelen müzik görünsün
                ListItems(lstMusics, FileService.GetFiles(FileService.musicDir));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Render sýrasýnda hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnConvert.Enabled = true;
                btnConvert.Text = "Dönüþtür!";
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

                currentNote = Path.Combine(FileService.notesDir, fileName);

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
                    currentSound = Path.Combine(FileService.soundsDir, fileName);
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

                currentMusic = Path.Combine(FileService.musicDir, fileName);

                string newMusic = fileName.Split('(')[0].Trim();

                foreach (var item in lstNotes.Items)
                {
                    string fullImageName = item.ToString() ?? "";
                    string imageNameOnly = Path.GetFileNameWithoutExtension(fullImageName);

                    if (imageNameOnly.Contains(newMusic))
                    {
                        picNote.Image = Image.FromFile(Path.Combine(FileService.notesDir, fullImageName));
                        break;
                    }
                }
            }

        }

        private void btnPlayStop_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrEmpty(currentMusic) || !File.Exists(currentMusic))
            {
                MessageBox.Show("Lütfen geçerli bir müzik seçin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isPlaying)
            {
                // OYNATMA BAÞLAT
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

                        // Þarký bittiðinde butonu eski haline getirmek için event
                        waveOutDevice.PlaybackStopped += (s, a) =>
                        {
                            isPlaying = false;
                            btnPlayStop.Text = "Oynat";
                            trackTime.Value = 0;
                            playbackTimer?.Stop();
                            DisposeWave();
                        };

                        // Playback Timer'ý baþlat (100ms interval ile güncelle)
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oynatma hatasý: " + ex.Message);
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

                // TrackBar'ý güncelle
                trackTime.Value = Math.Min(currentSeconds, trackTime.Maximum);

                // Zaman etiketi güncelle (MM:SS / MM:SS formatýnda)
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
            // Kullanýcý TrackBar'ý kaydýrdýðýnda, müzik pozisyonunu deðiþtir
            if (audioFileReader != null && waveOutDevice != null && waveOutDevice.PlaybackState != PlaybackState.Stopped)
            {
                audioFileReader.CurrentTime = TimeSpan.FromSeconds(trackTime.Value);
            }
        }

        private void trackVolume_Scroll(object sender, EventArgs e)
        {
            // Ses seviyesini 0-100 arasýnda ayarla
            if (audioFileReader != null)
            {
                audioFileReader.Volume = trackVolume.Value / 100f;
            }
        }

        // Bellek temizliði için yardýmcý metod (Memory Leak olmasýn)
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

        // Form kapanýrken sesi kapatmayý unutma
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();
        }

        
    }
}
