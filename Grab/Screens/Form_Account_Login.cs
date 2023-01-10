using Grab.Database.DAO;
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
    public partial class Form_Account_Login : Form
    {
        DataProvider provider = new DataProvider();

        public Form_Account_Login()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void TextBox_Account_Enter(object sender, EventArgs e)
        {
            Label_ErrorLogin.Visible = false;
            if (TextBox_Account.Text == "Số điện thoại ..." && TextBox_Account.ForeColor == Color.Silver)
            {
                TextBox_Account.Text = "";
                TextBox_Account.ForeColor = Color.Black;
            }
        }

        private void TextBox_Account_Leave(object sender, EventArgs e)
        {
            if (TextBox_Account.Text == "")
            {
                TextBox_Account.Text = "Số điện thoại ...";
                TextBox_Account.ForeColor = Color.Silver;
            }
        }

        private void TextBox_Password_Enter(object sender, EventArgs e)
        {
            Label_ErrorLogin.Visible = false;
            if (TextBox_Password.Text == "Mật khẩu ..." && TextBox_Password.ForeColor == Color.Silver)
            {
                TextBox_Password.UseSystemPasswordChar = true;
                TextBox_Password.Text = "";
                TextBox_Password.ForeColor = Color.Black;
            }
        }

        private void TextBox_Password_Leave(object sender, EventArgs e)
        {
            if (TextBox_Password.Text == "")
            {
                TextBox_Password.UseSystemPasswordChar = false;
                TextBox_Password.Text = "Mật khẩu ...";
                TextBox_Password.ForeColor = Color.Silver;
            }
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            string query = $"select * " +
                $"from CUSTOMER " +
                $"where CUSTOMER_PHONE_NUMBER = '{TextBox_Account.Text}' COLLATE SQL_Latin1_General_CP1_CS_AS " +
                $"and CUSTOMER_PASSWORD = '{TextBox_Password.Text}' COLLATE SQL_Latin1_General_CP1_CS_AS";
            Assets.Variables.Account.DataTableAccount = provider.ExecuteQuery(query);
            if (Assets.Variables.Account.DataTableAccount.Rows.Count > 0)
            {
                Form HomeForm = new Form_Home();
                HomeForm.Show();
                Close();
            }
            else
            {
                Label_ErrorLogin.Visible = true;
                TextBox_Password.UseSystemPasswordChar = false;
                TextBox_Password.Text = "Mật khẩu ...";
                TextBox_Password.ForeColor = Color.Silver;
            }
        }

        private void Button_Register_Click(object sender, EventArgs e)
        {
            Form RegisterForm = new Form_Account_Register();
            RegisterForm.Show();
            Close();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Close_MouseEnter(object sender, EventArgs e)
        {
            Button_Close.BackColor = Color.Maroon;
            Button_Close.IconColor = Color.White;
        }

        private void Button_Close_MouseLeave(object sender, EventArgs e)
        {
            Button_Close.BackColor = Color.Transparent;
            Button_Close.IconColor = Color.White;
        }

        private void Label_ForgotPassword_Click(object sender, EventArgs e)
        {
            Form change_password = new Form_Forgot_Password();
            change_password.Show();
            Close();
        }
    }
}
