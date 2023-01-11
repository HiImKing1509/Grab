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
    public partial class Control_Province : UserControl
    {
        int id = 0;
        public Control_Province()
        {
            // InitializeComponent();
        }

        public Control_Province(DataRow row) : this()
        {
            InitializeComponent();
            id = Convert.ToInt16(row["PROVINCE_CODE"].ToString());
            Label_Location.Text = row["PROVINCE_NAME"].ToString();
        }

        private void Control_Province_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.Gainsboro;
        }

        private void Control_Province_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        private void Control_Province_Click(object sender, EventArgs e)
        {
            Screens.Form_Evaluation.form_evaluation.tb1.Text = Label_Location.Text;
            Screens.Form_Evaluation.form_evaluation.flp.Visible = false;
            Assets.Variables.UtilsFunction.Evaluation_id_province = id;
        }

        private void Control_Province_MouseClick(object sender, MouseEventArgs e)
        {
            Screens.Form_Evaluation.form_evaluation.tb1.Text = Label_Location.Text;
            Screens.Form_Evaluation.form_evaluation.flp.Visible = false;
            Assets.Variables.UtilsFunction.Evaluation_id_province = id;
        }
    }
}
