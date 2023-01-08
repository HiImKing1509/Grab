namespace Grab.UserControls
{
    partial class Control_Service
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
            this.panelGradient1 = new Grab.CustomControls.PanelGradient();
            this.Label_ServiceDescription = new System.Windows.Forms.Label();
            this.Label_ServiceName = new System.Windows.Forms.Label();
            this.panelGradient1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGradient1
            // 
            this.panelGradient1.Angle = 0F;
            this.panelGradient1.BottomColor = System.Drawing.Color.White;
            this.panelGradient1.Controls.Add(this.Label_ServiceDescription);
            this.panelGradient1.Controls.Add(this.Label_ServiceName);
            this.panelGradient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGradient1.Location = new System.Drawing.Point(0, 0);
            this.panelGradient1.Name = "panelGradient1";
            this.panelGradient1.Size = new System.Drawing.Size(1527, 133);
            this.panelGradient1.TabIndex = 0;
            this.panelGradient1.TopColor = System.Drawing.Color.Green;
            // 
            // Label_ServiceDescription
            // 
            this.Label_ServiceDescription.AutoSize = true;
            this.Label_ServiceDescription.BackColor = System.Drawing.Color.Transparent;
            this.Label_ServiceDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Label_ServiceDescription.Font = new System.Drawing.Font("Montserrat SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ServiceDescription.ForeColor = System.Drawing.Color.White;
            this.Label_ServiceDescription.Location = new System.Drawing.Point(56, 79);
            this.Label_ServiceDescription.Name = "Label_ServiceDescription";
            this.Label_ServiceDescription.Size = new System.Drawing.Size(554, 25);
            this.Label_ServiceDescription.TabIndex = 5;
            this.Label_ServiceDescription.Text = "Thuê xe cùng tài xế để phục vụ nhu cầu đi lại riêng của bạn";
            // 
            // Label_ServiceName
            // 
            this.Label_ServiceName.AutoSize = true;
            this.Label_ServiceName.BackColor = System.Drawing.Color.Transparent;
            this.Label_ServiceName.Font = new System.Drawing.Font("Montserrat", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ServiceName.ForeColor = System.Drawing.Color.White;
            this.Label_ServiceName.Location = new System.Drawing.Point(50, 18);
            this.Label_ServiceName.Name = "Label_ServiceName";
            this.Label_ServiceName.Size = new System.Drawing.Size(155, 61);
            this.Label_ServiceName.TabIndex = 0;
            this.Label_ServiceName.Text = "label1";
            // 
            // Control_Service
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelGradient1);
            this.Name = "Control_Service";
            this.Size = new System.Drawing.Size(1527, 133);
            this.panelGradient1.ResumeLayout(false);
            this.panelGradient1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.PanelGradient panelGradient1;
        private System.Windows.Forms.Label Label_ServiceName;
        private System.Windows.Forms.Label Label_ServiceDescription;
    }
}
