using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class connection_string
    {
        public class Utils
        {
            private static string connectionString = "server= lochnagar.abertay.ac.uk; database= sql2202448; username = sql2202448; password = Fz2ggjKkinH6";

            public static string ConnectionString
            {
                get
                {
                    return connectionString;
                }
                set
                {
                    connectionString = value;
                }
            }
        }
    }
}