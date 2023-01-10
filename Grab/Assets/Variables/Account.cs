using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grab.Assets.Variables
{
    public class Account
    {
        // DataTable Account
        private static DataTable dtAccount = new DataTable();
        public static DataTable DataTableAccount { get { return dtAccount; } set { dtAccount = value; } }
    }
}
