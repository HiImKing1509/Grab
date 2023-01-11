using FontAwesome.Sharp;
using Grab.Database.DAO;
using Grab.UserControls;
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
    public partial class Form_Home : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form activeForm = null;
        public Form_Home()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;

            BackColor = Assets.Variables.Colors.White;

            // Set color
            Panel_Image.BackColor = Assets.Variables.Colors.ForestGreen;
            Panel_Header.BackColor = Assets.Variables.Colors.Green;
            Panel_Menu.BackColor = Assets.Variables.Colors.DarkGreen_x11;
            Panel_Body.BackColor = Assets.Variables.Colors.White;

            Button_Activity.BackColor = Assets.Variables.Colors.DarkGreen_x11;
            Button_Home.BackColor = Assets.Variables.Colors.DarkGreen_x11;
            Button_Messages.BackColor = Assets.Variables.Colors.DarkGreen_x11;
            Button_Payment.BackColor = Assets.Variables.Colors.DarkGreen_x11;


            leftBorderBtn = new Panel();
            Button_UserInformation.Text = Assets.Variables.Account.DataTableAccount.Rows[0]["CUSTOMER_NAME"].ToString();
            leftBorderBtn.Size = new Size(7, Button_Home.Height);
            Panel_Menu.Controls.Add(leftBorderBtn);
            ActivateButton(Button_Home);

            Assets.Variables.ListFormPanel.ListFormsPanel.Add(Panel_Body);
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            ActivateAllServices();
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Assets.Variables.Colors.White;
                currentBtn.ForeColor = Assets.Variables.Colors.DarkGreen_x11;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Assets.Variables.Colors.DarkGreen_x11;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = Assets.Variables.Colors.DarkGreen_x11;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Assets.Variables.Colors.DarkGreen_x11;
                currentBtn.ForeColor = Assets.Variables.Colors.White;
                currentBtn.IconColor = Assets.Variables.Colors.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.Overlay;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void Button_Home_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            ResetHomePage((Button)sender);
        }

        private void Button_Activity_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new Form_Activity_History());
        }

        private void Button_Payment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new Form_Rent_History());
        }

        private void Button_Messages_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildForm(new Form_Evaluation());
        }

        private void Button_Account_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button_About_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void ActivateAllServices()
        {
            foreach (Control item in Panel_Body.Controls.OfType<FlowLayoutPanel>().ToList())
                Assets.Variables.ListFormPanel.ListFormsPanel[0].Controls.Remove(item);
            foreach (Control item in Panel_Body.Controls.OfType<Form>().ToList())
                Assets.Variables.ListFormPanel.ListFormsPanel[0].Controls.Remove(item);
            FlowLayoutPanel flpShowContent = new FlowLayoutPanel();
            Assets.Variables.ListFormPanel.ListFormsPanel[0].Controls.Add(flpShowContent);
            flpShowContent.Dock = DockStyle.Fill;
            flpShowContent.AutoScroll = true;

            DataProvider provider = new DataProvider();
            
            // Get service
            DataTable dtShowServiceCategory = provider.ExecuteQuery("select * from GRAB_CATEGORY");
            DataTable dtShowTransportService = provider.ExecuteQuery("select * from GRAB_TRANSPORT");
            DataTable dtShowDeliveryService = provider.ExecuteQuery("select * from GRAB_DELIVERY");

            flpShowContent.Controls.Add(new Control_Service(dtShowServiceCategory.Rows[0]));
            foreach (DataRow row in dtShowTransportService.Rows)
            {
                Bitmap myImage = (Bitmap)Assets.Variables.ResourcesManager.rm_grab_transport.GetObject(row["GRAB_ID"].ToString());
                Control_Item_Service item = new Control_Item_Service(
                    myImage,
                    row
                );
                flpShowContent.Controls.Add(item);
            }
        }

        private void TextBox_LocationSearch_Enter(object sender, EventArgs e)
        {
            if (TextBox_LocationSearch.Text == "Tìm kiếm dịch vụ ..." && TextBox_LocationSearch.ForeColor == Color.Gray)
            {
                TextBox_LocationSearch.Text = "";
                TextBox_LocationSearch.ForeColor = Color.Black;
            }
        }

        private void TextBox_LocationSearch_Leave(object sender, EventArgs e)
        {
            if (TextBox_LocationSearch.Text == "")
            {
                TextBox_LocationSearch.Text = "Tìm kiếm dịch vụ ...";
                TextBox_LocationSearch.ForeColor = Color.Gray;
            }
        }

        private void Button_Search_MouseEnter(object sender, EventArgs e)
        {
            Button_Search.BackColor = Assets.Variables.Colors.DarkGreen_x11;
            Button_Search.IconColor = Assets.Variables.Colors.White;
        }

        private void Button_Search_MouseLeave(object sender, EventArgs e)
        {
            Button_Search.BackColor = Assets.Variables.Colors.White;
            Button_Search.IconColor = Color.Black;
        }

        private void Button_Minimize_MouseEnter(object sender, EventArgs e)
        {
            Button_Minimize.BackColor = Color.White;
            Button_Minimize.IconColor = Color.Green;
        }

        private void Button_Minimize_MouseLeave(object sender, EventArgs e)
        {
            Button_Minimize.BackColor = Color.Transparent;
            Button_Minimize.IconColor = Color.White;
        }

        private void Button_Maximum_MouseEnter(object sender, EventArgs e)
        {
            Button_Maximum.BackColor = Color.White;
            Button_Maximum.IconColor = Color.Green;
        }

        private void Button_Maximum_MouseLeave(object sender, EventArgs e)
        {
            Button_Maximum.BackColor = Color.Transparent;
            Button_Maximum.IconColor = Color.White;
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

        private void Button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button_Maximum_Click(object sender, EventArgs e)
        {
            //if (this.WindowState == FormWindowState.Normal)
            //    this.WindowState = FormWindowState.Maximized;
            //else
            //    this.WindowState = FormWindowState.Normal;
        }

        private void ResetHomePage(Button btn = null)
        {
            TextBox_LocationSearch.Text = "Tìm kiếm dịch vụ ...";
            TextBox_LocationSearch.ForeColor = Color.Gray;
            if (btn != null)
                ActivateButton(btn);
            //CloseForm();
            ActivateAllServices();
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

        private void Button_UserInformation_Click(object sender, EventArgs e)
        {
            DropdownMenu_LoadUserInformation.Show(Button_UserInformation, 0, Button_UserInformation.Height);
        }

        private void Button_UserInformation_MouseEnter(object sender, EventArgs e)
        {
            Button_UserInformation.BackColor = Color.Green;
        }

        private void Button_UserInformation_MouseLeave(object sender, EventArgs e)
        {
            Button_UserInformation.BackColor = Color.Transparent;
        }

        private void ToolStripMenuItem_LogOut_Click(object sender, EventArgs e)
        {
            Form form_login = new Form_Account_Login();
            form_login.Show();
            Close();
            Assets.Variables.ListFormPanel.ListFormsPanel.Clear();
        }

        private void ToolStripMenuItem_Profile_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_User_Information());
        }

        private void ToolStripMenuItem_ChanePassword_Click(object sender, EventArgs e)
        {
            openChildForm(new Form_Change_Password());
        }

        private void TextBox_LocationSearch_TextChanged(object sender, EventArgs e)
        {
            Assets.Variables.ListFormPanel.ListFormsPanel[0].Controls.Clear();
            string query = $"select * from GRAB_TRANSPORT where dbo.LanguageComprehension(GRAB_NAME) like '%{Assets.Variables.StringProcessing.convertToUnSign3(TextBox_LocationSearch.Text)}%'";
            FlowLayoutPanel flpShowContent = new FlowLayoutPanel();
            Assets.Variables.ListFormPanel.ListFormsPanel[0].Controls.Add(flpShowContent);
            flpShowContent.Dock = DockStyle.Fill;
            flpShowContent.AutoScroll = true;

            DataProvider provider = new DataProvider();
            DataTable dtShowServiceCategory = provider.ExecuteQuery(query);
            foreach (DataRow row in dtShowServiceCategory.Rows)
            {
                Bitmap myImage = (Bitmap)Assets.Variables.ResourcesManager.rm_grab_transport.GetObject(row["GRAB_ID"].ToString());
                Control_Item_Service item = new Control_Item_Service(
                    myImage,
                    row
                );
                flpShowContent.Controls.Add(item);
            }
        }
    }
}
