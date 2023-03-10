using Grab.Database.DAO;
using Grab.UserControls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.WebRequestMethods;
using MessageBox = System.Windows.Forms.MessageBox;
using Point = System.Drawing.Point;
using Size = System.Drawing.Size;

namespace Grab.Screens
{
    public partial class Form_Booking : Form
    {
        DataProvider provider = new DataProvider();
        DataTable dt_just_grab = new DataTable();
        private Form activeForm = null;
        string query = "";
        public static Form_Booking form_booking;
        public TextBox tbx1;
        public TextBox tbx2;
        public Form_Booking()
        {

        }
        public Form_Booking(string name_service) : this()
        {
            InitializeComponent();
            form_booking = this;
            tbx1 = TextBox_LocationStartSearch;
            tbx2 = TextBox_LocationDestinationSearch;
            Panel_SearchLocation.BottomColor = Assets.Variables.Colors.ForestGreen;
            Panel_SearchLocation.TopColor = Assets.Variables.Colors.White;
            Label_ServiceName.Text = name_service;
        }

        private void TextBox_LocationStartSearch_Enter(object sender, EventArgs e)
        {
            if (TextBox_LocationStartSearch.Text == "Điểm đón ..." && TextBox_LocationStartSearch.ForeColor == Color.Silver)
            {
                TextBox_LocationStartSearch.Text = "";
                TextBox_LocationStartSearch.ForeColor = Color.Black;
            }
        }

        private void TextBox_LocationStartSearch_Leave(object sender, EventArgs e)
        {
            if (TextBox_LocationStartSearch.Text == "")
            {
                TextBox_LocationStartSearch.Text = "Điểm đón ...";
                TextBox_LocationStartSearch.ForeColor = Color.Silver;
            }
            Panel_Recommendation1.Visible = false;
        }

        private void TextBox_LocationDestinationSearch_Enter(object sender, EventArgs e)
        {
            if (TextBox_LocationDestinationSearch.Text == "Điểm đến ..." && TextBox_LocationDestinationSearch.ForeColor == Color.Silver)
            {
                TextBox_LocationDestinationSearch.Text = "";
                TextBox_LocationDestinationSearch.ForeColor = Color.Black;
            }
        }

        private void TextBox_LocationDestinationSearch_Leave(object sender, EventArgs e)
        {
            if (TextBox_LocationDestinationSearch.Text == "")
            {
                TextBox_LocationDestinationSearch.Text = "Điểm đến ...";
                TextBox_LocationDestinationSearch.ForeColor = Color.Silver;
            }
            Panel_Recommendation2.Visible = false;
        }

