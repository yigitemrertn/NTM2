using NoteToMusic.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteToMusic.Services
{
    /// <summary>
    /// Created by: Yiğit Emre ERTEN
    /// Date: 20.12.2025
    /// Description: Audiveris işlemlerini yöneten servis.
    /// </summary>
    public class SAudiveris : ISAudiveris
    {
        private readonly string _audiverisPath;

        public SAudiveris()
        {
            _audiverisPath = Properties.Settings.Default.AudiverisPath;
            CheckDepens();
        }

        /// <summary>
        /// Görüntü dosyasını MusicXML formatına dönüştürür.
        /// </summary>
        /// <param name="imagePath">Görüntü dosyasının yolu</param>
        /// <returns>Oluşturulan XML dosyasının yolu veya hata mesajı</returns>
        public async Task<string> ConvertImageToMusicXmlAsync(string imagePath)
        {
            try
            {
                // Step 1: Convert to MXL using Audiveris
                await Task.Run(() =>
                {
                    using (Process p = new Process())
                    {
                        var startInfo = new ProcessStartInfo
                        {
                            FileName = _audiverisPath,
                            Arguments = $"-batch -output \"{SFile.tempDir}\" -export -- \"{imagePath}\"",
                            RedirectStandardOutput = false,
                            RedirectStandardError = false,
                            CreateNoWindow = true,
                            UseShellExecute = false
                        };
                        p.StartInfo = startInfo;
                        p.Start();
                        p.WaitForExit();
                    }
                });

                // Step 2: Get MXL path and check if it exists
                string mxlPath = Path.Combine(SFile.tempDir, Path.GetFileNameWithoutExtension(imagePath) + ".mxl");
                
                if (!File.Exists(mxlPath))
                {
                    return "HATA: Audiveris MXL dosyası oluşturamadı.";
                }

                // Step 3: Extract XML from MXL
                string xmlPath = await Task.Run(() =>
                {
                    using (ZipArchive archive = ZipFile.OpenRead(mxlPath))
                    {
                        var xmlEntry = archive.Entries.FirstOrDefault(f => f.Name.EndsWith(".xml") || f.Name.EndsWith(".musicxml"));

                        if (xmlEntry == null)
                        {
                            return "HATA: .mxl içinde .xml veya .musicxml dosyası bulunamadı!";
                        }

                        string xmlFilePath = Path.Combine(SFile.tempDir, xmlEntry.Name);
                        xmlEntry.ExtractToFile(xmlFilePath, true);
                        return xmlFilePath;
                    }
                });

                // If extraction returned an error message
                if (xmlPath.StartsWith("HATA:"))
                {
                    return xmlPath;
                }

                return xmlPath;
            }
            catch (Exception ex)
            {
                return $"HATA: Görüntü -> MusicXML dönüştürme sırasında hata oluştu. {ex.Message}";
            }
        }


        /// <summary>
        /// Programın bağımlılıklarını kontrol eder (Audiveris.exe var mı?)
        /// </summary>
        private void CheckDepens()
        {
            if (File.Exists(_audiverisPath))
            {
                return;
            }

            MessageBox.Show("Audiveris path'i bulunamadı. Lütfen Audiveris.exe dosyasının konumunu belirtiniz.", "Dosya Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Executable Files|*.exe|All Files|*.*";
                ofd.Title = "Bağımlılık Dosyasını Seç";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.AudiverisPath = ofd.FileName;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Audiveris path'i başarıyla güncellendi. Lütfen uygulamayı yeniden başlatın.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Dosya seçilmedi... Program Audiveris olmadan çalışamaz lütfen Audiverisi indirip tekrar başlatın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }
    }
}
