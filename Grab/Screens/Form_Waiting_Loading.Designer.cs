namespace Grab.Screens
{
    partial class Form_Waiting_Loading
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelGradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGradient1
            // 
            this.panelGradient1.Angle = 0F;
            this.panelGradient1.BottomColor = System.Drawing.Color.White;
            this.panelGradient1.Controls.Add(this.pictureBox1);
            this.panelGradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGradient1.Location = new System.Drawing.Point(0, 0);
            this.panelGradient1.Name = "panelGradient1";
            this.panelGradient1.Size = new System.Drawing.Size(694, 401);
            this.panelGradient1.TabIndex = 0;
            this.panelGradient1.TopColor = System.Drawing.Color.Green;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Grab.Images_GrabLogo.LG2_04;
            this.pictureBox1.Location = new System.Drawing.Point(173, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(367, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Waiting_Loading
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(694, 401);
            this.Controls.Add(this.panelGradient1);
            this.Name = "Form_Waiting_Loading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Waiting_Loading";
            this.panelGradient1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.PanelGradient panelGradient1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}