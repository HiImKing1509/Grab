using FontAwesome.Sharp;
using Grab.Database.DAO;
using Grab.UserControls;
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
    public partial class Form_Activity_History : Form
    {
        DataProvider provider = new DataProvider();

        int num_stars = 0;

        public static Form_Activity_History form_history;
        public Label label_name_driver;
        public Label label_age_driver;
        public Label label_service;
        public Label label_seats;
        public Label label_number_service;
        public Label label_cost;
        public Label label_location_start;
        public Label label_location_destination;
        public Label label_distance;
        public Label label_nameservice;
        public Label label_time;
        public IconButton b1;
        public IconButton b2;
        public IconButton b3;
        public IconButton b4;
        public IconButton b5;
        public FlowLayoutPanel flp_infor;

        public Form_Activity_History()
        {
            InitializeComponent();
            Panel_SearchLocation.BottomColor = Assets.Variables.Colors.ForestGreen;
            Panel_SearchLocation.TopColor = Assets.Variables.Colors.White;
            LoadHistory("GrabCar");
            FlowLayoutPanel_Stars.Visible = false;
            form_history = this;
            label_name_driver = Label_DriverName;
            label_age_driver = Label_DriverAge;
            label_service = Label_ServiceCategory;
            label_seats = Label_Seats;
            label_number_service = Label_NumberService;
            label_cost = Label_Cost;
            label_location_start = Label_LocationStart;
            label_location_destination = Label_LocationDestination;
            label_distance = Label_Distance;
            label_nameservice = Label_NameService;
            label_time = Label_Time;
            b1 = A1;
            b2 = A2;
            b3 = A3;
            b4 = A4;
            b5 = A5;
            flp_infor = FlowLayoutPanel_Stars;
        }

        private void LoadHistory(string service)
        {
            Label_Service.Text = service.ToUpper();
            FlowLayoutPanel_LoadHistory.Controls.Clear();
            string query = "";
            switch (service)
            {
                case "GrabCar": case "JustGrab":
                    query = $"select * " +
                        $"from HISTORY " +
                        $"inner join GRAB_CAR on HISTORY.SERVICE_ID = GRAB_CAR.GRAB_CAR_ID " +
                        $"where HISTORY.SERVICE_ID like 'GC%' and GRAB_CAR.GRAB_CAR_ID_PROVINCE = HISTORY.PROVINCE_ID " +
                        $"order by HISTORY.SERVICE_TIME desc";
                    break;
                case "GrabBike":
                    query = $"select * " +
                        $"from HISTORY " +
                        $"inner join GRAB_BIKE on HISTORY.SERVICE_ID = GRAB_BIKE.GRAB_BIKE_ID " +
                        $"where HISTORY.SERVICE_ID like 'GB%' and GRAB_BIKE.GRAB_BIKE_ID_PROVINCE = HISTORY.PROVINCE_ID " +
                        $"order by HISTORY.SERVICE_TIME desc";
                    break;
                default:
                    query = "";
                    break;
            }
            DataTable dtShowProduct = provider.ExecuteQuery(query);
            foreach (DataRow row in dtShowProduct.Rows)
            {
                Bitmap myImage = (Bitmap)Assets.Variables.ResourcesManager.rm_grab_transport.GetObject(service);
                Control_ActivityHistory item = new Control_ActivityHistory(
                    service,
                    myImage,
                    row
                );
                FlowLayoutPanel_LoadHistory.Controls.Add(item);
            }
        }

        private void Button_GrabCar_Click(object sender, EventArgs e)
        {
            Label_Service.Text = Button_GrabCar.Text.ToUpper();
            Seats.Visible = true;
            LoadHistory(Button_GrabCar.Text);
        }

        private void Button_GrabBike_Click(object sender, EventArgs e)
        {
            Label_Service.Text = Button_GrabBike.Text.ToUpper();
            Seats.Visible = false;
            LoadHistory(Button_GrabBike.Text);
        }

        private void B1_MouseEnter(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            string numberStar = btn.Name.Substring(1);

            foreach (IconButton item in FlowLayoutPanel_Stars.Controls)
            {
                if (Convert.ToInt16(item.Name.Substring(1)) <= Convert.ToInt16(numberStar))
                    item.IconColor = Assets.Variables.Colors.MetallicYellow;
                else
                    item.IconColor = Color.Black;
            }
        }

        private void B1_MouseLeave(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            LoadStars();
        }

        private void LoadStars()
        {
            DataProvider provider = new DataProvider();
            string query = $"select * from HISTORY where CUSTOMER_ID = '{Assets.Variables.Account.DataTableAccount.Rows[0]["CUSTOMER_PHONE_NUMBER"]}' " +
                $"and SERVICE_TIME = '{Label_Time.Text}'";
            DataTable dt = provider.ExecuteQuery(query);

            DataRow dr = dt.Rows[0];

            string numberStar = dr["SERVICE_EVALUATE_SCORE"].ToString();

            foreach (IconButton item in FlowLayoutPanel_Stars.Controls)
            {
                if (Convert.ToInt16(item.Name.Substring(1)) <= Convert.ToInt16(numberStar))
                    item.IconColor = Assets.Variables.Colors.MetallicYellow;
                else
                    item.IconColor = Color.Black;
            }
        }

        private void B1_Click(object sender, EventArgs e)
        {
            IconButton btn = (IconButton)sender;
            DataProvider provider = new DataProvider();
            string query = $"update HISTORY set SERVICE_EVALUATE_SCORE = {btn.Name.Substring(1)} where CUSTOMER_ID = '{Assets.Variables.Account.DataTableAccount.Rows[0]["CUSTOMER_PHONE_NUMBER"]}' " +
                $"and SERVICE_TIME = '{Label_Time.Text}'";
            int a = provider.ExecuteNonQuery(query);
            LoadStars();
            LoadHistory(Label_ServiceCategory.Text);
        }
    }
}
