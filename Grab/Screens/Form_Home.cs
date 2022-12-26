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
            BackColor = Assets.Variables.Colors.White;

            // Set color
            Panel_Image.BackColor = Assets.Variables.Colors.ForestGreen;
            Panel_Header.BackColor = Assets.Variables.Colors.Green;
            Panel_Menu.BackColor = Assets.Variables.Colors.DarkGreen_x11;
            Panel_Body.BackColor = Assets.Variables.Colors.White;

            Button_About.BackColor = Assets.Variables.Colors.DarkGreen_x11;
            Button_Account.BackColor = Assets.Variables.Colors.DarkGreen_x11;
            Button_Activity.BackColor = Assets.Variables.Colors.DarkGreen_x11;
            Button_Home.BackColor = Assets.Variables.Colors.DarkGreen_x11;
            Button_Messages.BackColor = Assets.Variables.Colors.DarkGreen_x11;
            Button_Payment.BackColor = Assets.Variables.Colors.DarkGreen_x11;


            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, Button_Home.Height);
            Panel_Menu.Controls.Add(leftBorderBtn);
            ActivateButton(Button_Home);

            Assets.Variables.ListFormPanel.ListFormsPanel.Add(Panel_Body);
        }

        private void Form_Home_Load(object sender, EventArgs e)
        {
            ActivateAllServices("select * from GRAB_SERVICES");
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
        }

        private void Button_Activity_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button_Payment_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button_Messages_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button_Account_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Button_About_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void ActivateAllServices(string query)
        {
            foreach (Control item in Panel_Body.Controls.OfType<FlowLayoutPanel>().ToList())
                Assets.Variables.ListFormPanel.ListFormsPanel[0].Controls.Remove(item);
            foreach (Control item in Panel_Body.Controls.OfType<Form>().ToList())
                Assets.Variables.ListFormPanel.ListFormsPanel[0].Controls.Remove(item);
            FlowLayoutPanel flpShowProduct = new FlowLayoutPanel();
            Assets.Variables.ListFormPanel.ListFormsPanel[0].Controls.Add(flpShowProduct);
            flpShowProduct.Dock = DockStyle.Fill;
            flpShowProduct.AutoScroll = true;

            DataProvider provider = new DataProvider();
            DataTable dtShowProduct = provider.ExecuteQuery(query);

            foreach (DataRow row in dtShowProduct.Rows)
            {
                Bitmap myImage = (Bitmap)Assets.Variables.ResourcesManager.rm_services.GetObject(row["GRAB_SERVICE_ID"].ToString());
                Control_Item_Service item = new Control_Item_Service(
                    myImage,
                    row
                );
                flpShowProduct.Controls.Add(item);
            }
        }
    }
}
