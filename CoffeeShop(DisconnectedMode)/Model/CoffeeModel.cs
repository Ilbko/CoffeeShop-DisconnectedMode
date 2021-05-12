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
    //Класс модели (контроллера)
    public static class CoffeeModel
    {
        //ДатаТейблы всего кофе и найденного кофе
        public static DataTable coffeeTable;
        public static DataTable coffeeTableFound;

        //Строка подключения к БД и команда выборки
        public static readonly string connStr = @"Data Source=COMPUTER\SQLEXPRESS;Initial Catalog=CoffeeDB;Integrated Security=True;MultipleActiveResultSets=True;";
        public static string sqlComm = "SELECT * FROM Coffee";

        //Переменная "были ли изменения в основной таблице"
        public static bool isChanges = false;

        //При первом обращении к этому классу выполняется заполнение главного ДатаТейбла кофе
        static CoffeeModel()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                //Подключение не асинхронное, ведь при установке источника данных для главного ДатаГрида нужна полная таблица.
                //Вышеуказанное действие - первое обращение к классу модели, поэтому нужно сначала провести подключение, а потом устанавливать источник.
                conn.Open();

                SqlDataAdapter adapter = new SqlDataAdapter(sqlComm, conn);
                DataSet set = new DataSet();
                adapter.Fill(set);
                coffeeTable = set.Tables[0];
            }
        }

        //Метод сохранения изменений в БД
        internal static void SaveChanges(DataGridView dataGridView1)
        {
            //Если были изменения
            if (isChanges)
                //Если пользователь захотел сохранить изменения
                if (MessageBox.Show("Сохранить изменения в БД?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        //Асинхронное подключение
                        conn.OpenAsync();

                        SqlDataAdapter adapter = new SqlDataAdapter(sqlComm, conn);
                        SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);

                        try
                        {
                            //Попытка обновления таблицы в БД
                            adapter.Update(coffeeTable);
                        } catch (System.Data.SqlClient.SqlException e)
                        {
                            //515 - Cannot insert the value NULL into column '%.*ls', table '%.*ls'; column does not allow nulls. %ls fails.
                            //Если пустое какое-то с полей, которое не поддерживает null
                            if (e.Number == 515)
                            {
                                //Если non-nullable поле пустое в какой-то записи, то оно заполняется значением по-умолчанию
                                foreach (DataRow item in coffeeTable.Rows)
                                {
                                    //Если поле содержит null, то оно заполняется значением по-умолчанию. Иначе поле принимает своё же значение
                                    //as ОБЯЗАТЕЛЕН!
                                    //item["Coffee_Name"] = item["Coffee_Name"] ?? "template"; не сработает
                                    item["Coffee_Name"] = item["Coffee_Name"] as string ?? "template";

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
