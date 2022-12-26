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
    public partial class Control_Item_Service : UserControl
    {
        public Control_Item_Service()
        {
            //InitializeComponent();
        }

        public Control_Item_Service(Bitmap image, DataRow dr) : this()
        {
            InitializeComponent();
            PictureBox_Images.Image = image;
            Label_Name.Text = dr["GRAB_SERVICE_NAME"].ToString();
        }
    }
}
