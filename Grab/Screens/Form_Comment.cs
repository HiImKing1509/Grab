using Grab.Database.DAO;
using Grab.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grab.Screens
{
    public partial class Form_Comment : Form
    {
        DataProvider provider = new DataProvider();
        public Form_Comment()
        {
            // InitializeComponent();
        }

        public Form_Comment(string service, DataRow row) : this()
        {
            InitializeComponent();
            if (service == "GrabCar")
            {
                Label_DriverName.Text = row["GRAB_CAR_DRIVER_NAME"].ToString();
                Label_DriverAge.Text = row["GRAB_CAR_DRIVER_AGE"].ToString() + " tuổi";
                Label_Service.Text = row["GRAB_CAR_NAME"].ToString();
                Label_Number_Drive.Text = row["GRAB_CAR_NUMBER"].ToString();
                Picture_Avt.Name = row["GRAB_CAR_ID"].ToString();
            }
            else
            {
                Label_DriverName.Text = row["GRAB_BIKE_DRIVER_NAME"].ToString();
                Label_DriverAge.Text = row["GRAB_BIKE_DRIVER_AGE"].ToString() + " tuổi";
                Label_Service.Text = row["GRAB_BIKE_NAME"].ToString();
                Label_Number_Drive.Text = row["GRAB_BIKE_NUMBER"].ToString();
                Picture_Avt.Name = row["GRAB_BIKE_ID"].ToString();
            }
            LoadComments();
        }

        private void Button_BackTo_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form_Evaluation>().First().Show();
            Close();
        }

        private void TextBox_Rate_TextChanged(object sender, EventArgs e)
        {
            if ((TextBox_Rate.Text != "1" 
                && TextBox_Rate.Text != "2"
                && TextBox_Rate.Text != "3"
                && TextBox_Rate.Text != "4"
                && TextBox_Rate.Text != "5") || textBox1.Text == "")
            {
                Button_OK.BackColor = Assets.Variables.Colors.UERed;
            }
            else
                Button_OK.BackColor = Assets.Variables.Colors.MetallicYellow;
        }

        private void Button_OK_Click(object sender, EventArgs e)
        {
            if (Button_OK.BackColor == Assets.Variables.Colors.MetallicYellow)
            {
                string query = $"insert into COMMENT values ('{Picture_Avt.Name}', '{Assets.Variables.Account.DataTableAccount.Rows[0]["CUSTOMER_PHONE_NUMBER"]}', '{DateTime.Now.ToString("MM-dd-yyyy hh:mm:ss tt")}', N'{textBox1.Text}', {TextBox_Rate.Text});";
                int a = provider.ExecuteNonQuery(query);
                LoadComments();
            }
        }

        private void LoadComments()
        {
            string query = $"select * from COMMENT join CUSTOMER on COMMENT.CUSTOMER_ID = CUSTOMER.CUSTOMER_PHONE_NUMBER where COMMENT.DRIVER_ID = '{Picture_Avt.Name}'";
            DataTable dtComments = provider.ExecuteQuery(query);

            FLP_Comment.Controls.Clear();
            foreach (DataRow row in dtComments.Rows)
            {
                Control_Comment item = new Control_Comment(
                    row
                );
                FLP_Comment.Controls.Add(item);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((TextBox_Rate.Text != "1"
                && TextBox_Rate.Text != "2"
                && TextBox_Rate.Text != "3"
                && TextBox_Rate.Text != "4"
                && TextBox_Rate.Text != "5") || textBox1.Text == "")
            {
                Button_OK.BackColor = Assets.Variables.Colors.UERed;
            }
            else
                Button_OK.BackColor = Assets.Variables.Colors.MetallicYellow;
        }
    }
}
