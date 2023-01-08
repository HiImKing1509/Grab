using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Grab.Assets.Variables
{
    public class StringProcessing
    {
        public static string convertToUnSign3(string s)
        {
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }

        public static double MeterToKilometer(double meter)
        {
            return (double)Math.Round(meter / 1000, 1);
        }
    }
}
