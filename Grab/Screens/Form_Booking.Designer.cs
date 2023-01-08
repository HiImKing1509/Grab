namespace Grab.Screens
{
    partial class Form_Booking
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
            this.WebBrowser_GoogleMap = new System.Windows.Forms.WebBrowser();
            this.Panel_Recommendation2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_Recommendation1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelGradient2 = new Grab.CustomControls.PanelGradient();
            this.FlowLayoutPanel_TransportServices = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Label_Distance = new System.Windows.Forms.Label();
            this.Label_LocationDestination = new System.Windows.Forms.Label();
            this.Label_LocationStart = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Panel_SearchLocation = new Grab.CustomControls.PanelGradient();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBox_LocationDestinationSearch = new System.Windows.Forms.TextBox();
            this.Button_ServiceQuery = new FontAwesome.Sharp.IconButton();
            this.Label_ServiceName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.TextBox_LocationStartSearch = new System.Windows.Forms.TextBox();
            this.panelGradient2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Panel_SearchLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // WebBrowser_GoogleMap
            // 
            this.WebBrowser_GoogleMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WebBrowser_GoogleMap.Location = new System.Drawing.Point(657, 193);
            this.WebBrowser_GoogleMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrowser_GoogleMap.Name = "WebBrowser_GoogleMap";
            this.WebBrowser_GoogleMap.Size = new System.Drawing.Size(914, 759);
            this.WebBrowser_GoogleMap.TabIndex = 2;
            // 
            // Panel_Recommendation2
            // 
            this.Panel_Recommendation2.AutoScroll = true;
            this.Panel_Recommendation2.Location = new System.Drawing.Point(1038, 97);
            this.Panel_Recommendation2.Name = "Panel_Recommendation2";
            this.Panel_Recommendation2.Size = new System.Drawing.Size(478, 409);
            this.Panel_Recommendation2.TabIndex = 7;
            this.Panel_Recommendation2.Visible = false;
            // 
            // Panel_Recommendation1
            // 
            this.Panel_Recommendation1.AutoScroll = true;
            this.Panel_Recommendation1.Location = new System.Drawing.Point(406, 97);
            this.Panel_Recommendation1.Name = "Panel_Recommendation1";
            this.Panel_Recommendation1.Size = new System.Drawing.Size(478, 409);
            this.Panel_Recommendation1.TabIndex = 8;
            this.Panel_Recommendation1.Visible = false;
            // 
            // panelGradient2
            // 
            this.panelGradient2.Angle = 60F;
            this.panelGradient2.BackColor = System.Drawing.Color.Green;
            this.panelGradient2.BottomColor = System.Drawing.Color.Empty;
            this.panelGradient2.Controls.Add(this.FlowLayoutPanel_TransportServices);
            this.panelGradient2.Controls.Add(this.panel1);
            this.panelGradient2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelGradient2.Location = new System.Drawing.Point(0, 193);
            this.panelGradient2.Name = "panelGradient2";
            this.panelGradient2.Size = new System.Drawing.Size(657, 759);
            this.panelGradient2.TabIndex = 1;
            this.panelGradient2.TopColor = System.Drawing.Color.White;
            // 
            // FlowLayoutPanel_TransportServices
            // 
            this.FlowLayoutPanel_TransportServices.AutoScroll = true;
            this.FlowLayoutPanel_TransportServices.Location = new System.Drawing.Point(42, 244);
            this.FlowLayoutPanel_TransportServices.Name = "FlowLayoutPanel_TransportServices";
            this.FlowLayoutPanel_TransportServices.Size = new System.Drawing.Size(568, 488);
            this.FlowLayoutPanel_TransportServices.TabIndex = 8;
            this.FlowLayoutPanel_TransportServices.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Label_Distance);
            this.panel1.Controls.Add(this.Label_LocationDestination);
            this.panel1.Controls.Add(this.Label_LocationStart);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(42, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 184);
            this.panel1.TabIndex = 7;
            // 
            // Label_Distance
            // 
            this.Label_Distance.AutoSize = true;
            this.Label_Distance.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.Label_Distance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_Distance.Location = new System.Drawing.Point(228, 140);
            this.Label_Distance.Name = "Label_Distance";
            this.Label_Distance.Size = new System.Drawing.Size(53, 27);
            this.Label_Distance.TabIndex = 7;
            this.Label_Distance.Text = "0km";
            // 
            // Label_LocationDestination
            // 
            this.Label_LocationDestination.AutoSize = true;
            this.Label_LocationDestination.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.Label_LocationDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_LocationDestination.Location = new System.Drawing.Point(134, 76);
            this.Label_LocationDestination.MaximumSize = new System.Drawing.Size(450, 0);
            this.Label_LocationDestination.Name = "Label_LocationDestination";
            this.Label_LocationDestination.Size = new System.Drawing.Size(230, 27);
            this.Label_LocationDestination.TabIndex = 6;
            this.Label_LocationDestination.Text = "Vui lòng chọn điểm đến";
            // 
            // Label_LocationStart
            // 
            this.Label_LocationStart.AutoSize = true;
            this.Label_LocationStart.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.Label_LocationStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label_LocationStart.Location = new System.Drawing.Point(133, 12);
            this.Label_LocationStart.MaximumSize = new System.Drawing.Size(450, 0);
            this.Label_LocationStart.Name = "Label_LocationStart";
            this.Label_LocationStart.Size = new System.Drawing.Size(231, 27);
            this.Label_LocationStart.TabIndex = 5;
            this.Label_LocationStart.Text = "Vui lòng chọn điểm đón";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(18, 134);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(515, 3);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(18, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(515, 3);
            this.panel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tổng quãng đường:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm đến:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm đón:";
            // 
            // Panel_SearchLocation
            // 
            this.Panel_SearchLocation.Angle = 0F;
            this.Panel_SearchLocation.BackColor = System.Drawing.Color.White;
            this.Panel_SearchLocation.BottomColor = System.Drawing.Color.Empty;
            this.Panel_SearchLocation.Controls.Add(this.pictureBox1);
            this.Panel_SearchLocation.Controls.Add(this.panel2);
            this.Panel_SearchLocation.Controls.Add(this.Button_ServiceQuery);
            this.Panel_SearchLocation.Controls.Add(this.Label_ServiceName);
            this.Panel_SearchLocation.Controls.Add(this.panel5);
            this.Panel_SearchLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_SearchLocation.Location = new System.Drawing.Point(0, 0);
            this.Panel_SearchLocation.Name = "Panel_SearchLocation";
            this.Panel_SearchLocation.Size = new System.Drawing.Size(1571, 193);
            this.Panel_SearchLocation.TabIndex = 0;
            this.Panel_SearchLocation.TopColor = System.Drawing.Color.White;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Grab.Images_GrabIcon.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(917, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.TextBox_LocationDestinationSearch);
            this.panel2.Location = new System.Drawing.Point(1038, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(478, 54);
            this.panel2.TabIndex = 4;
            // 
            // TextBox_LocationDestinationSearch
            // 
            this.TextBox_LocationDestinationSearch.BackColor = System.Drawing.Color.White;
            this.TextBox_LocationDestinationSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_LocationDestinationSearch.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_LocationDestinationSearch.ForeColor = System.Drawing.Color.Silver;
            this.TextBox_LocationDestinationSearch.Location = new System.Drawing.Point(14, 16);
            this.TextBox_LocationDestinationSearch.Name = "TextBox_LocationDestinationSearch";
            this.TextBox_LocationDestinationSearch.Size = new System.Drawing.Size(447, 28);
            this.TextBox_LocationDestinationSearch.TabIndex = 0;
            this.TextBox_LocationDestinationSearch.Text = "Điểm đến ...";
            this.TextBox_LocationDestinationSearch.Enter += new System.EventHandler(this.TextBox_LocationDestinationSearch_Enter);
            this.TextBox_LocationDestinationSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_LocationDestinationSearch_KeyPress);
            this.TextBox_LocationDestinationSearch.Leave += new System.EventHandler(this.TextBox_LocationDestinationSearch_Leave);
            // 
            // Button_ServiceQuery
            // 
            this.Button_ServiceQuery.BackColor = System.Drawing.Color.Green;
            this.Button_ServiceQuery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ServiceQuery.FlatAppearance.BorderSize = 0;
            this.Button_ServiceQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ServiceQuery.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ServiceQuery.ForeColor = System.Drawing.Color.White;
            this.Button_ServiceQuery.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_ServiceQuery.IconColor = System.Drawing.Color.Black;
            this.Button_ServiceQuery.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_ServiceQuery.Location = new System.Drawing.Point(42, 113);
            this.Button_ServiceQuery.Name = "Button_ServiceQuery";
            this.Button_ServiceQuery.Size = new System.Drawing.Size(287, 54);
            this.Button_ServiceQuery.TabIndex = 6;
            this.Button_ServiceQuery.Text = "Truy vấn dịch vụ";
            this.Button_ServiceQuery.UseVisualStyleBackColor = false;
            this.Button_ServiceQuery.Click += new System.EventHandler(this.Button_ServiceQuery_Click);
            // 
            // Label_ServiceName
            // 
            this.Label_ServiceName.AutoSize = true;
            this.Label_ServiceName.BackColor = System.Drawing.Color.Transparent;
            this.Label_ServiceName.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_ServiceName.Font = new System.Drawing.Font("Montserrat", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ServiceName.ForeColor = System.Drawing.Color.Green;
            this.Label_ServiceName.Location = new System.Drawing.Point(31, 22);
            this.Label_ServiceName.Name = "Label_ServiceName";
            this.Label_ServiceName.Size = new System.Drawing.Size(165, 65);
            this.Label_ServiceName.TabIndex = 4;
            this.Label_ServiceName.Text = "label1";
            this.Label_ServiceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.TextBox_LocationStartSearch);
            this.panel5.Location = new System.Drawing.Point(406, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(478, 54);
            this.panel5.TabIndex = 3;
            // 
            // TextBox_LocationStartSearch
            // 
            this.TextBox_LocationStartSearch.BackColor = System.Drawing.Color.White;
            this.TextBox_LocationStartSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_LocationStartSearch.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_LocationStartSearch.ForeColor = System.Drawing.Color.Silver;
            this.TextBox_LocationStartSearch.Location = new System.Drawing.Point(14, 16);
            this.TextBox_LocationStartSearch.Name = "TextBox_LocationStartSearch";
            this.TextBox_LocationStartSearch.Size = new System.Drawing.Size(447, 28);
            this.TextBox_LocationStartSearch.TabIndex = 0;
            this.TextBox_LocationStartSearch.Text = "Điểm đón ...";
            this.TextBox_LocationStartSearch.Enter += new System.EventHandler(this.TextBox_LocationStartSearch_Enter);
            this.TextBox_LocationStartSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_LocationStartSearch_KeyPress);
            this.TextBox_LocationStartSearch.Leave += new System.EventHandler(this.TextBox_LocationStartSearch_Leave);
            // 
            // Form_Booking
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1571, 952);
            this.Controls.Add(this.Panel_Recommendation1);
            this.Controls.Add(this.Panel_Recommendation2);
            this.Controls.Add(this.WebBrowser_GoogleMap);
            this.Controls.Add(this.panelGradient2);
            this.Controls.Add(this.Panel_SearchLocation);
            this.Name = "Form_Booking";
            this.Text = "Form_Booking";
            this.panelGradient2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel_SearchLocation.ResumeLayout(false);
            this.Panel_SearchLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.PanelGradient Panel_SearchLocation;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextBox_LocationDestinationSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox TextBox_LocationStartSearch;
        private CustomControls.PanelGradient panelGradient2;
        private System.Windows.Forms.Label Label_ServiceName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton Button_ServiceQuery;
        private System.Windows.Forms.FlowLayoutPanel FlowLayoutPanel_TransportServices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Distance;
        private System.Windows.Forms.Label Label_LocationDestination;
        private System.Windows.Forms.Label Label_LocationStart;
        private System.Windows.Forms.WebBrowser WebBrowser_GoogleMap;
        private System.Windows.Forms.FlowLayoutPanel Panel_Recommendation2;
        private System.Windows.Forms.FlowLayoutPanel Panel_Recommendation1;
    }
}