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
        public static ResourceManager rm_services = new ResourceManager("Grab.Images_Services", Assembly.GetExecutingAssembly());
    }
}
