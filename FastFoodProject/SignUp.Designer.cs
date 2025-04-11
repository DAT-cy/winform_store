namespace FastFoodProject
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            pnlLeft = new Panel();
            lblSlogan = new Label();
            lblWelcome = new Label();
            picLogo = new PictureBox();
            pnlRight = new Panel();
            lnkLogin = new LinkLabel();
            btnCancel = new Button();
            btnSignUp = new Button();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            txtUsername = new TextBox();
            lblUsername = new Label();
            lblTitle = new Label();
            pnlUsername = new Panel();
            pnlPassword = new Panel();
            pnlConfirmPassword = new Panel();
            pnlFullName = new Panel();
            pnlPhoneNumber = new Panel();
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
            pnlLeft.Size = new Size(300, 530);
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
            lblSlogan.Text = "Đăng ký để trải nghiệm dịch vụ đặt đồ ăn nhanh chóng và tiện lợi";
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
            lblWelcome.Text = "Chao";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(85, 130);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(138, 100);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            picLogo.Click += picLogo_Click;
            // 
            // pnlRight
            // 
            pnlRight.BackColor = Color.White;
            pnlRight.Controls.Add(lnkLogin);
            pnlRight.Controls.Add(btnCancel);
            pnlRight.Controls.Add(btnSignUp);
            pnlRight.Controls.Add(txtConfirmPassword);
            pnlRight.Controls.Add(lblConfirmPassword);
            pnlRight.Controls.Add(txtPassword);
            pnlRight.Controls.Add(lblPassword);
            pnlRight.Controls.Add(txtPhoneNumber);
            pnlRight.Controls.Add(lblPhoneNumber);
            pnlRight.Controls.Add(txtFullName);
            pnlRight.Controls.Add(lblFullName);
            pnlRight.Controls.Add(txtUsername);
            pnlRight.Controls.Add(lblUsername);
            pnlRight.Controls.Add(lblTitle);
            pnlRight.Controls.Add(pnlUsername);
            pnlRight.Controls.Add(pnlPassword);
            pnlRight.Controls.Add(pnlConfirmPassword);
            pnlRight.Controls.Add(pnlFullName);
            pnlRight.Controls.Add(pnlPhoneNumber);
            pnlRight.Dock = DockStyle.Fill;
            pnlRight.Location = new Point(300, 0);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(482, 530);
            pnlRight.TabIndex = 1;
            // 
            // lnkLogin
            // 
            lnkLogin.ActiveLinkColor = Color.FromArgb(31, 97, 141);
            lnkLogin.AutoSize = true;
            lnkLogin.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkLogin.LinkColor = Color.FromArgb(41, 128, 185);
            lnkLogin.Location = new Point(150, 470);
            lnkLogin.Name = "lnkLogin";
            lnkLogin.Size = new Size(217, 19);
            lnkLogin.TabIndex = 15;
            lnkLogin.TabStop = true;
            lnkLogin.Text = "Đã có tài khoản? Đăng nhập ngay";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(41, 128, 185);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.FromArgb(41, 128, 185);
            btnCancel.Location = new Point(50, 420);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(400, 40);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "HỦY";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(41, 128, 185);
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(50, 370);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(400, 40);
            btnSignUp.TabIndex = 13;
            btnSignUp.Text = "ĐĂNG KÝ";
            btnSignUp.UseVisualStyleBackColor = false;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.None;
            txtConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(50, 320);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '•';
            txtConfirmPassword.Size = new Size(400, 22);
            txtConfirmPassword.TabIndex = 12;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.ForeColor = Color.FromArgb(64, 64, 64);
            lblConfirmPassword.Location = new Point(50, 300);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(137, 20);
            lblConfirmPassword.TabIndex = 11;
            lblConfirmPassword.Text = "Xác nhận mật khẩu:";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(50, 270);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(400, 22);
            txtPassword.TabIndex = 10;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(64, 64, 64);
            lblPassword.Location = new Point(50, 250);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 9;
            lblPassword.Text = "Mật khẩu:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.None;
            txtPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.Location = new Point(50, 225);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(400, 22);
            txtPhoneNumber.TabIndex = 8;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhoneNumber.ForeColor = Color.FromArgb(64, 64, 64);
            lblPhoneNumber.Location = new Point(50, 205);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(100, 20);
            lblPhoneNumber.TabIndex = 7;
            lblPhoneNumber.Text = "Số điện thoại:";
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.None;
            txtFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.Location = new Point(50, 180);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(400, 22);
            txtFullName.TabIndex = 4;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.ForeColor = Color.FromArgb(64, 64, 64);
            lblFullName.Location = new Point(50, 160);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(76, 20);
            lblFullName.TabIndex = 3;
            lblFullName.Text = "Họ và tên:";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(50, 130);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 22);
            txtUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.FromArgb(64, 64, 64);
            lblUsername.Location = new Point(50, 110);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(74, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Tài khoản:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(41, 128, 185);
            lblTitle.Location = new Point(130, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(253, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "TẠO TÀI KHOẢN";
            // 
            // pnlUsername
            // 
            pnlUsername.BackColor = Color.FromArgb(41, 128, 185);
            pnlUsername.Location = new Point(50, 152);
            pnlUsername.Name = "pnlUsername";
            pnlUsername.Size = new Size(400, 2);
            pnlUsername.TabIndex = 15;
            // 
            // pnlPassword
            // 
            pnlPassword.BackColor = Color.FromArgb(41, 128, 185);
            pnlPassword.Location = new Point(50, 292);
            pnlPassword.Name = "pnlPassword";
            pnlPassword.Size = new Size(400, 2);
            pnlPassword.TabIndex = 16;
            // 
            // pnlConfirmPassword
            // 
            pnlConfirmPassword.BackColor = Color.FromArgb(41, 128, 185);
            pnlConfirmPassword.Location = new Point(50, 342);
            pnlConfirmPassword.Name = "pnlConfirmPassword";
            pnlConfirmPassword.Size = new Size(400, 2);
            pnlConfirmPassword.TabIndex = 17;
            // 
            // pnlFullName
            // 
            pnlFullName.BackColor = Color.FromArgb(41, 128, 185);
            pnlFullName.Location = new Point(50, 202);
            pnlFullName.Name = "pnlFullName";
            pnlFullName.Size = new Size(400, 2);
            pnlFullName.TabIndex = 18;
            // 
            // pnlPhoneNumber
            // 
            pnlPhoneNumber.BackColor = Color.FromArgb(41, 128, 185);
            pnlPhoneNumber.Location = new Point(50, 247);
            pnlPhoneNumber.Name = "pnlPhoneNumber";
            pnlPhoneNumber.Size = new Size(400, 2);
            pnlPhoneNumber.TabIndex = 19;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 530);
            Controls.Add(pnlRight);
            Controls.Add(pnlLeft);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng Ký - Hệ Thống Fast Food";
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
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Button btnCancel;
        private LinkLabel lnkLogin;
        private Panel pnlUsername;
        private Panel pnlPassword;
        private Panel pnlConfirmPassword;
        private Panel pnlFullName;
        private Panel pnlPhoneNumber;
    }
}