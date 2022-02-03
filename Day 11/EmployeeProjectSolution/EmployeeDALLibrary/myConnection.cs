using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDALLibrary
{
    internal class myConnection
    {
        SqlConnection conn;
        static myConnection connection;
        private myConnection()
        {
            conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        }

        public static SqlConnection GetConnection()
        {
            if (connection == null)
                connection = new myConnection();
            return connection.conn;
        }
    }
}
