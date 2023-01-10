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
    public partial class Form_Waiting_Booking : Form
    {
        string service_id = "";
        public Form_Waiting_Booking()
        {
            // InitializeComponent();
        }

        public Form_Waiting_Booking(string service, DataRow row) : this()
        {
            InitializeComponent();
            BackColor = Assets.Variables.Colors.SoftPeach;
            switch (service)
            {
                case "GrabCar":
                case "JustGrab":
                    service_id = row["GRAB_CAR_ID"].ToString();
                    Label_ServiceName.Text = row["GRAB_CAR_NAME"].ToString();
                    Label_WaitingTime.Text = row["GRAB_CAR_START"].ToString() + " - " + row["GRAB_CAR_END"].ToString() + " mins";
                    Label_DriverName.Text = row["GRAB_CAR_DRIVER_NAME"].ToString();
                    Label_DriverAge.Text = row["GRAB_CAR_DRIVER_AGE"].ToString();
                    Label_ServiceCategory.Text = service;

                    Seats.Visible = true;
                    Label_Seats.Visible = true;

                    Label_Seats.Text = row["GRAB_CAR_SEATS"].ToString();
                    Label_NumberService.Text = row["GRAB_CAR_NUMBER"].ToString();
                    Label_LocationStart.Text = Assets.Variables.UtilsFunction.Start_location;
                    Label_LocationDestination.Text = Assets.Variables.UtilsFunction.End_location;
                    Label_Cost.Text = row["GRAB_CAR_COST"].ToString() + ".000";
                    break;
                case "GrabBike":
                    service_id = row["GRAB_BIKE_ID"].ToString();
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
    }
}
