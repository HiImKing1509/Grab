namespace Grab.UserControls
{
    partial class Control_Item_Service
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Panel_Infor = new System.Windows.Forms.Panel();
            this.Label_Description = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.PictureBox_Image = new System.Windows.Forms.PictureBox();
            this.Panel_Infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Infor
            // 
            this.Panel_Infor.Controls.Add(this.Label_Description);
            this.Panel_Infor.Controls.Add(this.Label_Name);
            this.Panel_Infor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_Infor.Dock = System.Windows.Forms.DockStyle.Right;
            this.Panel_Infor.Location = new System.Drawing.Point(417, 0);
            this.Panel_Infor.Name = "Panel_Infor";
            this.Panel_Infor.Size = new System.Drawing.Size(366, 256);
            this.Panel_Infor.TabIndex = 4;
            this.Panel_Infor.Click += new System.EventHandler(this.PictureBox_Image_Click);
            this.Panel_Infor.MouseEnter += new System.EventHandler(this.PictureBox_Image_MouseEnter);
            this.Panel_Infor.MouseLeave += new System.EventHandler(this.PictureBox_Image_MouseLeave);
            // 
            // Label_Description
            // 
            this.Label_Description.AutoSize = true;
            this.Label_Description.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Description.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description.Location = new System.Drawing.Point(30, 91);
            this.Label_Description.MaximumSize = new System.Drawing.Size(300, 0);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.Size = new System.Drawing.Size(299, 50);
            this.Label_Description.TabIndex = 4;
            this.Label_Description.Text = "Thuê xe cùng tài xế để phục vụ nhu cầu đi lại riêng của bạn";
            this.Label_Description.Click += new System.EventHandler(this.PictureBox_Image_Click);
            this.Label_Description.MouseEnter += new System.EventHandler(this.PictureBox_Image_MouseEnter);
            this.Label_Description.MouseLeave += new System.EventHandler(this.PictureBox_Image_MouseLeave);
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Name.Font = new System.Drawing.Font("Montserrat", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.Location = new System.Drawing.Point(23, 17);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(165, 65);
            this.Label_Name.TabIndex = 3;
            this.Label_Name.Text = "label1";
            this.Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_Name.Click += new System.EventHandler(this.PictureBox_Image_Click);
            this.Label_Name.MouseEnter += new System.EventHandler(this.PictureBox_Image_MouseEnter);
            this.Label_Name.MouseLeave += new System.EventHandler(this.PictureBox_Image_MouseLeave);
            // 
            // PictureBox_Image
            // 
            this.PictureBox_Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_Image.Location = new System.Drawing.Point(41, 17);
            this.PictureBox_Image.Name = "PictureBox_Image";
            this.PictureBox_Image.Size = new System.Drawing.Size(333, 220);
            this.PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Image.TabIndex = 5;
            this.PictureBox_Image.TabStop = false;
            this.PictureBox_Image.Click += new System.EventHandler(this.PictureBox_Image_Click);
            this.PictureBox_Image.MouseEnter += new System.EventHandler(this.PictureBox_Image_MouseEnter);
            this.PictureBox_Image.MouseLeave += new System.EventHandler(this.PictureBox_Image_MouseLeave);
            // 
            // Control_Item_Service
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PictureBox_Image);
            this.Controls.Add(this.Panel_Infor);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Control_Item_Service";
            this.Size = new System.Drawing.Size(783, 256);
            this.Click += new System.EventHandler(this.PictureBox_Image_Click);
            this.MouseEnter += new System.EventHandler(this.PictureBox_Image_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PictureBox_Image_MouseLeave);
            this.Panel_Infor.ResumeLayout(false);
            this.Panel_Infor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Infor;
        private System.Windows.Forms.Label Label_Description;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.PictureBox PictureBox_Image;
    }
}
