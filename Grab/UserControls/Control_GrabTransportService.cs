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
    public partial class Control_GrabTransportService : UserControl
    {
        private Form activeForm = null;
        private string _service = null;
        private DataRow row = null;
        public Control_GrabTransportService()
        {
            // InitializeComponent();
        }

        public Control_GrabTransportService(string service, Bitmap image, DataRow dr)
        {
            InitializeComponent();
            row = dr;
            _service = service;
            PictureBox_Image.Image = image;
            switch (service)
            {
                case "GrabCar":
                    Label_Name.Text = dr["GRAB_CAR_NAME"].ToString();
                    Label_Seat.Visible = true;
                    Label_Seat.Text = dr["GRAB_CAR_SEATS"].ToString() + " seats";
                    Label_Cost.Text = dr["GRAB_CAR_COST"].ToString() + ".000";
                    Label_Time.Text = dr["GRAB_CAR_START"].ToString() + " - " + dr["GRAB_CAR_END"].ToString() + "mins";
                    break;
                case "GrabBike":
                    Label_Name.Text = dr["GRAB_BIKE_NAME"].ToString();
                    Label_Seat.Visible = false;
                    // Label_Seat.Text = dr["GRAB_BIKE_SEATS"].ToString() + " seats";
                    Label_Cost.Text = dr["GRAB_BIKE_COST"].ToString() + ".000";
                    Label_Time.Text = dr["GRAB_BIKE_START"].ToString() + " - " + dr["GRAB_BIKE_END"].ToString() + "mins";
                    break;
                default:    
                    break;
            }
        }

        private void Control_GrabTransportService_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Assets.Variables.Colors.MintGreen;
        }

        private void Control_GrabTransportService_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Assets.Variables.Colors.White;
        }

        private void Control_GrabTransportService_Click(object sender, EventArgs e)
        {
            openChildForm(new Screens.Form_Confirm_Booking(_service, row));
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Hide();
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
