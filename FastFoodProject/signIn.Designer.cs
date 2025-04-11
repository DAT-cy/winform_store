namespace FastFoodProject
{
    partial class signIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signIn));
            pnlLeft = new Panel();
            lblSlogan = new Label();
            lblWelcome = new Label();
            picLogo = new PictureBox();
            pnlRight = new Panel();
            lnkSignUp = new LinkLabel();
            btnCancel = new Button();
            btnLogin = new Button();
            lnkForgotPassword = new LinkLabel();
            chkRememberMe = new CheckBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblTitle = new Label();
            pnlUsername = new Panel();
            pnlPassword = new Panel();
            pnlLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            pnlRight.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(41, 128, 185);
            pnlLeft.Controls.Add(lblSlogan);
            pnlLeft.Controls.Add(lblWelcome);
            pnlLeft.Controls.Add(picLogo);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(300, 500);
            pnlLeft.TabIndex = 0;
            // 
            // lblSlogan
            // 
            lblSlogan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSlogan.ForeColor = Color.White;
            lblSlogan.Location = new Point(30, 300);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(240, 60);
            lblSlogan.TabIndex = 2;
            lblSlogan.Text = "Đăng nhập để trải nghiệm dịch vụ đặt đồ ăn nhanh chóng và tiện lợi";
            lblSlogan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(50, 250);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(220, 37);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Chào mừng bạn";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(81, 96);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(148, 113);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(lnkSignUp);
            pnlRight.Controls.Add(btnCancel);
            pnlRight.Controls.Add(btnLogin);
            pnlRight.Controls.Add(lnkForgotPassword);
            pnlRight.Controls.Add(chkRememberMe);
            pnlRight.Controls.Add(txtPassword);
            pnlRight.Controls.Add(lblPassword);
            pnlRight.Controls.Add(txtUsername);
            pnlRight.Controls.Add(lblUsername);
            pnlRight.Controls.Add(lblTitle);
            pnlRight.Controls.Add(pnlUsername);
            pnlRight.Controls.Add(pnlPassword);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(300, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(500, 500);
            pnlRight.TabIndex = 1;
            // 
            // lnkSignUp
            // 
            lnkSignUp.ActiveLinkColor = Color.FromArgb(31, 97, 141);
            lnkSignUp.AutoSize = true;
            lnkSignUp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkSignUp.LinkColor = Color.FromArgb(41, 128, 185);
            lnkSignUp.Location = new Point(150, 460);
            lnkSignUp.Name = "lnkSignUp";
            lnkSignUp.Size = new Size(215, 19);
            lnkSignUp.TabIndex = 9;
            lnkSignUp.TabStop = true;
            lnkSignUp.Text = "Chưa có tài khoản? Đăng ký ngay";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(41, 128, 185);
            btnCancel.Location = new Point(50, 395);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(400, 45);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "HỦY";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(41, 128, 185);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(50, 340);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(400, 45);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // lnkForgotPassword
            // 
            lnkForgotPassword.ActiveLinkColor = Color.FromArgb(31, 97, 141);
            lnkForgotPassword.AutoSize = true;
            lnkForgotPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkForgotPassword.LinkColor = Color.FromArgb(41, 128, 185);
            lnkForgotPassword.Location = new Point(320, 295);
            lnkForgotPassword.Name = "lnkForgotPassword";
            lnkForgotPassword.Size = new Size(111, 19);
            lnkForgotPassword.TabIndex = 6;
            lnkForgotPassword.TabStop = true;
            lnkForgotPassword.Text = "Quên mật khẩu?";
            // 
            // chkRememberMe
            // 
            chkRememberMe.AutoSize = true;
            chkRememberMe.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkRememberMe.ForeColor = Color.FromArgb(64, 64, 64);
            chkRememberMe.Location = new Point(50, 295);
            chkRememberMe.Name = "chkRememberMe";
            chkRememberMe.Size = new Size(124, 23);
            chkRememberMe.TabIndex = 5;
            chkRememberMe.Text = "Nhớ đăng nhập";
            chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(50, 255);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(400, 22);
            txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(64, 64, 64);
            lblPassword.Location = new Point(50, 230);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(78, 21);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Mật khẩu:";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(50, 185);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 22);
            txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(64, 64, 64);
            lblUsername.Location = new Point(50, 160);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(78, 21);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Tài khoản:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(41, 128, 185);
            lblTitle.Location = new Point(150, 80);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(217, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG NHẬP";
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.FromArgb(41, 128, 185);
            pnlUsername.Location = new Point(50, 207);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(400, 2);
            pnlUsername.TabIndex = 10;
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.FromArgb(41, 128, 185);
            pnlPassword.Location = new Point(50, 277);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(400, 2);
            pnlPassword.TabIndex = 11;
            // 
            // signIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "signIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Nhập - Hệ Thống Fast Food";
            Load += signIn_Load;
            pnlLeft.ResumeLayout(false);
            pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            pnlRight.ResumeLayout(false);
            pnlRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlLeft;
        private PictureBox picLogo;
        private Label lblWelcome;
        private Label lblSlogan;
        private Panel pnlRight;
        private Label lblTitle;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private CheckBox chkRememberMe;
        private LinkLabel lnkForgotPassword;
        private Button btnLogin;
        private Button btnCancel;
        private LinkLabel lnkSignUp;
        private Panel pnlUsername;
        private Panel pnlPassword;
    }
}