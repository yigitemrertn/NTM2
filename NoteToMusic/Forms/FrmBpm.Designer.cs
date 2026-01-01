namespace NoteToMusic.Forms
{
    partial class FrmBpm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblInfo = new Label();
            txtBpm = new TextBox();
            btnStart = new Button();
            SuspendLayout();
            
            // lblInfo
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(30, 30);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(340, 28);
            lblInfo.TabIndex = 0;
            lblInfo.Text = "Lütfen BPM değerini giriniz (örn. 120):";
            
            // txtBpm
            txtBpm.BackColor = Color.FromArgb(39, 39, 58);
            txtBpm.BorderStyle = BorderStyle.FixedSingle;
            txtBpm.Font = new Font("Segoe UI", 11F);
            txtBpm.ForeColor = Color.White;
            txtBpm.Location = new Point(30, 70);
            txtBpm.Name = "txtBpm";
            txtBpm.Size = new Size(340, 32);
            txtBpm.TabIndex = 1;
            txtBpm.Text = "120";
            txtBpm.TextAlign = HorizontalAlignment.Center;
            
            // btnStart
            btnStart.BackColor = Color.FromArgb(59, 130, 246);
            btnStart.Cursor = Cursors.Hand;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(30, 120);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(340, 45);
            btnStart.TabIndex = 2;
            btnStart.Text = "Devam Et";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            
            // FrmBpm
            AcceptButton = btnStart;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 37);
            ClientSize = new Size(400, 195);
            Controls.Add(btnStart);
            Controls.Add(txtBpm);
            Controls.Add(lblInfo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmBpm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BPM Ayarı";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblInfo;
        private TextBox txtBpm;
        private Button btnStart;
    }
}
