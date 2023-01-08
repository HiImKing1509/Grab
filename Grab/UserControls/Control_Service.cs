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
    public partial class Control_Service : UserControl
    {
        public Control_Service()
        {
            InitializeComponent();
        }

        public Control_Service(DataRow dr) : this()
        {
            Label_ServiceName.Text = dr["GRAB_CATEGORY_NAME"].ToString().ToUpper();
            Label_ServiceDescription.Text = dr["GRAB_CATEGORY_DESCRIPTION"].ToString();
        }
    }
}
