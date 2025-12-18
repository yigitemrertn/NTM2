using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteToMusic
{
    public static class FileManager
    {
        static public string baseDir = Application.StartupPath; // bin\Debug
        static public string assetDir = Path.Combine(baseDir, "Assets");
        static public string notesDir = Path.Combine(assetDir, "Notes");
        static public string soundsDir = Path.Combine(assetDir, "Soundfonts");
        static public string musicDir = Path.Combine(assetDir, "Musics");
        static public string tempDir = Path.Combine(assetDir, "Temp");



        public static void ListItems(ListBox lstBox, String path)
        {
            lstBox.Items.Clear();
            var files = Directory.GetFiles(path);

            if (files.Length == 0)
            {
                lstBox.Items.Add("Dosya bulunamadı!");
                return;
            }
            foreach (var item in files)
            {
                lstBox.Items.Add(Path.GetFileName(item));
            }
        }
    }
}

    
