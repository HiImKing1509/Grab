using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
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

        public static string Start_location { get => start_location; set => start_location=value; }
        public static string End_location { get => end_location; set => end_location=value; }
        public static double Distance { get => distance; set => distance=value; }
        public static double Start_location_lat { get => start_location_lat; set => start_location_lat=value; }
        public static double Start_location_long { get => start_location_long; set => start_location_long=value; }
        public static double End_location_lat { get => end_location_lat; set => end_location_lat=value; }
        public static double End_location_long { get => end_location_long; set => end_location_long=value; }
        public static int Start_id_province { get => start_id_province; set => start_id_province=value; }

        public static double distanceLocation(double sLatitude, double sLongitude, double eLatitude, double eLongitude)
        {
            var sCoord = new GeoCoordinate(sLatitude, sLongitude);
            var eCoord = new GeoCoordinate(eLatitude, eLongitude);

            return (double)sCoord.GetDistanceTo(eCoord);
        }
    }
}
