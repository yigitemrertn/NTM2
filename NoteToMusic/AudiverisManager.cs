using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteToMusic
{
    public class AudiverisManager
    {
        private string audiverisPath;

        public AudiverisManager()
        {
            audiverisPath = Properties.Settings.Default.AudiverisPath;
            CheckDepens();
        }


        public async Task ConvertToMXL(string imagePath)
        {
            await Task.Run(() =>
            {
                using (Process p = new Process())
                {
                    var startInfo = new ProcessStartInfo
                    {
                        FileName = audiverisPath,
                        //KOD:  audiveris -batch -output cıkısyolu -export -- resimyolu
                        Arguments = $"-batch -output \"{FileManager.tempDir}\" -export -- \"{imagePath}\"",
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
            
        }

        public string GetMxlPath(string imagePath)
        {
            return Path.Combine(FileManager.tempDir, Path.GetFileNameWithoutExtension(imagePath) + ".mxl");
        }

        public string GetXmlPath(string imagePath)
        {
            return Path.Combine(FileManager.tempDir, Path.GetFileNameWithoutExtension(imagePath) + ".xml");
        }

        public async Task ConvertToXML(string mxlFile)
        {
            await Task.Run(() =>
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
                        MessageBox.Show(".mxl içinde .xml veya .musicxml dosyası bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string xmlFilePath = Path.Combine(FileManager.tempDir, xmlEntry.Name);

                    xmlEntry.ExtractToFile(xmlFilePath, true);
                }
            });
            
        }
        private void CheckDepens()
        {
            if (File.Exists(audiverisPath))
            {
                return;
            }

            MessageBox.Show("Audiveris path'i bulunamadı. Lütfen Audiveris.exe dosyasının konumunu belirtiniz.", "Dosya Eksik", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Executable Files|*.exe|All Files|*.*"; // Dosya tipine göre filtrele
                ofd.Title = "Bağımlılık Dosyasını Seç";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Ayarı güncelle
                    Properties.Settings.Default.AudiverisPath = ofd.FileName;
                    // Diske yaz (AppData altına user.config oluşturur)
                    Properties.Settings.Default.Save();
                }
                else
                {
                    // Seçmediyse kapat ya da hata ver
                    MessageBox.Show("Dosya seçilmedi... Program Audiveris olmadan çalışamaz lütfen Audiverisi indirip tekrar başlatın", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
        }
    }



}
