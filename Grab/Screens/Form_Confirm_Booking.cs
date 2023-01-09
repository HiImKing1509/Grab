using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grab.Screens
{
    public partial class Form_Confirm_Booking : Form
    {
        public Form_Confirm_Booking()
        {
            // InitializeComponent();
        }

        public Form_Confirm_Booking(string service, DataRow row) : this()
        {
            InitializeComponent();
            Panel_Information.BackColor = Assets.Variables.Colors.MintGreen;
            LoadMap(Assets.Variables.UtilsFunction.Start_location, Assets.Variables.UtilsFunction.End_location);
            switch (service)
            {
                case "GrabCar":
                    Label_ServiceName.Text = row["GRAB_CAR_NAME"].ToString();
                    Label_WaitingTime.Text = row["GRAB_CAR_START"].ToString() + " - " + row["GRAB_CAR_END"].ToString() + " mins";
                    Label_DriverName.Text = row["GRAB_CAR_DRIVER_NAME"].ToString();
                    Label_DriverAge.Text = row["GRAB_CAR_DRIVER_AGE"].ToString();
                    Label_ServiceCategory.Text = service;

                    Seats.Visible = false;
                    Label_Seats.Visible = false;

                    Label_Seats.Text = row["GRAB_CAR_SEATS"].ToString();
                    Label_NumberService.Text = row["GRAB_CAR_NUMBER"].ToString();
                    Label_LocationStart.Text = Assets.Variables.UtilsFunction.Start_location;
                    Label_LocationDestination.Text = Assets.Variables.UtilsFunction.End_location;
                    Label_Cost.Text = row["GRAB_CAR_COST"].ToString() + ".000";
                    break;
                case "GrabBike":
                    Label_ServiceName.Text = row["GRAB_BIKE_NAME"].ToString();
                    Label_WaitingTime.Text = row["GRAB_BIKE_START"].ToString() + " - " + row["GRAB_BIKE_END"].ToString() + " mins";
                    Label_DriverName.Text = row["GRAB_BIKE_DRIVER_NAME"].ToString();
                    Label_DriverAge.Text = row["GRAB_BIKE_DRIVER_AGE"].ToString();
                    Label_ServiceCategory.Text = service;

                    Seats.Visible = false;
                    Label_Seats.Visible = false;

                    Label_NumberService.Text = row["GRAB_BIKE_NUMBER"].ToString();
                    Label_LocationStart.Text = Assets.Variables.UtilsFunction.Start_location;
                    Label_LocationDestination.Text = Assets.Variables.UtilsFunction.End_location;
                    Label_Cost.Text = row["GRAB_BIKE_COST"].ToString() + ".000";
                    break;
                default:
                    break;
            }
        }

        private void LoadMap(string start_location, string destination_location)
        {
            string start = Assets.Variables.StringProcessing.convertToUnSign3(start_location);
            string end = Assets.Variables.StringProcessing.convertToUnSign3(destination_location);
            string url = string.Format($"https://www.google.com/maps/dir/" +
                $"{start}/" +
                $"{end}");
            WebBrowser_GoogleMap.Navigate(url);
        }

        private void Button_ChangeLocation_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form_Booking>().First().Show();
            Close();
        }
    }
}
