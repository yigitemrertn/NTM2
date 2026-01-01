namespace NoteToMusic.Forms
{
    partial class FrmFeedback
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
            pnlTitleBar = new Panel();
            lblTitle = new Label();
            pnlContent = new Panel();
            lblUsername = new Label();
            lblPerformance = new Label();
            cmbPerformance = new ComboBox();
            lblAccuracy = new Label();
            cmbAccuracy = new ComboBox();
            lblFunctionality = new Label();
            cmbFunctionality = new ComboBox();
            lblOverall = new Label();
            cmbOverall = new ComboBox();
            lblComments = new Label();
            rtbComments = new RichTextBox();
            pnlButtons = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            pnlTitleBar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            
            // pnlTitleBar
            pnlTitleBar.BackColor = Color.FromArgb(20, 20, 30);
            pnlTitleBar.Controls.Add(lblTitle);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(550, 50);
            pnlTitleBar.TabIndex = 0;
            
            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "💬 Geri Bildirim";
            
            // pnlContent
            pnlContent.BackColor = Color.FromArgb(24, 24, 37);
            pnlContent.Controls.Add(rtbComments);
            pnlContent.Controls.Add(lblComments);
            pnlContent.Controls.Add(cmbOverall);
            pnlContent.Controls.Add(lblOverall);
            pnlContent.Controls.Add(cmbFunctionality);
            pnlContent.Controls.Add(lblFunctionality);
            pnlContent.Controls.Add(cmbAccuracy);
            pnlContent.Controls.Add(lblAccuracy);
            pnlContent.Controls.Add(cmbPerformance);
            pnlContent.Controls.Add(lblPerformance);
            pnlContent.Controls.Add(lblUsername);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 50);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(20);
            pnlContent.Size = new Size(550, 470);
            pnlContent.TabIndex = 1;
            
            // lblUsername
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 10F);
            lblUsername.ForeColor = Color.FromArgb(161, 161, 170);
            lblUsername.Location = new Point(20, 20);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(130, 23);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Kullanıcı: USER";
            
            // lblPerformance
            lblPerformance.AutoSize = true;
            lblPerformance.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblPerformance.ForeColor = Color.White;
            lblPerformance.Location = new Point(20, 60);
            lblPerformance.Name = "lblPerformance";
            lblPerformance.Size = new Size(150, 25);
            lblPerformance.TabIndex = 1;
            lblPerformance.Text = "Hız Performansı:";
            
            // cmbPerformance
            cmbPerformance.BackColor = Color.FromArgb(39, 39, 58);
            cmbPerformance.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPerformance.FlatStyle = FlatStyle.Flat;
            cmbPerformance.Font = new Font("Segoe UI", 11F);
            cmbPerformance.ForeColor = Color.White;
            cmbPerformance.FormattingEnabled = true;
            cmbPerformance.Location = new Point(250, 57);
            cmbPerformance.Name = "cmbPerformance";
            cmbPerformance.Size = new Size(280, 33);
            cmbPerformance.TabIndex = 2;
            
            // lblAccuracy
            lblAccuracy.AutoSize = true;
            lblAccuracy.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblAccuracy.ForeColor = Color.White;
            lblAccuracy.Location = new Point(20, 110);
            lblAccuracy.Name = "lblAccuracy";
            lblAccuracy.Size = new Size(190, 25);
            lblAccuracy.TabIndex = 3;
            lblAccuracy.Text = "Doğruluk Performansı:";
            
            // cmbAccuracy
            cmbAccuracy.BackColor = Color.FromArgb(39, 39, 58);
            cmbAccuracy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAccuracy.FlatStyle = FlatStyle.Flat;
            cmbAccuracy.Font = new Font("Segoe UI", 11F);
            cmbAccuracy.ForeColor = Color.White;
            cmbAccuracy.FormattingEnabled = true;
            cmbAccuracy.Location = new Point(250, 107);
            cmbAccuracy.Name = "cmbAccuracy";
            cmbAccuracy.Size = new Size(280, 33);
            cmbAccuracy.TabIndex = 4;
            
            // lblFunctionality
            lblFunctionality.AutoSize = true;
            lblFunctionality.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblFunctionality.ForeColor = Color.White;
            lblFunctionality.Location = new Point(20, 160);
            lblFunctionality.Name = "lblFunctionality";
            lblFunctionality.Size = new Size(100, 25);
            lblFunctionality.TabIndex = 5;
            lblFunctionality.Text = "İşlevsellik:";
            
            // cmbFunctionality
            cmbFunctionality.BackColor = Color.FromArgb(39, 39, 58);
            cmbFunctionality.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFunctionality.FlatStyle = FlatStyle.Flat;
            cmbFunctionality.Font = new Font("Segoe UI", 11F);
            cmbFunctionality.ForeColor = Color.White;
            cmbFunctionality.FormattingEnabled = true;
            cmbFunctionality.Location = new Point(250, 157);
            cmbFunctionality.Name = "cmbFunctionality";
            cmbFunctionality.Size = new Size(280, 33);
            cmbFunctionality.TabIndex = 6;
            
            // lblOverall
            lblOverall.AutoSize = true;
            lblOverall.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblOverall.ForeColor = Color.White;
            lblOverall.Location = new Point(20, 210);
            lblOverall.Name = "lblOverall";
            lblOverall.Size = new Size(160, 25);
            lblOverall.TabIndex = 7;
            lblOverall.Text = "Genel Memnuniyet:";
            
            // cmbOverall
            cmbOverall.BackColor = Color.FromArgb(39, 39, 58);
            cmbOverall.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOverall.FlatStyle = FlatStyle.Flat;
            cmbOverall.Font = new Font("Segoe UI", 11F);
            cmbOverall.ForeColor = Color.White;
            cmbOverall.FormattingEnabled = true;
            cmbOverall.Location = new Point(250, 207);
            cmbOverall.Name = "cmbOverall";
            cmbOverall.Size = new Size(280, 33);
            cmbOverall.TabIndex = 8;
            
            // lblComments
            lblComments.AutoSize = true;
            lblComments.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblComments.ForeColor = Color.White;
            lblComments.Location = new Point(20, 260);
            lblComments.Name = "lblComments";
            lblComments.Size = new Size(125, 25);
            lblComments.TabIndex = 9;
            lblComments.Text = "Yorumlarınız:";
            
            // rtbComments
            rtbComments.BackColor = Color.FromArgb(39, 39, 58);
            rtbComments.BorderStyle = BorderStyle.FixedSingle;
            rtbComments.Font = new Font("Segoe UI", 11F);
            rtbComments.ForeColor = Color.White;
            rtbComments.Location = new Point(20, 290);
            rtbComments.Name = "rtbComments";
            rtbComments.Size = new Size(510, 150);
            rtbComments.TabIndex = 10;
            rtbComments.Text = "";
            
            // pnlButtons
            pnlButtons.BackColor = Color.FromArgb(20, 20, 30);
            pnlButtons.Controls.Add(btnCancel);
            pnlButtons.Controls.Add(btnSave);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 520);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(550, 70);
            pnlButtons.TabIndex = 2;
            
            // btnSave
            btnSave.BackColor = Color.FromArgb(59, 130, 246);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(160, 15);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "Gönder";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            
            // btnCancel
            btnCancel.BackColor = Color.FromArgb(39, 39, 58);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(370, 15);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 40);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            
            // FrmFeedback
            AcceptButton = btnSave;
            CancelButton = btnCancel;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 37);
            ClientSize = new Size(550, 590);
            Controls.Add(pnlContent);
            Controls.Add(pnlButtons);
            Controls.Add(pnlTitleBar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFeedback";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Geri Bildirim";
            Load += FrmFeedback_Load;
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlTitleBar;
        private Label lblTitle;
        private Panel pnlContent;
        private Label lblUsername;
        private Label lblPerformance;
        private ComboBox cmbPerformance;
        private Label lblAccuracy;
        private ComboBox cmbAccuracy;
        private Label lblFunctionality;
        private ComboBox cmbFunctionality;
        private Label lblOverall;
        private ComboBox cmbOverall;
        private Label lblComments;
        private RichTextBox rtbComments;
        private Panel pnlButtons;
        private Button btnSave;
        private Button btnCancel;
    }
}
