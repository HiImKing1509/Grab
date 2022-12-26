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
            this.Label_Name = new System.Windows.Forms.Label();
            this.PictureBox_Images = new Grab.CustomControls.CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Images)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Name
            // 
            this.Label_Name.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Name.Location = new System.Drawing.Point(22, 272);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(232, 36);
            this.Label_Name.TabIndex = 1;
            this.Label_Name.Text = "label1";
            this.Label_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox_Images
            // 
            this.PictureBox_Images.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            this.PictureBox_Images.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.PictureBox_Images.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.PictureBox_Images.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.PictureBox_Images.BorderSize = 6;
            this.PictureBox_Images.GradientAngle = 50F;
            this.PictureBox_Images.Image = global::Grab.Images_Services.SV02;
            this.PictureBox_Images.Location = new System.Drawing.Point(22, 16);
            this.PictureBox_Images.Name = "PictureBox_Images";
            this.PictureBox_Images.Size = new System.Drawing.Size(232, 232);
            this.PictureBox_Images.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Images.TabIndex = 0;
            this.PictureBox_Images.TabStop = false;
            // 
            // Control_Item_Service
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.PictureBox_Images);
            this.Name = "Control_Item_Service";
            this.Size = new System.Drawing.Size(276, 326);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Images)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.CirclePictureBox PictureBox_Images;
        private System.Windows.Forms.Label Label_Name;
    }
}
