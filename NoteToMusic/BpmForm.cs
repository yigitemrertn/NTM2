using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteToMusic
{
    public partial class BpmForm : Form
    {
        public BpmForm()
        {
            InitializeComponent();
        }
        int bpm = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bpm = Convert.ToInt32(textBox1.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu. " + ex.Message);
            }
        }

        private void BpmForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.bpm = bpm;
        }

        private void BpmForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void BpmForm_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
