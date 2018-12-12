using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public static class DataProvider
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=.;Initial Catalog=dbQuanLySinhVien;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}
