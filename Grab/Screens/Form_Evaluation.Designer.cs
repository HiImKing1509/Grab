namespace Grab.Screens
{
    partial class Form_Evaluation
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
            this.Panel_SearchLocation = new Grab.CustomControls.PanelGradient();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_Search = new FontAwesome.Sharp.IconButton();
            this.Button_ServiceCategory = new FontAwesome.Sharp.IconButton();
            this.Label_ServiceCategory = new System.Windows.Forms.Label();
            this.Picture_ServiceCategory = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TextBox_Province = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_DriverName = new System.Windows.Forms.TextBox();
            this.FLP_LoadDriver = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_Recommendation1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel_SearchLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ServiceCategory)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_SearchLocation
            // 
            this.Panel_SearchLocation.Angle = 0F;
            this.Panel_SearchLocation.BackColor = System.Drawing.Color.White;
            this.Panel_SearchLocation.BottomColor = System.Drawing.Color.Empty;
            this.Panel_SearchLocation.Controls.Add(this.label2);
            this.Panel_SearchLocation.Controls.Add(this.Button_Search);
            this.Panel_SearchLocation.Controls.Add(this.Button_ServiceCategory);
            this.Panel_SearchLocation.Controls.Add(this.Label_ServiceCategory);
            this.Panel_SearchLocation.Controls.Add(this.Picture_ServiceCategory);
            this.Panel_SearchLocation.Controls.Add(this.panel2);
            this.Panel_SearchLocation.Controls.Add(this.panel1);
            this.Panel_SearchLocation.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_SearchLocation.Location = new System.Drawing.Point(0, 0);
            this.Panel_SearchLocation.Name = "Panel_SearchLocation";
            this.Panel_SearchLocation.Size = new System.Drawing.Size(1613, 200);
            this.Panel_SearchLocation.TabIndex = 1;
            this.Panel_SearchLocation.TopColor = System.Drawing.Color.White;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(395, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 27);
            this.label2.TabIndex = 27;
            this.label2.Text = "Tìm tên tài xế";
            // 
            // Button_Search
            // 
            this.Button_Search.BackColor = System.Drawing.Color.Green;
            this.Button_Search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Search.FlatAppearance.BorderSize = 0;
            this.Button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Search.ForeColor = System.Drawing.Color.White;
            this.Button_Search.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.Button_Search.IconColor = System.Drawing.Color.White;
            this.Button_Search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Search.IconSize = 28;
            this.Button_Search.Location = new System.Drawing.Point(1310, 23);
            this.Button_Search.Name = "Button_Search";
            this.Button_Search.Size = new System.Drawing.Size(68, 54);
            this.Button_Search.TabIndex = 26;
            this.Button_Search.UseVisualStyleBackColor = false;
            this.Button_Search.Click += new System.EventHandler(this.Button_Search_Click);
            // 
            // Button_ServiceCategory
            // 
            this.Button_ServiceCategory.BackColor = System.Drawing.Color.Green;
            this.Button_ServiceCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_ServiceCategory.FlatAppearance.BorderSize = 0;
            this.Button_ServiceCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ServiceCategory.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_ServiceCategory.ForeColor = System.Drawing.Color.White;
            this.Button_ServiceCategory.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Button_ServiceCategory.IconColor = System.Drawing.Color.Black;
            this.Button_ServiceCategory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_ServiceCategory.Location = new System.Drawing.Point(538, 23);
            this.Button_ServiceCategory.Name = "Button_ServiceCategory";
            this.Button_ServiceCategory.Size = new System.Drawing.Size(287, 54);
            this.Button_ServiceCategory.TabIndex = 25;
            this.Button_ServiceCategory.Text = "GrabCar";
            this.Button_ServiceCategory.UseVisualStyleBackColor = false;
            this.Button_ServiceCategory.Click += new System.EventHandler(this.Button_ServiceCategory_Click);
            // 
            // Label_ServiceCategory
            // 
            this.Label_ServiceCategory.AutoSize = true;
            this.Label_ServiceCategory.BackColor = System.Drawing.Color.Transparent;
            this.Label_ServiceCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label_ServiceCategory.Font = new System.Drawing.Font("Montserrat", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ServiceCategory.ForeColor = System.Drawing.Color.Green;
            this.Label_ServiceCategory.Location = new System.Drawing.Point(196, 21);
            this.Label_ServiceCategory.Name = "Label_ServiceCategory";
            this.Label_ServiceCategory.Size = new System.Drawing.Size(228, 65);
            this.Label_ServiceCategory.TabIndex = 24;
            this.Label_ServiceCategory.Text = "GrabCar";
            this.Label_ServiceCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Picture_ServiceCategory
            // 
            this.Picture_ServiceCategory.BackColor = System.Drawing.Color.Transparent;
            this.Picture_ServiceCategory.Image = global::Grab.Images_GrabTransport.GrabCar;
            this.Picture_ServiceCategory.Location = new System.Drawing.Point(27, 21);
            this.Picture_ServiceCategory.Name = "Picture_ServiceCategory";
            this.Picture_ServiceCategory.Size = new System.Drawing.Size(152, 146);
            this.Picture_ServiceCategory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture_ServiceCategory.TabIndex = 23;
            this.Picture_ServiceCategory.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.TextBox_Province);
            this.panel2.Location = new System.Drawing.Point(866, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 54);
            this.panel2.TabIndex = 4;
            // 
            // TextBox_Province
            // 
            this.TextBox_Province.BackColor = System.Drawing.Color.White;
            this.TextBox_Province.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_Province.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Province.ForeColor = System.Drawing.Color.Silver;
            this.TextBox_Province.Location = new System.Drawing.Point(14, 16);
            this.TextBox_Province.Name = "TextBox_Province";
            this.TextBox_Province.Size = new System.Drawing.Size(404, 28);
            this.TextBox_Province.TabIndex = 0;
            this.TextBox_Province.Text = "Tỉnh, thành ...";
            this.TextBox_Province.TextChanged += new System.EventHandler(this.TextBox_Province_TextChanged);
            this.TextBox_Province.Enter += new System.EventHandler(this.TextBox_Province_Enter);
            this.TextBox_Province.Leave += new System.EventHandler(this.TextBox_Province_Leave);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.TextBox_DriverName);
            this.panel1.Location = new System.Drawing.Point(538, 113);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 54);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // TextBox_DriverName
            // 
            this.TextBox_DriverName.BackColor = System.Drawing.Color.White;
            this.TextBox_DriverName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_DriverName.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_DriverName.ForeColor = System.Drawing.Color.Silver;
            this.TextBox_DriverName.Location = new System.Drawing.Point(14, 16);
            this.TextBox_DriverName.Name = "TextBox_DriverName";
            this.TextBox_DriverName.Size = new System.Drawing.Size(862, 28);
            this.TextBox_DriverName.TabIndex = 0;
            this.TextBox_DriverName.TextChanged += new System.EventHandler(this.TextBox_DriverName_TextChanged);
            // 
            // FLP_LoadDriver
            // 
            this.FLP_LoadDriver.AutoScroll = true;
            this.FLP_LoadDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FLP_LoadDriver.Location = new System.Drawing.Point(0, 200);
            this.FLP_LoadDriver.Name = "FLP_LoadDriver";
            this.FLP_LoadDriver.Size = new System.Drawing.Size(1613, 646);
            this.FLP_LoadDriver.TabIndex = 2;
            // 
            // Panel_Recommendation1
            // 
            this.Panel_Recommendation1.AutoScroll = true;
            this.Panel_Recommendation1.BackColor = System.Drawing.Color.White;
            this.Panel_Recommendation1.Location = new System.Drawing.Point(866, 83);
            this.Panel_Recommendation1.Name = "Panel_Recommendation1";
            this.Panel_Recommendation1.Size = new System.Drawing.Size(438, 395);
            this.Panel_Recommendation1.TabIndex = 9;
            this.Panel_Recommendation1.Visible = false;
            // 
            // Form_Evaluation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1613, 846);
            this.Controls.Add(this.Panel_Recommendation1);
            this.Controls.Add(this.FLP_LoadDriver);
            this.Controls.Add(this.Panel_SearchLocation);
            this.Name = "Form_Evaluation";
            this.Text = "Form_Evaluation";
            this.Panel_SearchLocation.ResumeLayout(false);
            this.Panel_SearchLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_ServiceCategory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.PanelGradient Panel_SearchLocation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TextBox_DriverName;
        private System.Windows.Forms.PictureBox Picture_ServiceCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TextBox_Province;
        private FontAwesome.Sharp.IconButton Button_ServiceCategory;
        private System.Windows.Forms.Label Label_ServiceCategory;
        private System.Windows.Forms.FlowLayoutPanel FLP_LoadDriver;
        private System.Windows.Forms.FlowLayoutPanel Panel_Recommendation1;
        private FontAwesome.Sharp.IconButton Button_Search;
        private System.Windows.Forms.Label label2;
    }
}