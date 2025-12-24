namespace NoteToMusic.Forms
{
    partial class FrmBpm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBpm = new TextBox();
            lblBpm = new Label();
            btnStart = new Button();
            lblInfo = new Label();
            SuspendLayout();
            // 
            // txtBpm
            // 
            txtBpm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtBpm.Location = new Point(187, 47);
            txtBpm.Margin = new Padding(4, 3, 4, 3);
            txtBpm.Name = "txtBpm";
            txtBpm.Size = new Size(204, 29);
            txtBpm.TabIndex = 0;
            // 
            // lblBpm
            // 
            lblBpm.AutoSize = true;
            lblBpm.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBpm.Location = new Point(40, 51);
            lblBpm.Margin = new Padding(4, 0, 4, 0);
            lblBpm.Name = "lblBpm";
            lblBpm.Size = new Size(139, 20);
            lblBpm.TabIndex = 1;
            lblBpm.Text = "Lütfen Bpm Giriniz:";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(40, 91);
            btnStart.Margin = new Padding(4, 3, 4, 3);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(351, 37);
            btnStart.TabIndex = 2;
            btnStart.Text = "Baþla";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = SystemColors.GrayText;
            lblInfo.Location = new Point(17, 198);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(404, 40);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "Þarkýnýn BPM(Tempo) deðerini metin kutusuna girip.\r\nEnter tuþuna basarak keyfinize göre ayarlayýnýz.";
            // 
            // BpmForm
            // 
            AcceptButton = btnStart;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 247);
            Controls.Add(lblInfo);
            Controls.Add(btnStart);
            Controls.Add(lblBpm);
            Controls.Add(txtBpm);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BpmForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "BpmForm";
            FormClosing += BpmForm_FormClosing;
            Load += BpmForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBpm;
        private System.Windows.Forms.Label lblBpm;
        private System.Windows.Forms.Button btnStart;
        private Label lblInfo;
    }
}
