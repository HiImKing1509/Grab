using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grab.UserControls
{
    public partial class Control_Rent_History : UserControl
    {
        DataRow _row = null;
        string _province_name;
        public Control_Rent_History()
        {
            // InitializeComponent();
        }

        public Control_Rent_History(Bitmap image, string province_name,DataRow row) : this()
        {
            InitializeComponent();
            _row = row;
            _province_name = province_name;
            PictureBox_Image.Image = image;
            Label_Name.Text = row["SERVICE_CATEGORY"].ToString() + " " + _province_name;
            label1.Text = row["SERVICE_NUMBER_CAR"].ToString();
            Label_Time.Text = row["SERVICE_TIME"].ToString();
            Label_TimeRent.Text = row["SERVICE_TIME_RENT"].ToString() + " hours";
        }

        private void Control_Rent_History_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Assets.Variables.Colors.MintGreen;
        }

        private void Control_Rent_History_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Assets.Variables.Colors.White;
        }

        private void Control_Rent_History_Click(object sender, EventArgs e)
        {
            Screens.Form_Rent_History.form_rent.label_name_service.Text = _row["SERVICE_CATEGORY"].ToString().ToUpper() + " " + _province_name.ToUpper();
            Screens.Form_Rent_History.form_rent.label_service.Text = _row["SERVICE_CATEGORY"].ToString();
            Screens.Form_Rent_History.form_rent.label_seats.Text = _row["SERVICE_NUMBER_SEATS"].ToString() + " seats";
            Screens.Form_Rent_History.form_rent.label_number_service.Text = _row["SERVICE_NUMBER_CAR"].ToString();
            Screens.Form_Rent_History.form_rent.label_timerent.Text = _row["SERVICE_TIME_RENT"].ToString();
            Screens.Form_Rent_History.form_rent.label_cost.Text = _row["SERVICE_COST"].ToString() + ".000";
            Screens.Form_Rent_History.form_rent.label_time.Text = _row["SERVICE_TIME"].ToString();
        }
    }
}
