using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Grab.Screens
{
    public partial class Form_Booking : Form
    {
        public Form_Booking()
        {
            InitializeComponent();
            Panel_SearchLocation.BottomColor = Assets.Variables.Colors.ForestGreen;
            Panel_SearchLocation.TopColor = Assets.Variables.Colors.White;
        }

        private void TextBox_LocationStartSearch_Enter(object sender, EventArgs e)
        {
            if (TextBox_LocationStartSearch.Text == "Điểm đón ..." && TextBox_LocationStartSearch.ForeColor == Color.Silver)
            {
                TextBox_LocationStartSearch.Text = "";
                TextBox_LocationStartSearch.ForeColor = Color.Black;
            }
        }

        private void TextBox_LocationStartSearch_Leave(object sender, EventArgs e)
        {
            if (TextBox_LocationStartSearch.Text == "")
            {
                TextBox_LocationStartSearch.Text = "Điểm đón ...";
                TextBox_LocationStartSearch.ForeColor = Color.Silver;
            }
        }

        private void TextBox_LocationDestinationSearch_Enter(object sender, EventArgs e)
        {
            if (TextBox_LocationDestinationSearch.Text == "Điểm đến ..." && TextBox_LocationDestinationSearch.ForeColor == Color.Silver)
            {
                TextBox_LocationDestinationSearch.Text = "";
                TextBox_LocationDestinationSearch.ForeColor = Color.Black;
            }
        }

        private void TextBox_LocationDestinationSearch_Leave(object sender, EventArgs e)
        {
            if (TextBox_LocationDestinationSearch.Text == "")
            {
                TextBox_LocationDestinationSearch.Text = "Điểm đến ...";
                TextBox_LocationDestinationSearch.ForeColor = Color.Silver;
            }
        }

        private void Button_ServiceQuery_Click(object sender, EventArgs e)
        {
            // UI 
            Label_LocationStart.Text = TextBox_LocationStartSearch.Text;
            Label_LocationDestination.Text = TextBox_LocationDestinationSearch.Text;
            Label_LocationStart.ForeColor = Color.Green;
            Label_LocationDestination.ForeColor = Color.Green;
            // Web browser

            string start = Assets.Variables.StringProcessing.convertToUnSign3(TextBox_LocationStartSearch.Text);
            string end = Assets.Variables.StringProcessing.convertToUnSign3(TextBox_LocationDestinationSearch.Text);
            string url = string.Format($"https://www.google.com/maps/dir/" +
                $"{start}/" +
                $"{end}");
            WebBrowser_GoogleMap.Navigate(url);
        }

        //public int getDistance(string origin, string destination)
        //{
        //    System.Threading.Thread.Sleep(1000);
        //    int distance = 100;
        //    //string from = origin.Text;
        //    //string to = destination.Text;
        //    string url = "http://maps.googleapis.com/maps/api/directions/json?origin=" + origin + "&destination=" + destination + "&sensor=false";
        //    string requesturl = url;
        //    //string requesturl = @"http://maps.googleapis.com/maps/api/directions/json?origin=" + from + "&alternatives=false&units=imperial&destination=" + to + "&sensor=false";
        //    string content = fileGetContents(requesturl);
        //    JObject o = JObject.Parse(content);
        //    System.Windows.Forms.MessageBox.Show(o.ToString());
        //    try
        //    {
        //        distance = (int)o.SelectToken("routes[0].legs[0].distance.value");
        //        return distance;
        //    }
        //    catch
        //    {
        //        return distance;
        //    }
        //    //ResultingDistance.Text = distance;
        //}

        //protected string fileGetContents(string fileName)
        //{
        //    string sContents = string.Empty;
        //    string me = string.Empty;
        //    try
        //    {
        //        if (fileName.ToLower().IndexOf("http:") > -1)
        //        {
        //            System.Net.WebClient wc = new System.Net.WebClient();
        //            byte[] response = wc.DownloadData(fileName);
        //            sContents = System.Text.Encoding.ASCII.GetString(response);

        //        }
        //        else
        //        {
        //            System.IO.StreamReader sr = new System.IO.StreamReader(fileName);
        //            sContents = sr.ReadToEnd();
        //            sr.Close();
        //        }
        //    }
        //    catch { sContents = "unable to connect to server "; }
        //    return sContents;
        //}
    }
}
