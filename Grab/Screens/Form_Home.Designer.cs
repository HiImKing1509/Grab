namespace Grab.Screens
{
    partial class Form_Home
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
            this.components = new System.ComponentModel.Container();
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.Panel_Image = new System.Windows.Forms.Panel();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TextBox_LocationSearch = new System.Windows.Forms.TextBox();
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.Button_UserInformation = new FontAwesome.Sharp.IconButton();
            this.Button_Minimize = new FontAwesome.Sharp.IconButton();
            this.Button_Maximum = new FontAwesome.Sharp.IconButton();
            this.Button_Close = new FontAwesome.Sharp.IconButton();
            this.Button_Search = new FontAwesome.Sharp.IconButton();
            this.Button_Messages = new FontAwesome.Sharp.IconButton();
            this.Button_Payment = new FontAwesome.Sharp.IconButton();
            this.Button_Activity = new FontAwesome.Sharp.IconButton();
            this.Button_Home = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.circlePictureBox1 = new Grab.CustomControls.CirclePictureBox();
            this.DropdownMenu_LoadUserInformation = new Grab.CustomControls.CustomDropdownMenu(this.components);
            this.ToolStripMenuItem_Profile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ChanePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_LogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_Menu.SuspendLayout();
            this.Panel_Image.SuspendLayout();
            this.Panel_Header.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox1)).BeginInit();
            this.DropdownMenu_LoadUserInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.Controls.Add(this.Button_Messages);
            this.Panel_Menu.Controls.Add(this.Button_Payment);
            this.Panel_Menu.Controls.Add(this.Button_Activity);
            this.Panel_Menu.Controls.Add(this.Button_Home);
            this.Panel_Menu.Controls.Add(this.Panel_Image);
            this.Panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(312, 1033);
            this.Panel_Menu.TabIndex = 0;
            // 
            // Panel_Image
            // 
            this.Panel_Image.Controls.Add(this.pictureBox1);
            this.Panel_Image.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Image.Location = new System.Drawing.Point(0, 0);
            this.Panel_Image.Name = "Panel_Image";
            this.Panel_Image.Size = new System.Drawing.Size(312, 140);
            this.Panel_Image.TabIndex = 0;
            // 
            // Panel_Header
            // 
            this.Panel_Header.Controls.Add(this.circlePictureBox1);
            this.Panel_Header.Controls.Add(this.Button_UserInformation);
            this.Panel_Header.Controls.Add(this.Button_Minimize);
            this.Panel_Header.Controls.Add(this.Button_Maximum);
            this.Panel_Header.Controls.Add(this.Button_Close);
            this.Panel_Header.Controls.Add(this.panel5);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(312, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(1589, 140);
            this.Panel_Header.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.Button_Search);
            this.panel5.Controls.Add(this.TextBox_LocationSearch);
            this.panel5.Location = new System.Drawing.Point(62, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(958, 54);
            this.panel5.TabIndex = 1;
            // 
            // TextBox_LocationSearch
            // 
            this.TextBox_LocationSearch.BackColor = System.Drawing.Color.White;
            this.TextBox_LocationSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_LocationSearch.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.TextBox_LocationSearch.ForeColor = System.Drawing.Color.Gray;
            this.TextBox_LocationSearch.Location = new System.Drawing.Point(14, 16);
            this.TextBox_LocationSearch.Name = "TextBox_LocationSearch";
            this.TextBox_LocationSearch.Size = new System.Drawing.Size(850, 25);
            this.TextBox_LocationSearch.TabIndex = 0;
            this.TextBox_LocationSearch.Text = "Tìm kiếm dịch vụ ...";
            this.TextBox_LocationSearch.TextChanged += new System.EventHandler(this.TextBox_LocationSearch_TextChanged);
            this.TextBox_LocationSearch.Enter += new System.EventHandler(this.TextBox_LocationSearch_Enter);
            this.TextBox_LocationSearch.Leave += new System.EventHandler(this.TextBox_LocationSearch_Leave);
            // 
            // Panel_Body
            // 
            this.Panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Body.Location = new System.Drawing.Point(312, 140);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(1589, 893);
            this.Panel_Body.TabIndex = 2;
            // 
            // Button_UserInformation
            // 
            this.Button_UserInformation.BackColor = System.Drawing.Color.Transparent;
            this.Button_UserInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_UserInformation.FlatAppearance.BorderSize = 0;
            this.Button_UserInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_UserInformation.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_UserInformation.ForeColor = System.Drawing.Color.White;
            this.Button_UserInformation.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_UserInformation.IconColor = System.Drawing.Color.Black;
            this.Button_UserInformation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_UserInformation.Location = new System.Drawing.Point(1290, 67);
            this.Button_UserInformation.Name = "Button_UserInformation";
            this.Button_UserInformation.Size = new System.Drawing.Size(287, 54);
            this.Button_UserInformation.TabIndex = 7;
            this.Button_UserInformation.Text = "Huỳnh Viết Tuấn Kiệt";
            this.Button_UserInformation.UseVisualStyleBackColor = false;
            this.Button_UserInformation.Click += new System.EventHandler(this.Button_UserInformation_Click);
            this.Button_UserInformation.MouseEnter += new System.EventHandler(this.Button_UserInformation_MouseEnter);
            this.Button_UserInformation.MouseLeave += new System.EventHandler(this.Button_UserInformation_MouseLeave);
            // 
            // Button_Minimize
            // 
            this.Button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.Button_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Minimize.FlatAppearance.BorderSize = 0;
            this.Button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Minimize.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            this.Button_Minimize.IconColor = System.Drawing.Color.White;
            this.Button_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Minimize.IconSize = 24;
            this.Button_Minimize.Location = new System.Drawing.Point(1452, 0);
            this.Button_Minimize.Name = "Button_Minimize";
            this.Button_Minimize.Size = new System.Drawing.Size(45, 45);
            this.Button_Minimize.TabIndex = 4;
            this.Button_Minimize.UseVisualStyleBackColor = false;
            this.Button_Minimize.Click += new System.EventHandler(this.Button_Minimize_Click);
            this.Button_Minimize.MouseEnter += new System.EventHandler(this.Button_Minimize_MouseEnter);
            this.Button_Minimize.MouseLeave += new System.EventHandler(this.Button_Minimize_MouseLeave);
            // 
            // Button_Maximum
            // 
            this.Button_Maximum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Maximum.BackColor = System.Drawing.Color.Transparent;
            this.Button_Maximum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Maximum.FlatAppearance.BorderSize = 0;
            this.Button_Maximum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Maximum.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.Button_Maximum.IconColor = System.Drawing.Color.White;
            this.Button_Maximum.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Maximum.IconSize = 24;
            this.Button_Maximum.Location = new System.Drawing.Point(1498, 0);
            this.Button_Maximum.Name = "Button_Maximum";
            this.Button_Maximum.Size = new System.Drawing.Size(45, 45);
            this.Button_Maximum.TabIndex = 3;
            this.Button_Maximum.UseVisualStyleBackColor = false;
            this.Button_Maximum.Click += new System.EventHandler(this.Button_Maximum_Click);
            this.Button_Maximum.MouseEnter += new System.EventHandler(this.Button_Maximum_MouseEnter);
            this.Button_Maximum.MouseLeave += new System.EventHandler(this.Button_Maximum_MouseLeave);
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
            this.Button_Close.Location = new System.Drawing.Point(1544, 0);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(45, 45);
            this.Button_Close.TabIndex = 2;
            this.Button_Close.UseVisualStyleBackColor = false;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            this.Button_Close.MouseEnter += new System.EventHandler(this.Button_Close_MouseEnter);
            this.Button_Close.MouseLeave += new System.EventHandler(this.Button_Close_MouseLeave);
            // 
            // Button_Search
            // 
            this.Button_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Search.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_Search.FlatAppearance.BorderSize = 0;
            this.Button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.Button_Search.IconColor = System.Drawing.Color.Black;
            this.Button_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Search.IconSize = 28;
            this.Button_Search.Location = new System.Drawing.Point(890, 0);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(68, 54);
            this.Button_Search.TabIndex = 0;
            this.Button_Search.UseVisualStyleBackColor = true;
            this.Button_Search.MouseEnter += new System.EventHandler(this.Button_Search_MouseEnter);
            this.Button_Search.MouseLeave += new System.EventHandler(this.Button_Search_MouseLeave);
            // 
            // Button_Messages
            // 
            this.Button_Messages.BackColor = System.Drawing.Color.Transparent;
            this.Button_Messages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Messages.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Messages.FlatAppearance.BorderSize = 0;
            this.Button_Messages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Messages.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Messages.ForeColor = System.Drawing.Color.White;
            this.Button_Messages.IconChar = FontAwesome.Sharp.IconChar.Message;
            this.Button_Messages.IconColor = System.Drawing.Color.White;
            this.Button_Messages.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Messages.IconSize = 28;
            this.Button_Messages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Messages.Location = new System.Drawing.Point(0, 326);
            this.Button_Messages.Name = "Button_Messages";
            this.Button_Messages.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_Messages.Size = new System.Drawing.Size(312, 62);
            this.Button_Messages.TabIndex = 7;
            this.Button_Messages.Text = "Đánh giá";
            this.Button_Messages.UseVisualStyleBackColor = false;
            this.Button_Messages.Click += new System.EventHandler(this.Button_Messages_Click);
            // 
            // Button_Payment
            // 
            this.Button_Payment.BackColor = System.Drawing.Color.Transparent;
            this.Button_Payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Payment.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Payment.FlatAppearance.BorderSize = 0;
            this.Button_Payment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Payment.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Payment.ForeColor = System.Drawing.Color.White;
            this.Button_Payment.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.Button_Payment.IconColor = System.Drawing.Color.White;
            this.Button_Payment.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Payment.IconSize = 28;
            this.Button_Payment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Payment.Location = new System.Drawing.Point(0, 264);
            this.Button_Payment.Name = "Button_Payment";
            this.Button_Payment.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_Payment.Size = new System.Drawing.Size(312, 62);
            this.Button_Payment.TabIndex = 6;
            this.Button_Payment.Text = "Thuê";
            this.Button_Payment.UseVisualStyleBackColor = false;
            this.Button_Payment.Click += new System.EventHandler(this.Button_Payment_Click);
            // 
            // Button_Activity
            // 
            this.Button_Activity.BackColor = System.Drawing.Color.Transparent;
            this.Button_Activity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Activity.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Activity.FlatAppearance.BorderSize = 0;
            this.Button_Activity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Activity.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Activity.ForeColor = System.Drawing.Color.White;
            this.Button_Activity.IconChar = FontAwesome.Sharp.IconChar.ListSquares;
            this.Button_Activity.IconColor = System.Drawing.Color.White;
            this.Button_Activity.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Activity.IconSize = 28;
            this.Button_Activity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Activity.Location = new System.Drawing.Point(0, 202);
            this.Button_Activity.Name = "Button_Activity";
            this.Button_Activity.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_Activity.Size = new System.Drawing.Size(312, 62);
            this.Button_Activity.TabIndex = 5;
            this.Button_Activity.Text = "Hoạt động";
            this.Button_Activity.UseVisualStyleBackColor = false;
            this.Button_Activity.Click += new System.EventHandler(this.Button_Activity_Click);
            // 
            // Button_Home
            // 
            this.Button_Home.BackColor = System.Drawing.Color.Transparent;
            this.Button_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Home.FlatAppearance.BorderSize = 0;
            this.Button_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Home.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Home.ForeColor = System.Drawing.Color.White;
            this.Button_Home.IconChar = FontAwesome.Sharp.IconChar.Compass;
            this.Button_Home.IconColor = System.Drawing.Color.White;
            this.Button_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Home.IconSize = 28;
            this.Button_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Home.Location = new System.Drawing.Point(0, 140);
            this.Button_Home.Name = "Button_Home";
            this.Button_Home.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_Home.Size = new System.Drawing.Size(312, 62);
            this.Button_Home.TabIndex = 4;
            this.Button_Home.Text = "Trang chủ";
            this.Button_Home.UseVisualStyleBackColor = false;
            this.Button_Home.Click += new System.EventHandler(this.Button_Home_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Grab.Images_GrabLogo.LG2_06;
            this.pictureBox1.Location = new System.Drawing.Point(59, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // circlePictureBox1
            // 
            this.circlePictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circlePictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.circlePictureBox1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.circlePictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.circlePictureBox1.BorderSize = 2;
            this.circlePictureBox1.GradientAngle = 50F;
            this.circlePictureBox1.Image = global::Grab.Images_GrabUser.Driver;
            this.circlePictureBox1.Location = new System.Drawing.Point(1225, 67);
            this.circlePictureBox1.Name = "circlePictureBox1";
            this.circlePictureBox1.Size = new System.Drawing.Size(59, 59);
            this.circlePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circlePictureBox1.TabIndex = 8;
            this.circlePictureBox1.TabStop = false;
            // 
            // DropdownMenu_LoadUserInformation
            // 
            this.DropdownMenu_LoadUserInformation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.DropdownMenu_LoadUserInformation.IsMainMenu = false;
            this.DropdownMenu_LoadUserInformation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Profile,
            this.ToolStripMenuItem_ChanePassword,
            this.ToolStripMenuItem_LogOut});
            this.DropdownMenu_LoadUserInformation.MenuItemHeight = 25;
            this.DropdownMenu_LoadUserInformation.MenuItemTextColor = System.Drawing.Color.Empty;
            this.DropdownMenu_LoadUserInformation.Name = "DropdownMenu_LoadUserInformation";
            this.DropdownMenu_LoadUserInformation.PrimaryColor = System.Drawing.Color.Empty;
            this.DropdownMenu_LoadUserInformation.Size = new System.Drawing.Size(207, 140);
            // 
            // ToolStripMenuItem_Profile
            // 
            this.ToolStripMenuItem_Profile.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem_Profile.Margin = new System.Windows.Forms.Padding(0, 10, 0, 5);
            this.ToolStripMenuItem_Profile.Name = "ToolStripMenuItem_Profile";
            this.ToolStripMenuItem_Profile.Size = new System.Drawing.Size(206, 32);
            this.ToolStripMenuItem_Profile.Text = "Profile";
            this.ToolStripMenuItem_Profile.Click += new System.EventHandler(this.ToolStripMenuItem_Profile_Click);
            // 
            // ToolStripMenuItem_ChanePassword
            // 
            this.ToolStripMenuItem_ChanePassword.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem_ChanePassword.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.ToolStripMenuItem_ChanePassword.Name = "ToolStripMenuItem_ChanePassword";
            this.ToolStripMenuItem_ChanePassword.Size = new System.Drawing.Size(206, 32);
            this.ToolStripMenuItem_ChanePassword.Text = "Đổi mật khẩu";
            this.ToolStripMenuItem_ChanePassword.Click += new System.EventHandler(this.ToolStripMenuItem_ChanePassword_Click);
            // 
            // ToolStripMenuItem_LogOut
            // 
            this.ToolStripMenuItem_LogOut.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItem_LogOut.Margin = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.ToolStripMenuItem_LogOut.Name = "ToolStripMenuItem_LogOut";
            this.ToolStripMenuItem_LogOut.Size = new System.Drawing.Size(206, 32);
            this.ToolStripMenuItem_LogOut.Text = "Log out";
            this.ToolStripMenuItem_LogOut.Click += new System.EventHandler(this.ToolStripMenuItem_LogOut_Click);
            // 
            // Form_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1901, 1033);
            this.Controls.Add(this.Panel_Body);
            this.Controls.Add(this.Panel_Header);
            this.Controls.Add(this.Panel_Menu);
            this.Name = "Form_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_Home_Load);
            this.Panel_Menu.ResumeLayout(false);
            this.Panel_Image.ResumeLayout(false);
            this.Panel_Header.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circlePictureBox1)).EndInit();
            this.DropdownMenu_LoadUserInformation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Panel Panel_Image;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton Button_Messages;
        private FontAwesome.Sharp.IconButton Button_Payment;
        private FontAwesome.Sharp.IconButton Button_Activity;
        private FontAwesome.Sharp.IconButton Button_Home;
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton Button_Search;
        private System.Windows.Forms.TextBox TextBox_LocationSearch;
        private System.Windows.Forms.Panel Panel_Body;
        private FontAwesome.Sharp.IconButton Button_Minimize;
        private FontAwesome.Sharp.IconButton Button_Maximum;
        private FontAwesome.Sharp.IconButton Button_Close;
        private CustomControls.CirclePictureBox circlePictureBox1;
        private FontAwesome.Sharp.IconButton Button_UserInformation;
        private CustomControls.CustomDropdownMenu DropdownMenu_LoadUserInformation;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Profile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ChanePassword;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_LogOut;
    }
}