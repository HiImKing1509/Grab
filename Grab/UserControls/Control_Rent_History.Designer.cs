namespace Grab.UserControls
{
    partial class Control_Rent_History
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
            this.Label_Time = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.PictureBox_Image = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Label_TimeRent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Time
            // 
            this.Label_Time.AutoSize = true;
            this.Label_Time.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Time.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Time.ForeColor = System.Drawing.Color.DimGray;
            this.Label_Time.Location = new System.Drawing.Point(547, 85);
            this.Label_Time.Name = "Label_Time";
            this.Label_Time.Size = new System.Drawing.Size(191, 23);
            this.Label_Time.TabIndex = 12;
            this.Label_Time.Text = "12-18-2022 15:45:21 PM";
            this.Label_Time.MouseEnter += new System.EventHandler(this.Control_Rent_History_MouseEnter);
            this.Label_Time.MouseLeave += new System.EventHandler(this.Control_Rent_History_MouseLeave);
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Name.Font = new System.Drawing.Font("Noto Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.ForeColor = System.Drawing.Color.Green;
            this.Label_Name.Location = new System.Drawing.Point(132, 18);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(319, 32);
            this.Label_Name.TabIndex = 10;
            this.Label_Name.Text = "GrabCar Bình Dương 4 chỗ";
            this.Label_Name.MouseEnter += new System.EventHandler(this.Control_Rent_History_MouseEnter);
            this.Label_Name.MouseLeave += new System.EventHandler(this.Control_Rent_History_MouseLeave);
            // 
            // PictureBox_Image
            // 
            this.PictureBox_Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_Image.Image = global::Grab.Images_GrabTransport.GrabBike;
            this.PictureBox_Image.Location = new System.Drawing.Point(20, 18);
            this.PictureBox_Image.Name = "PictureBox_Image";
            this.PictureBox_Image.Size = new System.Drawing.Size(90, 90);
            this.PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Image.TabIndex = 9;
            this.PictureBox_Image.TabStop = false;
            this.PictureBox_Image.MouseEnter += new System.EventHandler(this.Control_Rent_History_MouseEnter);
            this.PictureBox_Image.MouseLeave += new System.EventHandler(this.Control_Rent_History_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(541, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 41);
            this.label1.TabIndex = 13;
            this.label1.Text = "XX-XX XXXX";
            this.label1.MouseEnter += new System.EventHandler(this.Control_Rent_History_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.Control_Rent_History_MouseLeave);
            // 
            // Label_TimeRent
            // 
            this.Label_TimeRent.AutoSize = true;
            this.Label_TimeRent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_TimeRent.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TimeRent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_TimeRent.Location = new System.Drawing.Point(133, 61);
            this.Label_TimeRent.Name = "Label_TimeRent";
            this.Label_TimeRent.Size = new System.Drawing.Size(85, 27);
            this.Label_TimeRent.TabIndex = 14;
            this.Label_TimeRent.Text = "4 hours";
            this.Label_TimeRent.MouseEnter += new System.EventHandler(this.Control_Rent_History_MouseEnter);
            this.Label_TimeRent.MouseLeave += new System.EventHandler(this.Control_Rent_History_MouseLeave);
            // 
            // Control_Rent_History
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Label_TimeRent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Label_Time);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.PictureBox_Image);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Control_Rent_History";
            this.Size = new System.Drawing.Size(750, 127);
            this.Click += new System.EventHandler(this.Control_Rent_History_Click);
            this.MouseEnter += new System.EventHandler(this.Control_Rent_History_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Control_Rent_History_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Time;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.PictureBox PictureBox_Image;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_TimeRent;
    }
}
