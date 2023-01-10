namespace Grab.Screens
{
    partial class Form_Change_Password
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
            this.Picture_ValidNewPassword = new System.Windows.Forms.PictureBox();
            this.Picture_ValidAccount = new System.Windows.Forms.PictureBox();
            this.Label_OKSignup = new System.Windows.Forms.Label();
            this.Label_2 = new System.Windows.Forms.Label();
            this.Panel_NewPassword = new System.Windows.Forms.Panel();
            this.TextBox_NewPassword = new System.Windows.Forms.TextBox();
            this.Label_ErrorLogin = new System.Windows.Forms.Label();
            this.Button_ChangePassword = new FontAwesome.Sharp.IconButton();
            this.Label_3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel_Password = new System.Windows.Forms.Panel();
            this.TextBox_Password = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TextBox_OldPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelGradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ValidNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ValidAccount)).BeginInit();
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
            this.panelGradient1.Controls.Add(this.Picture_ValidNewPassword);
            this.panelGradient1.Controls.Add(this.Picture_ValidAccount);
            this.panelGradient1.Controls.Add(this.Label_OKSignup);
            this.panelGradient1.Controls.Add(this.Label_2);
            this.panelGradient1.Controls.Add(this.Panel_NewPassword);
            this.panelGradient1.Controls.Add(this.Label_ErrorLogin);
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
            this.panelGradient1.Size = new System.Drawing.Size(1613, 846);
            this.panelGradient1.TabIndex = 4;
            this.panelGradient1.TopColor = System.Drawing.Color.White;
            // 
            // Picture_ValidNewPassword
            // 
            this.Picture_ValidNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.Picture_ValidNewPassword.Image = global::Grab.Images_GrabIcon.Success;
            this.Picture_ValidNewPassword.Location = new System.Drawing.Point(1057, 488);
            this.Picture_ValidNewPassword.Name = "Picture_ValidNewPassword";
            this.Picture_ValidNewPassword.Size = new System.Drawing.Size(25, 25);
            this.Picture_ValidNewPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_ValidNewPassword.TabIndex = 22;
            this.Picture_ValidNewPassword.TabStop = false;
            this.Picture_ValidNewPassword.Visible = false;
            // 
            // Picture_ValidAccount
            // 
            this.Picture_ValidAccount.BackColor = System.Drawing.Color.Transparent;
            this.Picture_ValidAccount.Image = global::Grab.Images_GrabIcon.Success;
            this.Picture_ValidAccount.Location = new System.Drawing.Point(1057, 259);
            this.Picture_ValidAccount.Name = "Picture_ValidAccount";
            this.Picture_ValidAccount.Size = new System.Drawing.Size(25, 25);
            this.Picture_ValidAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_ValidAccount.TabIndex = 20;
            this.Picture_ValidAccount.TabStop = false;
            this.Picture_ValidAccount.Visible = false;
            // 
            // Label_OKSignup
            // 
            this.Label_OKSignup.AutoSize = true;
            this.Label_OKSignup.BackColor = System.Drawing.Color.Transparent;
            this.Label_OKSignup.Font = new System.Drawing.Font("Noto Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_OKSignup.ForeColor = System.Drawing.Color.Green;
            this.Label_OKSignup.Location = new System.Drawing.Point(745, 597);
            this.Label_OKSignup.Name = "Label_OKSignup";
            this.Label_OKSignup.Size = new System.Drawing.Size(306, 32);
            this.Label_OKSignup.TabIndex = 19;
            this.Label_OKSignup.Text = "Đổi mật khẩu thành công";
            this.Label_OKSignup.Visible = false;
            // 
            // Label_2
            // 
            this.Label_2.AutoSize = true;
            this.Label_2.BackColor = System.Drawing.Color.Transparent;
            this.Label_2.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_2.ForeColor = System.Drawing.Color.White;
            this.Label_2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label_2.Location = new System.Drawing.Point(474, 312);
            this.Label_2.Name = "Label_2";
            this.Label_2.Size = new System.Drawing.Size(120, 23);
            this.Label_2.TabIndex = 7;
            this.Label_2.Text = "Mật khẩu mới";
            // 
            // Panel_NewPassword
            // 
            this.Panel_NewPassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel_NewPassword.BackColor = System.Drawing.Color.White;
            this.Panel_NewPassword.Controls.Add(this.TextBox_NewPassword);
            this.Panel_NewPassword.Location = new System.Drawing.Point(478, 338);
            this.Panel_NewPassword.Name = "Panel_NewPassword";
            this.Panel_NewPassword.Size = new System.Drawing.Size(573, 59);
            this.Panel_NewPassword.TabIndex = 6;
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
            this.Label_ErrorLogin.Location = new System.Drawing.Point(678, 606);
            this.Label_ErrorLogin.Name = "Label_ErrorLogin";
            this.Label_ErrorLogin.Size = new System.Drawing.Size(373, 23);
            this.Label_ErrorLogin.TabIndex = 10;
            this.Label_ErrorLogin.Text = "Thông tin chưa chính xác, vui lòng kiểm tra lại";
            this.Label_ErrorLogin.Visible = false;
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
            this.Button_ChangePassword.Location = new System.Drawing.Point(478, 643);
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
            this.Label_3.Location = new System.Drawing.Point(474, 428);
            this.Label_3.Name = "Label_3";
            this.Label_3.Size = new System.Drawing.Size(200, 23);
            this.Label_3.TabIndex = 5;
            this.Label_3.Text = "Xác nhận mật khẩu mới";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(474, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu cũ";
            // 
            // Panel_Password
            // 
            this.Panel_Password.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel_Password.BackColor = System.Drawing.Color.White;
            this.Panel_Password.Controls.Add(this.TextBox_Password);
            this.Panel_Password.Location = new System.Drawing.Point(478, 454);
            this.Panel_Password.Name = "Panel_Password";
            this.Panel_Password.Size = new System.Drawing.Size(573, 59);
            this.Panel_Password.TabIndex = 3;
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
            this.panel5.Controls.Add(this.TextBox_OldPassword);
            this.panel5.Location = new System.Drawing.Point(478, 225);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(573, 59);
            this.panel5.TabIndex = 2;
            // 
            // TextBox_OldPassword
            // 
            this.TextBox_OldPassword.BackColor = System.Drawing.Color.White;
            this.TextBox_OldPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_OldPassword.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_OldPassword.ForeColor = System.Drawing.Color.Silver;
            this.TextBox_OldPassword.Location = new System.Drawing.Point(14, 20);
            this.TextBox_OldPassword.Name = "TextBox_OldPassword";
            this.TextBox_OldPassword.Size = new System.Drawing.Size(542, 28);
            this.TextBox_OldPassword.TabIndex = 0;
            this.TextBox_OldPassword.Text = "Mật khẩu cũ ...";
            this.TextBox_OldPassword.TextChanged += new System.EventHandler(this.TextBox_OldPassword_TextChanged);
            this.TextBox_OldPassword.Enter += new System.EventHandler(this.TextBox_OldPassword_Enter);
            this.TextBox_OldPassword.Leave += new System.EventHandler(this.TextBox_OldPassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(222, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 82);
            this.label1.TabIndex = 1;
            this.label1.Text = "THAY ĐỔI MẬT KHẨU";
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
            // Form_Change_Password
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1613, 846);
            this.Controls.Add(this.panelGradient1);
            this.Name = "Form_Change_Password";
            this.Text = "Form_Change_Password";
            this.panelGradient1.ResumeLayout(false);
            this.panelGradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ValidNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ValidAccount)).EndInit();
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
        private System.Windows.Forms.PictureBox Picture_ValidNewPassword;
        private System.Windows.Forms.PictureBox Picture_ValidAccount;
        private System.Windows.Forms.Label Label_OKSignup;
        private System.Windows.Forms.Label Label_2;
        private System.Windows.Forms.Panel Panel_NewPassword;
        private System.Windows.Forms.TextBox TextBox_NewPassword;
        private System.Windows.Forms.Label Label_ErrorLogin;
        private FontAwesome.Sharp.IconButton Button_ChangePassword;
        private System.Windows.Forms.Label Label_3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Panel_Password;
        private System.Windows.Forms.TextBox TextBox_Password;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TextBox_OldPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}