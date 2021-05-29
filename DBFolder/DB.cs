using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapApp.DBFolder
{
    class DB
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;user=prog;password=prog;database=mapapp");

        public void openCon()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeCon()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        public MySqlConnection getCon()
        {
            return connection;
        }
    }
}
