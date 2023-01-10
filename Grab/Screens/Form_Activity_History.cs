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
        public static Form_Activity_History form_history;
        public Label label_name_driver;
        public Label label_age_driver;
        public Label label_service;
        public Label label_seats;
        public Label label_number_service;
        public Label label_cost;
        public Label label_location_start;
        public Label label_location_destination;

        public Form_Activity_History()
        {
            InitializeComponent();
            LoadHistory("GrabCar");
            form_history = this;
            label_name_driver = Label_DriverName;
            label_age_driver = Label_DriverAge;
            label_service = Label_ServiceCategory;
            label_seats = Label_Seats;
            label_number_service = Label_NumberService;
            label_cost = Label_Cost;
            label_location_start = Label_LocationStart;
            label_location_destination = Label_LocationDestination;
        }

        private void LoadHistory(string service)
        {
            FlowLayoutPanel_LoadHistory.Controls.Clear();
            string query = "";
            switch (service)
            {
                case "GrabCar":
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
    }
}