        private void Button_ServiceQuery_Click(object sender, EventArgs e)
        {
            if (TextBox_LocationStartSearch.Text == "Điểm đón ..."
                || TextBox_LocationStartSearch.Text == ""
                || TextBox_LocationDestinationSearch.Text == "Điểm đến ..."
                || TextBox_LocationDestinationSearch.Text == "")
            {
                Alert("Vui lòng chọn địa điểm!", Notification_Form.enmType.Error);
                Label_Distance.ForeColor = Assets.Variables.Colors.UERed;
                Label_Distance.Text = "0km";
            }
            else
            {
                // UI 
                Label_LocationStart.Text = TextBox_LocationStartSearch.Text;
                Label_LocationDestination.Text = TextBox_LocationDestinationSearch.Text;
                Label_LocationStart.ForeColor = Color.Green;
                Label_LocationDestination.ForeColor = Color.Green;
                Label_Distance.ForeColor = Color.Green;
                int num = 5;
                if (Assets.Variables.UtilsFunction.Start_id_province == 1 || Assets.Variables.UtilsFunction.Start_id_province == 48 || Assets.Variables.UtilsFunction.Start_id_province == 79)
                    num = 20;
                Label_Distance.Text = (Assets.Variables.StringProcessing.MeterToKilometer(
                    Assets.Variables.UtilsFunction.distanceLocation(
                    Assets.Variables.UtilsFunction.Start_location_lat,
                    Assets.Variables.UtilsFunction.Start_location_long,
                    Assets.Variables.UtilsFunction.End_location_lat,
                    Assets.Variables.UtilsFunction.End_location_long)) + Assets.Variables.UtilsFunction.randomDouble(num)).ToString() + "km";

                double distance = Convert.ToDouble(Label_Distance.Text.Remove(Label_Distance.Text.Length - 2).ToString());
                int min_cost = 0;
                int max_cost = 0;
                if (distance < 200.0)
                {
                    min_cost = 200;
                    max_cost = 400;
                }
                else if (distance < 800.0)
                {
                    min_cost = 400;
                    max_cost = 600;
                }
                else if (distance < 2000.0)
                {
                    min_cost = 600;
                    max_cost = 800;
                }
                else
                {
                    min_cost = 600;
                    max_cost = 800;
                }

                // Web browser

                string start = Assets.Variables.StringProcessing.convertToUnSign3(TextBox_LocationStartSearch.Text);
                string end = Assets.Variables.StringProcessing.convertToUnSign3(TextBox_LocationDestinationSearch.Text);
                string url = string.Format($"https://www.google.com/maps/dir/" +
                    $"{start}/" +
                    $"{end}");
                WebBrowser_GoogleMap.Navigate(url);

                // Transport Services
                FlowLayoutPanel_TransportServices.Controls.Clear();

                //int num_vehicles = 5;
                //switch (Assets.Variables.UtilsFunction.Start_id_province)
                //{
                //    case 1: case 79:
                //        if (Label_ServiceName.Text == "GrabCar")
                //            num_vehicles = 8;
                //        else if (Label_ServiceName.Text == "GrabBike")
                //            num_vehicles = 5;
                //        break;
                //    default:
                //        if (Label_ServiceName.Text == "GrabCar")
                //            num_vehicles = 5;
                //        else if (Label_ServiceName.Text == "GrabBike")
                //            num_vehicles = 4;
                //        break;
                //}

                switch (Label_ServiceName.Text)
                {
                    case "GrabCar":
                        query = $"select * from GRAB_CAR where GRAB_CAR_ID_PROVINCE = {Assets.Variables.UtilsFunction.Start_id_province} " +
                            $"and GRAB_CAR_COST < {max_cost} and GRAB_CAR_COST > {min_cost}";
                        break;
                    case "GrabBike":
                        query = $"select * from GRAB_BIKE where GRAB_BIKE_ID_PROVINCE = {Assets.Variables.UtilsFunction.Start_id_province} " +
                            $"and GRAB_BIKE_COST < {max_cost} and GRAB_BIKE_COST > {min_cost}";
                        break;
                    case "JustGrab":
                        query = $"select * from GRAB_CAR where GRAB_CAR_ID_PROVINCE = {Assets.Variables.UtilsFunction.Start_id_province} " +
                            $"and GRAB_CAR_COST < {max_cost} and GRAB_CAR_COST > {min_cost} and GRAB_CAR_SEATS = 4 order by GRAB_CAR_COST asc";
                        break;
                    default:
                        query = $"select * from GRAB_CAR where GRAB_CAR_ID_PROVINCE = {Assets.Variables.UtilsFunction.Start_id_province} " +
                            $"and GRAB_CAR_COST < {max_cost} and GRAB_CAR_COST > {min_cost}";
                        break;
                }

                DataTable dt = provider.ExecuteQuery(query);
                if (Label_ServiceName.Text == "GrabCar" || Label_ServiceName.Text == "GrabBike")
                {
                    FlowLayoutPanel_TransportServices.Visible = true;
                    Panel_JustGrab.Visible = false;
                    foreach (DataRow row in dt.Rows)
                    {
                        Bitmap myImage = (Bitmap)Assets.Variables.ResourcesManager.rm_grab_transport.GetObject(Label_ServiceName.Text);
                        Control_GrabTransportService item = new Control_GrabTransportService(
                            Convert.ToDouble(Label_Distance.Text.Remove(Label_Distance.Text.Length - 2).ToString()),
                            Label_ServiceName.Text,
                            myImage,
                            row
                        );
                        FlowLayoutPanel_TransportServices.Controls.Add(item);
                    }
                    FlowLayoutPanel_TransportServices.Visible = true;
                }
                else
                {
                    dt_just_grab = dt;
                    if (dt.Rows.Count > 0)
                    {
                        FlowLayoutPanel_TransportServices.Visible = false;
                        Panel_JustGrab.Visible = true;
                        Label_DriverName_JustGrab.Text = dt.Rows[0]["GRAB_CAR_DRIVER_NAME"].ToString();
                        Label_DriverAge_JustGrab.Text = dt.Rows[0]["GRAB_CAR_DRIVER_AGE"].ToString();
                        Label_ServiceCategory_JustGrab.Text = Label_ServiceName.Text;
                        Label_Seats_JustGrab.Text = dt.Rows[0]["GRAB_CAR_SEATS"].ToString();
                        Label_Cost_JustGrab.Text = dt.Rows[0]["GRAB_CAR_COST"].ToString() + ".000";
                        Label_WaitingTime.Text = dt.Rows[0]["GRAB_CAR_START"].ToString() + " - " + dt.Rows[0]["GRAB_CAR_END"].ToString() + " mins";
                    }
                }
            }
        }

