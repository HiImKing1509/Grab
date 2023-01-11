using Grab.Database.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace Grab.Screens
{
    public partial class Form_Confirm_Booking : Form
    {
        private Form activeForm = null;
        DataProvider provider = new DataProvider();
        DataRow row_global = null;
        string service_id = "";
        double _distance = 0.0;


        public Form_Confirm_Booking()
        {
            // InitializeComponent();
        }

        public Form_Confirm_Booking(double distance, string service, DataRow row) : this()
        {
            InitializeComponent();
            row_global = row;
            _distance = distance;
            Panel_Information.BackColor = Assets.Variables.Colors.MintGreen;
            LoadMap(Assets.Variables.UtilsFunction.Start_location, Assets.Variables.UtilsFunction.End_location);
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

        private void Button_ServiceComfirm_Click(object sender, EventArgs e)
        {
            // Send mail
            string query = $"INSERT INTO HISTORY (SERVICE_ID, CUSTOMER_ID, PROVINCE_ID, LOCATION_START, LOCATION_END, DISTANCE, SERVICE_TIME, SERVICE_EVALUATE_SCORE) VALUES " +
                $"('{service_id}', '{Assets.Variables.Account.DataTableAccount.Rows[0]["CUSTOMER_PHONE_NUMBER"]}', {Assets.Variables.UtilsFunction.Start_id_province}, N'{Assets.Variables.UtilsFunction.Start_location}', N'{Assets.Variables.UtilsFunction.End_location}', {_distance} ,'{DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss tt")}', 0);";
            int a = provider.ExecuteNonQuery(query);

            openChildForm(new Form_Waiting_Booking(Label_ServiceCategory.Text, row_global));
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
