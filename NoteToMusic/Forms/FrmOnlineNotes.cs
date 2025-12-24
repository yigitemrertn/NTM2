using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NoteToMusic.Forms
{
    /// <summary>
    /// IMSLP nota arama - Browser'da açma
    /// </summary>
    public partial class FrmOnlineNotes : Form
    {
        public FrmOnlineNotes()
        {
            InitializeComponent();
        }

        private void FrmOnlineNotes_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "IMSLP'de arama yapmak için yukarıdaki kutuya besteci veya eser adı girin.";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();
            
            if (string.IsNullOrWhiteSpace(query))
            {
                MessageBox.Show("Lütfen bir arama terimi girin (örn: beethoven, mozart, symphony).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // IMSLP search URL
                string searchUrl = $"https://imslp.org/wiki/Special:Search?search={Uri.EscapeDataString(query)}";

                // Browser'da aç
                Process.Start(new ProcessStartInfo
                {
                    FileName = searchUrl,
                    UseShellExecute = true
                });

                lblStatus.Text = $"IMSLP'de '{query}' araması browser'da açıldı.";
                MessageBox.Show($"IMSLP sitesi browser'da açıldı.\n\nArama: {query}\n\nİstediğiniz notayı bulup manuel olarak indirebilirsiniz.", "Site Açıldı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Site açılırken hata:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                // IMSLP ana sayfa
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://imslp.org/wiki/Main_Page",
                    UseShellExecute = true
                });

                lblStatus.Text = "IMSLP ana sayfası açıldı.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Site açılırken hata:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
