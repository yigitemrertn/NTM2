using NoteToMusic.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteToMusic.Services
{
    /*
     * Created by: Yiðit Emre ERTEN
     * Date: 20.12.2025
     * Description: Audiveris iþlemlerini yöneten servis.
     */

    public class AudiverisService : IAudiverisService
    {
        private string _audiverisPath;

        public AudiverisService()
        {
            _audiverisPath = Properties.Settings.Default.AudiverisPath;
            CheckDepens();
        }


        /// <summary>
        /// Yüklenen resmi MXL formatýna dönüþtürür
        /// </summary>
        /// <param name="imagePath">Ýlgili resmin yolu</param>
        public async Task ConvertToMxlAsync(string imagePath)
        {
            await Task.Run(() =>
            {
                try
                {
                    using (Process p = new Process())
                    {
                        var startInfo = new ProcessStartInfo
                        {
                            FileName = _audiverisPath,
                            //KOD:  audiveris -batch -output cýkýsyolu -export -- resimyolu
                            Arguments = $"-batch -output \"{FileService.tempDir}\" -export -- \"{imagePath}\"",
                            RedirectStandardOutput = false,
                            RedirectStandardError = false,
                            CreateNoWindow = true,
                            UseShellExecute = false
                        };
                        p.StartInfo = startInfo;
                        p.Start();
                        p.WaitForExit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("XML Dönüþtürme iþlemi sýrasýnda bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            });
            
        }

        /// <summary>
        /// MXL yolunu döndürür
        /// </summary>
        /// <param name="imagePath">Ýlgili remsin yolu</param>
        /// <returns>MXL yol deðerir</returns>
        public string GetMxlPath(string imagePath)
        {
            return Path.Combine(FileService.tempDir, Path.GetFileNameWithoutExtension(imagePath) + ".mxl");
        }

        /// <summary>
        /// MXL dosyasýný XML'e dönüþtürür
        /// </summary>
        /// <param name="mxlFile">MXL dosyasýnýn yolu</param>
        public async Task ConvertToXmlAsync(string mxlFile)
        {
            await Task.Run(() =>
            {
                try
                {
                    if (!File.Exists(mxlFile))
                    {
                        return;
                    }

                    using (ZipArchive archive = ZipFile.OpenRead(mxlFile))
                    {
                        var xmlEntry = archive.Entries.FirstOrDefault(f => f.Name.EndsWith(".xml") || f.Name.EndsWith(".musicxml"));

                        if (xmlEntry == null)
                        {
                            MessageBox.Show(".mxl içinde .xml veya .musicxml dosyasý bulunamadý!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string xmlFilePath = Path.Combine(FileService.tempDir, xmlEntry.Name);

                        xmlEntry.ExtractToFile(xmlFilePath, true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ayýklama iþlemi sýrasýnda bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            });
            
        }


        /// <summary>
        /// XML dosyasýnýn yolunu döndürür
        /// </summary>
        /// <param name="imagePath">Ýlgili resmin yolu</param>
        /// <returns>MXL dosyasýnýn yolu</returns>
        public string GetXmlPath(string imagePath)
        {
            return Path.Combine(FileService.tempDir, Path.GetFileNameWithoutExtension(imagePath) + ".xml");
        }

        /// <summary>
        /// Programýn baðýmlýlýklarýný kontrol eder (Audiveris.exe var mý?)
        /// </summary>
        private void CheckDepens()
        {
            if (File.Exists(_audiverisPath))
            {
                return;
            }

            MessageBox.Show("Audiveris path'i bulunamadý. Lütfen Audiveris.exe dosyasýnýn konumunu belirtiniz.", "Dosya Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Executable Files|*.exe|All Files|*.*";
                ofd.Title = "Baðýmlýlýk Dosyasýný Seç";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.AudiverisPath = ofd.FileName;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    // Seçmediyse kapat ya da hata ver
                    MessageBox.Show("Dosya seçilmedi... Program Audiveris olmadan çalýþamaz lütfen Audiverisi indirip tekrar baþlatýn", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }
    }



}
