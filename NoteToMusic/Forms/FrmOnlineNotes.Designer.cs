namespace NoteToMusic.Forms
{
    partial class FrmOnlineNotes
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            lblStatus = new System.Windows.Forms.Label();
            btnBrowse = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblInfo = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(280, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Online Nota İndirme (IMSLP)";
            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSearch.Location = new System.Drawing.Point(20, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Besteci veya eser adı girin (örn: Beethoven, Symphony)";
            txtSearch.Size = new System.Drawing.Size(450, 25);
            txtSearch.TabIndex = 1;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnSearch.Location = new System.Drawing.Point(480, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(100, 25);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "🔍 IMSLP'de Ara";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblInfo
            // 
            lblInfo.Location = new System.Drawing.Point(20, 90);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new System.Drawing.Size(560, 80);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "IMSLP (International Music Score Library Project) - Public domain klasik müzik notaları\\r\\n\\r\\n" +
                          "✅ Ücretsiz ve legal\\r\\n" +
                          "✅ Yüksek kaliteli PDF/PNG\\r\\n" +
                          "✅ Binlerce besteci ve eser\\r\\n\\r\\n" +
                          "Site browser'da açılacak, istediğiniz notayı bulup manuel indirebilirsiniz.";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            lblStatus.ForeColor = System.Drawing.Color.Gray;
            lblStatus.Location = new System.Drawing.Point(20, 180);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(150, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Hazır...";
            // 
            // btnBrowse
            // 
            btnBrowse.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnBrowse.Location = new System.Drawing.Point(370, 210);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new System.Drawing.Size(100, 30);
            btnBrowse.TabIndex = 5;
            btnBrowse.Text = "🌐 IMSLP Ana Sayfa";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(480, 210);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(100, 30);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Kapat";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FrmOnlineNotes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(600, 260);
            Controls.Add(btnCancel);
            Controls.Add(btnBrowse);
            Controls.Add(lblStatus);
            Controls.Add(lblInfo);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmOnlineNotes";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Online Nota İndirme";
            Load += FrmOnlineNotes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInfo;
    }
}
