using NoteToMusic.Helpers;
using System;
using System.Windows.Forms;

namespace NoteToMusic.Forms
{
    public partial class FrmLogin : Form
    {
        private int failedAttempts = 0;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            if (SecurityHelper.VerifyAdminPassword(password))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                failedAttempts++;
                
                if (failedAttempts >= 3)
                {
                    MessageBox.Show("Çok fazla hatalı deneme. Giriş iptal edildi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
                else
                {
                    MessageBox.Show($"Hatalı şifre! Kalan deneme hakkı: {3 - failedAttempts}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
