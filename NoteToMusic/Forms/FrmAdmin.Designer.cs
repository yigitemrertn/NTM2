namespace NoteToMusic.Forms
{
    partial class FrmAdmin
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
            grpFilters = new System.Windows.Forms.GroupBox();
            lblStartDate = new System.Windows.Forms.Label();
            dtpStart = new System.Windows.Forms.DateTimePicker();
            lblEndDate = new System.Windows.Forms.Label();
            dtpEnd = new System.Windows.Forms.DateTimePicker();
            lblUserFilter = new System.Windows.Forms.Label();
            txtUserFilter = new System.Windows.Forms.TextBox();
            lblMinRating = new System.Windows.Forms.Label();
            nudMinRating = new System.Windows.Forms.NumericUpDown();
            btnFilter = new System.Windows.Forms.Button();
            btnClearFilter = new System.Windows.Forms.Button();
            btnRefresh = new System.Windows.Forms.Button();
            btnExportExcel = new System.Windows.Forms.Button();
            dgvFeedback = new System.Windows.Forms.DataGridView();
            grpStatistics = new System.Windows.Forms.GroupBox();
            lblTotalFeedback = new System.Windows.Forms.Label();
            lblAvgOverall = new System.Windows.Forms.Label();
            lblAvgPerformance = new System.Windows.Forms.Label();
            lblAvgAccuracy = new System.Windows.Forms.Label();
            lblAvgFunctionality = new System.Windows.Forms.Label();
            lblStatus = new System.Windows.Forms.Label();
            grpFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinRating).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFeedback).BeginInit();
            grpStatistics.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblTitle.Location = new System.Drawing.Point(320, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(360, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "NTM2 Admin Panel - Feedback Yönetimi";
            // 
            // grpFilters
            // 
            grpFilters.Controls.Add(lblStartDate);
            grpFilters.Controls.Add(dtpStart);
            grpFilters.Controls.Add(lblEndDate);
            grpFilters.Controls.Add(dtpEnd);
            grpFilters.Controls.Add(lblUserFilter);
            grpFilters.Controls.Add(txtUserFilter);
            grpFilters.Controls.Add(lblMinRating);
            grpFilters.Controls.Add(nudMinRating);
            grpFilters.Controls.Add(btnFilter);
            grpFilters.Controls.Add(btnClearFilter);
            grpFilters.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            grpFilters.Location = new System.Drawing.Point(20, 60);
            grpFilters.Name = "grpFilters";
            grpFilters.Size = new System.Drawing.Size(960, 100);
            grpFilters.TabIndex = 1;
            grpFilters.TabStop = false;
            grpFilters.Text = "Filtreler";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblStartDate.Location = new System.Drawing.Point(15, 30);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new System.Drawing.Size(60, 15);
            lblStartDate.TabIndex = 0;
            lblStartDate.Text = "Başlangıç:";
            // 
            // dtpStart
            // 
            dtpStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpStart.Location = new System.Drawing.Point(15, 50);
            dtpStart.Name = "dtpStart";
            dtpStart.ShowCheckBox = true;
            dtpStart.Size = new System.Drawing.Size(140, 23);
            dtpStart.TabIndex = 1;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblEndDate.Location = new System.Drawing.Point(175, 30);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new System.Drawing.Size(32, 15);
            lblEndDate.TabIndex = 2;
            lblEndDate.Text = "Bitiş:";
            // 
            // dtpEnd
            // 
            dtpEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dtpEnd.Location = new System.Drawing.Point(175, 50);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.ShowCheckBox = true;
            dtpEnd.Size = new System.Drawing.Size(140, 23);
            dtpEnd.TabIndex = 3;
            // 
            // lblUserFilter
            // 
            lblUserFilter.AutoSize = true;
            lblUserFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblUserFilter.Location = new System.Drawing.Point(335, 30);
            lblUserFilter.Name = "lblUserFilter";
            lblUserFilter.Size = new System.Drawing.Size(57, 15);
            lblUserFilter.TabIndex = 4;
            lblUserFilter.Text = "Kullanıcı:";
            // 
            // txtUserFilter
            // 
            txtUserFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            txtUserFilter.Location = new System.Drawing.Point(335, 50);
            txtUserFilter.Name = "txtUserFilter";
            txtUserFilter.PlaceholderText = "Kullanıcı adı ara...";
            txtUserFilter.Size = new System.Drawing.Size(150, 23);
            txtUserFilter.TabIndex = 5;
            // 
            // lblMinRating
            // 
            lblMinRating.AutoSize = true;
            lblMinRating.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblMinRating.Location = new System.Drawing.Point(505, 30);
            lblMinRating.Name = "lblMinRating";
            lblMinRating.Size = new System.Drawing.Size(100, 15);
            lblMinRating.TabIndex = 6;
            lblMinRating.Text = "Min Genel Puan:";
            // 
            // nudMinRating
            // 
            nudMinRating.Font = new System.Drawing.Font("Segoe UI", 9F);
            nudMinRating.Location = new System.Drawing.Point(505, 50);
            nudMinRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudMinRating.Name = "nudMinRating";
            nudMinRating.Size = new System.Drawing.Size(80, 23);
            nudMinRating.TabIndex = 7;
            // 
            // btnFilter
            // 
            btnFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnFilter.Location = new System.Drawing.Point(710, 45);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new System.Drawing.Size(110, 30);
            btnFilter.TabIndex = 8;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // btnClearFilter
            // 
            btnClearFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            btnClearFilter.Location = new System.Drawing.Point(830, 45);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new System.Drawing.Size(110, 30);
            btnClearFilter.TabIndex = 9;
            btnClearFilter.Text = "Temizle";
            btnClearFilter.UseVisualStyleBackColor = true;
            btnClearFilter.Click += btnClearFilter_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnRefresh.Location = new System.Drawing.Point(750, 170);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new System.Drawing.Size(110, 35);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "🔄 Yenile";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            btnExportExcel.Location = new System.Drawing.Point(870, 170);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new System.Drawing.Size(110, 35);
            btnExportExcel.TabIndex = 3;
            btnExportExcel.Text = "📊 Excel'e Aktar";
            btnExportExcel.UseVisualStyleBackColor = true;
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // dgvFeedback
            // 
            dgvFeedback.AllowUserToAddRows = false;
            dgvFeedback.AllowUserToDeleteRows = false;
            dgvFeedback.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFeedback.Location = new System.Drawing.Point(20, 215);
            dgvFeedback.Name = "dgvFeedback";
            dgvFeedback.ReadOnly = true;
            dgvFeedback.RowHeadersWidth = 25;
            dgvFeedback.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvFeedback.Size = new System.Drawing.Size(960, 350);
            dgvFeedback.TabIndex = 4;
            // 
            // grpStatistics
            // 
            grpStatistics.Controls.Add(lblTotalFeedback);
            grpStatistics.Controls.Add(lblAvgOverall);
            grpStatistics.Controls.Add(lblAvgPerformance);
            grpStatistics.Controls.Add(lblAvgAccuracy);
            grpStatistics.Controls.Add(lblAvgFunctionality);
            grpStatistics.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            grpStatistics.Location = new System.Drawing.Point(20, 575);
            grpStatistics.Name = "grpStatistics";
            grpStatistics.Size = new System.Drawing.Size(960, 70);
            grpStatistics.TabIndex = 5;
            grpStatistics.TabStop = false;
            grpStatistics.Text = "İstatistikler";
            // 
            // lblTotalFeedback
            // 
            lblTotalFeedback.AutoSize = true;
            lblTotalFeedback.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblTotalFeedback.Location = new System.Drawing.Point(15, 30);
            lblTotalFeedback.Name = "lblTotalFeedback";
            lblTotalFeedback.Size = new System.Drawing.Size(110, 15);
            lblTotalFeedback.TabIndex = 0;
            lblTotalFeedback.Text = "Toplam Feedback: 0";
            // 
            // lblAvgOverall
            // 
            lblAvgOverall.AutoSize = true;
            lblAvgOverall.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            lblAvgOverall.ForeColor = System.Drawing.Color.DarkGreen;
            lblAvgOverall.Location = new System.Drawing.Point(200, 28);
            lblAvgOverall.Name = "lblAvgOverall";
            lblAvgOverall.Size = new System.Drawing.Size(150, 19);
            lblAvgOverall.TabIndex = 1;
            lblAvgOverall.Text = "Ort. Genel Puan: -";
            // 
            // lblAvgPerformance
            // 
            lblAvgPerformance.AutoSize = true;
            lblAvgPerformance.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblAvgPerformance.Location = new System.Drawing.Point(420, 30);
            lblAvgPerformance.Name = "lblAvgPerformance";
            lblAvgPerformance.Size = new System.Drawing.Size(80, 15);
            lblAvgPerformance.TabIndex = 2;
            lblAvgPerformance.Text = "Ort. Hız: -";
            // 
            // lblAvgAccuracy
            // 
            lblAvgAccuracy.AutoSize = true;
            lblAvgAccuracy.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblAvgAccuracy.Location = new System.Drawing.Point(560, 30);
            lblAvgAccuracy.Name = "lblAvgAccuracy";
            lblAvgAccuracy.Size = new System.Drawing.Size(110, 15);
            lblAvgAccuracy.TabIndex = 3;
            lblAvgAccuracy.Text = "Ort. Doğruluk: -";
            // 
            // lblAvgFunctionality
            // 
            lblAvgFunctionality.AutoSize = true;
            lblAvgFunctionality.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblAvgFunctionality.Location = new System.Drawing.Point(730, 30);
            lblAvgFunctionality.Name = "lblAvgFunctionality";
            lblAvgFunctionality.Size = new System.Drawing.Size(90, 15);
            lblAvgFunctionality.TabIndex = 4;
            lblAvgFunctionality.Text = "Ort. İşlev: -";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            lblStatus.ForeColor = System.Drawing.Color.Gray;
            lblStatus.Location = new System.Drawing.Point(20, 655);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new System.Drawing.Size(100, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Hazır...";
            // 
            // FrmAdmin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1000, 680);
            Controls.Add(lblStatus);
            Controls.Add(grpStatistics);
            Controls.Add(dgvFeedback);
            Controls.Add(btnExportExcel);
            Controls.Add(btnRefresh);
            Controls.Add(grpFilters);
            Controls.Add(lblTitle);
            Name = "FrmAdmin";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "NTM2 Admin Panel";
            Load += FrmAdmin_Load;
            grpFilters.ResumeLayout(false);
            grpFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinRating).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFeedback).EndInit();
            grpStatistics.ResumeLayout(false);
            grpStatistics.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpFilters;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblUserFilter;
        private System.Windows.Forms.TextBox txtUserFilter;
        private System.Windows.Forms.Label lblMinRating;
        private System.Windows.Forms.NumericUpDown nudMinRating;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridView dgvFeedback;
        private System.Windows.Forms.GroupBox grpStatistics;
        private System.Windows.Forms.Label lblTotalFeedback;
        private System.Windows.Forms.Label lblAvgOverall;
        private System.Windows.Forms.Label lblAvgPerformance;
        private System.Windows.Forms.Label lblAvgAccuracy;
        private System.Windows.Forms.Label lblAvgFunctionality;
        private System.Windows.Forms.Label lblStatus;
    }
}
