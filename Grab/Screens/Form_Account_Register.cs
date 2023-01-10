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
    public partial class Form_Account_Register : Form
    {
        string pass_code = Assets.Variables.UtilsFunction.randomString(15);
        DataProvider provider = new DataProvider();
        public Form_Account_Register()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void Button_Close_MouseEnter(object sender, EventArgs e)
        {
            Button_Close.BackColor = Assets.Variables.Colors.UERed;
        }

        private void Button_Close_MouseLeave(object sender, EventArgs e)
        {
            Button_Close.BackColor = Color.Transparent;
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

        private void TextBox_FullName_Enter(object sender, EventArgs e)
        {
            Label_ErrorLogin.Visible = false;
            if (TextBox_FullName.Text == "Họ và tên ..." && TextBox_FullName.ForeColor == Color.Silver)
            {
                TextBox_FullName.Text = "";
                TextBox_FullName.ForeColor = Color.Black;
            }
        }

        private void TextBox_FullName_Leave(object sender, EventArgs e)
        {
            if (TextBox_FullName.Text == "")
            {
                TextBox_FullName.Text = "Họ và tên ...";
                TextBox_FullName.ForeColor = Color.Silver;
            }
        }

        private void TextBox_Email_Enter(object sender, EventArgs e)
        {
            Label_ErrorLogin.Visible = false;
            if (TextBox_Email.Text == "Email ..." && TextBox_Email.ForeColor == Color.Silver)
            {
                TextBox_Email.Text = "";
                TextBox_Email.ForeColor = Color.Black;
            }
        }

        private void TextBox_Email_Leave(object sender, EventArgs e)
        {
            if (TextBox_Email.Text == "")
            {
                TextBox_Email.Text = "Email ...";
                TextBox_Email.ForeColor = Color.Silver;
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

        private void Button_Login_Click(object sender, EventArgs e)
        {
            Form form_login = new Form_Account_Login();
            form_login.Show();
            Close();
        }

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox_RePassword_Enter(object sender, EventArgs e)
        {
            if (TextBox_RePassword.Text == "Nhập lại mật khẩu ..." && TextBox_RePassword.ForeColor == Color.Silver)
            {
                TextBox_RePassword.UseSystemPasswordChar = true;
                TextBox_RePassword.Text = "";
                TextBox_RePassword.ForeColor = Color.Black;
            }
        }

        private void TextBox_RePassword_Leave(object sender, EventArgs e)
        {
            if (TextBox_RePassword.Text == "")
            {
                TextBox_RePassword.UseSystemPasswordChar = false;
                TextBox_RePassword.Text = "Nhập lại mật khẩu ...";
                TextBox_RePassword.ForeColor = Color.Silver;
            }
        }

        private void Button_SignUp_Click(object sender, EventArgs e)
        {
            if (TextBox_ConfirmCode.Text == "Confirm Code ..." 
                || TextBox_ConfirmCode.Text == "" 
                || TextBox_ConfirmCode.Text != pass_code 
                || Picture_ValidAccount.Visible == false
                || Picture_ValidPassword.Visible == false)
            {
                Label_ErrorLogin.Visible = true;
                Label_TextComfirm.Visible = false;
                Label_TitleConfirm.Visible = false;
                Panel_ConfirmCode.Visible = false;
            }
            else
            {
                Label_OKSignup.Visible = true;
                string query = $"insert into CUSTOMER values('{TextBox_Account.Text}', '{TextBox_Password.Text}', N'{TextBox_FullName.Text}', '{TextBox_Email.Text}')";
                int insert = provider.ExecuteNonQuery(query);
                LoadLoginForm();
            }
        }

        private void Button_SendCode_Click(object sender, EventArgs e)
        {
            Label_ErrorLogin.Visible = false;
            if (TextBox_Email.Text != "" && TextBox_Email.Text != "Email ...")
            {
                pass_code = Assets.Variables.UtilsFunction.randomString(15);
                string title = "VERIFY YOUR ACCOUNT";
                string body =
                    "<body>" +
                        $"<p>This is an E-Signature request from {TextBox_Account.Text}</p>" +
                        "<p>" +
                            "This E-signature is intended for the owner of the following email" +
                            $"address: {TextBox_Email.Text}" +
                        "</p>" +

                        "<div style=\"border-style: solid; max-width: 1000px;\">" +
                            "<p style=\"margin-left: 20px;\">" +
                                "A temporary 6-digit verification code has been sent to this email." +
                                "Enter the code below to verify your identity" +
                            "</p>" +

                            "<p style=\"margin-left: 20px;\">" +
                                "Id you didn't receive an email, please chekc your spam folder. To" +
                                "send the email again, Click \"Send code\" in your application" +
                            "</p>" +
                        "</div>" +

                        $"<p>Your code: <h1 style=\"color:red;\">{pass_code}</h1></p>" +
                    "</body>";
                Assets.Variables.UtilsFunction.sendEmail("hvtkiet.15092002@gmail.com", TextBox_Email.Text, title, body);
                Label_TextComfirm.Visible = true;
                Label_TitleConfirm.Visible = true;
                Panel_ConfirmCode.Visible = true;
                TextBox_ConfirmCode.Text = "Confirm Code ...";
                TextBox_ConfirmCode.ForeColor = Color.Silver;
            }
            else
            {
                Label_ErrorLogin.Visible = true;
                Label_TextComfirm.Visible = false;
                Label_TitleConfirm.Visible = false;
                Panel_ConfirmCode.Visible = false;
            }
        }
        public async void LoadLoginForm()
        {
            await Task.Delay(3000);
            Form LoginForm = new Form_Account_Login();
            LoginForm.Show();
            Close();
        }

        private void TextBox_Account_TextChanged(object sender, EventArgs e)
        {
            string query = $"select * from CUSTOMER where CUSTOMER_PHONE_NUMBER = '{TextBox_Account.Text}'";
            if (provider.ExecuteQuery(query).Rows.Count != 0 || TextBox_Account.Text.Length != 10) 
                Picture_ValidAccount.Visible = false;
            else
                Picture_ValidAccount.Visible = true;
        }

        private void TextBox_RePassword_TextChanged(object sender, EventArgs e)
        {
            if (TextBox_RePassword.Text == TextBox_Password.Text && TextBox_RePassword.ForeColor == TextBox_Password.ForeColor)
                Picture_ValidPassword.Visible = true;
            else
                Picture_ValidPassword.Visible = false;
        }
    }
}
