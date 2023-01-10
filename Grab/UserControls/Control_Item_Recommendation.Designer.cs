namespace Grab.UserControls
{
    partial class Control_Item_Recommendation
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
            this.Label_Location = new System.Windows.Forms.Label();
            this.PictureBox_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Location
            // 
            this.Label_Location.AutoSize = true;
            this.Label_Location.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Location.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Location.ForeColor = System.Drawing.Color.DimGray;
            this.Label_Location.Location = new System.Drawing.Point(52, 17);
            this.Label_Location.Name = "Label_Location";
            this.Label_Location.Size = new System.Drawing.Size(378, 23);
            this.Label_Location.TabIndex = 1;
            this.Label_Location.Text = "Tổ 2, khối Hà Trung, phường Cẩm Nam, Hội An";
            this.Label_Location.Click += new System.EventHandler(this.Label_Location_Click);
            this.Label_Location.MouseEnter += new System.EventHandler(this.Control_Item_Recommendation_MouseEnter);
            this.Label_Location.MouseLeave += new System.EventHandler(this.Control_Item_Recommendation_MouseLeave);
            // 
            // PictureBox_Image
            // 
            this.PictureBox_Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureBox_Image.Image = global::Grab.Images_GrabIcon.NoLocation;
            this.PictureBox_Image.Location = new System.Drawing.Point(18, 15);
            this.PictureBox_Image.Name = "PictureBox_Image";
            this.PictureBox_Image.Size = new System.Drawing.Size(25, 25);
            this.PictureBox_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox_Image.TabIndex = 0;
            this.PictureBox_Image.TabStop = false;
            this.PictureBox_Image.Click += new System.EventHandler(this.Label_Location_Click);
            this.PictureBox_Image.MouseEnter += new System.EventHandler(this.Control_Item_Recommendation_MouseEnter);
            this.PictureBox_Image.MouseLeave += new System.EventHandler(this.Control_Item_Recommendation_MouseLeave);
            // 
            // Control_Item_Recommendation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Label_Location);
            this.Controls.Add(this.PictureBox_Image);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Control_Item_Recommendation";
            this.Size = new System.Drawing.Size(450, 55);
            this.Click += new System.EventHandler(this.Label_Location_Click);
            this.MouseEnter += new System.EventHandler(this.Control_Item_Recommendation_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Control_Item_Recommendation_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Label_Location;
        private System.Windows.Forms.PictureBox PictureBox_Image;
    }
}
