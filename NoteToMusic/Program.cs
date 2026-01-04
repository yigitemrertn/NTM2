using NoteToMusic.Forms;
using System;
using System.Windows.Forms;

namespace NoteToMusic
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Syncfusion lisans kaydı
            // Trial mode için boş bırakılabilir, 30 günlük deneme başlar
            // Community License için https://www.syncfusion.com/products/communitylicense adresinden key alınmalı
            try
            {
                string? licenseKey = System.Configuration.ConfigurationManager.AppSettings["SyncfusionLicenseKey"];
                if (!string.IsNullOrWhiteSpace(licenseKey))
                {
                    Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(licenseKey);
                }
                // Lisans key boşsa trial mode otomatik başlar
            }
            catch (Exception ex)
            {
                // Lisans hatası uygulamayı durdurmasın, trial mode devam etsin
                System.Diagnostics.Debug.WriteLine($"Syncfusion lisans hatası: {ex.Message}");
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new FrmMain());
        }
    }
}