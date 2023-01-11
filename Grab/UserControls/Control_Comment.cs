using FontAwesome.Sharp;
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
    public partial class Control_Comment : UserControl
    {
        public Control_Comment()
        {
            // InitializeComponent();
        }

        public Control_Comment(DataRow row) : this()
        {
            InitializeComponent();
            Label_Name.Text = row["CUSTOMER_NAME"].ToString();
            Label_Time.Text = row["COMMENT_TIME"].ToString();
            Label_Content.Text = row["COMMENT_CONTENT"].ToString();

            foreach (IconButton item in FlowLayoutPanel_Stars.Controls)
            {
                if (Convert.ToInt16(item.Name.Substring(1)) <= Convert.ToInt16(row["COMMENT_RATE"]))
                    item.IconColor = Assets.Variables.Colors.MetallicYellow;
                else
                    item.IconColor = Color.Black;
            }
        }
    }
}
