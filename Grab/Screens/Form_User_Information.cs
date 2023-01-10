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
    public partial class Form_User_Information : Form
    {
        public Form_User_Information()
        {
            InitializeComponent();
            Label_Name.Text = Assets.Variables.Account.DataTableAccount.Rows[0]["CUSTOMER_NAME"].ToString();
            Label_Phone.Text = Assets.Variables.Account.DataTableAccount.Rows[0]["CUSTOMER_PHONE_NUMBER"].ToString();
            Label_Mail.Text = Assets.Variables.Account.DataTableAccount.Rows[0]["CUSTOMER_EMAIL"].ToString();
            Label_Password.Text = Assets.Variables.Account.DataTableAccount.Rows[0]["CUSTOMER_PASSWORD"].ToString();
        }
    }
}
