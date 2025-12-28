namespace NoteToMusic.Forms
{
    partial class FrmMain
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
            picNote = new PictureBox();
            lstNotes = new ListBox();
            lblNotes = new Label();
            trackTime = new TrackBar();
            lblTime = new Label();
            btnPlayStop = new Button();
            btnFeedback = new Button();
            lblSounds = new Label();
            lstSounds = new ListBox();
            lblMusics = new Label();
            lstMusics = new ListBox();
            btnNotes = new Button();
            btnSounds = new Button();
            trackVolume = new TrackBar();
            btnConvert = new Button();
            txtNoteSearch = new TextBox();
            txtSoundSearch = new TextBox();
            btnPrevious = new Button();
            btnRewind = new Button();
            btnForward = new Button();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)picNote).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackVolume).BeginInit();
            SuspendLayout();
            // 
            // picNote
            // 
            picNote.BackColor = Color.FromArgb(45, 45, 48);
            picNote.BorderStyle = BorderStyle.FixedSingle;
            picNote.Location = new Point(340, 20);
            picNote.Margin = new Padding(4, 3, 4, 3);
            picNote.Name = "picNote";
            picNote.Size = new Size(900, 800);
            picNote.SizeMode = PictureBoxSizeMode.Zoom;
            picNote.TabIndex = 0;
            picNote.TabStop = false;
            // 
            // lstNotes
            // 
            lstNotes.BackColor = Color.FromArgb(37, 37, 38);
            lstNotes.BorderStyle = BorderStyle.FixedSingle;
            lstNotes.Font = new Font("Segoe UI", 10F);
            lstNotes.ForeColor = Color.White;
            lstNotes.FormattingEnabled = true;
            lstNotes.ItemHeight = 23;
            lstNotes.Location = new Point(20, 90);
            lstNotes.Margin = new Padding(4, 3, 4, 3);
            lstNotes.Name = "lstNotes";
            lstNotes.Size = new Size(300, 208);
            lstNotes.TabIndex = 1;
            lstNotes.SelectedIndexChanged += lstNotes_SelectedIndexChanged;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblNotes.ForeColor = Color.White;
            lblNotes.Location = new Point(20, 20);
            lblNotes.Margin = new Padding(4, 0, 4, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(73, 25);
            lblNotes.TabIndex = 5;
            lblNotes.Text = "📄 Notalar";
            // 
            // txtNoteSearch
            // 
            txtNoteSearch.BackColor = Color.FromArgb(37, 37, 38);
            txtNoteSearch.BorderStyle = BorderStyle.FixedSingle;
            txtNoteSearch.Font = new Font("Segoe UI", 10F);
            txtNoteSearch.ForeColor = Color.White;
            txtNoteSearch.Location = new Point(20, 50);
            txtNoteSearch.Name = "txtNoteSearch";
            txtNoteSearch.PlaceholderText = "🔍 Ara...";
            txtNoteSearch.Size = new Size(220, 30);
            txtNoteSearch.TabIndex = 18;
            txtNoteSearch.TextChanged += txtNoteSearch_TextChanged;
            // 
            // btnNotes
            // 
            btnNotes.BackColor = Color.FromArgb(28, 151, 234);
            btnNotes.FlatAppearance.BorderSize = 0;
            btnNotes.FlatStyle = FlatStyle.Flat;
            btnNotes.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnNotes.ForeColor = Color.White;
            btnNotes.Location = new Point(20, 304);
            btnNotes.Margin = new Padding(4, 3, 4, 3);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(300, 35);
            btnNotes.TabIndex = 15;
            btnNotes.Text = "➕ Nota Ekle";
            btnNotes.UseVisualStyleBackColor = false;
            btnNotes.Click += btnNotes_Click;
            // 
            // lblSounds
            // 
            lblSounds.AutoSize = true;
            lblSounds.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblSounds.ForeColor = Color.White;
            lblSounds.Location = new Point(20, 360);
            lblSounds.Margin = new Padding(4, 0, 4, 0);
            lblSounds.Name = "lblSounds";
            lblSounds.Size = new Size(112, 25);
            lblSounds.TabIndex = 12;
            lblSounds.Text = "🎹 SoundFont";
            // 
            // txtSoundSearch
            // 
            txtSoundSearch.BackColor = Color.FromArgb(37, 37, 38);
            txtSoundSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSoundSearch.Font = new Font("Segoe UI", 10F);
            txtSoundSearch.ForeColor = Color.White;
            txtSoundSearch.Location = new Point(20, 390);
            txtSoundSearch.Name = "txtSoundSearch";
            txtSoundSearch.PlaceholderText = "🔍 Ara...";
            txtSoundSearch.Size = new Size(220, 30);
            txtSoundSearch.TabIndex = 20;
            txtSoundSearch.TextChanged += txtSoundSearch_TextChanged;
            // 
            // lstSounds
            // 
            lstSounds.BackColor = Color.FromArgb(37, 37, 38);
            lstSounds.BorderStyle = BorderStyle.FixedSingle;
            lstSounds.Font = new Font("Segoe UI", 10F);
            lstSounds.ForeColor = Color.White;
            lstSounds.FormattingEnabled = true;
            lstSounds.ItemHeight = 23;
            lstSounds.Location = new Point(20, 430);
            lstSounds.Margin = new Padding(4, 3, 4, 3);
            lstSounds.Name = "lstSounds";
            lstSounds.Size = new Size(300, 208);
            lstSounds.TabIndex = 11;
            lstSounds.SelectedIndexChanged += lstSounds_SelectedIndexChanged;
            // 
            // btnSounds
            // 
            btnSounds.BackColor = Color.FromArgb(28, 151, 234);
            btnSounds.FlatAppearance.BorderSize = 0;
            btnSounds.FlatStyle = FlatStyle.Flat;
            btnSounds.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSounds.ForeColor = Color.White;
            btnSounds.Location = new Point(20, 644);
            btnSounds.Margin = new Padding(4, 3, 4, 3);
            btnSounds.Name = "btnSounds";
            btnSounds.Size = new Size(300, 35);
            btnSounds.TabIndex = 16;
            btnSounds.Text = "➕ SoundFont Ekle";
            btnSounds.UseVisualStyleBackColor = false;
            btnSounds.Click += btnSounds_Click;
            // 
            // lblMusics
            // 
            lblMusics.AutoSize = true;
            lblMusics.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblMusics.ForeColor = Color.White;
            lblMusics.Location = new Point(1260, 400);
            lblMusics.Margin = new Padding(4, 0, 4, 0);
            lblMusics.Name = "lblMusics";
            lblMusics.Size = new Size(96, 25);
            lblMusics.TabIndex = 14;
            lblMusics.Text = "🎵 Müzikler";
            // 
            // lstMusics
            // 
            lstMusics.BackColor = Color.FromArgb(37, 37, 38);
            lstMusics.BorderStyle = BorderStyle.FixedSingle;
            lstMusics.Font = new Font("Segoe UI", 10F);
            lstMusics.ForeColor = Color.White;
            lstMusics.FormattingEnabled = true;
            lstMusics.ItemHeight = 23;
            lstMusics.Location = new Point(1260, 435);
            lstMusics.Margin = new Padding(4, 3, 4, 3);
            lstMusics.Name = "lstMusics";
            lstMusics.Size = new Size(310, 140);
            lstMusics.TabIndex = 13;
            lstMusics.SelectedIndexChanged += lstMusics_SelectedIndexChanged;
            // 
            // btnPlayStop
            // 
            btnPlayStop.BackColor = Color.FromArgb(106, 176, 76);
            btnPlayStop.FlatAppearance.BorderSize = 0;
            btnPlayStop.FlatStyle = FlatStyle.Flat;
            btnPlayStop.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            btnPlayStop.ForeColor = Color.White;
            btnPlayStop.Location = new Point(1260, 590);
            btnPlayStop.Margin = new Padding(4, 3, 4, 3);
            btnPlayStop.Name = "btnPlayStop";
            btnPlayStop.Size = new Size(310, 50);
            btnPlayStop.TabIndex = 3;
            btnPlayStop.Text = "▶ Oynat";
            btnPlayStop.UseVisualStyleBackColor = false;
            btnPlayStop.Click += btnPlayStop_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(0, 122, 204);
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.Location = new Point(1260, 655);
            btnPrevious.Margin = new Padding(4, 3, 4, 3);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(60, 45);
            btnPrevious.TabIndex = 23;
            btnPrevious.Text = "⏮";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnRewind
            // 
            btnRewind.BackColor = Color.FromArgb(60, 60, 60);
            btnRewind.FlatAppearance.BorderSize = 0;
            btnRewind.FlatStyle = FlatStyle.Flat;
            btnRewind.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnRewind.ForeColor = Color.White;
            btnRewind.Location = new Point(1330, 655);
            btnRewind.Margin = new Padding(4, 3, 4, 3);
            btnRewind.Name = "btnRewind";
            btnRewind.Size = new Size(60, 45);
            btnRewind.TabIndex = 24;
            btnRewind.Text = "-5s";
            btnRewind.UseVisualStyleBackColor = false;
            btnRewind.Click += btnRewind_Click;
            // 
            // btnForward
            // 
            btnForward.BackColor = Color.FromArgb(60, 60, 60);
            btnForward.FlatAppearance.BorderSize = 0;
            btnForward.FlatStyle = FlatStyle.Flat;
            btnForward.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnForward.ForeColor = Color.White;
            btnForward.Location = new Point(1400, 655);
            btnForward.Margin = new Padding(4, 3, 4, 3);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(60, 45);
            btnForward.TabIndex = 25;
            btnForward.Text = "+5s";
            btnForward.UseVisualStyleBackColor = false;
            btnForward.Click += btnForward_Click;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(0, 122, 204);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(1470, 655);
            btnNext.Margin = new Padding(4, 3, 4, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(60, 45);
            btnNext.TabIndex = 26;
            btnNext.Text = "⏭";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // trackTime
            // 
            trackTime.BackColor = Color.FromArgb(45, 45, 48);
            trackTime.Location = new Point(1260, 715);
            trackTime.Margin = new Padding(4, 3, 4, 3);
            trackTime.Maximum = 100;
            trackTime.Name = "trackTime";
            trackTime.Size = new Size(310, 56);
            trackTime.TabIndex = 4;
            trackTime.TickStyle = TickStyle.None;
            trackTime.Scroll += trackTime_Scroll;
            trackTime.MouseDown += trackTime_MouseDown;
            // 
            // lblTime
            // 
            lblTime.Font = new Font("Segoe UI", 10F);
            lblTime.ForeColor = Color.LightGray;
            lblTime.Location = new Point(1260, 775);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(310, 25);
            lblTime.TabIndex = 9;
            lblTime.Text = "00:00 / 00:00";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackVolume
            // 
            trackVolume.BackColor = Color.FromArgb(45, 45, 48);
            trackVolume.Location = new Point(1480, 810);
            trackVolume.Margin = new Padding(4, 3, 4, 3);
            trackVolume.Maximum = 100;
            trackVolume.Name = "trackVolume";
            trackVolume.Orientation = Orientation.Vertical;
            trackVolume.Size = new Size(60, 80);
            trackVolume.TabIndex = 18;
            trackVolume.TickFrequency = 10;
            trackVolume.TickStyle = TickStyle.None;
            trackVolume.Value = 100;
            trackVolume.Scroll += trackVolume_Scroll;
            // 
            // btnConvert
            // 
            btnConvert.BackColor = Color.FromArgb(204, 78, 92);
            btnConvert.FlatAppearance.BorderSize = 0;
            btnConvert.FlatStyle = FlatStyle.Flat;
            btnConvert.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnConvert.ForeColor = Color.White;
            btnConvert.Location = new Point(340, 835);
            btnConvert.Margin = new Padding(4, 3, 4, 3);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(900, 55);
            btnConvert.TabIndex = 10;
            btnConvert.Text = "🎼 Dönüştür!";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            // 
            // btnFeedback
            // 
            btnFeedback.BackColor = Color.FromArgb(0, 122, 204);
            btnFeedback.Enabled = false;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatStyle = FlatStyle.Flat;
            btnFeedback.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnFeedback.ForeColor = Color.White;
            btnFeedback.Location = new Point(20, 835);
            btnFeedback.Margin = new Padding(4, 3, 4, 3);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(300, 55);
            btnFeedback.TabIndex = 17;
            btnFeedback.Text = "💬 Geri Bildirim Ver";
            btnFeedback.UseVisualStyleBackColor = false;
            btnFeedback.Click += btnFeedback_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1600, 920);
            Controls.Add(btnNext);
            Controls.Add(btnForward);
            Controls.Add(btnRewind);
            Controls.Add(btnPrevious);
            Controls.Add(txtSoundSearch);
            Controls.Add(txtNoteSearch);
            Controls.Add(trackVolume);
            Controls.Add(btnFeedback);
            Controls.Add(btnSounds);
            Controls.Add(btnNotes);
            Controls.Add(lblMusics);
            Controls.Add(lstMusics);
            Controls.Add(lblSounds);
            Controls.Add(lstSounds);
            Controls.Add(btnConvert);
            Controls.Add(lblTime);
            Controls.Add(trackTime);
            Controls.Add(btnPlayStop);
            Controls.Add(lblNotes);
            Controls.Add(lstNotes);
            Controls.Add(picNote);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = true;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "🎵 Note To Music";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)picNote).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackVolume).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNote;
        private System.Windows.Forms.ListBox lstNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TrackBar trackTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnPlayStop;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Label lblSounds;
        private System.Windows.Forms.ListBox lstSounds;
        private System.Windows.Forms.Label lblMusics;
        private System.Windows.Forms.ListBox lstMusics;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnSounds;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtNoteSearch;
        private System.Windows.Forms.TextBox txtSoundSearch;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnRewind;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnNext;
    }
}



