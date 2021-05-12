using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop_DisconnectedMode_.Control
{
    public static class CoffeeModel
    {
        public static DataTable coffeeTable;
        public static DataTable coffeeTableFound;
        public static readonly string connStr = @"Data Source=COMPUTER\SQLEXPRESS;Initial Catalog=CoffeeDB;Integrated Security=True;MultipleActiveResultSets=True;";
        public static string sqlComm = "SELECT * FROM Coffee";
        public static bool isChanges = false;

        static CoffeeModel()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlComm, conn);
                DataSet set = new DataSet();
                adapter.Fill(set);
                coffeeTable = set.Tables[0];
            }

            //CoffeeModel.Init(ref coffeeTable);
        }

        internal static void SaveChanges(DataGridView dataGridView1)
        {
            if (isChanges)
                if (MessageBox.Show("Сохранить изменения в БД?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.OpenAsync();

                        SqlDataAdapter adapter = new SqlDataAdapter(sqlComm, conn);
                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                        try
                        {
                            adapter.Update(coffeeTable);
                        } catch (System.Data.SqlClient.SqlException e)
                        {
                            if (e.Number == 515)
                            {
                                foreach (DataRow item in coffeeTable.Rows)
                                {
                                    //if ((item["Coffee_Name"] as string) == null)
                                    //    item["Coffee_Name"] = "template";

                                    //as ОБЯЗАТЕЛЕН!
                                    //item["Coffee_Name"] = item["Coffee_Name"] ?? "template"; не сработает
                                    item["Coffee_Name"] = item["Coffee_Name"] as string ?? "template";

                                    //if ((item["Coffee_Grams"] as int?) == null)
                                    //    item["Coffee_Grams"] = 0;
                                    item["Coffee_Grams"] = item["Coffee_Grams"] as int? ?? 0;

                                    //if ((item["Coffee_Price"] as double?) == null)
                                    //    item["Coffee_Price"] = 0;
                                    item["Coffee_Price"] = item["Coffee_Price"] as double? ?? 0;
                                }
                            }
                        } finally
                        {
                            adapter.Update(coffeeTable);
                        }
                    }
        }
    }
}