        private void Load_Recommendation(FlowLayoutPanel flp, string location, int num_id)
        {
            string query = $"SELECT PROVINCE_CODE, A.WARDS_CODE as WARDS_CODE, A.LOCATION as LOCATION_RECOMMEDATION, PROVINCE_LATITUDE, PROVINCE_LONGITUDE FROM " +
                           $"( " +
                               $"SELECT " +
                                   $"WARDS.WARDS_CODE, " +
                                   $"PROVINCES.PROVINCE_CODE, " + 
                                   $"PROVINCES.PROVINCE_LATITUDE, " +
                                   $"PROVINCES.PROVINCE_LONGITUDE, " +
                                   $"CONCAT(WARDS.WARDS_NAME,', ',DISTRICTS.DISTRICTS_NAME, ', ', PROVINCES.PROVINCE_NAME) as LOCATION, " +
                                   $"CONCAT(WARDS.WARDS_CODE_NAME,', ',DISTRICTS.DISTRICTS_CODE_NAME, ', ', PROVINCES.PROVINCE_CODE_NAME) as LOCATION_CODE_A, " +
                                   $"CONCAT(WARDS.WARDS_CODE_NAME,', ',PROVINCES.PROVINCE_CODE_NAME, ', ', DISTRICTS.DISTRICTS_CODE_NAME) as LOCATION_CODE_B, " +
                                   $"CONCAT(DISTRICTS.DISTRICTS_CODE_NAME,', ',WARDS.WARDS_CODE_NAME, ', ', PROVINCES.PROVINCE_CODE_NAME) as LOCATION_CODE_C, " +
                                   $"CONCAT(PROVINCES.PROVINCE_CODE_NAME,', ',WARDS.WARDS_CODE_NAME, ', ', DISTRICTS.DISTRICTS_CODE_NAME) as LOCATION_CODE_D, " +
                                   $"CONCAT(DISTRICTS.DISTRICTS_CODE_NAME,', ',PROVINCES.PROVINCE_CODE_NAME, ', ', WARDS.WARDS_CODE_NAME) as LOCATION_CODE_E, " +
                                   $"CONCAT(PROVINCES.PROVINCE_CODE_NAME,', ',DISTRICTS.DISTRICTS_CODE_NAME, ', ', WARDS.WARDS_CODE_NAME) as LOCATION_CODE_F " +
                               $"FROM PROVINCES " +
                               $"JOIN DISTRICTS " +
                                   $"ON PROVINCES.PROVINCE_CODE = DISTRICTS.PROVINCE_CODE " +
                               $"JOIN WARDS " +
                                   $"ON DISTRICTS.DISTRICTS_CODE = WARDS.DISTRICTS_CODE " +
                           $") A " +
                           $"WHERE A.LOCATION_CODE_A like N'%{location}%' " +
                               $"or A.LOCATION_CODE_B like N'%{location}%' " +
                               $"or A.LOCATION_CODE_C like N'%{location}%' " +
                               $"or A.LOCATION_CODE_D like N'%{location}%' " +
                               $"or A.LOCATION_CODE_E like N'%{location}%' " +
                               $"or A.LOCATION_CODE_F like N'%{location}%'";
            DataTable recommendation_location = provider.ExecuteQuery(query);
            flp.Controls.Clear();

            if (recommendation_location.Rows.Count == 0)
            {
                flp.Visible = false;
            }
            else
            {
                flp.Visible = true;

                foreach (DataRow row in recommendation_location.Rows)
                {
                    Control_Item_Recommendation item = new Control_Item_Recommendation(
                        num_id,
                        row
                    );
                    flp.Controls.Add(item);
                }
            }
        }

