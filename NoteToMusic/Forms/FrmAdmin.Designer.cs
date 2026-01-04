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

        private void InitializeComponent()
        {
            pnlTitleBar = new Panel();
            lblTitle = new Label();
            pnlStats = new Panel();
            lblTotalFeedback = new Label();
            lblAvgOverall = new Label();
            lblAvgPerformance = new Label();
            lblAvgAccuracy = new Label();
            lblAvgFunctionality = new Label();
            pnlFilters = new Panel();
            lblFilterTitle = new Label();
            lblStartDate = new Label();
            dtpStart = new DateTimePicker();
            lblEndDate = new Label();
            dtpEnd = new DateTimePicker();
            lblUserFilter = new Label();
            txtUserFilter = new TextBox();
            lblMinRating = new Label();
            nudMinRating = new NumericUpDown();
            btnFilter = new Button();
            btnClearFilter = new Button();
            pnlData = new Panel();
            dgvFeedback = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            pnlActions = new Panel();
            btnRefresh = new Button();
            btnExportExcel = new Button();
            lblStatus = new Label();
            pnlTitleBar.SuspendLayout();
            pnlStats.SuspendLayout();
            pnlFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinRating).BeginInit();
            pnlData.SuspendLayout();
            // SfDataGrid doesn't need ISupportInitialize
            pnlActions.SuspendLayout();
            SuspendLayout();
            
            // pnlTitleBar
            pnlTitleBar.BackColor = Color.FromArgb(20, 20, 30);
            pnlTitleBar.Controls.Add(lblTitle);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1400, 60);
            pnlTitleBar.TabIndex = 0;
            
            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(220, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🔧 Admin Paneli";
            
            // pnlStats
            pnlStats.BackColor = Color.FromArgb(30, 30, 46);
            pnlStats.Controls.Add(lblAvgFunctionality);
            pnlStats.Controls.Add(lblAvgAccuracy);
            pnlStats.Controls.Add(lblAvgPerformance);
            pnlStats.Controls.Add(lblAvgOverall);
            pnlStats.Controls.Add(lblTotalFeedback);
            pnlStats.Dock = DockStyle.Top;
            pnlStats.Location = new Point(0, 60);
            pnlStats.Name = "pnlStats";
            pnlStats.Padding = new Padding(20, 15, 20, 15);
            pnlStats.Size = new Size(1400, 80);
            pnlStats.TabIndex = 1;
            
            // lblTotalFeedback
            lblTotalFeedback.AutoSize = true;
            lblTotalFeedback.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotalFeedback.ForeColor = Color.White;
            lblTotalFeedback.Location = new Point(20, 25);
            lblTotalFeedback.Name = "lblTotalFeedback";
            lblTotalFeedback.Size = new Size(180, 28);
            lblTotalFeedback.TabIndex = 0;
            lblTotalFeedback.Text = "Toplam Feedback: 0";
            
            // lblAvgOverall
            lblAvgOverall.AutoSize = true;
            lblAvgOverall.Font = new Font("Segoe UI", 11F);
            lblAvgOverall.ForeColor = Color.FromArgb(161, 161, 170);
            lblAvgOverall.Location = new Point(250, 25);
            lblAvgOverall.Name = "lblAvgOverall";
            lblAvgOverall.Size = new Size(180, 25);
            lblAvgOverall.TabIndex = 1;
            lblAvgOverall.Text = "Ort. Genel Puan: -";
            
            // lblAvgPerformance
            lblAvgPerformance.AutoSize = true;
            lblAvgPerformance.Font = new Font("Segoe UI", 11F);
            lblAvgPerformance.ForeColor = Color.FromArgb(161, 161, 170);
            lblAvgPerformance.Location = new Point(480, 25);
            lblAvgPerformance.Name = "lblAvgPerformance";
            lblAvgPerformance.Size = new Size(110, 25);
            lblAvgPerformance.TabIndex = 2;
            lblAvgPerformance.Text = "Ort. Hız: -";
            
            // lblAvgAccuracy
            lblAvgAccuracy.AutoSize = true;
            lblAvgAccuracy.Font = new Font("Segoe UI", 11F);
            lblAvgAccuracy.ForeColor = Color.FromArgb(161, 161, 170);
            lblAvgAccuracy.Location = new Point(650, 25);
            lblAvgAccuracy.Name = "lblAvgAccuracy";
            lblAvgAccuracy.Size = new Size(160, 25);
            lblAvgAccuracy.TabIndex = 3;
            lblAvgAccuracy.Text = "Ort. Doğruluk: -";
            
            // lblAvgFunctionality
            lblAvgFunctionality.AutoSize = true;
            lblAvgFunctionality.Font = new Font("Segoe UI", 11F);
            lblAvgFunctionality.ForeColor = Color.FromArgb(161, 161, 170);
            lblAvgFunctionality.Location = new Point(860, 25);
            lblAvgFunctionality.Name = "lblAvgFunctionality";
            lblAvgFunctionality.Size = new Size(130, 25);
            lblAvgFunctionality.TabIndex = 4;
            lblAvgFunctionality.Text = "Ort. İşlev: -";
            
            // pnlFilters
            pnlFilters.BackColor = Color.FromArgb(30, 30, 46);
            pnlFilters.Controls.Add(btnClearFilter);
            pnlFilters.Controls.Add(btnFilter);
            pnlFilters.Controls.Add(nudMinRating);
            pnlFilters.Controls.Add(lblMinRating);
            pnlFilters.Controls.Add(txtUserFilter);
            pnlFilters.Controls.Add(lblUserFilter);
            pnlFilters.Controls.Add(dtpEnd);
            pnlFilters.Controls.Add(lblEndDate);
            pnlFilters.Controls.Add(dtpStart);
            pnlFilters.Controls.Add(lblStartDate);
            pnlFilters.Controls.Add(lblFilterTitle);
            pnlFilters.Dock = DockStyle.Top;
            pnlFilters.Location = new Point(0, 140);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Padding = new Padding(20);
            pnlFilters.Size = new Size(1400, 120);
            pnlFilters.TabIndex = 2;
            
            // lblFilterTitle
            lblFilterTitle.AutoSize = true;
            lblFilterTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblFilterTitle.ForeColor = Color.White;
            lblFilterTitle.Location = new Point(20, 15);
            lblFilterTitle.Name = "lblFilterTitle";
            lblFilterTitle.Size = new Size(85, 28);
            lblFilterTitle.TabIndex = 0;
            lblFilterTitle.Text = "Filtreler";
            
            // lblStartDate
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 10F);
            lblStartDate.ForeColor = Color.FromArgb(161, 161, 170);
            lblStartDate.Location = new Point(20, 55);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(110, 23);
            lblStartDate.TabIndex = 1;
            lblStartDate.Text = "Başlangıç:";
            
            // dtpStart
            dtpStart.CalendarMonthBackground = Color.FromArgb(39, 39, 58);
            dtpStart.CalendarTitleBackColor = Color.FromArgb(59, 130, 246);
            dtpStart.Font = new Font("Segoe UI", 10F);
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(20, 80);
            dtpStart.Name = "dtpStart";
            dtpStart.ShowCheckBox = true;
            dtpStart.Size = new Size(180, 30);
            dtpStart.TabIndex = 2;
            
            // lblEndDate
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 10F);
            lblEndDate.ForeColor = Color.FromArgb(161, 161, 170);
            lblEndDate.Location = new Point(220, 55);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(60, 23);
            lblEndDate.TabIndex = 3;
            lblEndDate.Text = "Bitiş:";
            
            // dtpEnd
            dtpEnd.CalendarMonthBackground = Color.FromArgb(39, 39, 58);
            dtpEnd.CalendarTitleBackColor = Color.FromArgb(59, 130, 246);
            dtpEnd.Font = new Font("Segoe UI", 10F);
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(220, 80);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.ShowCheckBox = true;
            dtpEnd.Size = new Size(180, 30);
            dtpEnd.TabIndex = 4;
            
            // lblUserFilter
            lblUserFilter.AutoSize = true;
            lblUserFilter.Font = new Font("Segoe UI", 10F);
            lblUserFilter.ForeColor = Color.FromArgb(161, 161, 170);
            lblUserFilter.Location = new Point(420, 55);
            lblUserFilter.Name = "lblUserFilter";
            lblUserFilter.Size = new Size(95, 23);
            lblUserFilter.TabIndex = 5;
            lblUserFilter.Text = "Kullanıcı:";
            
            // txtUserFilter
            txtUserFilter.BackColor = Color.FromArgb(39, 39, 58);
            txtUserFilter.BorderStyle = BorderStyle.FixedSingle;
            txtUserFilter.Font = new Font("Segoe UI", 10F);
            txtUserFilter.ForeColor = Color.White;
            txtUserFilter.Location = new Point(420, 80);
            txtUserFilter.Name = "txtUserFilter";
            txtUserFilter.Size = new Size(200, 30);
            txtUserFilter.TabIndex = 6;
            
            // lblMinRating
            lblMinRating.AutoSize = true;
            lblMinRating.Font = new Font("Segoe UI", 10F);
            lblMinRating.ForeColor = Color.FromArgb(161, 161, 170);
            lblMinRating.Location = new Point(640, 55);
            lblMinRating.Name = "lblMinRating";
            lblMinRating.Size = new Size(110, 23);
            lblMinRating.TabIndex = 7;
            lblMinRating.Text = "Min. Puan:";
            
            // nudMinRating
            nudMinRating.BackColor = Color.FromArgb(39, 39, 58);
            nudMinRating.BorderStyle = BorderStyle.FixedSingle;
            nudMinRating.Font = new Font("Segoe UI", 10F);
            nudMinRating.ForeColor = Color.White;
            nudMinRating.Location = new Point(640, 80);
            nudMinRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            nudMinRating.Name = "nudMinRating";
            nudMinRating.Size = new Size(100, 30);
            nudMinRating.TabIndex = 8;
            
            // btnFilter
            btnFilter.BackColor = Color.FromArgb(59, 130, 246);
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.FlatAppearance.BorderSize = 0;
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnFilter.ForeColor = Color.White;
            btnFilter.Location = new Point(760, 75);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(120, 35);
            btnFilter.TabIndex = 9;
            btnFilter.Text = "Filtrele";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            
            // btnClearFilter
            btnClearFilter.BackColor = Color.FromArgb(39, 39, 58);
            btnClearFilter.Cursor = Cursors.Hand;
            btnClearFilter.FlatAppearance.BorderSize = 0;
            btnClearFilter.FlatStyle = FlatStyle.Flat;
            btnClearFilter.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnClearFilter.ForeColor = Color.White;
            btnClearFilter.Location = new Point(890, 75);
            btnClearFilter.Name = "btnClearFilter";
            btnClearFilter.Size = new Size(120, 35);
            btnClearFilter.TabIndex = 10;
            btnClearFilter.Text = "Temizle";
            btnClearFilter.UseVisualStyleBackColor = false;
            btnClearFilter.Click += btnClearFilter_Click;
            
            // pnlData
            pnlData.BackColor = Color.FromArgb(24, 24, 37);
            pnlData.Controls.Add(dgvFeedback);
            pnlData.Dock = DockStyle.Fill;
            pnlData.Location = new Point(0, 260);
            pnlData.Name = "pnlData";
            pnlData.Padding = new Padding(10); // 20'den 10'a düşürüldü
            pnlData.Size = new Size(1400, 440);
            pnlData.TabIndex = 3;
            
            // dgvFeedback (SfDataGrid)
            dgvFeedback.AccessibleName = "";
            dgvFeedback.AllowEditing = false;
            dgvFeedback.AllowFiltering = true;
            dgvFeedback.AllowGrouping = true;
            dgvFeedback.AllowResizingColumns = true;
            dgvFeedback.AllowSorting = true;
            dgvFeedback.AutoGenerateColumns = true;
            dgvFeedback.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            dgvFeedback.BackColor = Color.FromArgb(30, 30, 46);
            dgvFeedback.Dock = DockStyle.Fill;
            dgvFeedback.Location = new Point(20, 20);
            dgvFeedback.Name = "dgvFeedback";
            dgvFeedback.ShowGroupDropArea = true;
            dgvFeedback.Size = new Size(1360, 400);
            dgvFeedback.TabIndex = 0;
            
            // Styling - Header
            dgvFeedback.Style.HeaderStyle.BackColor = Color.FromArgb(59, 130, 246);
            dgvFeedback.Style.HeaderStyle.TextColor = Color.White;
            
            // Styling - Cells  
            dgvFeedback.Style.CellStyle.BackColor = Color.FromArgb(39, 39, 58);
            dgvFeedback.Style.CellStyle.TextColor = Color.White;
            
            // Styling - Selection
            dgvFeedback.Style.SelectionStyle.BackColor = Color.FromArgb(59, 130, 246);
            dgvFeedback.Style.SelectionStyle.TextColor = Color.White;
            
            // Grid styling
            dgvFeedback.Style.BorderColor = Color.FromArgb(50, 50, 70);
            
            // pnlActions
            pnlActions.BackColor = Color.FromArgb(20, 20, 30);
            pnlActions.Controls.Add(lblStatus);
            pnlActions.Controls.Add(btnExportExcel);
            pnlActions.Controls.Add(btnRefresh);
            pnlActions.Dock = DockStyle.Bottom;
            pnlActions.Location = new Point(0, 700);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(1400, 70);
            pnlActions.TabIndex = 4;
            
            // btnRefresh
            btnRefresh.BackColor = Color.FromArgb(59, 130, 246);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(20, 15);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(150, 40);
            btnRefresh.TabIndex = 0;
            btnRefresh.Text = "🔄 Yenile";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            
            // btnExportExcel
            btnExportExcel.BackColor = Color.FromArgb(34, 197, 94);
            btnExportExcel.Cursor = Cursors.Hand;
            btnExportExcel.FlatAppearance.BorderSize = 0;
            btnExportExcel.FlatStyle = FlatStyle.Flat;
            btnExportExcel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnExportExcel.ForeColor = Color.White;
            btnExportExcel.Location = new Point(180, 15);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Size = new Size(180, 40);
            btnExportExcel.TabIndex = 1;
            btnExportExcel.Text = "📊 Excel Aktar";
            btnExportExcel.UseVisualStyleBackColor = false;
            btnExportExcel.Click += btnExportExcel_Click;
            
            // lblStatus
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F);
            lblStatus.ForeColor = Color.FromArgb(161, 161, 170);
            lblStatus.Location = new Point(380, 23);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(70, 23);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Hazır...";
            
            // FrmAdmin
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 37);
            ClientSize = new Size(1400, 770);
            Controls.Add(pnlData);
            Controls.Add(pnlActions);
            Controls.Add(pnlFilters);
            Controls.Add(pnlStats);
            Controls.Add(pnlTitleBar);
            MinimumSize = new Size(1200, 700);
            Name = "FrmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Paneli";
            Load += FrmAdmin_Load;
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            pnlStats.ResumeLayout(false);
            pnlStats.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnlFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudMinRating).EndInit();
            pnlData.ResumeLayout(false);
            // SfDataGrid doesn't need ISupportInitialize
            pnlActions.ResumeLayout(false);
            pnlActions.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlTitleBar;
        private Label lblTitle;
        private Panel pnlStats;
        private Label lblTotalFeedback;
        private Label lblAvgOverall;
        private Label lblAvgPerformance;
        private Label lblAvgAccuracy;
        private Label lblAvgFunctionality;
        private Panel pnlFilters;
        private Label lblFilterTitle;
        private Label lblStartDate;
        private DateTimePicker dtpStart;
        private Label lblEndDate;
        private DateTimePicker dtpEnd;
        private Label lblUserFilter;
        private TextBox txtUserFilter;
        private Label lblMinRating;
        private NumericUpDown nudMinRating;
        private Button btnFilter;
        private Button btnClearFilter;
        private Panel pnlData;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dgvFeedback;
        private Panel pnlActions;
        private Button btnRefresh;
        private Button btnExportExcel;
        private Label lblStatus;
    }
}
