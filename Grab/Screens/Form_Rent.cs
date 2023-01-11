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
    public partial class Form_Rent : Form
    {
        DataProvider provider = new DataProvider();
        string _service = "";
        int _seats = 0;
        private Form activeForm = null;
        public static Form_Rent form_rent;
        public Label label_location;
        public TextBox tbsearch;
        public Form_Rent()
        {
            InitializeComponent();
            Panel_SearchLocation.BottomColor = Assets.Variables.Colors.ForestGreen;
            Panel_SearchLocation.TopColor = Assets.Variables.Colors.White;
            form_rent = this;
            label_location = Label_Location;
            tbsearch = TextBox_LocationStartSearch;
        }

        private void TextBox_LocationStartSearch_Enter(object sender, EventArgs e)
        {
            if (TextBox_LocationStartSearch.Text == "Địa điểm ..." && TextBox_LocationStartSearch.ForeColor == Color.Silver)
            {
                TextBox_LocationStartSearch.Text = "";
                TextBox_LocationStartSearch.ForeColor = Color.Black;
            }
        }

        private void TextBox_LocationStartSearch_Leave(object sender, EventArgs e)
        {
            if (TextBox_LocationStartSearch.Text == "")
            {
                TextBox_LocationStartSearch.Text = "Địa điểm ...";
                TextBox_LocationStartSearch.ForeColor = Color.Silver;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Assets.Variables.Colors.MintGreen;
            panel3.BackColor = Assets.Variables.Colors.White;
            panel4.BackColor = Assets.Variables.Colors.White;
            Label_ServiceCategory.Text = iconButton1.Text;
            Label_ServiceCategory.ForeColor = Color.Green;
            _service = "GrabCar";
            _seats = 4;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Assets.Variables.Colors.White;
            panel3.BackColor = Assets.Variables.Colors.MintGreen;
            panel4.BackColor = Assets.Variables.Colors.White;
            Label_ServiceCategory.Text = iconButton2.Text;
            Label_ServiceCategory.ForeColor = Color.Green;
            _service = "GrabCar";
            _seats = 7;
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Assets.Variables.Colors.White;
            panel3.BackColor = Assets.Variables.Colors.White;
            panel4.BackColor = Assets.Variables.Colors.MintGreen;
            Label_ServiceCategory.Text = iconButton4.Text;
            Label_ServiceCategory.ForeColor = Color.Green;
            _service = "GrabBike";
            _seats = 0;
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            Label_RentTime.Text = label2.Text;
            Label_Cost.Text = label11.Text;
            Label_RentTime.ForeColor = Color.Green;
            Label_Cost.BackColor = Color.Green;
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            Label_RentTime.Text = label12.Text;
            Label_Cost.Text = label13.Text;
            Label_RentTime.ForeColor = Color.Green;
            Label_Cost.BackColor = Color.Green;

        }

        private void panel9_Click(object sender, EventArgs e)
        {
            Label_RentTime.Text = label14.Text;
            Label_Cost.Text = label15.Text;
            Label_RentTime.ForeColor = Color.Green;
            Label_Cost.BackColor = Color.Green;

        }

        private void panel10_Click(object sender, EventArgs e)
        {
            Label_RentTime.Text = label16.Text;
            Label_Cost.Text = label18.Text;
            Label_RentTime.ForeColor = Color.Green;
            Label_Cost.BackColor = Color.Green;
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            Label_RentTime.Text = label19.Text;
            Label_Cost.Text = label20.Text;
            Label_RentTime.ForeColor = Color.Green;
            Label_Cost.BackColor = Color.Green;
        }

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Assets.Variables.Colors.MintGreen;

        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Assets.Variables.Colors.White;

        }

        private void TextBox_LocationStartSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == (char)13)
                Load_Recommendation(Panel_Recommendation1, Assets.Variables.StringProcessing.convertToUnSign3(TextBox_LocationStartSearch.Text), 3);
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

        private void Form_Rent_Click(object sender, EventArgs e)
        {
            Panel_Recommendation1.Visible = false;
        }

        private void Button_ServiceQuery_Click(object sender, EventArgs e)
        {
            string query = $"select * from RENT_CAR where SERVICE_CATEGORY = '{_service}' and SERVICE_NUMBER_SEATS = {_seats} and STATUS_RENT = 0 and PROVINCE_CODE = '{Assets.Variables.UtilsFunction.Rent_id_province}'";
            DataTable dt = provider.ExecuteQuery(query);

            if (dt.Rows.Count > 0) 
            {
                Label_NumberService.Text = dt.Rows[0]["SERVICE_NUMBER_CAR"].ToString();
                Label_NumberService.ForeColor = Color.Green;
                Button_ConfirmRent.Visible = true;
            }
        }

        private void Button_ConfirmRent_Click(object sender, EventArgs e)
        {
            string query = $"INSERT INTO RENT_CAR_HISTORY (CUSTOMER_ID, SERVICE_NUMBER_CAR, SERVICE_TIME, SERVICE_TIME_RENT, SERVICE_COST) VALUES " +
                $"('{Assets.Variables.Account.DataTableAccount.Rows[0]["CUSTOMER_PHONE_NUMBER"]}', '{Label_NumberService.Text}', '{DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss tt")}', {Label_RentTime.Text.Remove(Label_RentTime.Text.Length - 4)}, {Label_Cost.Text.Remove(Label_Cost.Text.Length - 4)});";
            int a = provider.ExecuteNonQuery(query);

            query = $"update RENT_CAR set STATUS_RENT = 1 where SERVICE_NUMBER_CAR = '{Label_NumberService.Text}'";
            a = provider.ExecuteNonQuery(query);
            openChildForm(new Form_Rent());
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
