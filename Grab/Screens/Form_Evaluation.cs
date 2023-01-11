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
using static System.Net.WebRequestMethods;

namespace Grab.Screens
{
    public partial class Form_Evaluation : Form
    {
        DataProvider provider = new DataProvider();
        public static Form_Evaluation form_evaluation;
        public TextBox tb1;
        public FlowLayoutPanel flp;
        public Form_Evaluation()
        {
            InitializeComponent();

            form_evaluation = this;
            tb1 = TextBox_Province;
            flp = Panel_Recommendation1;

            Panel_SearchLocation.BottomColor = Assets.Variables.Colors.ForestGreen;
            Panel_SearchLocation.TopColor = Assets.Variables.Colors.White;
        }

        private void Button_ServiceCategory_Click(object sender, EventArgs e)
        {
            if (Button_ServiceCategory.Text == "GrabCar")
            {
                Button_ServiceCategory.Text = "GrabBike";
                Label_ServiceCategory.Text = "GrabBike";
                Bitmap myImage = (Bitmap)Assets.Variables.ResourcesManager.rm_grab_transport.GetObject("GrabBike");
                Picture_ServiceCategory.Image = myImage;
                Button_ServiceCategory.BackColor = Assets.Variables.Colors.UERed;
            }
            else
            {
                Button_ServiceCategory.Text = "GrabCar";
                Label_ServiceCategory.Text = "GrabCar";
                Bitmap myImage = (Bitmap)Assets.Variables.ResourcesManager.rm_grab_transport.GetObject("GrabCar");
                Picture_ServiceCategory.Image = myImage;
                Button_ServiceCategory.BackColor = Color.Green;
            }
            panel1.Visible = false;
        }

        private void TextBox_Province_Enter(object sender, EventArgs e)
        {
            if (TextBox_Province.Text == "Tỉnh, thành ..." && TextBox_Province.ForeColor == Color.Silver)
            {
                TextBox_Province.Text = "";
                TextBox_Province.ForeColor = Color.Black;
            }
        }

        private void TextBox_Province_Leave(object sender, EventArgs e)
        {
            Panel_Recommendation1.Visible = false;
            if (TextBox_Province.Text == "")
            {
                TextBox_Province.Text = "Tỉnh, thành ...";
                TextBox_Province.ForeColor = Color.Silver;
            }
        }

        private void TextBox_Province_TextChanged(object sender, EventArgs e)
        {
            string query = $"select * from PROVINCES where PROVINCE_CODE_NAME like N'%{Assets.Variables.StringProcessing.convertToUnSign3(TextBox_Province.Text)}%'";
            DataTable dt_province = provider.ExecuteQuery(query);

            Panel_Recommendation1.Controls.Clear();

            if (dt_province.Rows.Count == 0)
            {
                Panel_Recommendation1.Visible = false;
            }
            else
            {
                Panel_Recommendation1.Visible = true;

                foreach (DataRow row in dt_province.Rows)
                {
                    Control_Province item = new Control_Province(
                        row
                    );
                    Panel_Recommendation1.Controls.Add(item);
                }
            }
        }

        private void Button_Search_Click(object sender, EventArgs e)
        {
            string query = "";
            if (Label_ServiceCategory.Text == "GrabCar")
            {
                query = $"select * from GRAB_CAR where GRAB_CAR_ID_PROVINCE = {Assets.Variables.UtilsFunction.Evaluation_id_province}";
            }
            else
                query = $"select * from GRAB_BIKE where GRAB_BIKE_ID_PROVINCE = {Assets.Variables.UtilsFunction.Evaluation_id_province}";
            FLP_LoadDriver.Controls.Clear();

            DataTable dt_driver = provider.ExecuteQuery(query);
            foreach (DataRow row in dt_driver.Rows)
            {
                Control_Driver item = new Control_Driver(
                    Label_ServiceCategory.Text,
                    row
                );
                FLP_LoadDriver.Controls.Add(item);
            }
            panel1.Visible = true;
        }

        private void TextBox_DriverName_TextChanged(object sender, EventArgs e)
        {
            string query = "";
            if (Label_ServiceCategory.Text == "GrabCar")
            {
                query = $"select * from GRAB_CAR where GRAB_CAR_ID_PROVINCE = {Assets.Variables.UtilsFunction.Evaluation_id_province} and GRAB_CAR_DRIVER_NAME like N'%{TextBox_DriverName.Text}%'";
            }
            else
                query = $"select * from GRAB_BIKE where GRAB_BIKE_ID_PROVINCE = {Assets.Variables.UtilsFunction.Evaluation_id_province} and GRAB_BIKE_DRIVER_NAME like N'%{TextBox_DriverName.Text}%'";
            FLP_LoadDriver.Controls.Clear();

            DataTable dt_driver = provider.ExecuteQuery(query);
            foreach (DataRow row in dt_driver.Rows)
            {
                Control_Driver item = new Control_Driver(
                    Label_ServiceCategory.Text,
                    row
                );
                FLP_LoadDriver.Controls.Add(item);
            }
        }
    }
}
