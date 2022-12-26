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
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.Button_About = new FontAwesome.Sharp.IconButton();
            this.Button_Account = new FontAwesome.Sharp.IconButton();
            this.Button_Messages = new FontAwesome.Sharp.IconButton();
            this.Button_Payment = new FontAwesome.Sharp.IconButton();
            this.Button_Activity = new FontAwesome.Sharp.IconButton();
            this.Button_Home = new FontAwesome.Sharp.IconButton();
            this.Panel_Image = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Header = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Button_MovieSearch = new FontAwesome.Sharp.IconButton();
            this.TextBox_MovieSearch = new System.Windows.Forms.TextBox();
            this.Panel_Body = new System.Windows.Forms.Panel();
            this.Panel_Menu.SuspendLayout();
            this.Panel_Image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Header.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.Controls.Add(this.Button_About);
            this.Panel_Menu.Controls.Add(this.Button_Account);
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
            // Button_About
            // 
            this.Button_About.BackColor = System.Drawing.Color.Transparent;
            this.Button_About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_About.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button_About.FlatAppearance.BorderSize = 0;
            this.Button_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_About.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_About.ForeColor = System.Drawing.Color.White;
            this.Button_About.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.Button_About.IconColor = System.Drawing.Color.White;
            this.Button_About.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_About.IconSize = 28;
            this.Button_About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_About.Location = new System.Drawing.Point(0, 971);
            this.Button_About.Name = "Button_About";
            this.Button_About.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_About.Size = new System.Drawing.Size(312, 62);
            this.Button_About.TabIndex = 9;
            this.Button_About.Text = "About me";
            this.Button_About.UseVisualStyleBackColor = false;
            this.Button_About.Click += new System.EventHandler(this.Button_About_Click);
            // 
            // Button_Account
            // 
            this.Button_Account.BackColor = System.Drawing.Color.Transparent;
            this.Button_Account.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Account.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Account.FlatAppearance.BorderSize = 0;
            this.Button_Account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Account.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Account.ForeColor = System.Drawing.Color.White;
            this.Button_Account.IconChar = FontAwesome.Sharp.IconChar.User;
            this.Button_Account.IconColor = System.Drawing.Color.White;
            this.Button_Account.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Account.IconSize = 28;
            this.Button_Account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Account.Location = new System.Drawing.Point(0, 440);
            this.Button_Account.Name = "Button_Account";
            this.Button_Account.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_Account.Size = new System.Drawing.Size(312, 62);
            this.Button_Account.TabIndex = 8;
            this.Button_Account.Text = "Account";
            this.Button_Account.UseVisualStyleBackColor = false;
            this.Button_Account.Click += new System.EventHandler(this.Button_Account_Click);
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
            this.Button_Messages.Location = new System.Drawing.Point(0, 378);
            this.Button_Messages.Name = "Button_Messages";
            this.Button_Messages.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_Messages.Size = new System.Drawing.Size(312, 62);
            this.Button_Messages.TabIndex = 7;
            this.Button_Messages.Text = "Messages";
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
            this.Button_Payment.Location = new System.Drawing.Point(0, 316);
            this.Button_Payment.Name = "Button_Payment";
            this.Button_Payment.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_Payment.Size = new System.Drawing.Size(312, 62);
            this.Button_Payment.TabIndex = 6;
            this.Button_Payment.Text = "Payment";
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
            this.Button_Activity.Location = new System.Drawing.Point(0, 254);
            this.Button_Activity.Name = "Button_Activity";
            this.Button_Activity.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_Activity.Size = new System.Drawing.Size(312, 62);
            this.Button_Activity.TabIndex = 5;
            this.Button_Activity.Text = "Activity";
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
            this.Button_Home.Location = new System.Drawing.Point(0, 192);
            this.Button_Home.Name = "Button_Home";
            this.Button_Home.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Button_Home.Size = new System.Drawing.Size(312, 62);
            this.Button_Home.TabIndex = 4;
            this.Button_Home.Text = "Home";
            this.Button_Home.UseVisualStyleBackColor = false;
            this.Button_Home.Click += new System.EventHandler(this.Button_Home_Click);
            // 
            // Panel_Image
            // 
            this.Panel_Image.Controls.Add(this.pictureBox1);
            this.Panel_Image.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Image.Location = new System.Drawing.Point(0, 0);
            this.Panel_Image.Name = "Panel_Image";
            this.Panel_Image.Size = new System.Drawing.Size(312, 192);
            this.Panel_Image.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(46, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 105);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Panel_Header
            // 
            this.Panel_Header.Controls.Add(this.panel5);
            this.Panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Header.Location = new System.Drawing.Point(312, 0);
            this.Panel_Header.Name = "Panel_Header";
            this.Panel_Header.Size = new System.Drawing.Size(1589, 192);
            this.Panel_Header.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.Button_MovieSearch);
            this.panel5.Controls.Add(this.TextBox_MovieSearch);
            this.panel5.Location = new System.Drawing.Point(62, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(958, 54);
            this.panel5.TabIndex = 1;
            // 
            // Button_MovieSearch
            // 
            this.Button_MovieSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_MovieSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_MovieSearch.FlatAppearance.BorderSize = 0;
            this.Button_MovieSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_MovieSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.Button_MovieSearch.IconColor = System.Drawing.Color.Black;
            this.Button_MovieSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_MovieSearch.IconSize = 28;
            this.Button_MovieSearch.Location = new System.Drawing.Point(890, 0);
            this.Button_MovieSearch.Name = "Button_MovieSearch";
            this.Button_MovieSearch.Size = new System.Drawing.Size(68, 54);
            this.Button_MovieSearch.TabIndex = 0;
            this.Button_MovieSearch.UseVisualStyleBackColor = true;
            // 
            // TextBox_MovieSearch
            // 
            this.TextBox_MovieSearch.BackColor = System.Drawing.Color.White;
            this.TextBox_MovieSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_MovieSearch.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
            this.TextBox_MovieSearch.ForeColor = System.Drawing.Color.Gray;
            this.TextBox_MovieSearch.Location = new System.Drawing.Point(14, 16);
            this.TextBox_MovieSearch.Name = "TextBox_MovieSearch";
            this.TextBox_MovieSearch.Size = new System.Drawing.Size(850, 25);
            this.TextBox_MovieSearch.TabIndex = 0;
            this.TextBox_MovieSearch.Text = "Location ...";
            // 
            // Panel_Body
            // 
            this.Panel_Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Body.Location = new System.Drawing.Point(312, 192);
            this.Panel_Body.Name = "Panel_Body";
            this.Panel_Body.Size = new System.Drawing.Size(1589, 841);
            this.Panel_Body.TabIndex = 2;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Header.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Panel Panel_Image;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton Button_About;
        private FontAwesome.Sharp.IconButton Button_Account;
        private FontAwesome.Sharp.IconButton Button_Messages;
        private FontAwesome.Sharp.IconButton Button_Payment;
        private FontAwesome.Sharp.IconButton Button_Activity;
        private FontAwesome.Sharp.IconButton Button_Home;
        private System.Windows.Forms.Panel Panel_Header;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton Button_MovieSearch;
        private System.Windows.Forms.TextBox TextBox_MovieSearch;
        private System.Windows.Forms.Panel Panel_Body;
    }
}