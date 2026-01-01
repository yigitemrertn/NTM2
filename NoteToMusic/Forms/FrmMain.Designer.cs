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
            // Custom Title Bar
            pnlTitleBar = new Panel();
            lblTitle = new Label();
            btnHelp = new Button();
            btnMinimize = new Button();
            btnClose = new Button();
            
            // Sol Panel (Dosyalar)
            pnlLeftSidebar = new Panel();
            lblDosyalar = new Label();
            pnlDosyalarUnderline = new Panel();
            lblNotes = new Label();
            txtNoteSearch = new TextBox();
            pnlSearchNotesUnderline = new Panel();
            lstNotes = new ListBox();
            btnNotes = new Button();
            lblSounds = new Label();
            txtSoundSearch = new TextBox();
            pnlSearchSoundfontUnderline = new Panel();
            lstSounds = new ListBox();
            btnSounds = new Button();
            btnConvert = new Button();
            
            // Orta Panel (Resim)
            pnlMainContent = new Panel();
            picNote = new PictureBox();
            
            // Sağ Panel (Müzikler)
            pnlRightSidebar = new Panel();
            lblMuzikler = new Label();
            pnlMuziklerUnderline = new Panel();
            txtMusicSearch = new TextBox();
            pnlSearchMusicUnderline = new Panel();
            lstMusics = new ListBox();
            btnPlayStop = new Button();
            btnPrevious = new Button();
            btnRewind = new Button();
            btnForward = new Button();
            btnNext = new Button();
            trackTime = new TrackBar();
            lblTime = new Label();
            lblVolume = new Label();
            trackVolume = new TrackBar();
            btnFeedback = new Button();
            
            pnlTitleBar.SuspendLayout();
            pnlLeftSidebar.SuspendLayout();
            pnlMainContent.SuspendLayout();
            pnlRightSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picNote).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackVolume).BeginInit();
            SuspendLayout();
            
            // 
            // pnlTitleBar (Custom Title Bar)
            // 
            pnlTitleBar.BackColor = Color.FromArgb(20, 20, 30);
            pnlTitleBar.Controls.Add(btnClose);
            pnlTitleBar.Controls.Add(btnMinimize);
            pnlTitleBar.Controls.Add(btnHelp);
            pnlTitleBar.Controls.Add(lblTitle);
            pnlTitleBar.Dock = DockStyle.Top;
            pnlTitleBar.Location = new Point(0, 0);
            pnlTitleBar.Name = "pnlTitleBar";
            pnlTitleBar.Size = new Size(1600, 40);
            pnlTitleBar.TabIndex = 0;
            pnlTitleBar.MouseDown += pnlTitleBar_MouseDown;
            pnlTitleBar.MouseMove += pnlTitleBar_MouseMove;
            pnlTitleBar.MouseUp += pnlTitleBar_MouseUp;
            
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(15, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🎵 Note To Music";
            lblTitle.MouseDown += pnlTitleBar_MouseDown;
            lblTitle.MouseMove += pnlTitleBar_MouseMove;
            lblTitle.MouseUp += pnlTitleBar_MouseUp;
            
            // 
            // btnHelp
            // 
            btnHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnHelp.BackColor = Color.FromArgb(59, 130, 246);
            btnHelp.Cursor = Cursors.Hand;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnHelp.ForeColor = Color.White;
            btnHelp.Location = new Point(1450, 0);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new Size(50, 40);
            btnHelp.TabIndex = 1;
            btnHelp.Text = "?";
            btnHelp.UseVisualStyleBackColor = false;
            btnHelp.Click += btnHelp_Click;
            
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.FromArgb(30, 30, 46);
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1500, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(50, 40);
            btnMinimize.TabIndex = 1;
            btnMinimize.Text = "─";
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(220, 38, 38);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1550, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(50, 40);
            btnClose.TabIndex = 2;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            
            // 
            // pnlLeftSidebar (Dosyalar - Sol Panel)
            // 
            pnlLeftSidebar.BackColor = Color.FromArgb(30, 30, 46);
            pnlLeftSidebar.Controls.Add(btnConvert);
            pnlLeftSidebar.Controls.Add(btnSounds);
            pnlLeftSidebar.Controls.Add(lstSounds);
            pnlLeftSidebar.Controls.Add(pnlSearchSoundfontUnderline);
            pnlLeftSidebar.Controls.Add(txtSoundSearch);
            pnlLeftSidebar.Controls.Add(lblSounds);
            pnlLeftSidebar.Controls.Add(btnNotes);
            pnlLeftSidebar.Controls.Add(lstNotes);
            pnlLeftSidebar.Controls.Add(pnlSearchNotesUnderline);
            pnlLeftSidebar.Controls.Add(txtNoteSearch);
            pnlLeftSidebar.Controls.Add(lblNotes);
            pnlLeftSidebar.Controls.Add(pnlDosyalarUnderline);
            pnlLeftSidebar.Controls.Add(lblDosyalar);
            pnlLeftSidebar.Dock = DockStyle.Left;
            pnlLeftSidebar.Location = new Point(0, 40);
            pnlLeftSidebar.Name = "pnlLeftSidebar";
            pnlLeftSidebar.Padding = new Padding(0, 20, 0, 0);
            pnlLeftSidebar.Size = new Size(440, 1010);
            pnlLeftSidebar.TabIndex = 0;
            
            // 
            // lblDosyalar
            // 
            lblDosyalar.AutoSize = true;
            lblDosyalar.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblDosyalar.ForeColor = Color.White;
            lblDosyalar.Location = new Point(20, 15);
            lblDosyalar.Name = "lblDosyalar";
            lblDosyalar.Size = new Size(104, 32);
            lblDosyalar.TabIndex = 0;
            lblDosyalar.Text = "Dosyalar";
            
            // 
            // pnlDosyalarUnderline
            // 
            pnlDosyalarUnderline.BackColor = Color.FromArgb(59, 130, 246);
            pnlDosyalarUnderline.Location = new Point(20, 52);
            pnlDosyalarUnderline.Name = "pnlDosyalarUnderline";
            pnlDosyalarUnderline.Size = new Size(400, 3);
            pnlDosyalarUnderline.TabIndex = 1;
            
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblNotes.ForeColor = Color.White;
            lblNotes.Location = new Point(20, 75);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(82, 28);
            lblNotes.TabIndex = 2;
            lblNotes.Text = "Notalar";
            
            // 
            // txtNoteSearch
            // 
            txtNoteSearch.BackColor = Color.FromArgb(30, 30, 46);
            txtNoteSearch.BorderStyle = BorderStyle.None;
            txtNoteSearch.Font = new Font("Segoe UI", 11F);
            txtNoteSearch.ForeColor = Color.FromArgb(161, 161, 170);
            txtNoteSearch.Location = new Point(20, 118);
            txtNoteSearch.Name = "txtNoteSearch";
            txtNoteSearch.PlaceholderText = "Ara...";
            txtNoteSearch.Size = new Size(400, 25);
            txtNoteSearch.TabIndex = 3;
            txtNoteSearch.TextChanged += txtNoteSearch_TextChanged;
            
            // 
            // pnlSearchNotesUnderline
            // 
            pnlSearchNotesUnderline.BackColor = Color.FromArgb(59, 130, 246);
            pnlSearchNotesUnderline.Location = new Point(20, 148);
            pnlSearchNotesUnderline.Name = "pnlSearchNotesUnderline";
            pnlSearchNotesUnderline.Size = new Size(400, 2);
            pnlSearchNotesUnderline.TabIndex = 4;
            
            // 
            // lstNotes
            // 
            lstNotes.BackColor = Color.FromArgb(39, 39, 58);
            lstNotes.BorderStyle = BorderStyle.None;
            lstNotes.Font = new Font("Segoe UI", 11F);
            lstNotes.ForeColor = Color.White;
            lstNotes.FormattingEnabled = true;
            lstNotes.ItemHeight = 25;
            lstNotes.Location = new Point(20, 160);
            lstNotes.Name = "lstNotes";
            lstNotes.Size = new Size(400, 250);
            lstNotes.TabIndex = 5;
            lstNotes.SelectedIndexChanged += lstNotes_SelectedIndexChanged;
            
            // 
            // btnNotes
            // 
            btnNotes.BackColor = Color.FromArgb(59, 130, 246);
            btnNotes.Cursor = Cursors.Hand;
            btnNotes.FlatAppearance.BorderSize = 0;
            btnNotes.FlatStyle = FlatStyle.Flat;
            btnNotes.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnNotes.ForeColor = Color.White;
            btnNotes.Location = new Point(20, 425);
            btnNotes.Name = "btnNotes";
            btnNotes.Size = new Size(400, 40);
            btnNotes.TabIndex = 6;
            btnNotes.Text = "➕ Nota Ekle";
            btnNotes.UseVisualStyleBackColor = false;
            btnNotes.Click += btnNotes_Click;
            
            // 
            // lblSounds
            // 
            lblSounds.AutoSize = true;
            lblSounds.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSounds.ForeColor = Color.White;
            lblSounds.Location = new Point(20, 485);
            lblSounds.Name = "lblSounds";
            lblSounds.Size = new Size(107, 28);
            lblSounds.TabIndex = 7;
            lblSounds.Text = "Soundfont";
            
            // 
            // txtSoundSearch
            // 
            txtSoundSearch.BackColor = Color.FromArgb(30, 30, 46);
            txtSoundSearch.BorderStyle = BorderStyle.None;
            txtSoundSearch.Font = new Font("Segoe UI", 11F);
            txtSoundSearch.ForeColor = Color.FromArgb(161, 161, 170);
            txtSoundSearch.Location = new Point(20, 528);
            txtSoundSearch.Name = "txtSoundSearch";
            txtSoundSearch.PlaceholderText = "Ara...";
            txtSoundSearch.Size = new Size(400, 25);
            txtSoundSearch.TabIndex = 8;
            txtSoundSearch.TextChanged += txtSoundSearch_TextChanged;
            
            // 
            // pnlSearchSoundfontUnderline
            // 
            pnlSearchSoundfontUnderline.BackColor = Color.FromArgb(59, 130, 246);
            pnlSearchSoundfontUnderline.Location = new Point(20, 558);
            pnlSearchSoundfontUnderline.Name = "pnlSearchSoundfontUnderline";
            pnlSearchSoundfontUnderline.Size = new Size(400, 2);
            pnlSearchSoundfontUnderline.TabIndex = 9;
            
            // 
            // lstSounds
            // 
            lstSounds.BackColor = Color.FromArgb(39, 39, 58);
            lstSounds.BorderStyle = BorderStyle.None;
            lstSounds.Font = new Font("Segoe UI", 11F);
            lstSounds.ForeColor = Color.White;
            lstSounds.FormattingEnabled = true;
            lstSounds.ItemHeight = 25;
            lstSounds.Location = new Point(20, 570);
            lstSounds.Name = "lstSounds";
            lstSounds.Size = new Size(400, 250);
            lstSounds.TabIndex = 10;
            lstSounds.SelectedIndexChanged += lstSounds_SelectedIndexChanged;
            
            // 
            // btnSounds
            // 
            btnSounds.BackColor = Color.FromArgb(59, 130, 246);
            btnSounds.Cursor = Cursors.Hand;
            btnSounds.FlatAppearance.BorderSize = 0;
            btnSounds.FlatStyle = FlatStyle.Flat;
            btnSounds.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnSounds.ForeColor = Color.White;
            btnSounds.Location = new Point(20, 835);
            btnSounds.Name = "btnSounds";
            btnSounds.Size = new Size(400, 40);
            btnSounds.TabIndex = 11;
            btnSounds.Text = "➕ SoundFont Ekle";
            btnSounds.UseVisualStyleBackColor = false;
            btnSounds.Click += btnSounds_Click;
            
            // 
            // btnConvert
            // 
            btnConvert.BackColor = Color.FromArgb(236, 72, 153);
            btnConvert.Cursor = Cursors.Hand;
            btnConvert.FlatAppearance.BorderSize = 0;
            btnConvert.FlatStyle = FlatStyle.Flat;
            btnConvert.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            btnConvert.ForeColor = Color.White;
            btnConvert.Location = new Point(20, 935);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(400, 50);
            btnConvert.TabIndex = 12;
            btnConvert.Text = "DÖNÜŞTÜR";
            btnConvert.UseVisualStyleBackColor = false;
            btnConvert.Click += btnConvert_Click;
            
            // 
            // pnlMainContent (Orta - Resim)
            // 
            pnlMainContent.BackColor = Color.FromArgb(24, 24, 37);
            pnlMainContent.Controls.Add(picNote);
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(220, 0);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Padding = new Padding(10);
            pnlMainContent.Size = new Size(1140, 1000);
            pnlMainContent.TabIndex = 1;
            
            // 
            // picNote
            // 
            picNote.BackColor = Color.FromArgb(24, 24, 37);
            picNote.BorderStyle = BorderStyle.None;
            picNote.Dock = DockStyle.Fill;
            picNote.Location = new Point(10, 10);
            picNote.Name = "picNote";
            picNote.Size = new Size(1120, 980);
            picNote.SizeMode = PictureBoxSizeMode.Zoom;
            picNote.TabIndex = 0;
            picNote.TabStop = false;
            
            // 
            // pnlRightSidebar (Müzikler - Sağ Panel)
            // 
            pnlRightSidebar.BackColor = Color.FromArgb(30, 30, 46);
            pnlRightSidebar.Controls.Add(btnFeedback);
            pnlRightSidebar.Controls.Add(trackVolume);
            pnlRightSidebar.Controls.Add(lblVolume);
            pnlRightSidebar.Controls.Add(lblTime);
            pnlRightSidebar.Controls.Add(trackTime);
            pnlRightSidebar.Controls.Add(btnNext);
            pnlRightSidebar.Controls.Add(btnForward);
            pnlRightSidebar.Controls.Add(btnRewind);
            pnlRightSidebar.Controls.Add(btnPrevious);
            pnlRightSidebar.Controls.Add(btnPlayStop);
            pnlRightSidebar.Controls.Add(lstMusics);
            pnlRightSidebar.Controls.Add(pnlSearchMusicUnderline);
            pnlRightSidebar.Controls.Add(txtMusicSearch);
            pnlRightSidebar.Controls.Add(pnlMuziklerUnderline);
            pnlRightSidebar.Controls.Add(lblMuzikler);
            pnlRightSidebar.Dock = DockStyle.Right;
            pnlRightSidebar.Location = new Point(1160, 0);
            pnlRightSidebar.Name = "pnlRightSidebar";
            pnlRightSidebar.Size = new Size(440, 1000);
            pnlRightSidebar.TabIndex = 2;
            
            // 
            // lblMuzikler
            // 
            lblMuzikler.AutoSize = true;
            lblMuzikler.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblMuzikler.ForeColor = Color.White;
            lblMuzikler.Location = new Point(20, 15);
            lblMuzikler.Name = "lblMuzikler";
            lblMuzikler.Size = new Size(131, 32);
            lblMuzikler.TabIndex = 0;
            lblMuzikler.Text = "Müzikler";
            
            // 
            // pnlMuziklerUnderline
            // 
            pnlMuziklerUnderline.BackColor = Color.FromArgb(59, 130, 246);
            pnlMuziklerUnderline.Location = new Point(20, 52);
            pnlMuziklerUnderline.Name = "pnlMuziklerUnderline";
            pnlMuziklerUnderline.Size = new Size(400, 3);
            pnlMuziklerUnderline.TabIndex = 1;
            
            // 
            // txtMusicSearch
            // 
            txtMusicSearch.BackColor = Color.FromArgb(30, 30, 46);
            txtMusicSearch.BorderStyle = BorderStyle.None;
            txtMusicSearch.Font = new Font("Segoe UI", 11F);
            txtMusicSearch.ForeColor = Color.FromArgb(161, 161, 170);
            txtMusicSearch.Location = new Point(20, 78);
            txtMusicSearch.Name = "txtMusicSearch";
            txtMusicSearch.PlaceholderText = "Ara...";
            txtMusicSearch.Size = new Size(400, 25);
            txtMusicSearch.TabIndex = 2;
            txtMusicSearch.TextChanged += txtMusicSearch_TextChanged;
            
            // 
            // pnlSearchMusicUnderline
            // 
            pnlSearchMusicUnderline.BackColor = Color.FromArgb(59, 130, 246);
            pnlSearchMusicUnderline.Location = new Point(20, 108);
            pnlSearchMusicUnderline.Name = "pnlSearchMusicUnderline";
            pnlSearchMusicUnderline.Size = new Size(400, 2);
            pnlSearchMusicUnderline.TabIndex = 3;
            
            // 
            // lstMusics
            // 
            lstMusics.BackColor = Color.FromArgb(39, 39, 58);
            lstMusics.BorderStyle = BorderStyle.None;
            lstMusics.Font = new Font("Segoe UI", 11F);
            lstMusics.ForeColor = Color.White;
            lstMusics.FormattingEnabled = true;
            lstMusics.ItemHeight = 25;
            lstMusics.Location = new Point(20, 120);
            lstMusics.Name = "lstMusics";
            lstMusics.Size = new Size(400, 250);
            lstMusics.TabIndex = 4;
            lstMusics.SelectedIndexChanged += lstMusics_SelectedIndexChanged;
            
            // 
            // btnPlayStop
            // 
            btnPlayStop.BackColor = Color.FromArgb(59, 130, 246);
            btnPlayStop.Cursor = Cursors.Hand;
            btnPlayStop.FlatAppearance.BorderSize = 0;
            btnPlayStop.FlatStyle = FlatStyle.Flat;
            btnPlayStop.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            btnPlayStop.ForeColor = Color.White;
            btnPlayStop.Location = new Point(20, 385);
            btnPlayStop.Name = "btnPlayStop";
            btnPlayStop.Size = new Size(400, 55);
            btnPlayStop.TabIndex = 5;
            btnPlayStop.Text = "▶ Oynat";
            btnPlayStop.UseVisualStyleBackColor = false;
            btnPlayStop.Click += btnPlayStop_Click;
            
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.FromArgb(39, 39, 58);
            btnPrevious.Cursor = Cursors.Hand;
            btnPrevious.FlatAppearance.BorderSize = 0;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.Location = new Point(20, 455);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(85, 45);
            btnPrevious.TabIndex = 6;
            btnPrevious.Text = "⏮";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            
            // 
            // btnRewind
            // 
            btnRewind.BackColor = Color.FromArgb(39, 39, 58);
            btnRewind.Cursor = Cursors.Hand;
            btnRewind.FlatAppearance.BorderSize = 0;
            btnRewind.FlatStyle = FlatStyle.Flat;
            btnRewind.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnRewind.ForeColor = Color.White;
            btnRewind.Location = new Point(120, 455);
            btnRewind.Name = "btnRewind";
            btnRewind.Size = new Size(85, 45);
            btnRewind.TabIndex = 7;
            btnRewind.Text = "-5s";
            btnRewind.UseVisualStyleBackColor = false;
            btnRewind.Click += btnRewind_Click;
            
            // 
            // btnForward
            // 
            btnForward.BackColor = Color.FromArgb(39, 39, 58);
            btnForward.Cursor = Cursors.Hand;
            btnForward.FlatAppearance.BorderSize = 0;
            btnForward.FlatStyle = FlatStyle.Flat;
            btnForward.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnForward.ForeColor = Color.White;
            btnForward.Location = new Point(220, 455);
            btnForward.Name = "btnForward";
            btnForward.Size = new Size(85, 45);
            btnForward.TabIndex = 8;
            btnForward.Text = "+5s";
            btnForward.UseVisualStyleBackColor = false;
            btnForward.Click += btnForward_Click;
            
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(39, 39, 58);
            btnNext.Cursor = Cursors.Hand;
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(320, 455);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(100, 45);
            btnNext.TabIndex = 9;
            btnNext.Text = "⏭";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            
            // 
            // trackTime
            // 
            trackTime.BackColor = Color.FromArgb(30, 30, 46);
            trackTime.Location = new Point(20, 515);
            trackTime.Maximum = 100;
            trackTime.Name = "trackTime";
            trackTime.Size = new Size(400, 56);
            trackTime.TabIndex = 10;
            trackTime.TickStyle = TickStyle.None;
            trackTime.Scroll += trackTime_Scroll;
            trackTime.MouseDown += trackTime_MouseDown;
            
            // 
            // lblTime
            // 
            lblTime.Font = new Font("Segoe UI", 10F);
            lblTime.ForeColor = Color.FromArgb(161, 161, 170);
            lblTime.Location = new Point(20, 575);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(400, 22);
            lblTime.TabIndex = 11;
            lblTime.Text = "00:00 / 00:00";
            lblTime.TextAlign = ContentAlignment.MiddleCenter;
            
            // 
            // lblVolume
            // 
            lblVolume.AutoSize = true;
            lblVolume.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lblVolume.ForeColor = Color.White;
            lblVolume.Location = new Point(20, 615);
            lblVolume.Name = "lblVolume";
            lblVolume.Size = new Size(38, 25);
            lblVolume.TabIndex = 12;
            lblVolume.Text = "Ses";
            
            // 
            // trackVolume
            // 
            trackVolume.BackColor = Color.FromArgb(30, 30, 46);
            trackVolume.Location = new Point(20, 650);
            trackVolume.Maximum = 100;
            trackVolume.Name = "trackVolume";
            trackVolume.Size = new Size(400, 56);
            trackVolume.TabIndex = 13;
            trackVolume.TickStyle = TickStyle.None;
            trackVolume.Value = 100;
            trackVolume.Scroll += trackVolume_Scroll;
            
            // 
            // btnFeedback
            // 
            btnFeedback.BackColor = Color.FromArgb(39, 39, 58);
            btnFeedback.Enabled = false;
            btnFeedback.FlatAppearance.BorderSize = 0;
            btnFeedback.FlatStyle = FlatStyle.Flat;
            btnFeedback.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnFeedback.ForeColor = Color.White;
            btnFeedback.Location = new Point(20, 720);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(400, 40);
            btnFeedback.TabIndex = 14;
            btnFeedback.Text = "💬 Geri Bildirim Ver";
            btnFeedback.UseVisualStyleBackColor = false;
            btnFeedback.Click += btnFeedback_Click;
            
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 37);
            ClientSize = new Size(1600, 1050);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlRightSidebar);
            Controls.Add(pnlLeftSidebar);
            Controls.Add(pnlTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "🎵 Note To Music";
            WindowState = FormWindowState.Maximized;
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            pnlTitleBar.ResumeLayout(false);
            pnlTitleBar.PerformLayout();
            pnlLeftSidebar.ResumeLayout(false);
            pnlLeftSidebar.PerformLayout();
            pnlMainContent.ResumeLayout(false);
            pnlRightSidebar.ResumeLayout(false);
            pnlRightSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picNote).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackVolume).EndInit();
            ResumeLayout(false);
        }

        #endregion

        // Custom Title Bar
        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        
        // Sol Panel (Dosyalar)
        private System.Windows.Forms.Panel pnlLeftSidebar;
        private System.Windows.Forms.Label lblDosyalar;
        private System.Windows.Forms.Panel pnlDosyalarUnderline;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNoteSearch;
        private System.Windows.Forms.Panel pnlSearchNotesUnderline;
        private System.Windows.Forms.ListBox lstNotes;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Label lblSounds;
        private System.Windows.Forms.TextBox txtSoundSearch;
        private System.Windows.Forms.Panel pnlSearchSoundfontUnderline;
        private System.Windows.Forms.ListBox lstSounds;
        private System.Windows.Forms.Button btnSounds;
        private System.Windows.Forms.Button btnConvert;
        
        // Orta Panel (Resim)
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.PictureBox picNote;
        
        // Sağ Panel (Müzikler)
        private System.Windows.Forms.Panel pnlRightSidebar;
        private System.Windows.Forms.Label lblMuzikler;
        private System.Windows.Forms.Panel pnlMuziklerUnderline;
        private System.Windows.Forms.TextBox txtMusicSearch;
        private System.Windows.Forms.Panel pnlSearchMusicUnderline;
        private System.Windows.Forms.ListBox lstMusics;
        private System.Windows.Forms.Button btnPlayStop;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnRewind;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TrackBar trackTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Button btnFeedback;
    }
}
