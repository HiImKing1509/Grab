namespace Grab.UserControls
{
    partial class Control_Driver
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
            this.Label_ServiceName = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_Age = new System.Windows.Forms.Label();
            this.Label_Service_Number = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_ServiceName
            // 
            this.Label_ServiceName.AutoSize = true;
            this.Label_ServiceName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_ServiceName.Font = new System.Drawing.Font("Montserrat", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ServiceName.Location = new System.Drawing.Point(145, 73);
            this.Label_ServiceName.MaximumSize = new System.Drawing.Size(300, 0);
            this.Label_ServiceName.Name = "Label_ServiceName";
            this.Label_ServiceName.Size = new System.Drawing.Size(150, 25);
            this.Label_ServiceName.TabIndex = 6;
            this.Label_ServiceName.Text = "Grabike Hà Nội";
            this.Label_ServiceName.MouseEnter += new System.EventHandler(this.Control_Driver_MouseEnter);
            this.Label_ServiceName.MouseLeave += new System.EventHandler(this.Control_Driver_MouseLeave);
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Name.Font = new System.Drawing.Font("Noto Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.Location = new System.Drawing.Point(143, 26);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(258, 32);
            this.Label_Name.TabIndex = 5;
            this.Label_Name.Text = "Đặng Dân Hải Dương";
            this.Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label_Name.MouseEnter += new System.EventHandler(this.Control_Driver_MouseEnter);
            this.Label_Name.MouseLeave += new System.EventHandler(this.Control_Driver_MouseLeave);
            // 
            // Label_Age
            // 
            this.Label_Age.AutoSize = true;
            this.Label_Age.BackColor = System.Drawing.Color.Transparent;
            this.Label_Age.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Age.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Age.ForeColor = System.Drawing.Color.Green;
            this.Label_Age.Location = new System.Drawing.Point(390, 125);
            this.Label_Age.MaximumSize = new System.Drawing.Size(300, 0);
            this.Label_Age.Name = "Label_Age";
            this.Label_Age.Size = new System.Drawing.Size(80, 27);
            this.Label_Age.TabIndex = 7;
            this.Label_Age.Text = "30 tuổi";
            this.Label_Age.MouseEnter += new System.EventHandler(this.Control_Driver_MouseEnter);
            this.Label_Age.MouseLeave += new System.EventHandler(this.Control_Driver_MouseLeave);
            // 
            // Label_Service_Number
            // 
            this.Label_Service_Number.AutoSize = true;
            this.Label_Service_Number.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Service_Number.Font = new System.Drawing.Font("Noto Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Service_Number.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Service_Number.Location = new System.Drawing.Point(147, 125);
            this.Label_Service_Number.Name = "Label_Service_Number";
            this.Label_Service_Number.Size = new System.Drawing.Size(148, 32);
            this.Label_Service_Number.TabIndex = 8;
            this.Label_Service_Number.Text = "XX-XX XXXX";
            this.Label_Service_Number.MouseEnter += new System.EventHandler(this.Control_Driver_MouseEnter);
            this.Label_Service_Number.MouseLeave += new System.EventHandler(this.Control_Driver_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Grab.Images_GrabUser.Driver;
            this.pictureBox1.Location = new System.Drawing.Point(31, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.Control_Driver_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.Control_Driver_MouseLeave);
            // 
            // Control_Driver
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Label_Service_Number);
            this.Controls.Add(this.Label_Age);
            this.Controls.Add(this.Label_ServiceName);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Control_Driver";
            this.Size = new System.Drawing.Size(522, 183);
            this.Click += new System.EventHandler(this.Control_Driver_Click);
            this.MouseEnter += new System.EventHandler(this.Control_Driver_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Control_Driver_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_ServiceName;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_Age;
        private System.Windows.Forms.Label Label_Service_Number;
    }
}
