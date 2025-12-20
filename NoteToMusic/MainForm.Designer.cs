namespace NoteToMusic
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarýmcý deðiþkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanýlan tüm kaynaklarý temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doðru; aksi halde yanlýþ.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarýmcý desteði için gerekli metot - bu metodun 
        ///içeriðini kod düzenleyici ile deðiþtirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            picNote = new PictureBox();
            lstNotes = new ListBox();
            label1 = new Label();
            trackTime = new TrackBar();
            lblTime = new Label();
            btnPlayStop = new Button();
            label2 = new Label();
            lstSounds = new ListBox();
            label3 = new Label();
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
            lstNotes.Font = new Font("Noto Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lstNotes.FormattingEnabled = true;
            lstNotes.ItemHeight = 20;
            lstNotes.Location = new Point(658, 81);
            lstNotes.Margin = new Padding(4, 3, 4, 3);
            lstNotes.Name = "lstNotes";
            lstNotes.Size = new Size(275, 204);
            lstNotes.TabIndex = 1;
            lstNotes.SelectedIndexChanged += lstNotes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(653, 54);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 5;
            label1.Text = "Notalar";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(654, 340);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 12;
            label2.Text = "SoundFont";
            // 
            // lstSounds
            // 
            lstSounds.Font = new Font("Noto Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lstSounds.FormattingEnabled = true;
            lstSounds.ItemHeight = 20;
            lstSounds.Location = new Point(658, 368);
            lstSounds.Margin = new Padding(4, 3, 4, 3);
            lstSounds.Name = "lstSounds";
            lstSounds.Size = new Size(275, 204);
            lstSounds.TabIndex = 11;
            lstSounds.SelectedIndexChanged += lstSounds_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(654, 703);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 14;
            label3.Text = "Müzikler";
            // 
            // lstMusics
            // 
            lstMusics.Font = new Font("Noto Sans", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
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
            btnConvert.Text = "Dönüþtür!";
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
            Controls.Add(label3);
            Controls.Add(lstMusics);
            Controls.Add(label2);
            Controls.Add(lstSounds);
            Controls.Add(btnPlayStop);
            Controls.Add(lblTime);
            Controls.Add(trackTime);
            Controls.Add(label1);
            Controls.Add(lstNotes);
            Controls.Add(picNote);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoteToMusic";
            Load += Form1_Load;
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)picNote).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackVolume).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picNote;
        private System.Windows.Forms.ListBox lstNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnPlayStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSounds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstMusics;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnSounds;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Button btnConvert;
    }
}
