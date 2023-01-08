using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Grab.Assets.Variables
{
    public class ResourcesManager
    {
        public static ResourceManager rm_grab_transport = new ResourceManager("Grab.Images_GrabTransport", Assembly.GetExecutingAssembly());
        public static ResourceManager rm_grab_delivery = new ResourceManager("Grab.Images_GrabDelivery", Assembly.GetExecutingAssembly());
        public static ResourceManager rm_grab_brand = new ResourceManager("Grab.Images_GrabBrand", Assembly.GetExecutingAssembly());
        public static ResourceManager rm_grab_icon = new ResourceManager("Grab.Images_GrabIcon", Assembly.GetExecutingAssembly());
        public static ResourceManager rm_grab_logo = new ResourceManager("Grab.Images_GrabLogo", Assembly.GetExecutingAssembly());
    }
}
