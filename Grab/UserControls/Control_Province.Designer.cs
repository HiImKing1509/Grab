namespace Grab.UserControls
{
    partial class Control_Province
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
            this.SuspendLayout();
            // 
            // Label_Location
            // 
            this.Label_Location.AutoSize = true;
            this.Label_Location.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Label_Location.Font = new System.Drawing.Font("Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Location.ForeColor = System.Drawing.Color.DimGray;
            this.Label_Location.Location = new System.Drawing.Point(17, 16);
            this.Label_Location.Name = "Label_Location";
            this.Label_Location.Size = new System.Drawing.Size(378, 23);
            this.Label_Location.TabIndex = 2;
            this.Label_Location.Text = "Tổ 2, khối Hà Trung, phường Cẩm Nam, Hội An";
            this.Label_Location.Click += new System.EventHandler(this.Control_Province_Click);
            this.Label_Location.MouseEnter += new System.EventHandler(this.Control_Province_MouseEnter);
            this.Label_Location.MouseLeave += new System.EventHandler(this.Control_Province_MouseLeave);
            // 
            // Control_Province
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Label_Location);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Control_Province";
            this.Size = new System.Drawing.Size(409, 52);
            this.Click += new System.EventHandler(this.Control_Province_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Control_Province_MouseClick);
            this.MouseEnter += new System.EventHandler(this.Control_Province_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Control_Province_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Location;
    }
}
