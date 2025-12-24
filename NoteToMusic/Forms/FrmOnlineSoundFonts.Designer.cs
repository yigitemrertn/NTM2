namespace NoteToMusic.Forms
{
    partial class FrmOnlineSoundFonts
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
            btnRefresh = new System.Windows.Forms.Button();
            dgvSoundFonts = new System.Windows.Forms.DataGridView();
            lblStatus = new System.Windows.Forms.Label();
            btnOpenSite = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvSoundFonts).BeginInit();
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
            lblTitle.Text = "Online SoundFont Kaynakları";
            // 
            // txtSearch
            // 
            txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            txtSearch.Location = new System.Drawing.Point(20, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Filtrele (bass, piano, complete...)";
            txtSearch.Size = new System.Drawing.Size(450, 25);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnRefresh.Location = new System.Drawing.Point(480, 50);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(100, 25);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "🔄 Yenile";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgvSoundFonts
            // 
            dgvSoundFonts.AllowUserToAddRows = false;
            dgvSoundFonts.AllowUserToDeleteRows = false;
            dgvSoundFonts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvSoundFonts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSoundFonts.Location = new System.Drawing.Point(20, 90);
            dgvSoundFonts.MultiSelect = false;
            dgvSoundFonts.Name = "dgvSoundFonts";
            dgvSoundFonts.ReadOnly = true;
            dgvSoundFonts.RowHeadersWidth = 25;
            dgvSoundFonts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvSoundFonts.Size = new System.Drawing.Size(660, 300);
            dgvSoundFonts.TabIndex = 3;
            dgvSoundFonts.SelectionChanged += dgvSoundFonts_SelectionChanged;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            lblStatus.ForeColor = System.Drawing.Color.Gray;
            lblStatus.Location = new System.Drawing.Point(20, 400);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(150, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Hazır...";
            // 
            // btnOpenSite
            // 
            btnOpenSite.Enabled = false;
            btnOpenSite.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnOpenSite.Location = new System.Drawing.Point(470, 425);
            btnOpenSite.Name = "btnOpenSite";
            btnOpenSite.Size = new System.Drawing.Size(100, 30);
            btnOpenSite.TabIndex = 5;
            btnOpenSite.Text = "🌐 Siteyi Aç";
            btnOpenSite.UseVisualStyleBackColor = true;
            btnOpenSite.Click += btnOpenSite_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(580, 425);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(100, 30);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Kapat";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FrmOnlineSoundFonts
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(700, 470);
            Controls.Add(btnCancel);
            Controls.Add(btnOpenSite);
            Controls.Add(lblStatus);
            Controls.Add(dgvSoundFonts);
            Controls.Add(btnRefresh);
            Controls.Add(txtSearch);
            Controls.Add(lblTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmOnlineSoundFonts";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "SoundFont Kaynakları";
            Load += FrmOnlineSoundFonts_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSoundFonts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dgvSoundFonts;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnOpenSite;
        private System.Windows.Forms.Button btnCancel;
    }
}
