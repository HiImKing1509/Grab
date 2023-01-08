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
    public partial class Control_GrabTransportService : UserControl
    {
        public Control_GrabTransportService()
        {
            // InitializeComponent();
        }

        public Control_GrabTransportService(Bitmap image, DataRow dr)
        {
            InitializeComponent();
            PictureBox_Image.Image = image;
            Label_Name.Text = dr["GRAB_CAR_NAME"].ToString();
            Label_Seat.Text = dr["GRAB_CAR_SEATS"].ToString() + " seats";
            Label_Cost.Text = dr["GRAB_CAR_COST"].ToString() + ".000";
            Label_Time.Text = dr["GRAB_CAR_START"].ToString() + " - " + dr["GRAB_CAR_END"].ToString() + "mins";
        }

        private void Control_GrabTransportService_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Assets.Variables.Colors.MintGreen;
        }

        private void Control_GrabTransportService_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Assets.Variables.Colors.White;
        }
    }
}
