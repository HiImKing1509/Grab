using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grab.UserControls
{
    public partial class Control_Item_Service : UserControl
    {
        private Form activeForm = null;
        public Control_Item_Service()
        {
            //InitializeComponent();
        }

        public Control_Item_Service(Bitmap image, DataRow dr) : this()
        {
            InitializeComponent();
            Label_Name.ForeColor = Color.Black;
            Label_Description.ForeColor = Color.Gray;


            PictureBox_Image.Image = image;
            Label_Name.Text = dr["GRAB_NAME"].ToString();
            Label_Description.Text = dr["GRAB_DESCRIPTION"].ToString();
        }

        private void PictureBox_Image_MouseEnter(object sender, EventArgs e)
        {

            BackColor = Assets.Variables.Colors.Green;
            Panel_Infor.BackColor = Assets.Variables.Colors.Green;
            Label_Name.ForeColor = Color.White;
            Label_Description.ForeColor = Color.White;
            PictureBox_Image.Dock = DockStyle.Fill;
        }

        private void PictureBox_Image_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Assets.Variables.Colors.White;
            Panel_Infor.BackColor = Assets.Variables.Colors.White;
            Label_Name.ForeColor = Color.Black;
            Label_Description.ForeColor = Color.Gray;
            PictureBox_Image.Dock = DockStyle.None;
        }

        private void PictureBox_Image_Click(object sender, EventArgs e)
        {
            openChildForm(new Screens.Form_Booking());
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            Assets.Variables.ListFormPanel.ListFormsPanel[0].Controls.Add(childForm);
            Assets.Variables.ListFormPanel.ListFormsPanel[0].Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
