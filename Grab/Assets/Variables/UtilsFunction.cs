using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Grab.Assets.Variables
{
    public class UtilsFunction
    {
        private static string start_location = "";
        private static double start_location_lat = 0.0;
        private static double start_location_long = 0.0;

        private static string end_location = "";
        private static double end_location_lat = 0.0;
        private static double end_location_long = 0.0;

        private static double distance = 0.0;

        private static int start_id_province = 0;
        private static int rent_id_province = 0;
        private static int evaluation_id_province = 0;

        public static string Start_location { get => start_location; set => start_location=value; }
        public static string End_location { get => end_location; set => end_location=value; }
        public static double Distance { get => distance; set => distance=value; }
        public static double Start_location_lat { get => start_location_lat; set => start_location_lat=value; }
        public static double Start_location_long { get => start_location_long; set => start_location_long=value; }
        public static double End_location_lat { get => end_location_lat; set => end_location_lat=value; }
        public static double End_location_long { get => end_location_long; set => end_location_long=value; }
        public static int Start_id_province { get => start_id_province; set => start_id_province=value; }
        public static int Rent_id_province { get => rent_id_province; set => rent_id_province=value; }
        public static int Evaluation_id_province { get => evaluation_id_province; set => evaluation_id_province=value; }

        public static double distanceLocation(double sLatitude, double sLongitude, double eLatitude, double eLongitude)
        {
            var sCoord = new GeoCoordinate(sLatitude, sLongitude);
            var eCoord = new GeoCoordinate(eLatitude, eLongitude);

            return (double)sCoord.GetDistanceTo(eCoord);
        }

        public static void sendEmail(string fromMail, string toMail, string subject, string body)
        {
            string fromPassword = "ktfhsxjlswuxcfeh";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = subject;
            message.To.Add(new MailAddress(toMail));
            //message.Body = "<html><body> From C# Winform </body></html>";
            message.Body = $"<html><body> {body} </body></html>";
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };

            smtpClient.Send(message);
        }

        public static string randomString(int len)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, len).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static double randomDouble(int max)
        {
            return Math.Round(((new Random()).NextDouble() * max) + 1.0, 2);
        }
    }
}
