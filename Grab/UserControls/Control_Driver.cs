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
    public partial class Control_Driver : UserControl
    {
        private Form activeForm = null;
        string _service = null;
        DataRow _row = null;
        public Control_Driver()
        {
            // InitializeComponent();
        }

        public Control_Driver(string service, DataRow row) : this()
        {
            InitializeComponent();
            _service = service;
            _row = row;
            if (service == "GrabCar")
            {
                Label_Name.Text = row["GRAB_CAR_DRIVER_NAME"].ToString();
                Label_Age.Text = row["GRAB_CAR_DRIVER_AGE"].ToString() + " tuổi";
                Label_ServiceName.Text = row["GRAB_CAR_NAME"].ToString();
                Label_Service_Number.Text = row["GRAB_CAR_NUMBER"].ToString();
            }
            else
            {
                Label_Name.Text = row["GRAB_BIKE_DRIVER_NAME"].ToString();
                Label_Age.Text = row["GRAB_BIKE_DRIVER_AGE"].ToString() + " tuổi";
                Label_ServiceName.Text = row["GRAB_BIKE_NAME"].ToString();
                Label_Service_Number.Text = row["GRAB_BIKE_NUMBER"].ToString();
            }
        }

        private void Control_Driver_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Assets.Variables.Colors.MintGreen;
        }

        private void Control_Driver_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void Control_Driver_Click(object sender, EventArgs e)
        {
            openChildForm(new Screens.Form_Comment(_service, _row));
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
