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
    public partial class Form_Rent_History : Form
    {
        DataProvider provider = new DataProvider();
        public static Form_Rent_History form_rent;
        public Label label_name_service;
        public Label label_service;
        public Label label_seats;
        public Label label_number_service;
        public Label label_timerent;
        public Label label_cost;
        public Label label_time;
        public Form_Rent_History()
        {
            InitializeComponent();
            Panel_SearchLocation.BottomColor = Assets.Variables.Colors.ForestGreen;
            Panel_SearchLocation.TopColor = Assets.Variables.Colors.White;
            form_rent = this;
            label_name_service = Label_NameService;
            label_service = Label_ServiceCategory;
            label_seats = Label_Seats;
            label_number_service = Label_NumberService;
            label_timerent = Label_TimeRent;
            label_cost = Label_Cost;
            label_time = Label_Time;

            LoadRentHistory();
        }

        private void LoadRentHistory()
        {
            FlowLayoutPanel_LoadHistory.Controls.Clear();
            string query = $"select * from RENT_CAR_HISTORY join RENT_CAR on RENT_CAR_HISTORY.SERVICE_NUMBER_CAR = RENT_CAR.SERVICE_NUMBER_CAR where RENT_CAR_HISTORY.CUSTOMER_ID = '{Assets.Variables.Account.DataTableAccount.Rows[0]["CUSTOMER_PHONE_NUMBER"]}' order by SERVICE_TIME desc";
            DataTable dt = provider.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                query = $"select * from PROVINCES where PROVINCE_CODE = '{row["PROVINCE_CODE"]}'";
                DataTable _dt = provider.ExecuteQuery(query);
                Bitmap myImage = (Bitmap)Assets.Variables.ResourcesManager.rm_grab_transport.GetObject(row["SERVICE_CATEGORY"].ToString());
                Control_Rent_History item = new Control_Rent_History(
                    myImage,
                    _dt.Rows[0]["PROVINCE_NAME"].ToString(),
                    row
                );
                FlowLayoutPanel_LoadHistory.Controls.Add(item);
            }
        }

        private void LoadInStatus()
        {
            FlowLayoutPanel_LoadHistory.Controls.Clear();
            string query = $"select * from RENT_CAR_HISTORY join RENT_CAR on RENT_CAR_HISTORY.SERVICE_NUMBER_CAR = RENT_CAR.SERVICE_NUMBER_CAR where RENT_CAR_HISTORY.CUSTOMER_ID = '{Assets.Variables.Account.DataTableAccount.Rows[0]["CUSTOMER_PHONE_NUMBER"]}' and STATUS_RENT = 1 order by SERVICE_TIME desc";
            DataTable dt = provider.ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                query = $"select * from PROVINCES where PROVINCE_CODE = '{row["PROVINCE_CODE"]}'";
                DataTable _dt = provider.ExecuteQuery(query);
                Bitmap myImage = (Bitmap)Assets.Variables.ResourcesManager.rm_grab_transport.GetObject(row["SERVICE_CATEGORY"].ToString());
                Control_Rent_History item = new Control_Rent_History(
                    myImage,
                    _dt.Rows[0]["PROVINCE_NAME"].ToString(),
                    row
                );
                FlowLayoutPanel_LoadHistory.Controls.Add(item);
            }
        }

        private void Button_GrabCar_Click(object sender, EventArgs e)
        {
            LoadRentHistory();
        }

        private void Button_Instatus_Click(object sender, EventArgs e)
        {
            LoadInStatus();
        }
    }
}
