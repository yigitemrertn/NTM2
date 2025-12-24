namespace NoteToMusic.Forms
{
    partial class FrmFeedback
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
            lblTitle = new System.Windows.Forms.Label();
            lblUsername = new System.Windows.Forms.Label();
            lblPerformance = new System.Windows.Forms.Label();
            cmbPerformance = new System.Windows.Forms.ComboBox();
            lblAccuracy = new System.Windows.Forms.Label();
            cmbAccuracy = new System.Windows.Forms.ComboBox();
            lblFunctionality = new System.Windows.Forms.Label();
            cmbFunctionality = new System.Windows.Forms.ComboBox();
            lblOverall = new System.Windows.Forms.Label();
            cmbOverall = new System.Windows.Forms.ComboBox();
            lblComments = new System.Windows.Forms.Label();
            rtbComments = new System.Windows.Forms.RichTextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(120, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(260, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Geri Bildirim Formu";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblUsername.Location = new System.Drawing.Point(20, 50);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new System.Drawing.Size(100, 15);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Kullanıcı: ";
            // 
            // lblPerformance
            // 
            lblPerformance.AutoSize = true;
            lblPerformance.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblPerformance.Location = new System.Drawing.Point(20, 85);
            lblPerformance.Name = "lblPerformance";
            lblPerformance.Size = new System.Drawing.Size(240, 15);
            lblPerformance.TabIndex = 2;
            lblPerformance.Text = "Programın çalışma hızına puanınız (0-5):";
            // 
            // cmbPerformance
            // 
            cmbPerformance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPerformance.Font = new System.Drawing.Font("Segoe UI", 9F);
            cmbPerformance.FormattingEnabled = true;
            cmbPerformance.Location = new System.Drawing.Point(280, 82);
            cmbPerformance.Name = "cmbPerformance";
            cmbPerformance.Size = new System.Drawing.Size(180, 23);
            cmbPerformance.TabIndex = 3;
            // 
            // lblAccuracy
            // 
            lblAccuracy.AutoSize = true;
            lblAccuracy.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblAccuracy.Location = new System.Drawing.Point(20, 120);
            lblAccuracy.Name = "lblAccuracy";
            lblAccuracy.Size = new System.Drawing.Size(260, 15);
            lblAccuracy.TabIndex = 4;
            lblAccuracy.Text = "Programın çalışma doğruluğuna puanınız (0-5):";
            // 
            // cmbAccuracy
            // 
            cmbAccuracy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbAccuracy.Font = new System.Drawing.Font("Segoe UI", 9F);
            cmbAccuracy.FormattingEnabled = true;
            cmbAccuracy.Location = new System.Drawing.Point(280, 117);
            cmbAccuracy.Name = "cmbAccuracy";
            cmbAccuracy.Size = new System.Drawing.Size(180, 23);
            cmbAccuracy.TabIndex = 5;
            // 
            // lblFunctionality
            // 
            lblFunctionality.AutoSize = true;
            lblFunctionality.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblFunctionality.Location = new System.Drawing.Point(20, 155);
            lblFunctionality.Name = "lblFunctionality";
            lblFunctionality.Size = new System.Drawing.Size(220, 15);
            lblFunctionality.TabIndex = 6;
            lblFunctionality.Text = "Programın işlevine puanınız (0-5):";
            // 
            // cmbFunctionality
            // 
            cmbFunctionality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbFunctionality.Font = new System.Drawing.Font("Segoe UI", 9F);
            cmbFunctionality.FormattingEnabled = true;
            cmbFunctionality.Location = new System.Drawing.Point(280, 152);
            cmbFunctionality.Name = "cmbFunctionality";
            cmbFunctionality.Size = new System.Drawing.Size(180, 23);
            cmbFunctionality.TabIndex = 7;
            // 
            // lblOverall
            // 
            lblOverall.AutoSize = true;
            lblOverall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lblOverall.Location = new System.Drawing.Point(20, 190);
            lblOverall.Name = "lblOverall";
            lblOverall.Size = new System.Drawing.Size(210, 15);
            lblOverall.TabIndex = 8;
            lblOverall.Text = "Programa genel puanınız (0-5):";
            // 
            // cmbOverall
            // 
            cmbOverall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbOverall.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            cmbOverall.FormattingEnabled = true;
            cmbOverall.Location = new System.Drawing.Point(280, 187);
            cmbOverall.Name = "cmbOverall";
            cmbOverall.Size = new System.Drawing.Size(180, 23);
            cmbOverall.TabIndex = 9;
            // 
            // lblComments
            // 
            lblComments.AutoSize = true;
            lblComments.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblComments.Location = new System.Drawing.Point(20, 230);
            lblComments.Name = "lblComments";
            lblComments.Size = new System.Drawing.Size(150, 15);
            lblComments.TabIndex = 10;
            lblComments.Text = "Yorumlarınız (opsiyonel):";
            // 
            // rtbComments
            // 
            rtbComments.Font = new System.Drawing.Font("Segoe UI", 9F);
            rtbComments.Location = new System.Drawing.Point(20, 250);
            rtbComments.Name = "rtbComments";
            rtbComments.Size = new System.Drawing.Size(440, 100);
            rtbComments.TabIndex = 11;
            rtbComments.Text = "";
            // 
            // btnSave
            // 
            btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnSave.Location = new System.Drawing.Point(250, 370);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(100, 35);
            btnSave.TabIndex = 12;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnCancel.Location = new System.Drawing.Point(360, 370);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(100, 35);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FrmFeedback
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(484, 421);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(rtbComments);
            Controls.Add(lblComments);
            Controls.Add(cmbOverall);
            Controls.Add(lblOverall);
            Controls.Add(cmbFunctionality);
            Controls.Add(lblFunctionality);
            Controls.Add(cmbAccuracy);
            Controls.Add(lblAccuracy);
            Controls.Add(cmbPerformance);
            Controls.Add(lblPerformance);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmFeedback";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Geri Bildirim";
            Load += FrmFeedback_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPerformance;
        private System.Windows.Forms.ComboBox cmbPerformance;
        private System.Windows.Forms.Label lblAccuracy;
        private System.Windows.Forms.ComboBox cmbAccuracy;
        private System.Windows.Forms.Label lblFunctionality;
        private System.Windows.Forms.ComboBox cmbFunctionality;
        private System.Windows.Forms.Label lblOverall;
        private System.Windows.Forms.ComboBox cmbOverall;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.RichTextBox rtbComments;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}
