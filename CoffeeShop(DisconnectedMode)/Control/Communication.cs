using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop_DisconnectedMode_.Control
{
    public static class Communication
    {
        public static DataTable coffeeTable;
        public static DataTable coffeeTableFound;
        public static readonly string connStr = @"Data Source=COMPUTER\SQLEXPRESS;Initial Catalog=CoffeeDB;Integrated Security=True;MultipleActiveResultSets=True;";
        public static string sqlComm = "SELECT * FROM Coffee";

        static Communication()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlComm, conn);
                DataSet set = new DataSet();
                adapter.Fill(set);
                coffeeTable = set.Tables[0];
            }
        }
    }
}
