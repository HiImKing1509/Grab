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
    public partial class Form_Change_Password : Form
    {
        DataProvider provider = new DataProvider();
        private Form activeForm = null;
        public Form_Change_Password()
        {
            InitializeComponent();
        }

        private void TextBox_OldPassword_Enter(object sender, EventArgs e)
        {
            Label_ErrorLogin.Visible = false;
            if (TextBox_OldPassword.Text == "Mật khẩu cũ ..." && TextBox_OldPassword.ForeColor == Color.Silver)
            {
                TextBox_OldPassword.UseSystemPasswordChar = true;
                TextBox_OldPassword.Text = "";
                TextBox_OldPassword.ForeColor = Color.Black;
            }
        }

        private void TextBox_OldPassword_Leave(object sender, EventArgs e)
        {
            if (TextBox_OldPassword.Text == "")
            {
                TextBox_OldPassword.UseSystemPasswordChar = false;
                TextBox_OldPassword.Text = "Mật khẩu cũ ...";
                TextBox_OldPassword.ForeColor = Color.Silver;
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

        private void TextBox_OldPassword_TextChanged(object sender, EventArgs e)
        {
            string query = $"select * from CUSTOMER where CUSTOMER_PHONE_NUMBER = '{Assets.Variables.Account.DataTableAccount.Rows[0]["CUSTOMER_PHONE_NUMBER"]}' and CUSTOMER_PASSWORD = '{TextBox_OldPassword.Text}'";
            if (provider.ExecuteQuery(query).Rows.Count != 0)
            {
                Picture_ValidAccount.Visible = true;
            }
            else
            {
                Picture_ValidAccount.Visible = false;
            }
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
            if (Picture_ValidAccount.Visible == true && Picture_ValidNewPassword.Visible == true)
            {
                Label_OKSignup.Visible = true;
                Label_ErrorLogin.Visible = false;
                string query = $"update CUSTOMER set CUSTOMER_PASSWORD = '{TextBox_Password.Text}' where CUSTOMER_PHONE_NUMBER = '{Assets.Variables.Account.DataTableAccount.Rows[0]["CUSTOMER_PHONE_NUMBER"]}'";
                int a = provider.ExecuteNonQuery(query);
                WaitLoadingForm();
            }
            else
            {
                Label_OKSignup.Visible = false;
                Label_ErrorLogin.Visible = true;
            }
        }

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            Assets.Variables.ListFormPanel.ListFormsPanel[0].Controls.Add(childForm);
            Assets.Variables.ListFormPanel.ListFormsPanel[0].Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public async void WaitLoadingForm()
        {
            await Task.Delay(3000);
            openChildForm(new Form_Change_Password());
        }
    }
}
