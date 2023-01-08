using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grab.UserControls
{
    public partial class Control_Item_Recommendation : UserControl
    {
        int num = 0;
        double lat = 0.0;
        double lon = 0.0;
        int num_id_province = 0;
        public Control_Item_Recommendation()
        {
            // InitializeComponent();
        }

        public Control_Item_Recommendation(int num_id, DataRow dr) : this()
        {
            InitializeComponent();
            Label_Location.Text = dr["LOCATION_RECOMMEDATION"].ToString();
            PictureBox_Image.Name = dr["WARDS_CODE"].ToString();
            lat = Convert.ToDouble(dr["PROVINCE_LATITUDE"].ToString());
            lon = Convert.ToDouble(dr["PROVINCE_LONGITUDE"].ToString());
            num_id_province = Convert.ToInt16(dr["PROVINCE_CODE"].ToString());
            num = num_id;
        }

        private void Control_Item_Recommendation_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Gainsboro;
        }

        private void Control_Item_Recommendation_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void Label_Location_Click(object sender, EventArgs e)
        {
            if (num == 1)
            {
                Screens.Form_Booking.form_booking.tbx1.Text = Label_Location.Text;
                Assets.Variables.UtilsFunction.Start_location = Label_Location.Text;
                Assets.Variables.UtilsFunction.Start_location_lat = lat;
                Assets.Variables.UtilsFunction.Start_location_long = lon;
                Assets.Variables.UtilsFunction.Start_id_province = num_id_province;
            }
            else
            {
                Screens.Form_Booking.form_booking.tbx2.Text = Label_Location.Text;
                Assets.Variables.UtilsFunction.End_location = Label_Location.Text;
                Assets.Variables.UtilsFunction.End_location_lat = lat;
                Assets.Variables.UtilsFunction.End_location_long = lon;
            }
        }
    }
}
