namespace NoteToMusic.Forms
{
    partial class FrmTutorial
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
            pnlTitleBar = new Panel();
            lblTitle = new Label();
            pnlContent = new Panel();
            txtTutorial = new TextBox();
            pnlBottom = new Panel();
            lblStepCounter = new Label();
            btnSkip = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            
            pnlTitleBar.SuspendLayout();
            pnlContent.SuspendLayout();
            pnlBottom.SuspendLayout();
            SuspendLayout();
            
            // 
            // pnlTitleBar
            // 
            pnlTitleBar.BackColor = Color.FromArgb(20, 20, 30);
            pnlTitleBar.Controls.Add(lblTitle);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(700, 50);
            pnlTitleBar.TabIndex = 0;
            
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📖 Kullanım Kılavuzu";
            
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(24, 24, 37);
            pnlContent.Controls.Add(txtTutorial);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(0, 50);
            pnlContent.Name = "pnlContent";
            pnlContent.Padding = new Padding(30);
            pnlContent.Size = new Size(700, 380);
            pnlContent.TabIndex = 1;
            
            // 
            // txtTutorial
            // 
            txtTutorial.BackColor = Color.FromArgb(30, 30, 46);
            txtTutorial.BorderStyle = BorderStyle.None;
            txtTutorial.Dock = DockStyle.Fill;
            txtTutorial.Font = new Font("Segoe UI", 13F);
            txtTutorial.ForeColor = Color.White;
            txtTutorial.Location = new Point(30, 30);
            txtTutorial.Multiline = true;
            txtTutorial.Name = "txtTutorial";
            txtTutorial.ReadOnly = true;
            txtTutorial.Size = new Size(640, 320);
            txtTutorial.TabIndex = 0;
            txtTutorial.TabStop = false;
            txtTutorial.Text = "";
            
            // 
            // pnlBottom
            // 
            pnlBottom.BackColor = Color.FromArgb(20, 20, 30);
            pnlBottom.Controls.Add(lblStepCounter);
            pnlBottom.Controls.Add(btnSkip);
            pnlBottom.Controls.Add(btnPrevious);
            pnlBottom.Controls.Add(btnNext);
            pnlBottom.Dock = DockStyle.Bottom;
            pnlBottom.Location = new Point(0, 430);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(700, 70);
            pnlBottom.TabIndex = 2;
            
            // 
            // lblStepCounter
            // 
            lblStepCounter.AutoSize = true;
            lblStepCounter.Font = new Font("Segoe UI", 11F);
            lblStepCounter.ForeColor = Color.FromArgb(161, 161, 170);
            lblStepCounter.Location = new Point(20, 25);
            lblStepCounter.Name = "lblStepCounter";
            lblStepCounter.Size = new Size(100, 25);
            lblStepCounter.TabIndex = 0;
            lblStepCounter.Text = "Adım 1 / 7";
            
            // 
            // btnSkip
            // 
            btnSkip.BackColor = Color.FromArgb(39, 39, 58);
            btnSkip.Cursor = Cursors.Hand;
            btnSkip.FlatAppearance.BorderSize = 0;
            btnSkip.FlatStyle = FlatStyle.Flat;
            btnSkip.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnSkip.ForeColor = Color.White;
            btnSkip.Location = new Point(530, 15);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new Size(150, 40);
            btnSkip.TabIndex = 3;
            btnSkip.Text = "Atla";
            btnSkip.UseVisualStyleBackColor = false;
            btnSkip.Click += btnSkip_Click;
            
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(59, 130, 246);
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.Location = new Point(200, 15);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(150, 40);
            btnPrevious.TabIndex = 1;
            btnPrevious.Text = "⬅ Geri";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(59, 130, 246);
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(365, 15);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(150, 40);
            btnNext.TabIndex = 2;
            btnNext.Text = "İleri ➡";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            
            // 
            // FrmTutorial
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 37);
            ClientSize = new Size(700, 500);
            Controls.Add(pnlContent);
            Controls.Add(pnlBottom);
            Controls.Add(pnlTitleBar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTutorial";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Tutorial - Note To Music";
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            pnlContent.ResumeLayout(false);
            pnlContent.PerformLayout();
            pnlBottom.ResumeLayout(false);
            pnlBottom.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitleBar;
        private Label lblTitle;
        private Panel pnlContent;
        private TextBox txtTutorial;
        private Panel pnlBottom;
        private Label lblStepCounter;
        private Button btnSkip;
        private Button btnPrevious;
        private Button btnNext;
    }
}
