using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyInventoryManagement.Data
{
    public class DBConnection
    {
        public static SqlConnection GetConnection()
        {
            string cs = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyInventoryDB;Integrated Security=True;Connect Timeout=30";

            return new SqlConnection(cs);
        }
    }
}
