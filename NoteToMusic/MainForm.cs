using NAudio.Wave;
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
        AudiverisManager audiveris = new AudiverisManager();
        NAudioManager naudio = new NAudioManager();
        SoundRenderer renderer = new SoundRenderer();

        //Variables

        string currentNote = "", currentSound = "", currentMusic  = "";
        bool isPlaying;
        public static int bpm = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] paths = { FileManager.assetDir, FileManager.notesDir, FileManager.soundsDir, FileManager.musicDir, FileManager.tempDir };
            foreach (var item in paths)
            {
                if (!Directory.Exists(item))
                {
                    Directory.CreateDirectory(item);
                }
            }
            FileManager.ListItems(lstNotes, FileManager.notesDir);
            FileManager.ListItems(lstSounds, FileManager.soundsDir);
            FileManager.ListItems(lstMusics, FileManager.musicDir);
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.RestoreDirectory = true;
                ofd.CheckFileExists = true;
                ofd.Title = "Nota Şemasyonu Seçiniz...";

                if (ofd.ShowDialog() != DialogResult.OK) return;
                else
                {
                    picNote.Image = Image.FromFile(ofd.FileName);
                    string destPath = Path.Combine(FileManager.notesDir, Path.GetFileName(ofd.FileName));
                    File.Copy(ofd.FileName, destPath, true);
                    currentNote = ofd.FileName;
                    FileManager.ListItems(lstNotes, FileManager.notesDir);
                }
            }
        }
        private void btnSounds_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "SoundFont Dosyaları|*.sf2";
                ofd.RestoreDirectory = true;
                ofd.CheckFileExists = true;
                ofd.Title = "SoundFont Dosyası Seçiniz...";
                if (ofd.ShowDialog() != DialogResult.OK) return;
                else
                {
                    string destPath = Path.Combine(FileManager.soundsDir, Path.GetFileName(ofd.FileName));
                    File.Copy(ofd.FileName, destPath, true);
                    currentSound = ofd.FileName;
                    FileManager.ListItems(lstSounds, FileManager.soundsDir);
                }
            }
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            if (currentNote == "" || currentSound == "")
            {
                MessageBox.Show("Lütfen bir nota şemasyonu ve bir SoundFont dosyası seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            #region FIRSTSTEP
            //Png to MXL
            try
            {
                btnConvert.Enabled = false;
                btnConvert.Text = "XML Dönüşümü yapılıyor...";
                await audiveris.ConvertToMXL(currentNote);
            }
            catch (Exception ex)
            {
                MessageBox.Show("XML Dönüştürme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnConvert.Enabled = true;
                btnConvert.Text = "Dönüştür!";
            }
            #endregion
            #region SECONDSTEP
            //MXL to XML
            try
            {
                btnConvert.Text = "XML Çıkarılıyor...";
                await audiveris.ConvertToXML(audiveris.GetMxlPath(currentNote));

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ayıklama işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnConvert.Enabled = true;
                btnConvert.Text = "Dönüştür!";
            }
            #endregion
            #region THIRDSTEP
            //XML to MID
            try
            {
                BpmForm bpmform = new BpmForm();
                bpmform.ShowDialog();
                btnConvert.Text = "Midi Dönüşümü...";
                await naudio.ConvertXmlToMidi(audiveris.GetXmlPath(currentNote), naudio.getMidPath(currentNote), bpm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Midi Dönüştürme işlemi sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                btnConvert.Enabled = true;
                btnConvert.Text = "Dönüştür!";
            }

            #endregion
            #region FOURTHSTEP
            //MID + sf2 TO WAW
            try
            {
                btnConvert.Text = "WAV Render Alınıyor...";
                btnConvert.Enabled = false;

                // SoundRenderer sınıfını çağır
                await renderer.ConvertMidiToWav(naudio.getMidPath(currentNote), currentSound);

                MessageBox.Show("Dönüştürme Başarıyla Tamamlandı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                currentMusic = renderer.GetWavPath();

                // Listbox'ı yenile ki yeni gelen müzik görünsün
                FileManager.ListItems(lstMusics, FileManager.musicDir);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Render sırasında hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                currentNote = Path.Combine(FileManager.notesDir, fileName);

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
                // GÜNCELLEME: ?. ve ?? "" ekledik.
                string fileName = lstSounds.Items[index]?.ToString() ?? "";

                // Boş değilse yolu birleştir
                if (!string.IsNullOrEmpty(fileName))
                {
                    currentSound = Path.Combine(FileManager.soundsDir, fileName);
                }
            }
        }
        private void lstMusics_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lstMusics.SelectedIndex;

            // 1. Index kontrolü her şeyi kapsamalı
            if (index == -1) return;

            string fileName = lstMusics.Items[index]?.ToString() ?? "";

            if (!string.IsNullOrEmpty(fileName))
            {
                currentMusic = Path.Combine(FileManager.musicDir, fileName);

                // Trim() ekledik ki boşluklar eşleşmeyi bozmasın
                string newMusic = fileName.Split('(')[0].Trim();

                foreach (var item in lstNotes.Items)
                {
                    string fullImageName = item.ToString() ?? "";
                    string imageNameOnly = Path.GetFileNameWithoutExtension(fullImageName); // Split yerine daha güvenli

                    // İhtiyaca göre: imageNameOnly.Contains(newMusic) de olabilir
                    if (imageNameOnly.Contains(newMusic))
                    {
                        // Resim dosyasını yükle
                        picNote.Image = Image.FromFile(Path.Combine(FileManager.notesDir, fullImageName));
                        break; // Eşleşme bulduysan döngüden çıkabilirsin (isteğe bağlı)
                    }
                }
            }

        }

        IWavePlayer? waveOutDevice;
        AudioFileReader? audioFileReader;
        private void btnPlayStop_Click(object sender, EventArgs e)
        { 
            if (string.IsNullOrEmpty(currentMusic) || !File.Exists(currentMusic))
            {
                MessageBox.Show("Lütfen geçerli bir müzik seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                        // Şarkı bittiğinde butonu eski haline getirmek için event
                        waveOutDevice.PlaybackStopped += (s, a) =>
                        {
                            isPlaying = false;
                            btnPlayStop.Text = "Oynat";
                            DisposeWave();
                        };
                    }

                    waveOutDevice.Play();
                    isPlaying = true;
                    btnPlayStop.Text = "Durdur";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oynatma hatası: " + ex.Message);
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
                }
                // Stop eventi zaten tetikleneceği için buton yazısını orası değiştirecek
            }
        }

        // Bellek temizliği için yardımcı metod (Memory Leak olmasın)
        private void DisposeWave()
        {
            // ?. operatörü: "Eğer null değilse Dispose et, null ise hiçbir şey yapma"
            waveOutDevice?.Dispose();
            waveOutDevice = null;

            audioFileReader?.Dispose();
            audioFileReader = null;
        }

        // Form kapanırken sesi kapatmayı unutma
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();
        }

        
    }
}