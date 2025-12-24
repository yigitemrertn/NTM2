namespace NoteToMusic.Forms
{
    partial class FrmMain
    {
        /// <summary>
        ///Gerekli tasar�mc� de�i�keni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullan�lan t�m kaynaklar� temizleyin.
        /// </summary>
        ///<param name="disposing">y�netilen kaynaklar dispose edilmeliyse do�ru; aksi halde yanl��.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer �retilen kod

        /// <summary>
        /// Tasar�mc� deste�i i�in gerekli metot - bu metodun 
        ///i�eri�ini kod d�zenleyici ile de�i�tirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            picNote = new PictureBox();
            lstNotes = new ListBox();
            lblNotes = new Label();
            txtNoteSearch = new TextBox();
            btnOnlineNotes = new Button();
            trackTime = new TrackBar();
            lblTime = new Label();
            btnPlayStop = new Button();
            btnFeedback = new Button();
            lblSounds = new Label();
            lstSounds = new ListBox();
            txtSoundSearch = new TextBox();
            btnOnlineSounds = new Button();
            lblMusics = new Label();
            lstMusics = new ListBox();
            btnNotes = new Button();
            btnSounds = new Button();
            trackVolume = new TrackBar();
            btnConvert = new Button();
            ((System.ComponentModel.ISupportInitialize)picNote).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackVolume).BeginInit();
            SuspendLayout();
            // 
            // picNote
            // 
            picNote.BorderStyle = BorderStyle.FixedSingle;
            picNote.Location = new Point(14, 14);
            picNote.Margin = new Padding(4, 3, 4, 3);
            picNote.Name = "picNote";
            picNote.Size = new Size(623, 797);
            picNote.SizeMode = PictureBoxSizeMode.StretchImage;
            picNote.TabIndex = 0;
            picNote.TabStop = false;
            // 
            // lstNotes
            // 
            lstNotes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lstNotes.FormattingEnabled = true;
            lstNotes.ItemHeight = 20;
            lstNotes.Location = new Point(658, 81);
            lstNotes.Margin = new Padding(4, 3, 4, 3);
            lstNotes.Name = "lstNotes";
            lstNotes.Size = new Size(275, 204);
            lstNotes.TabIndex = 1;
            lstNotes.SelectedIndexChanged += lstNotes_SelectedIndexChanged;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblNotes.Location = new Point(653, 54);
            lblNotes.Margin = new Padding(4, 0, 4, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(54, 20);
            lblNotes.TabIndex = 5;
            lblNotes.Text = "Notalar";
            // 
            // txtNoteSearch
            // 
            txtNoteSearch.Location = new Point(658, 24);
            txtNoteSearch.Name = "txtNoteSearch";
            txtNoteSearch.PlaceholderText = "Ara...";
            txtNoteSearch.Size = new Size(195, 23);
            txtNoteSearch.TabIndex = 18;
            txtNoteSearch.TextChanged += txtNoteSearch_TextChanged;
            // 
            // btnOnlineNotes
            // 
            btnOnlineNotes.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnOnlineNotes.Location = new Point(858, 24);
            btnOnlineNotes.Name = "btnOnlineNotes";
            btnOnlineNotes.Size = new Size(75, 23);
            btnOnlineNotes.TabIndex = 19;
            btnOnlineNotes.Text = "🌐 Online";
            btnOnlineNotes.UseVisualStyleBackColor = true;
            btnOnlineNotes.Click += btnOnlineNotes_Click;
            // 
            // trackTime
            // 
            trackTime.LargeChange = 1;
            trackTime.Location = new Point(28, 909);
            trackTime.Margin = new Padding(4, 3, 4, 3);
            trackTime.Maximum = 100;
            trackTime.Name = "trackTime";
            trackTime.Size = new Size(511, 45);
            trackTime.TabIndex = 8;
            trackTime.TickFrequency = 100;
            trackTime.TickStyle = TickStyle.Both;
            trackTime.Scroll += trackTime_Scroll;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(546, 909);
            lblTime.Margin = new Padding(4, 0, 4, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(66, 15);
            lblTime.TabIndex = 9;
            lblTime.Text = "00:00/00:00";
            // 
            // btnPlayStop
            // 
            btnPlayStop.Location = new Point(285, 822);
            btnPlayStop.Margin = new Padding(4, 3, 4, 3);
            btnPlayStop.Name = "btnPlayStop";
            btnPlayStop.Size = new Size(86, 81);
            btnPlayStop.TabIndex = 10;
            btnPlayStop.Text = "Oynat";
            btnPlayStop.UseVisualStyleBackColor = true;
            btnPlayStop.Click += btnPlayStop_Click;
            // 
            // btnFeedback
            // 
            btnFeedback.Enabled = false;
            btnFeedback.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnFeedback.Location = new Point(658, 939);
            btnFeedback.Margin = new Padding(4, 3, 4, 3);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(275, 40);
            btnFeedback.TabIndex = 17;
            btnFeedback.Text = "Geri Bildirim Ver";
            btnFeedback.UseVisualStyleBackColor = true;
            btnFeedback.Click += btnFeedback_Click;
            // 
            // lblSounds
            // 
            lblSounds.AutoSize = true;
            lblSounds.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSounds.Location = new Point(654, 340);
            lblSounds.Margin = new Padding(4, 0, 4, 0);
            lblSounds.Name = "lblSounds";
            lblSounds.Size = new Size(76, 20);
            lblSounds.TabIndex = 12;
            lblSounds.Text = "SoundFont";
            // 
            // txtSoundSearch
            // 
            txtSoundSearch.Location = new Point(658, 310);
            txtSoundSearch.Name = "txtSoundSearch";
            txtSoundSearch.PlaceholderText = "Ara...";
            txtSoundSearch.Size = new Size(195, 23);
            txtSoundSearch.TabIndex = 20;
            txtSoundSearch.TextChanged += txtSoundSearch_TextChanged;
            // 
            // btnOnlineSounds
            // 
            btnOnlineSounds.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnOnlineSounds.Location = new Point(858, 310);
            btnOnlineSounds.Name = "btnOnlineSounds";
            btnOnlineSounds.Size = new Size(75, 23);
            btnOnlineSounds.TabIndex = 21;
            btnOnlineSounds.Text = "🌐 Online";
            btnOnlineSounds.UseVisualStyleBackColor = true;
            btnOnlineSounds.Click += btnOnlineSounds_Click;
            // 
            // lstSounds
            // 
            lstSounds.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lstSounds.FormattingEnabled = true;
            lstSounds.ItemHeight = 20;
            lstSounds.Location = new Point(658, 368);
            lstSounds.Margin = new Padding(4, 3, 4, 3);
            lstSounds.Name = "lstSounds";
            lstSounds.Size = new Size(275, 204);
            lstSounds.TabIndex = 11;
            lstSounds.SelectedIndexChanged += lstSounds_SelectedIndexChanged;
            // 
            // lblMusics
            // 
            lblMusics.AutoSize = true;
            lblMusics.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblMusics.Location = new Point(654, 703);
            lblMusics.Margin = new Padding(4, 0, 4, 0);
            lblMusics.Name = "lblMusics";
            lblMusics.Size = new Size(60, 20);
            lblMusics.TabIndex = 14;
            lblMusics.Text = "Müzikler";
            // 
            // lstMusics
            // 
            lstMusics.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lstMusics.FormattingEnabled = true;
            lstMusics.ItemHeight = 20;
            lstMusics.Location = new Point(658, 729);
            lstMusics.Margin = new Padding(4, 3, 4, 3);
            lstMusics.Name = "lstMusics";
            lstMusics.Size = new Size(275, 204);
            lstMusics.TabIndex = 13;
            lstMusics.SelectedIndexChanged += lstMusics_SelectedIndexChanged;
            // 
            // btnNotes
            // 
            btnNotes.Location = new Point(757, 54);
            btnNotes.Margin = new Padding(4, 3, 4, 3);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(176, 23);
            btnNotes.TabIndex = 15;
            btnNotes.Text = "Ekle!";
            btnNotes.UseVisualStyleBackColor = true;
            btnNotes.Click += btnNotes_Click;
            // 
            // btnSounds
            // 
            btnSounds.Location = new Point(757, 340);
            btnSounds.Margin = new Padding(4, 3, 4, 3);
            btnSounds.Name = "btnSounds";
            btnSounds.Size = new Size(176, 23);
            btnSounds.TabIndex = 16;
            btnSounds.Text = "Ekle!";
            btnSounds.UseVisualStyleBackColor = true;
            btnSounds.Click += btnSounds_Click;
            // 
            // trackVolume
            // 
            trackVolume.LargeChange = 20;
            trackVolume.Location = new Point(378, 850);
            trackVolume.Margin = new Padding(4, 3, 4, 3);
            trackVolume.Maximum = 100;
            trackVolume.Name = "trackVolume";
            trackVolume.Size = new Size(161, 45);
            trackVolume.TabIndex = 18;
            trackVolume.TickFrequency = 100;
            trackVolume.TickStyle = TickStyle.Both;
            trackVolume.Value = 100;
            trackVolume.Scroll += trackVolume_Scroll;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(659, 617);
            btnConvert.Margin = new Padding(4, 3, 4, 3);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(275, 33);
            btnConvert.TabIndex = 19;
            btnConvert.Text = "Dönüştür!";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 965);
            Controls.Add(btnConvert);
            Controls.Add(trackVolume);
            Controls.Add(btnSounds);
            Controls.Add(btnNotes);
            Controls.Add(lblMusics);
            Controls.Add(lstMusics);
            Controls.Add(lblSounds);
            Controls.Add(lstSounds);
            Controls.Add(btnPlayStop);
            Controls.Add(btnFeedback);
            Controls.Add(lblTime);
            Controls.Add(trackTime);
            Controls.Add(lblNotes);
            Controls.Add(lstNotes);
            Controls.Add(txtNoteSearch);
            Controls.Add(btnOnlineNotes);
            Controls.Add(txtSoundSearch);
            Controls.Add(btnOnlineSounds);
            Controls.Add(picNote);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoteToMusic";
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
        private System.Windows.Forms.Button btnOnlineNotes;
        private System.Windows.Forms.TextBox txtSoundSearch;
        private System.Windows.Forms.Button btnOnlineSounds;
    }
}



