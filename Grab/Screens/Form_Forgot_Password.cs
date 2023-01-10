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
    public partial class Form_Forgot_Password : Form
    {
        string pass_code = Assets.Variables.UtilsFunction.randomString(15);
        DataProvider provider = new DataProvider();
        public Form_Forgot_Password()
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

        private void TextBox_ConfirmCode_Enter(object sender, EventArgs e)
        {
            Label_ErrorLogin.Visible = false;
            if (TextBox_ConfirmCode.Text == "Confirm Code ..." && TextBox_ConfirmCode.ForeColor == Color.Silver)
            {
                TextBox_ConfirmCode.Text = "";
                TextBox_ConfirmCode.ForeColor = Color.Black;
            }
        }

        private void TextBox_ConfirmCode_Leave(object sender, EventArgs e)
        {
            if (TextBox_ConfirmCode.Text == "")
            {
                TextBox_ConfirmCode.Text = "Confirm Code ...";
                TextBox_ConfirmCode.ForeColor = Color.Silver;
            }
        }

        private void TextBox_NewPassword_Enter(object sender, EventArgs e)
        {
            Label_ErrorLogin.Visible = false;
            if (TextBox_NewPassword.Text == "Mật khẩu mới ..." && TextBox_NewPassword.ForeColor == Color.Silver)
            {
                TextBox_NewPassword.UseSystemPasswordChar = true;
                TextBox_NewPassword.Text = "";
                TextBox_NewPassword.ForeColor = Color.Black;
            }
        }

        private void TextBox_NewPassword_Leave(object sender, EventArgs e)
        {
            if (TextBox_NewPassword.Text == "")
            {
                TextBox_NewPassword.UseSystemPasswordChar = false;
                TextBox_NewPassword.Text = "Mật khẩu mới ...";
                TextBox_NewPassword.ForeColor = Color.Silver;
            }
        }

        private void TextBox_Password_Enter(object sender, EventArgs e)
        {
            Label_ErrorLogin.Visible = false;
            if (TextBox_Password.Text == "Xác nhận mật khẩu mới ..." && TextBox_Password.ForeColor == Color.Silver)
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
                TextBox_Password.Text = "Xác nhận mật khẩu mới ...";
                TextBox_Password.ForeColor = Color.Silver;
            }
        }

        private void TextBox_Account_TextChanged(object sender, EventArgs e)
        {
            string query = $"select * from CUSTOMER where CUSTOMER_PHONE_NUMBER = '{TextBox_Account.Text}'";
            if (provider.ExecuteQuery(query).Rows.Count != 0)
            {
                Picture_ValidAccount.Visible = true;
                Label_1.Visible = true;
                Panel_ConfirmCode.Visible = true;
                Button_SendCode.Visible = true;
            }    
            else
            {
                Picture_ValidAccount.Visible = false;
                Label_1.Visible = false;
                Panel_ConfirmCode.Visible = false;
                Button_SendCode.Visible = false;
                Label_TextComfirm.Visible = false;
            }
        }

        private void TextBox_ConfirmCode_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_ConfirmCode.Text == pass_code)
            {
                Picture_ValidCode.Visible = true;
                Label_2.Visible = true;
                Panel_NewPassword.Visible = true;
                Label_3.Visible = true;
                Panel_Password.Visible = true;
            }
            else
            {
                Picture_ValidCode.Visible = false;
                Label_2.Visible = false;
                Panel_NewPassword.Visible = false;
                Label_3.Visible = false;
                Panel_Password.Visible = false;
            }
        }

        private void Button_Close_MouseEnter(object sender, EventArgs e)
        {
            Button_Close.BackColor = Assets.Variables.Colors.UERed;
        }

        private void Button_Close_MouseLeave(object sender, EventArgs e)
        {
            Button_Close.BackColor = Color.Transparent;
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_Password.Text == TextBox_NewPassword.Text && TextBox_Password.ForeColor == TextBox_NewPassword.ForeColor)
                Picture_ValidNewPassword.Visible = true;
            else
                Picture_ValidNewPassword.Visible = false;
        }

        private void Button_ChangePassword_Click(object sender, EventArgs e)
        {
            if (Picture_ValidAccount.Visible == true && Picture_ValidCode.Visible == true && Picture_ValidNewPassword.Visible == true)
            {
                Label_OKSignup.Visible = true;
                Label_ErrorLogin.Visible = false;
                string query = $"update CUSTOMER set CUSTOMER_PASSWORD = '{TextBox_Password.Text}' where CUSTOMER_PHONE_NUMBER = '{TextBox_Account.Text}'";
                int a = provider.ExecuteNonQuery(query);
                string pass_code = Assets.Variables.UtilsFunction.randomString(15);
                LoadLoginForm();
            }
            else
            {
                Label_OKSignup.Visible = false;
                Label_ErrorLogin.Visible = true;
            }
        }

        private void Button_SendCode_Click(object sender, EventArgs e)
        {
            string query = $"select * from CUSTOMER where CUSTOMER_PHONE_NUMBER = {TextBox_Account.Text}";
            pass_code = Assets.Variables.UtilsFunction.randomString(15);
            string title = "VERIFY TO PASSWORD RECOVERY";
            string body =
                "<body>" +
                    $"<p>This is an E-Signature request from {TextBox_Account.Text}</p>" +
                    "<p>" +
                        "This E-signature is intended for the owner of the following email" +
                        $"address: {provider.ExecuteQuery(query).Rows[0]["CUSTOMER_EMAIL"]}" +
                    "</p>" +

                    "<div style=\"border-style: solid; max-width: 1000px;\">" +
                        "<p style=\"margin-left: 20px;\">" +
                            "A temporary 15-digit verification code has been sent to this email." +
                            "Enter the code below to verify your identity" +
                        "</p>" +

                        "<p style=\"margin-left: 20px;\">" +
                            "Id you didn't receive an email, please chekc your spam folder. To" +
                            "send the email again, Click \"Send code\" in your application" +
                        "</p>" +
                    "</div>" +

                    $"<p>Your code for Password recovery: <h1 style=\"color:red;\">{pass_code}</h1></p>" +
                "</body>";
            Assets.Variables.UtilsFunction.sendEmail("hvtkiet.15092002@gmail.com", provider.ExecuteQuery(query).Rows[0]["CUSTOMER_EMAIL"].ToString(), title, body);
            Label_TextComfirm.Visible = true;
        }

        public async void LoadLoginForm()
        {
            await Task.Delay(3000);
            Form LoginForm = new Form_Account_Login();
            LoginForm.Show();
            Close();
        }
    }
}
