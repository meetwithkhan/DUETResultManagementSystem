using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUET_ResultManagementSystem
{
    class DBConnector
    {
        string connectionString = @"server=(local)\SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=ResultManagementSystemDB";

        SqlConnection connection = null;

        public DBConnector()
        {
            connection = new SqlConnection(connectionString);
        }

        public SqlConnection Connect { get => connection; }
    }
}
