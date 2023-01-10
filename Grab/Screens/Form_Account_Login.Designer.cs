namespace Grab.Screens
{
    partial class Form_Account_Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelGradient1 = new Grab.CustomControls.PanelGradient();
            this.Label_ErrorLogin = new System.Windows.Forms.Label();
            this.Button_Close = new FontAwesome.Sharp.IconButton();
            this.Label_ForgotPassword = new System.Windows.Forms.Label();
            this.Button_Register = new FontAwesome.Sharp.IconButton();
            this.Button_Login = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TextBox_Account = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelGradient1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Grab.Images_GrabBrand.BR01;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 724);
            this.panel1.TabIndex = 0;
            // 
            // panelGradient1
            // 
            this.panelGradient1.Angle = 30F;
            this.panelGradient1.BottomColor = System.Drawing.Color.Green;
            this.panelGradient1.Controls.Add(this.Label_ErrorLogin);
            this.panelGradient1.Controls.Add(this.Button_Close);
            this.panelGradient1.Controls.Add(this.Label_ForgotPassword);
            this.panelGradient1.Controls.Add(this.Button_Register);
            this.panelGradient1.Controls.Add(this.Button_Login);
            this.panelGradient1.Controls.Add(this.label3);
            this.panelGradient1.Controls.Add(this.label2);
            this.panelGradient1.Controls.Add(this.panel2);
            this.panelGradient1.Controls.Add(this.panel5);
            this.panelGradient1.Controls.Add(this.label1);
            this.panelGradient1.Controls.Add(this.pictureBox1);
            this.panelGradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGradient1.Location = new System.Drawing.Point(483, 0);
            this.panelGradient1.Name = "panelGradient1";
            this.panelGradient1.Size = new System.Drawing.Size(675, 724);
            this.panelGradient1.TabIndex = 1;
            this.panelGradient1.TopColor = System.Drawing.Color.White;
            // 
            // Label_ErrorLogin
            // 
            this.Label_ErrorLogin.AutoSize = true;
            this.Label_ErrorLogin.BackColor = System.Drawing.Color.Transparent;
            this.Label_ErrorLogin.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ErrorLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_ErrorLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label_ErrorLogin.Location = new System.Drawing.Point(255, 436);
            this.Label_ErrorLogin.Name = "Label_ErrorLogin";
            this.Label_ErrorLogin.Size = new System.Drawing.Size(373, 23);
            this.Label_ErrorLogin.TabIndex = 10;
            this.Label_ErrorLogin.Text = "Thông tin chưa chính xác, vui lòng kiểm tra lại";
            this.Label_ErrorLogin.Visible = false;
            // 
            // Button_Close
            // 
            this.Button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Close.BackColor = System.Drawing.Color.Transparent;
            this.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Close.FlatAppearance.BorderSize = 0;
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.IconChar = FontAwesome.Sharp.IconChar.X;
            this.Button_Close.IconColor = System.Drawing.Color.White;
            this.Button_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Close.IconSize = 24;
            this.Button_Close.Location = new System.Drawing.Point(630, 0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(45, 45);
            this.Button_Close.TabIndex = 9;
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            this.Button_Close.MouseEnter += new System.EventHandler(this.Button_Close_MouseEnter);
            this.Button_Close.MouseLeave += new System.EventHandler(this.Button_Close_MouseLeave);
            // 
            // Label_ForgotPassword
            // 
            this.Label_ForgotPassword.AutoSize = true;
            this.Label_ForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.Label_ForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_ForgotPassword.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ForgotPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Label_ForgotPassword.Location = new System.Drawing.Point(110, 594);
            this.Label_ForgotPassword.Name = "Label_ForgotPassword";
            this.Label_ForgotPassword.Size = new System.Drawing.Size(161, 27);
            this.Label_ForgotPassword.TabIndex = 8;
            this.Label_ForgotPassword.Text = "Quên mật khẩu ";
            this.Label_ForgotPassword.Click += new System.EventHandler(this.Label_ForgotPassword_Click);
            // 
            // Button_Register
            // 
            this.Button_Register.BackColor = System.Drawing.Color.White;
            this.Button_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Register.FlatAppearance.BorderSize = 0;
            this.Button_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Register.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.Button_Register.ForeColor = System.Drawing.Color.Green;
            this.Button_Register.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_Register.IconColor = System.Drawing.Color.Black;
            this.Button_Register.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Register.Location = new System.Drawing.Point(352, 578);
            this.Button_Register.Name = "Button_Register";
            this.Button_Register.Size = new System.Drawing.Size(276, 59);
            this.Button_Register.TabIndex = 7;
            this.Button_Register.Text = "Chưa có tài khoản";
            this.Button_Register.UseVisualStyleBackColor = false;
            this.Button_Register.Click += new System.EventHandler(this.Button_Register_Click);
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.Color.Green;
            this.Button_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Login.FlatAppearance.BorderSize = 0;
            this.Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Login.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.Button_Login.ForeColor = System.Drawing.Color.White;
            this.Button_Login.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_Login.IconColor = System.Drawing.Color.Black;
            this.Button_Login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Login.Location = new System.Drawing.Point(55, 475);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(573, 59);
            this.Button_Login.TabIndex = 6;
            this.Button_Login.Text = "Đăng nhập";
            this.Button_Login.UseVisualStyleBackColor = false;
            this.Button_Login.Click += new System.EventHandler(this.Button_Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.Location = new System.Drawing.Point(51, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên đăng nhập";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.TextBox_Password);
            this.panel2.Location = new System.Drawing.Point(55, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 59);
            this.panel2.TabIndex = 3;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BackColor = System.Drawing.Color.White;
            this.TextBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Password.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Password.ForeColor = System.Drawing.Color.Silver;
            this.TextBox_Password.Location = new System.Drawing.Point(14, 19);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.Size = new System.Drawing.Size(542, 28);
            this.TextBox_Password.TabIndex = 0;
            this.TextBox_Password.Text = "Mật khẩu ...";
            this.TextBox_Password.Enter += new System.EventHandler(this.TextBox_Password_Enter);
            this.TextBox_Password.Leave += new System.EventHandler(this.TextBox_Password_Leave);
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.TextBox_Account);
            this.panel5.Location = new System.Drawing.Point(55, 254);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(573, 59);
            this.panel5.TabIndex = 2;
            // 
            // TextBox_Account
            // 
            this.TextBox_Account.BackColor = System.Drawing.Color.White;
            this.TextBox_Account.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Account.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Account.ForeColor = System.Drawing.Color.Silver;
            this.TextBox_Account.Location = new System.Drawing.Point(14, 20);
            this.TextBox_Account.Name = "TextBox_Account";
            this.TextBox_Account.Size = new System.Drawing.Size(542, 28);
            this.TextBox_Account.TabIndex = 0;
            this.TextBox_Account.Text = "Số điện thoại ...";
            this.TextBox_Account.Enter += new System.EventHandler(this.TextBox_Account_Enter);
            this.TextBox_Account.Leave += new System.EventHandler(this.TextBox_Account_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(222, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Grab.Images_GrabLogo.LG1_04;
            this.pictureBox1.Location = new System.Drawing.Point(32, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Account_Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1158, 724);
            this.Controls.Add(this.panelGradient1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Account_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Account_Login";
            this.panelGradient1.ResumeLayout(false);
            this.panelGradient1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CustomControls.PanelGradient panelGradient1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TextBox_Account;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label_ForgotPassword;
        private FontAwesome.Sharp.IconButton Button_Register;
        private FontAwesome.Sharp.IconButton Button_Login;
        private FontAwesome.Sharp.IconButton Button_Close;
        private System.Windows.Forms.Label Label_ErrorLogin;
    }
}