using NoteToMusic.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteToMusic.Services
{
    public static class FileService
    {
        /*
        * Created by: Yiğit Emre ERTEN
        * Date: 21.12.2025
        * Description: Dosya yollarının bulunduğu static class
        */

        public static string baseDir => Application.StartupPath;
        public static string assetDir => Path.Combine(baseDir, "Assets");
        public static string notesDir => Path.Combine(assetDir, "Notes");
        public static string soundsDir => Path.Combine(assetDir, "Soundfonts");
        public static string musicDir => Path.Combine(assetDir, "Musics");
        public static string tempDir => Path.Combine(assetDir, "Temp");


        /// <summary>
        /// Kök dizininde gerekli klasörlerin varlığını kontrol eder, yoksa oluşturur.
        /// </summary>
        public static void CheckAndCreateDirectories()
        {
            string[] paths = { assetDir, notesDir, soundsDir, musicDir, tempDir };
            foreach (var item in paths)
            {
                if (!Directory.Exists(item))
                {
                    Directory.CreateDirectory(item);
                }
            }
        }

        /// <summary>
        /// Yol değeri verilen klasördeki dosyaların isimlerini döner.
        /// </summary>
        /// <param name="path">Klasörün yolu</param>
        /// <returns>Dosya yolu listesi</returns>
        public static List<string> GetFiles(string path)
        {
            var fileList = new List<string>();

            if (!Directory.Exists(path)) return fileList;

            var files = Directory.GetFiles(path);

            if (files.Length == 0)
            {
                // Dosya yoksa boş döner, UI tarafı "Dosya Yok" yazar
                return fileList;
            }

            foreach (var item in files)
            {
                fileList.Add(Path.GetFileName(item));
            }

            return fileList;
        }
    }
}

    
