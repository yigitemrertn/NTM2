using System;
using System.Windows.Forms;

namespace NoteToMusic.Forms
{
    public partial class FrmBpm : Form
    {
        public FrmBpm()
        {
            InitializeComponent();
        }

        int bpm = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                bpm = Convert.ToInt32(txtBpm.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                lblInfo.Text = $"Hata: {ex.Message}";
            }
        }

        private void BpmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrmMain.bpm = bpm;
        }

        private void BpmForm_Load(object sender, EventArgs e)
        {
            txtBpm.Focus();
        }
    }
}
