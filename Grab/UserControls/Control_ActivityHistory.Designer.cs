namespace Grab.UserControls
{
    partial class Control_ActivityHistory
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
            this.Label_Seat = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.Label_Time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.B1 = new FontAwesome.Sharp.IconButton();
            this.B5 = new FontAwesome.Sharp.IconButton();
            this.B4 = new FontAwesome.Sharp.IconButton();
            this.B3 = new FontAwesome.Sharp.IconButton();
            this.B2 = new FontAwesome.Sharp.IconButton();
            this.FlowLayoutPanel_Stars = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).BeginInit();
            this.FlowLayoutPanel_Stars.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBox_Image
            // 
            this.PictureBox_Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_Image.Image = global::Grab.Images_GrabTransport.GrabBike;
            this.PictureBox_Image.Location = new System.Drawing.Point(18, 19);
            this.PictureBox_Image.Name = "PictureBox_Image";
            this.PictureBox_Image.Size = new System.Drawing.Size(90, 90);
            this.PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Image.TabIndex = 1;
            this.PictureBox_Image.TabStop = false;
            this.PictureBox_Image.MouseEnter += new System.EventHandler(this.PictureBox_Image_MouseEnter);
            this.PictureBox_Image.MouseLeave += new System.EventHandler(this.PictureBox_Image_MouseLeave);
            // 
            // Label_Seat
            // 
            this.Label_Seat.AutoSize = true;
            this.Label_Seat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Seat.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Seat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Seat.Location = new System.Drawing.Point(132, 56);
            this.Label_Seat.Name = "Label_Seat";
            this.Label_Seat.Size = new System.Drawing.Size(66, 23);
            this.Label_Seat.TabIndex = 7;
            this.Label_Seat.Text = "4 seats";
            this.Label_Seat.MouseEnter += new System.EventHandler(this.PictureBox_Image_MouseEnter);
            this.Label_Seat.MouseLeave += new System.EventHandler(this.PictureBox_Image_MouseLeave);
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Name.Font = new System.Drawing.Font("Noto Sans", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.ForeColor = System.Drawing.Color.Green;
            this.Label_Name.Location = new System.Drawing.Point(130, 19);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(319, 32);
            this.Label_Name.TabIndex = 6;
            this.Label_Name.Text = "GrabCar Bình Dương 4 chỗ";
            this.Label_Name.MouseEnter += new System.EventHandler(this.PictureBox_Image_MouseEnter);
            this.Label_Name.MouseLeave += new System.EventHandler(this.PictureBox_Image_MouseLeave);
            // 
            // Label_Time
            // 
            this.Label_Time.AutoSize = true;
            this.Label_Time.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Time.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Time.ForeColor = System.Drawing.Color.DimGray;
            this.Label_Time.Location = new System.Drawing.Point(538, 51);
            this.Label_Time.Name = "Label_Time";
            this.Label_Time.Size = new System.Drawing.Size(191, 23);
            this.Label_Time.TabIndex = 8;
            this.Label_Time.Text = "12-18-2022 15:45:21 PM";
            this.Label_Time.MouseEnter += new System.EventHandler(this.PictureBox_Image_MouseEnter);
            this.Label_Time.MouseLeave += new System.EventHandler(this.PictureBox_Image_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(433, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "ĐÁNH GIÁ:";
            this.label3.MouseEnter += new System.EventHandler(this.PictureBox_Image_MouseEnter);
            this.label3.MouseLeave += new System.EventHandler(this.PictureBox_Image_MouseLeave);
            // 
            // B1
            // 
            this.B1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B1.FlatAppearance.BorderSize = 0;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.B1.IconColor = System.Drawing.Color.Black;
            this.B1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.B1.IconSize = 28;
            this.B1.Location = new System.Drawing.Point(3, 3);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(32, 32);
            this.B1.TabIndex = 13;
            this.B1.UseVisualStyleBackColor = true;
            // 
            // B5
            // 
            this.B5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B5.FlatAppearance.BorderSize = 0;
            this.B5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B5.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.B5.IconColor = System.Drawing.Color.Black;
            this.B5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.B5.IconSize = 28;
            this.B5.Location = new System.Drawing.Point(155, 3);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(32, 32);
            this.B5.TabIndex = 14;
            this.B5.UseVisualStyleBackColor = true;
            // 
            // B4
            // 
            this.B4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B4.FlatAppearance.BorderSize = 0;
            this.B4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B4.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.B4.IconColor = System.Drawing.Color.Black;
            this.B4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.B4.IconSize = 28;
            this.B4.Location = new System.Drawing.Point(117, 3);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(32, 32);
            this.B4.TabIndex = 15;
            this.B4.UseVisualStyleBackColor = true;
            // 
            // B3
            // 
            this.B3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B3.FlatAppearance.BorderSize = 0;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.B3.IconColor = System.Drawing.Color.Black;
            this.B3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.B3.IconSize = 28;
            this.B3.Location = new System.Drawing.Point(79, 3);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(32, 32);
            this.B3.TabIndex = 16;
            this.B3.UseVisualStyleBackColor = true;
            // 
            // B2
            // 
            this.B2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B2.FlatAppearance.BorderSize = 0;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.B2.IconColor = System.Drawing.Color.Black;
            this.B2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.B2.IconSize = 28;
            this.B2.Location = new System.Drawing.Point(41, 3);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(32, 32);
            this.B2.TabIndex = 17;
            this.B2.UseVisualStyleBackColor = true;
            // 
            // FlowLayoutPanel_Stars
            // 
            this.FlowLayoutPanel_Stars.Controls.Add(this.B1);
            this.FlowLayoutPanel_Stars.Controls.Add(this.B2);
            this.FlowLayoutPanel_Stars.Controls.Add(this.B3);
            this.FlowLayoutPanel_Stars.Controls.Add(this.B4);
            this.FlowLayoutPanel_Stars.Controls.Add(this.B5);
            this.FlowLayoutPanel_Stars.Location = new System.Drawing.Point(542, 77);
            this.FlowLayoutPanel_Stars.Name = "FlowLayoutPanel_Stars";
            this.FlowLayoutPanel_Stars.Size = new System.Drawing.Size(196, 40);
            this.FlowLayoutPanel_Stars.TabIndex = 23;
            // 
            // Control_ActivityHistory
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.FlowLayoutPanel_Stars);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label_Time);
            this.Controls.Add(this.Label_Seat);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.PictureBox_Image);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Control_ActivityHistory";
            this.Size = new System.Drawing.Size(750, 127);
            this.Click += new System.EventHandler(this.Control_ActivityHistory_Click);
            this.MouseEnter += new System.EventHandler(this.PictureBox_Image_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.PictureBox_Image_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).EndInit();
            this.FlowLayoutPanel_Stars.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBox_Image;
        private System.Windows.Forms.Label Label_Seat;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label Label_Time;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton B1;
        private FontAwesome.Sharp.IconButton B5;
        private FontAwesome.Sharp.IconButton B4;
        private FontAwesome.Sharp.IconButton B3;
        private FontAwesome.Sharp.IconButton B2;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_Stars;
    }
}
