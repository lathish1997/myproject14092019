using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ClaimsBusinessLayer
{
    public class ConnectionHandler
    {
        static string variable = ConfigurationManager.ConnectionStrings["db_connection"].ToString();
        
        public static string ConnectionVariable
        {
            get
            {
                return variable;
            }
        }
    }
}