        private void TextBox_LocationStartSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == (char)13)
                Load_Recommendation(Panel_Recommendation1, Assets.Variables.StringProcessing.convertToUnSign3(TextBox_LocationStartSearch.Text), 1);
        }

        private void TextBox_LocationDestinationSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == (char)13)
                Load_Recommendation(Panel_Recommendation2, Assets.Variables.StringProcessing.convertToUnSign3(TextBox_LocationDestinationSearch.Text), 2);
        }

        public void Alert(string msg, Notification_Form.enmType type)
        {
            Notification_Form frm = new Notification_Form();
            frm.showAlert(msg, type);
        }

        private void Button_4_JustGrab_Click(object sender, EventArgs e)
        {
            double distance = Convert.ToDouble(Label_Distance.Text.Remove(Label_Distance.Text.Length - 2).ToString());
            int min_cost = 0;
            int max_cost = 0;
            if (distance < 200.0)
            {
                min_cost = 200;
                max_cost = 400;
            }
            else if (distance < 800.0)
            {
                min_cost = 400;
                max_cost = 600;
            }
            else if (distance < 2000.0)
            {
                min_cost = 600;
                max_cost = 800;
            }
            else
            {
                min_cost = 600;
                max_cost = 800;
            }
            string query = $"select * from GRAB_CAR where GRAB_CAR_ID_PROVINCE = {Assets.Variables.UtilsFunction.Start_id_province} " +
                            $"and GRAB_CAR_COST < {max_cost} and GRAB_CAR_COST > {min_cost} and GRAB_CAR_SEATS = 4 order by GRAB_CAR_COST asc";
            dt_just_grab = provider.ExecuteQuery(query);
            if (dt_just_grab.Rows.Count > 0)
            {
                FlowLayoutPanel_TransportServices.Visible = false;
                Panel_JustGrab.Visible = true;
                Label_DriverName_JustGrab.Text = dt_just_grab.Rows[0]["GRAB_CAR_DRIVER_NAME"].ToString();
                Label_DriverAge_JustGrab.Text = dt_just_grab.Rows[0]["GRAB_CAR_DRIVER_AGE"].ToString();
                Label_ServiceCategory_JustGrab.Text = Label_ServiceName.Text;
                Label_Seats_JustGrab.Text = dt_just_grab.Rows[0]["GRAB_CAR_SEATS"].ToString();
                Label_Cost_JustGrab.Text = dt_just_grab.Rows[0]["GRAB_CAR_COST"].ToString() + ".000";
                Label_WaitingTime.Text = dt_just_grab.Rows[0]["GRAB_CAR_START"].ToString() + " - " + dt_just_grab.Rows[0]["GRAB_CAR_END"].ToString() + " mins";
            }
        }

        private void Button_7_JustGrab_Click(object sender, EventArgs e)
        {
            double distance = Convert.ToDouble(Label_Distance.Text.Remove(Label_Distance.Text.Length - 2).ToString());
            int min_cost = 0;
            int max_cost = 0;
            if (distance < 200.0)
            {
                min_cost = 200;
                max_cost = 400;
            }
            else if (distance < 800.0)
            {
                min_cost = 400;
                max_cost = 600;
            }
            else if (distance < 2000.0)
            {
                min_cost = 600;
                max_cost = 800;
            }
            else
            {
                min_cost = 600;
                max_cost = 800;
            }
            string query = $"select * from GRAB_CAR where GRAB_CAR_ID_PROVINCE = {Assets.Variables.UtilsFunction.Start_id_province} " +
                            $"and GRAB_CAR_COST < {max_cost} and GRAB_CAR_COST > {min_cost} and GRAB_CAR_SEATS = 7 order by GRAB_CAR_COST asc";
            dt_just_grab = provider.ExecuteQuery(query);
            if (dt_just_grab.Rows.Count > 0)
            {
                FlowLayoutPanel_TransportServices.Visible = false;
                Panel_JustGrab.Visible = true;
                Label_DriverName_JustGrab.Text = dt_just_grab.Rows[0]["GRAB_CAR_DRIVER_NAME"].ToString();
                Label_DriverAge_JustGrab.Text = dt_just_grab.Rows[0]["GRAB_CAR_DRIVER_AGE"].ToString();
                Label_ServiceCategory_JustGrab.Text = Label_ServiceName.Text;
                Label_Seats_JustGrab.Text = dt_just_grab.Rows[0]["GRAB_CAR_SEATS"].ToString();
                Label_Cost_JustGrab.Text = dt_just_grab.Rows[0]["GRAB_CAR_COST"].ToString() + ".000";
                Label_WaitingTime.Text = dt_just_grab.Rows[0]["GRAB_CAR_START"].ToString() + " - " + dt_just_grab.Rows[0]["GRAB_CAR_END"].ToString() + " mins";
            }
        }

        private void Button_Booking_JustGrab_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Confirm_Booking(Convert.ToDouble(Label_Distance.Text.Remove(Label_Distance.Text.Length - 2).ToString()), "JustGrab", dt_just_grab.Rows[0]));
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