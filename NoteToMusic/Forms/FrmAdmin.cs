using NoteToMusic.Entities;
using NoteToMusic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace NoteToMusic.Forms
{
    public partial class FrmAdmin : Form
    {
        private List<Feedback> allFeedback = new List<Feedback>();

        public FrmAdmin()
        {
            InitializeComponent();
            // EPPlus license context
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        private async void FrmAdmin_Load(object sender, EventArgs e)
        {
            await LoadFeedback();
        }

        private async System.Threading.Tasks.Task LoadFeedback()
        {
            try
            {
                lblStatus.Text = "Veriler yükleniyor...";
                Application.DoEvents();

                var feedback = await SCloudSync.FetchAllFeedbackFromCloud();

                if (feedback == null || feedback.Count == 0)
                {
                    lblStatus.Text = "Henüz feedback verisi yok veya bağlantı hatası.";
                    return;
                }

                allFeedback = feedback;
                ApplyFilters();
                UpdateStatistics();
                
                lblStatus.Text = $"Toplam {allFeedback.Count} feedback yüklendi.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Veri yüklenirken hata oluştu.";
            }
        }

        private void ApplyFilters()
        {
            var filtered = allFeedback.AsEnumerable();

            // Tarih filtresi
            if (dtpStart.Checked)
            {
                filtered = filtered.Where(f => f.CreatedDate.Date >= dtpStart.Value.Date);
            }

            if (dtpEnd.Checked)
            {
                filtered = filtered.Where(f => f.CreatedDate.Date <= dtpEnd.Value.Date);
            }

            // Kullanıcı filtresi
            if (!string.IsNullOrWhiteSpace(txtUserFilter.Text))
            {
                string userFilter = txtUserFilter.Text.ToLower();
                filtered = filtered.Where(f => f.Username.ToLower().Contains(userFilter));
            }

            // Minimum rating filtresi
            int minRating = (int)nudMinRating.Value;
            if (minRating > 0)
            {
                filtered = filtered.Where(f => f.OverallRating >= minRating);
            }

            // DataGridView'a bind
            dgvFeedback.DataSource = filtered.ToList();
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            if (dgvFeedback.Columns.Count > 0)
            {
                dgvFeedback.Columns["Id"].HeaderText = "ID";
                dgvFeedback.Columns["Id"].Width = 50;
                
                dgvFeedback.Columns["Username"].HeaderText = "Kullanıcı";
                dgvFeedback.Columns["Username"].Width = 120;
                
                dgvFeedback.Columns["PerformanceRating"].HeaderText = "Hız";
                dgvFeedback.Columns["PerformanceRating"].Width = 60;
                
                dgvFeedback.Columns["AccuracyRating"].HeaderText = "Doğruluk";
                dgvFeedback.Columns["AccuracyRating"].Width = 80;
                
                dgvFeedback.Columns["FunctionalityRating"].HeaderText = "İşlev";
                dgvFeedback.Columns["FunctionalityRating"].Width = 60;
                
                dgvFeedback.Columns["OverallRating"].HeaderText = "Genel";
                dgvFeedback.Columns["OverallRating"].Width = 60;
                
                dgvFeedback.Columns["Comments"].HeaderText = "Yorum";
                dgvFeedback.Columns["Comments"].Width = 250;
                
                dgvFeedback.Columns["CreatedDate"].HeaderText = "Tarih";
                dgvFeedback.Columns["CreatedDate"].Width = 140;
                dgvFeedback.Columns["CreatedDate"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }
        }

        private void UpdateStatistics()
        {
            if (allFeedback.Count == 0)
            {
                lblTotalFeedback.Text = "Toplam Feedback: 0";
                lblAvgOverall.Text = "Ort. Genel Puan: -";
                lblAvgPerformance.Text = "Ort. Hız: -";
                lblAvgAccuracy.Text = "Ort. Doğruluk: -";
                lblAvgFunctionality.Text = "Ort. İşlev: -";
                return;
            }

            double avgOverall = allFeedback.Average(f => f.OverallRating);
            double avgPerformance = allFeedback.Average(f => f.PerformanceRating);
            double avgAccuracy = allFeedback.Average(f => f.AccuracyRating);
            double avgFunctionality = allFeedback.Average(f => f.FunctionalityRating);

            lblTotalFeedback.Text = $"Toplam Feedback: {allFeedback.Count}";
            lblAvgOverall.Text = $"Ort. Genel Puan: {avgOverall:F2} ⭐";
            lblAvgPerformance.Text = $"Ort. Hız: {avgPerformance:F2}";
            lblAvgAccuracy.Text = $"Ort. Doğruluk: {avgAccuracy:F2}";
            lblAvgFunctionality.Text = $"Ort. İşlev: {avgFunctionality:F2}";
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadFeedback();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            dtpStart.Checked = false;
            dtpEnd.Checked = false;
            txtUserFilter.Clear();
            nudMinRating.Value = 0;
            ApplyFilters();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Excel Dosyası|*.xlsx";
                sfd.FileName = $"Feedback_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportToExcel(sfd.FileName);
                    MessageBox.Show("Excel dosyası başarıyla oluşturuldu!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Excel export hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToExcel(string filePath)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Feedback");

                // Header
                worksheet.Cells[1, 1].Value = "ID";
                worksheet.Cells[1, 2].Value = "Kullanıcı";
                worksheet.Cells[1, 3].Value = "Hız";
                worksheet.Cells[1, 4].Value = "Doğruluk";
                worksheet.Cells[1, 5].Value = "İşlev";
                worksheet.Cells[1, 6].Value = "Genel";
                worksheet.Cells[1, 7].Value = "Yorum";
                worksheet.Cells[1, 8].Value = "Tarih";

                // Header bold
                using (var range = worksheet.Cells[1, 1, 1, 8])
                {
                    range.Style.Font.Bold = true;
                }

                // Data
                int row = 2;
                foreach (var feedback in allFeedback)
                {
                    worksheet.Cells[row, 1].Value = feedback.Id;
                    worksheet.Cells[row, 2].Value = feedback.Username;
                    worksheet.Cells[row, 3].Value = feedback.PerformanceRating;
                    worksheet.Cells[row, 4].Value = feedback.AccuracyRating;
                    worksheet.Cells[row, 5].Value = feedback.FunctionalityRating;
                    worksheet.Cells[row, 6].Value = feedback.OverallRating;
                    worksheet.Cells[row, 7].Value = feedback.Comments;
                    worksheet.Cells[row, 8].Value = feedback.CreatedDate.ToString("dd.MM.yyyy HH:mm");
                    row++;
                }

                // Auto-fit columns
                worksheet.Cells.AutoFitColumns();

                // Save
                FileInfo fi = new FileInfo(filePath);
                package.SaveAs(fi);
            }
        }
    }
}
