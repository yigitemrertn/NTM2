namespace NoteToMusic.Forms
{
    partial class FrmLogin
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
            lblTitle = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            SuspendLayout();
            
            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(30, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "🔐 Admin Girişi";
            
            // lblUsername
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11F);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(30, 70);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(108, 25);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Kullanıcı Adı";
            
            // txtUsername
            txtUsername.BackColor = Color.FromArgb(39, 39, 58);
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 11F);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(30, 100);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(340, 32);
            txtUsername.TabIndex = 2;
            
            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(30, 150);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(48, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Şifre";
            
            // txtPassword
            txtPassword.BackColor = Color.FromArgb(39, 39, 58);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(30, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(340, 32);
            txtPassword.TabIndex = 4;
            
            // btnLogin
            btnLogin.BackColor = Color.FromArgb(59, 130, 246);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(30, 240);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            
            // btnCancel
            btnCancel.BackColor = Color.FromArgb(39, 39, 58);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(210, 240);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 45);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "İptal";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            
            // FrmLogin
            AcceptButton = btnLogin;
            CancelButton = btnCancel;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 37);
            ClientSize = new Size(400, 315);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Admin Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
    }
}
