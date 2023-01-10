namespace Grab.Screens
{
    partial class Form_Forgot_Password
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
            this.panelGradient1 = new Grab.CustomControls.PanelGradient();
            this.Label_TextComfirm = new System.Windows.Forms.Label();
            this.Picture_ValidNewPassword = new System.Windows.Forms.PictureBox();
            this.Picture_ValidCode = new System.Windows.Forms.PictureBox();
            this.Picture_ValidAccount = new System.Windows.Forms.PictureBox();
            this.Label_OKSignup = new System.Windows.Forms.Label();
            this.Label_1 = new System.Windows.Forms.Label();
            this.Panel_ConfirmCode = new System.Windows.Forms.Panel();
            this.TextBox_ConfirmCode = new System.Windows.Forms.TextBox();
            this.Button_SendCode = new FontAwesome.Sharp.IconButton();
            this.Label_2 = new System.Windows.Forms.Label();
            this.Panel_NewPassword = new System.Windows.Forms.Panel();
            this.TextBox_NewPassword = new System.Windows.Forms.TextBox();
            this.Label_ErrorLogin = new System.Windows.Forms.Label();
            this.Button_Close = new FontAwesome.Sharp.IconButton();
            this.Button_Login = new FontAwesome.Sharp.IconButton();
            this.Button_ChangePassword = new FontAwesome.Sharp.IconButton();
            this.Label_3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel_Password = new System.Windows.Forms.Panel();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TextBox_Account = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelGradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ValidNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ValidCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ValidAccount)).BeginInit();
            this.Panel_ConfirmCode.SuspendLayout();
            this.Panel_NewPassword.SuspendLayout();
            this.Panel_Password.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGradient1
            // 
            this.panelGradient1.Angle = 30F;
            this.panelGradient1.BottomColor = System.Drawing.Color.Green;
            this.panelGradient1.Controls.Add(this.Label_TextComfirm);
            this.panelGradient1.Controls.Add(this.Picture_ValidNewPassword);
            this.panelGradient1.Controls.Add(this.Picture_ValidCode);
            this.panelGradient1.Controls.Add(this.Picture_ValidAccount);
            this.panelGradient1.Controls.Add(this.Label_OKSignup);
            this.panelGradient1.Controls.Add(this.Label_1);
            this.panelGradient1.Controls.Add(this.Panel_ConfirmCode);
            this.panelGradient1.Controls.Add(this.Button_SendCode);
            this.panelGradient1.Controls.Add(this.Label_2);
            this.panelGradient1.Controls.Add(this.Panel_NewPassword);
            this.panelGradient1.Controls.Add(this.Label_ErrorLogin);
            this.panelGradient1.Controls.Add(this.Button_Close);
            this.panelGradient1.Controls.Add(this.Button_Login);
            this.panelGradient1.Controls.Add(this.Button_ChangePassword);
            this.panelGradient1.Controls.Add(this.Label_3);
            this.panelGradient1.Controls.Add(this.label2);
            this.panelGradient1.Controls.Add(this.Panel_Password);
            this.panelGradient1.Controls.Add(this.panel5);
            this.panelGradient1.Controls.Add(this.label1);
            this.panelGradient1.Controls.Add(this.pictureBox1);
            this.panelGradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGradient1.Location = new System.Drawing.Point(0, 0);
            this.panelGradient1.Name = "panelGradient1";
            this.panelGradient1.Size = new System.Drawing.Size(1379, 849);
            this.panelGradient1.TabIndex = 3;
            this.panelGradient1.TopColor = System.Drawing.Color.White;
            // 
            // Label_TextComfirm
            // 
            this.Label_TextComfirm.AutoSize = true;
            this.Label_TextComfirm.BackColor = System.Drawing.Color.Transparent;
            this.Label_TextComfirm.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TextComfirm.ForeColor = System.Drawing.Color.Green;
            this.Label_TextComfirm.Location = new System.Drawing.Point(56, 356);
            this.Label_TextComfirm.Name = "Label_TextComfirm";
            this.Label_TextComfirm.Size = new System.Drawing.Size(323, 27);
            this.Label_TextComfirm.TabIndex = 23;
            this.Label_TextComfirm.Text = "Mã xác minh được gửi về Email";
            this.Label_TextComfirm.Visible = false;
            // 
            // Picture_ValidNewPassword
            // 
            this.Picture_ValidNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.Picture_ValidNewPassword.Image = global::Grab.Images_GrabIcon.Success;
            this.Picture_ValidNewPassword.Location = new System.Drawing.Point(974, 607);
            this.Picture_ValidNewPassword.Name = "Picture_ValidNewPassword";
            this.Picture_ValidNewPassword.Size = new System.Drawing.Size(25, 25);
            this.Picture_ValidNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_ValidNewPassword.TabIndex = 22;
            this.Picture_ValidNewPassword.TabStop = false;
            this.Picture_ValidNewPassword.Visible = false;
            // 
            // Picture_ValidCode
            // 
            this.Picture_ValidCode.BackColor = System.Drawing.Color.Transparent;
            this.Picture_ValidCode.Image = global::Grab.Images_GrabIcon.Success;
            this.Picture_ValidCode.Location = new System.Drawing.Point(974, 371);
            this.Picture_ValidCode.Name = "Picture_ValidCode";
            this.Picture_ValidCode.Size = new System.Drawing.Size(25, 25);
            this.Picture_ValidCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_ValidCode.TabIndex = 21;
            this.Picture_ValidCode.TabStop = false;
            this.Picture_ValidCode.Visible = false;
            // 
            // Picture_ValidAccount
            // 
            this.Picture_ValidAccount.BackColor = System.Drawing.Color.Transparent;
            this.Picture_ValidAccount.Image = global::Grab.Images_GrabIcon.Success;
            this.Picture_ValidAccount.Location = new System.Drawing.Point(974, 261);
            this.Picture_ValidAccount.Name = "Picture_ValidAccount";
            this.Picture_ValidAccount.Size = new System.Drawing.Size(25, 25);
            this.Picture_ValidAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_ValidAccount.TabIndex = 20;
            this.Picture_ValidAccount.TabStop = false;
            // 
            // Label_OKSignup
            // 
            this.Label_OKSignup.AutoSize = true;
            this.Label_OKSignup.BackColor = System.Drawing.Color.Transparent;
            this.Label_OKSignup.Font = new System.Drawing.Font("Noto Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_OKSignup.ForeColor = System.Drawing.Color.Green;
            this.Label_OKSignup.Location = new System.Drawing.Point(662, 702);
            this.Label_OKSignup.Name = "Label_OKSignup";
            this.Label_OKSignup.Size = new System.Drawing.Size(306, 32);
            this.Label_OKSignup.TabIndex = 19;
            this.Label_OKSignup.Text = "Đổi mật khẩu thành công";
            this.Label_OKSignup.Visible = false;
            // 
            // Label_1
            // 
            this.Label_1.AutoSize = true;
            this.Label_1.BackColor = System.Drawing.Color.Transparent;
            this.Label_1.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_1.ForeColor = System.Drawing.Color.White;
            this.Label_1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label_1.Location = new System.Drawing.Point(391, 311);
            this.Label_1.Name = "Label_1";
            this.Label_1.Size = new System.Drawing.Size(120, 23);
            this.Label_1.TabIndex = 18;
            this.Label_1.Text = "Confirm Code";
            this.Label_1.Visible = false;
            // 
            // Panel_ConfirmCode
            // 
            this.Panel_ConfirmCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel_ConfirmCode.BackColor = System.Drawing.Color.White;
            this.Panel_ConfirmCode.Controls.Add(this.TextBox_ConfirmCode);
            this.Panel_ConfirmCode.Location = new System.Drawing.Point(395, 337);
            this.Panel_ConfirmCode.Name = "Panel_ConfirmCode";
            this.Panel_ConfirmCode.Size = new System.Drawing.Size(573, 59);
            this.Panel_ConfirmCode.TabIndex = 17;
            this.Panel_ConfirmCode.Visible = false;
            // 
            // TextBox_ConfirmCode
            // 
            this.TextBox_ConfirmCode.BackColor = System.Drawing.Color.White;
            this.TextBox_ConfirmCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_ConfirmCode.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_ConfirmCode.ForeColor = System.Drawing.Color.Silver;
            this.TextBox_ConfirmCode.Location = new System.Drawing.Point(14, 19);
            this.TextBox_ConfirmCode.Name = "TextBox_ConfirmCode";
            this.TextBox_ConfirmCode.Size = new System.Drawing.Size(542, 28);
            this.TextBox_ConfirmCode.TabIndex = 0;
            this.TextBox_ConfirmCode.Text = "Confirm Code ...";
            this.TextBox_ConfirmCode.TextChanged += new System.EventHandler(this.TextBox_ConfirmCode_TextChanged);
            this.TextBox_ConfirmCode.Enter += new System.EventHandler(this.TextBox_ConfirmCode_Enter);
            this.TextBox_ConfirmCode.Leave += new System.EventHandler(this.TextBox_ConfirmCode_Leave);
            // 
            // Button_SendCode
            // 
            this.Button_SendCode.BackColor = System.Drawing.Color.White;
            this.Button_SendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_SendCode.FlatAppearance.BorderSize = 0;
            this.Button_SendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SendCode.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.Button_SendCode.ForeColor = System.Drawing.Color.Green;
            this.Button_SendCode.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_SendCode.IconColor = System.Drawing.Color.Black;
            this.Button_SendCode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_SendCode.Location = new System.Drawing.Point(1027, 227);
            this.Button_SendCode.Name = "Button_SendCode";
            this.Button_SendCode.Size = new System.Drawing.Size(254, 59);
            this.Button_SendCode.TabIndex = 15;
            this.Button_SendCode.Text = "Send code";
            this.Button_SendCode.UseVisualStyleBackColor = false;
            this.Button_SendCode.Click += new System.EventHandler(this.Button_SendCode_Click);
            // 
            // Label_2
            // 
            this.Label_2.AutoSize = true;
            this.Label_2.BackColor = System.Drawing.Color.Transparent;
            this.Label_2.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_2.ForeColor = System.Drawing.Color.White;
            this.Label_2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label_2.Location = new System.Drawing.Point(391, 431);
            this.Label_2.Name = "Label_2";
            this.Label_2.Size = new System.Drawing.Size(120, 23);
            this.Label_2.TabIndex = 7;
            this.Label_2.Text = "Mật khẩu mới";
            this.Label_2.Visible = false;
            // 
            // Panel_NewPassword
            // 
            this.Panel_NewPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel_NewPassword.BackColor = System.Drawing.Color.White;
            this.Panel_NewPassword.Controls.Add(this.TextBox_NewPassword);
            this.Panel_NewPassword.Location = new System.Drawing.Point(395, 457);
            this.Panel_NewPassword.Name = "Panel_NewPassword";
            this.Panel_NewPassword.Size = new System.Drawing.Size(573, 59);
            this.Panel_NewPassword.TabIndex = 6;
            this.Panel_NewPassword.Visible = false;
            // 
            // TextBox_NewPassword
            // 
            this.TextBox_NewPassword.BackColor = System.Drawing.Color.White;
            this.TextBox_NewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_NewPassword.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_NewPassword.ForeColor = System.Drawing.Color.Silver;
            this.TextBox_NewPassword.Location = new System.Drawing.Point(14, 19);
            this.TextBox_NewPassword.Name = "TextBox_NewPassword";
            this.TextBox_NewPassword.Size = new System.Drawing.Size(542, 28);
            this.TextBox_NewPassword.TabIndex = 0;
            this.TextBox_NewPassword.Text = "Mật khẩu mới ...";
            this.TextBox_NewPassword.Enter += new System.EventHandler(this.TextBox_NewPassword_Enter);
            this.TextBox_NewPassword.Leave += new System.EventHandler(this.TextBox_NewPassword_Leave);
            // 
            // Label_ErrorLogin
            // 
            this.Label_ErrorLogin.AutoSize = true;
            this.Label_ErrorLogin.BackColor = System.Drawing.Color.Transparent;
            this.Label_ErrorLogin.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ErrorLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_ErrorLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label_ErrorLogin.Location = new System.Drawing.Point(595, 711);
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
            this.Button_Close.Location = new System.Drawing.Point(1334, 0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(45, 45);
            this.Button_Close.TabIndex = 9;
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            this.Button_Close.MouseEnter += new System.EventHandler(this.Button_Close_MouseEnter);
            this.Button_Close.MouseLeave += new System.EventHandler(this.Button_Close_MouseLeave);
            // 
            // Button_Login
            // 
            this.Button_Login.BackColor = System.Drawing.Color.White;
            this.Button_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Login.FlatAppearance.BorderSize = 0;
            this.Button_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Login.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.Button_Login.ForeColor = System.Drawing.Color.Green;
            this.Button_Login.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_Login.IconColor = System.Drawing.Color.Black;
            this.Button_Login.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Login.Location = new System.Drawing.Point(1027, 748);
            this.Button_Login.Name = "Button_Login";
            this.Button_Login.Size = new System.Drawing.Size(276, 59);
            this.Button_Login.TabIndex = 7;
            this.Button_Login.Text = "Đăng nhập";
            this.Button_Login.UseVisualStyleBackColor = false;
            // 
            // Button_ChangePassword
            // 
            this.Button_ChangePassword.BackColor = System.Drawing.Color.Green;
            this.Button_ChangePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ChangePassword.FlatAppearance.BorderSize = 0;
            this.Button_ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ChangePassword.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.Button_ChangePassword.ForeColor = System.Drawing.Color.White;
            this.Button_ChangePassword.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_ChangePassword.IconColor = System.Drawing.Color.Black;
            this.Button_ChangePassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_ChangePassword.Location = new System.Drawing.Point(395, 748);
            this.Button_ChangePassword.Name = "Button_ChangePassword";
            this.Button_ChangePassword.Size = new System.Drawing.Size(573, 59);
            this.Button_ChangePassword.TabIndex = 6;
            this.Button_ChangePassword.Text = "Đổi mật khẩu";
            this.Button_ChangePassword.UseVisualStyleBackColor = false;
            this.Button_ChangePassword.Click += new System.EventHandler(this.Button_ChangePassword_Click);
            // 
            // Label_3
            // 
            this.Label_3.AutoSize = true;
            this.Label_3.BackColor = System.Drawing.Color.Transparent;
            this.Label_3.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_3.ForeColor = System.Drawing.Color.White;
            this.Label_3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label_3.Location = new System.Drawing.Point(391, 547);
            this.Label_3.Name = "Label_3";
            this.Label_3.Size = new System.Drawing.Size(200, 23);
            this.Label_3.TabIndex = 5;
            this.Label_3.Text = "Xác nhận mật khẩu mới";
            this.Label_3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(391, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên đăng nhập";
            // 
            // Panel_Password
            // 
            this.Panel_Password.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel_Password.BackColor = System.Drawing.Color.White;
            this.Panel_Password.Controls.Add(this.TextBox_Password);
            this.Panel_Password.Location = new System.Drawing.Point(395, 573);
            this.Panel_Password.Name = "Panel_Password";
            this.Panel_Password.Size = new System.Drawing.Size(573, 59);
            this.Panel_Password.TabIndex = 3;
            this.Panel_Password.Visible = false;
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
            this.TextBox_Password.Text = "Xác nhận mật khẩu mới ...";
            this.TextBox_Password.TextChanged += new System.EventHandler(this.TextBox_Password_TextChanged);
            this.TextBox_Password.Enter += new System.EventHandler(this.TextBox_Password_Enter);
            this.TextBox_Password.Leave += new System.EventHandler(this.TextBox_Password_Leave);
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.TextBox_Account);
            this.panel5.Location = new System.Drawing.Point(395, 227);
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
            this.TextBox_Account.TextChanged += new System.EventHandler(this.TextBox_Account_TextChanged);
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
            this.label1.Size = new System.Drawing.Size(710, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "KHÔI PHỤC MẬT KHẨU";
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
            // Form_Forgot_Password
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1379, 849);
            this.Controls.Add(this.panelGradient1);
            this.Name = "Form_Forgot_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Forgot_Password";
            this.panelGradient1.ResumeLayout(false);
            this.panelGradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ValidNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ValidCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ValidAccount)).EndInit();
            this.Panel_ConfirmCode.ResumeLayout(false);
            this.Panel_ConfirmCode.PerformLayout();
            this.Panel_NewPassword.ResumeLayout(false);
            this.Panel_NewPassword.PerformLayout();
            this.Panel_Password.ResumeLayout(false);
            this.Panel_Password.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.PanelGradient panelGradient1;
        private System.Windows.Forms.PictureBox Picture_ValidAccount;
        private System.Windows.Forms.Label Label_OKSignup;
        private System.Windows.Forms.Label Label_1;
        private System.Windows.Forms.Panel Panel_ConfirmCode;
        private System.Windows.Forms.TextBox TextBox_ConfirmCode;
        private FontAwesome.Sharp.IconButton Button_SendCode;
        private System.Windows.Forms.Label Label_ErrorLogin;
        private FontAwesome.Sharp.IconButton Button_Close;
        private FontAwesome.Sharp.IconButton Button_Login;
        private FontAwesome.Sharp.IconButton Button_ChangePassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TextBox_Account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Picture_ValidNewPassword;
        private System.Windows.Forms.PictureBox Picture_ValidCode;
        private System.Windows.Forms.Label Label_2;
        private System.Windows.Forms.Panel Panel_NewPassword;
        private System.Windows.Forms.TextBox TextBox_NewPassword;
        private System.Windows.Forms.Label Label_3;
        private System.Windows.Forms.Panel Panel_Password;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Label Label_TextComfirm;
    }
}