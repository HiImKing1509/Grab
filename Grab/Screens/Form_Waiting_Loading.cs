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
    public partial class Form_Waiting_Loading : Form
    {
        public Form_Waiting_Loading()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            WaitLoadingForm();
        }

        public async void WaitLoadingForm()
        {
            await Task.Delay(3000);
            Form LoginForm = new Form_Account_Login();
            Hide();
            LoginForm.Show();
        }
    }
}
