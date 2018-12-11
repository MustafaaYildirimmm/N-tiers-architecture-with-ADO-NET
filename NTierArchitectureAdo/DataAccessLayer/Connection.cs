using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccessLayer
{
    public class Connection
    {
        public static string CS = ConfigurationManager.ConnectionStrings["UserInterfaceLayer.Properties.Settings.Cs"].ConnectionString;
    }
}
