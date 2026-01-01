using System;
using System.Drawing;
using System.Windows.Forms;

namespace NoteToMusic.Forms
{
    /// <summary>
    /// Created by: Yiğit Emre ERTEN
    /// Date: 01.01.2026
    /// Description: Kullanıcı tutorial formu - Adım adım kullanım kılavuzu
    /// </summary>
    public partial class FrmTutorial : Form
    {
        private int currentStep = 0;
        private readonly string[] tutorialSteps = new string[]
        {
            $"🎵 Note To Music'e Hoş Geldiniz!{Environment.NewLine}{Environment.NewLine}Bu uygulama, nota görsellerini müziğe dönüştürmenizi sağlar.{Environment.NewLine}{Environment.NewLine}Devam etmek için 'İleri' butonuna tıklayın.",
            
            $"📄 ADIM 1: Nota Ekleme{Environment.NewLine}{Environment.NewLine}Sol panelde 'Notalar' bölümünde '➕ Nota Ekle' butonuna tıklayın.{Environment.NewLine}{Environment.NewLine}PNG, JPG veya PDF formatında nota dosyalarını seçebilirsiniz.",
            
            $"🎹 ADIM 2: SoundFont Seçimi{Environment.NewLine}{Environment.NewLine}Sol panelde 'Soundfont' bölümünde '➕ SoundFont Ekle' butonuna tıklayın.{Environment.NewLine}{Environment.NewLine}.sf2 formatında soundfont dosyaları ekleyebilirsiniz.",
            
            $"🔄 ADIM 3: Dönüştürme{Environment.NewLine}{Environment.NewLine}Sol panelin en altındaki pembe 'DÖNÜŞTÜR' butonuna tıklayın.{Environment.NewLine}{Environment.NewLine}Audiveris, notayı MusicXML formatına dönüştürecektir.{Environment.NewLine}{Environment.NewLine}Bu işlem birkaç saniye sürebilir.",
            
            $"🎶 ADIM 4: Müzik Çalma{Environment.NewLine}{Environment.NewLine}Dönüştürme tamamlandığında, sağ paneldeki 'Müzikler' listesinde yeni müziğinizi göreceksiniz.{Environment.NewLine}{Environment.NewLine}'▶ Oynat' butonuna tıklayarak müziğinizi dinleyebilirsiniz!",
            
            $"⚙️ EK ÖZELLİKLER{Environment.NewLine}{Environment.NewLine}• Müzikler arasında geçiş: ⏮ ve ⏭ butonları{Environment.NewLine}• 5 saniye geri/ileri: -5s ve +5s butonları{Environment.NewLine}• Ses seviyesi: Alt kısımdaki ses kaydırıcısı{Environment.NewLine}• Zaman çubuğu: Şarkının istediğiniz yerine atlayın",
            
            $"✅ Tutorial Tamamlandı!{Environment.NewLine}{Environment.NewLine}Artık Note To Music'i kullanmaya hazırsınız.{Environment.NewLine}{Environment.NewLine}İyi müzikler! 🎵{Environment.NewLine}{Environment.NewLine}Dinlediğiniz müziklere geri bildirim verebilirsiniz."
        };

        public FrmTutorial()
        {
            InitializeComponent();
            UpdateTutorialContent();
        }

        private void UpdateTutorialContent()
        {
            txtTutorial.Text = tutorialSteps[currentStep];
            lblStepCounter.Text = $"Adım {currentStep + 1} / {tutorialSteps.Length}";
            
            // Button visibility
            btnPrevious.Enabled = currentStep > 0;
            btnNext.Enabled = currentStep <= tutorialSteps.Length - 1;
            
            if (currentStep == tutorialSteps.Length - 1)
            {
                btnNext.Text = "Kapat";
            }
            else
            {
                btnNext.Text = "İleri ➡";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentStep < tutorialSteps.Length - 1)
            {
                currentStep++;
                UpdateTutorialContent();
            }
            else
            {
                this.Close();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentStep > 0)
            {
                currentStep--;
                UpdateTutorialContent();
            }
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
