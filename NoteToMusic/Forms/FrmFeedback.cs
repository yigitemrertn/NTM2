using NoteToMusic.Entities;
using NoteToMusic.Services;
using System;
using System.Windows.Forms;

namespace NoteToMusic.Forms
{
    public partial class FrmFeedback : Form
    {
        public FrmFeedback()
        {
            InitializeComponent();
        }

        private void FrmFeedback_Load(object sender, EventArgs e)
        {
            // ComboBox'ları doldur (0-5 arası)
            for (int i = 0; i <= 5; i++)
            {
                cmbPerformance.Items.Add(i);
                cmbAccuracy.Items.Add(i);
                cmbFunctionality.Items.Add(i);
                cmbOverall.Items.Add(i);
            }

            // Kullanıcı adını otomatik doldur
            lblUsername.Text = $"Kullanıcı: {Environment.UserName}";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Internet kontrolü
            if (!SCloudSync.IsOnline())
            {
                MessageBox.Show("İnternet bağlantısı yok! Geri bildirim göndermek için internete bağlanmanız gerekiyor.", "İnternet Gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation
            if (cmbPerformance.SelectedIndex == -1 || cmbAccuracy.SelectedIndex == -1 ||
                cmbFunctionality.SelectedIndex == -1 || cmbOverall.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm puanlama alanlarını doldurun!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Feedback entity oluştur
            Feedback feedback = new Feedback
            {
                Username = Environment.UserName,
                PerformanceRating = cmbPerformance.SelectedIndex,
                AccuracyRating = cmbAccuracy.SelectedIndex,
                FunctionalityRating = cmbFunctionality.SelectedIndex,
                OverallRating = cmbOverall.SelectedIndex,
                Comments = rtbComments.Text,
                CreatedDate = DateTime.Now
            };

            // Validation
            string validationError = feedback.Validate();
            if (!string.IsNullOrEmpty(validationError))
            {
                MessageBox.Show(validationError, "Geçersiz Veri", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Supabase'e kaydet
            this.Cursor = Cursors.WaitCursor;
            btnSave.Enabled = false;

            try
            {
                string result = await SCloudSync.SyncFeedbackToCloud(feedback);

                if (string.IsNullOrEmpty(result))
                {
                    MessageBox.Show("Geri bildiriminiz başarıyla gönderildi. Teşekkür ederiz!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Geri bildirim gönderilemedi:\n\n{result}\n\nLütfen internet bağlantınızı kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Beklenmeyen hata:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnSave.Enabled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
