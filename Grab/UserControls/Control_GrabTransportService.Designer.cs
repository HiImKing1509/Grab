namespace Grab.UserControls
{
    partial class Control_GrabTransportService
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
            this.PictureBox_Image = new System.Windows.Forms.PictureBox();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_Cost = new System.Windows.Forms.Label();
            this.Label_Time = new System.Windows.Forms.Label();
            this.Label_Seat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox_Image
            // 
            this.PictureBox_Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_Image.Image = global::Grab.Images_GrabTransport.GrabBike;
            this.PictureBox_Image.Location = new System.Drawing.Point(11, 17);
            this.PictureBox_Image.Name = "PictureBox_Image";
            this.PictureBox_Image.Size = new System.Drawing.Size(89, 75);
            this.PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Image.TabIndex = 0;
            this.PictureBox_Image.TabStop = false;
            this.PictureBox_Image.MouseEnter += new System.EventHandler(this.Control_GrabTransportService_MouseEnter);
            this.PictureBox_Image.MouseLeave += new System.EventHandler(this.Control_GrabTransportService_MouseLeave);
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Name.Font = new System.Drawing.Font("Noto Sans", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.Location = new System.Drawing.Point(106, 14);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(248, 24);
            this.Label_Name.TabIndex = 1;
            this.Label_Name.Text = "GrabCar Bình Dương 4 chỗ";
            this.Label_Name.MouseEnter += new System.EventHandler(this.Control_GrabTransportService_MouseEnter);
            this.Label_Name.MouseLeave += new System.EventHandler(this.Control_GrabTransportService_MouseLeave);
            // 
            // Label_Cost
            // 
            this.Label_Cost.AutoSize = true;
            this.Label_Cost.BackColor = System.Drawing.Color.Red;
            this.Label_Cost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Cost.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Cost.ForeColor = System.Drawing.Color.White;
            this.Label_Cost.Location = new System.Drawing.Point(420, 41);
            this.Label_Cost.Name = "Label_Cost";
            this.Label_Cost.Size = new System.Drawing.Size(84, 27);
            this.Label_Cost.TabIndex = 3;
            this.Label_Cost.Text = "250.000";
            this.Label_Cost.MouseEnter += new System.EventHandler(this.Control_GrabTransportService_MouseEnter);
            this.Label_Cost.MouseLeave += new System.EventHandler(this.Control_GrabTransportService_MouseLeave);
            // 
            // Label_Time
            // 
            this.Label_Time.AutoSize = true;
            this.Label_Time.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Time.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Time.ForeColor = System.Drawing.Color.DimGray;
            this.Label_Time.Location = new System.Drawing.Point(420, 72);
            this.Label_Time.Name = "Label_Time";
            this.Label_Time.Size = new System.Drawing.Size(84, 20);
            this.Label_Time.TabIndex = 4;
            this.Label_Time.Text = "7 - 15 mins";
            this.Label_Time.MouseEnter += new System.EventHandler(this.Control_GrabTransportService_MouseEnter);
            this.Label_Time.MouseLeave += new System.EventHandler(this.Control_GrabTransportService_MouseLeave);
            // 
            // Label_Seat
            // 
            this.Label_Seat.AutoSize = true;
            this.Label_Seat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Seat.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Seat.ForeColor = System.Drawing.Color.DimGray;
            this.Label_Seat.Location = new System.Drawing.Point(106, 48);
            this.Label_Seat.Name = "Label_Seat";
            this.Label_Seat.Size = new System.Drawing.Size(56, 20);
            this.Label_Seat.TabIndex = 5;
            this.Label_Seat.Text = "4 seats";
            this.Label_Seat.MouseEnter += new System.EventHandler(this.Control_GrabTransportService_MouseEnter);
            this.Label_Seat.MouseLeave += new System.EventHandler(this.Control_GrabTransportService_MouseLeave);
            // 
            // Control_GrabTransportService
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Label_Seat);
            this.Controls.Add(this.Label_Time);
            this.Controls.Add(this.Label_Cost);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.PictureBox_Image);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Control_GrabTransportService";
            this.Size = new System.Drawing.Size(541, 108);
            this.MouseEnter += new System.EventHandler(this.Control_GrabTransportService_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Control_GrabTransportService_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Image;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_Cost;
        private System.Windows.Forms.Label Label_Time;
        private System.Windows.Forms.Label Label_Seat;
    }
}
