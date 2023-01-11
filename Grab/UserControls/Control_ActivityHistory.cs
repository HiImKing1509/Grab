using FontAwesome.Sharp;
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
    public partial class Control_ActivityHistory : UserControl
    {
        string _service = null;
        DataRow row = null;
        public Control_ActivityHistory()
        {
            // InitializeComponent();
        }

        public Control_ActivityHistory(string service, Bitmap image, DataRow dr) : this()
        {
            InitializeComponent();
            PictureBox_Image.Image = image;
            _service = service;
            row = dr;

            switch (service)
            {
                case "GrabCar":
                    Label_Name.Text = dr["GRAB_CAR_NAME"].ToString();
                    Label_Seat.Text = dr["GRAB_CAR_SEATS"].ToString() + " seats";
                    Label_Time.Text = dr["SERVICE_TIME"].ToString();
                    break;
                case "GrabBike":
                    Label_Name.Text = dr["GRAB_BIKE_NAME"].ToString();
                    Label_Seat.Visible = false;
                    Label_Time.Text = dr["SERVICE_TIME"].ToString();
                    break;
                default:
                    break;
            }

            foreach (IconButton item in FlowLayoutPanel_Stars.Controls)
            {
                if (Convert.ToInt16(item.Name.Substring(1)) <= Convert.ToInt16(dr["SERVICE_EVALUATE_SCORE"]))
                    item.IconColor = Assets.Variables.Colors.MetallicYellow;
                else
                    item.IconColor = Color.Black;
            }
        }

        private void PictureBox_Image_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Assets.Variables.Colors.MintGreen;
        }

        private void PictureBox_Image_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Assets.Variables.Colors.White;
        }

        private void Control_ActivityHistory_Click(object sender, EventArgs e)
        {
            Screens.Form_Activity_History.form_history.flp_infor.Visible = true;
            if (_service == "GrabCar" || _service == "JustGrab")
            {
                Screens.Form_Activity_History.form_history.label_name_driver.Text = row["GRAB_CAR_DRIVER_NAME"].ToString();
                Screens.Form_Activity_History.form_history.label_age_driver.Text = row["GRAB_CAR_DRIVER_AGE"].ToString();
                Screens.Form_Activity_History.form_history.label_service.Text = _service;
                Screens.Form_Activity_History.form_history.label_seats.Visible = true;
                Screens.Form_Activity_History.form_history.label_seats.Text = row["GRAB_CAR_SEATS"].ToString();
                Screens.Form_Activity_History.form_history.label_number_service.Text = row["GRAB_CAR_NUMBER"].ToString();
                Screens.Form_Activity_History.form_history.label_cost.Text = row["GRAB_CAR_COST"].ToString() + ".000";
                Screens.Form_Activity_History.form_history.label_location_start.Text = row["LOCATION_START"].ToString();
                Screens.Form_Activity_History.form_history.label_location_destination.Text = row["LOCATION_END"].ToString();
                Screens.Form_Activity_History.form_history.label_distance.Text = row["DISTANCE"].ToString() + "km";
                Screens.Form_Activity_History.form_history.label_nameservice.Text = row["GRAB_CAR_NAME"].ToString();
                Screens.Form_Activity_History.form_history.label_time.Text = row["SERVICE_TIME"].ToString();
            }
            else if (_service == "GrabBike")
            {
                Screens.Form_Activity_History.form_history.label_name_driver.Text = row["GRAB_BIKE_DRIVER_NAME"].ToString();
                Screens.Form_Activity_History.form_history.label_age_driver.Text = row["GRAB_BIKE_DRIVER_AGE"].ToString();
                Screens.Form_Activity_History.form_history.label_service.Text = _service;
                Screens.Form_Activity_History.form_history.label_seats.Visible = false;
                Screens.Form_Activity_History.form_history.label_number_service.Text = row["GRAB_BIKE_NUMBER"].ToString();
                Screens.Form_Activity_History.form_history.label_cost.Text = row["GRAB_BIKE_COST"].ToString() + ".000";
                Screens.Form_Activity_History.form_history.label_location_start.Text = row["LOCATION_START"].ToString();
                Screens.Form_Activity_History.form_history.label_location_destination.Text = row["LOCATION_END"].ToString();
                Screens.Form_Activity_History.form_history.label_distance.Text = row["DISTANCE"].ToString() + "km";
                Screens.Form_Activity_History.form_history.label_nameservice.Text = row["GRAB_BIKE_NAME"].ToString();
                Screens.Form_Activity_History.form_history.label_time.Text = row["SERVICE_TIME"].ToString();
            }
            if (Convert.ToInt16(Screens.Form_Activity_History.form_history.b1.Name.Substring(1)) <= Convert.ToInt16(row["SERVICE_EVALUATE_SCORE"])) Screens.Form_Activity_History.form_history.b1.IconColor = Assets.Variables.Colors.MetallicYellow; else Screens.Form_Activity_History.form_history.b1.IconColor = Color.Black;
            if (Convert.ToInt16(Screens.Form_Activity_History.form_history.b2.Name.Substring(1)) <= Convert.ToInt16(row["SERVICE_EVALUATE_SCORE"])) Screens.Form_Activity_History.form_history.b2.IconColor = Assets.Variables.Colors.MetallicYellow; else Screens.Form_Activity_History.form_history.b2.IconColor = Color.Black;
            if (Convert.ToInt16(Screens.Form_Activity_History.form_history.b3.Name.Substring(1)) <= Convert.ToInt16(row["SERVICE_EVALUATE_SCORE"])) Screens.Form_Activity_History.form_history.b3.IconColor = Assets.Variables.Colors.MetallicYellow; else Screens.Form_Activity_History.form_history.b3.IconColor = Color.Black;
            if (Convert.ToInt16(Screens.Form_Activity_History.form_history.b4.Name.Substring(1)) <= Convert.ToInt16(row["SERVICE_EVALUATE_SCORE"])) Screens.Form_Activity_History.form_history.b4.IconColor = Assets.Variables.Colors.MetallicYellow; else Screens.Form_Activity_History.form_history.b4.IconColor = Color.Black;
            if (Convert.ToInt16(Screens.Form_Activity_History.form_history.b5.Name.Substring(1)) <= Convert.ToInt16(row["SERVICE_EVALUATE_SCORE"])) Screens.Form_Activity_History.form_history.b5.IconColor = Assets.Variables.Colors.MetallicYellow; else Screens.Form_Activity_History.form_history.b5.IconColor = Color.Black;
        }
    }
}
