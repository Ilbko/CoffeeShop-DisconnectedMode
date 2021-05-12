using CoffeeShop_DisconnectedMode_.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop_DisconnectedMode_.Control
{
    public class Logic
    {
        //Метод обновления датаГрида поиска
        private void Updater(DataGridView grid)
        {
            grid.DataSource = CoffeeModel.coffeeTableFound;
            grid.Update();
        }

        //Метод обновления текстБокса найденной информации
        private void Updater(TextBox box, Dictionary<string, int?> dict)
        {
            box.Text = string.Empty;
            foreach(var item in dict)
            {
                box.Text += $"{item.Key} : {item.Value}\r\n";
            }
        }

        //Хендлер вводимого текста для текстБоксов цены в окне поиска
        internal void TextHandler(TextBox sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.' && !sender.Text.Contains(".")))
                e.Handled = true;
        }

        //Метод поиска кофе, в описании которого упоминается вишня
        internal void FindCherry(DataGridView dataGridView2)
        {
            //Первый способ обработки значений Null - не допускать их в выборку
            CoffeeModel.coffeeTableFound = CoffeeModel.coffeeTable.AsEnumerable()
                .Where(x => x["Coffee_Info"] != null && (x["Coffee_Info"] as string).Contains("вишн")).CopyToDataTable();

            Updater(dataGridView2);
        }

        //Метод поиска трёх самых дешёвых кофе
        internal void FindTop3CheapestSort(DataGridView dataGridView2)
        {
            //Второй способ обработки значений Null - заставить пользователя ввести значение в пустые клетки
            try
            {
                //Сортировка кофе по цене
                DataTable temp = CoffeeModel.coffeeTable.AsEnumerable().OrderBy(x => x["Coffee_Price"]).CopyToDataTable();
                CoffeeModel.coffeeTableFound = temp.AsEnumerable().Take(3).CopyToDataTable();

                Updater(dataGridView2);
            } 
            catch(System.ArgumentException e)
            {
                MessageBox.Show("Заполните пустые клетки цен кофе.");
            }
        }

        //Метод поиска топ-трёх стран по количеству сортов
        internal void FindTop3CountriesSort(TextBox InfoTextBox)
        {
            Dictionary<string, int?> countries = new Dictionary<string, int?>();
            foreach(DataRow item in CoffeeModel.coffeeTable.Rows)
            {
                //Если страна не null
                if (item["Coffee_Country"] as string != null)
                {
                    string temp = (item["Coffee_Country"] as string).ToLower();

                    //Если страны нет в словаре
                    if (!countries.ContainsKey(temp))
                        countries.Add(temp, 1);
                    else
                        countries[temp]++;
                }
            }
            countries = countries.OrderBy(x => x.Value).Reverse().Take(3).ToDictionary(y => y.Key, y => y.Value);

            Updater(InfoTextBox, countries);
        }

        //Метод поиска топ-трёх стран по суммарному количеству граммов кофе 
        internal void FindTop3CountriesGram(TextBox InfoTextBox)
        {
            Dictionary<string, int?> countries = new Dictionary<string, int?>();                 
            foreach(DataRow item in CoffeeModel.coffeeTable.Rows)
            {
                if (item["Coffee_Country"] as string != null)
                {
                    string temp = (item["Coffee_Country"] as string).ToLower();                 

                    if (item["Coffee_Grams"] as int? != null)
                    {
                        if (!countries.ContainsKey(temp))
                            countries.Add(temp, item["Coffee_Grams"] as int?);
                        else
                            countries[temp] += item["Coffee_Grams"] as int?;
                    }
                }
            }
            countries = countries.OrderBy(x => x.Value).Reverse().Take(3).ToDictionary(y => y.Key, y => y.Value);

            Updater(InfoTextBox, countries);
        }

        //Метод поиска топ-трёх арабики по граммам
        internal void FindTop3ArabicaGram(DataGridView dataGridView2)
        {
            try
            {
                DataTable temp = CoffeeModel.coffeeTable.AsEnumerable().Where(x => (x["Coffee_Type"] as string).ToLower() == "арабика").OrderBy(x => x["Coffee_Grams"]).CopyToDataTable();
                CoffeeModel.coffeeTableFound = temp.AsEnumerable().Reverse().Take(3).CopyToDataTable();

                Updater(dataGridView2);
            }
            catch (System.ArgumentException e) 
            {
                MessageBox.Show("Заполните пустые клетки граммов кофе.");
            }
        }

        //то же самое, только с робустой
        internal void FindTop3RobustaGram(DataGridView dataGridView2)
        {
            try
            { 
                DataTable temp = CoffeeModel.coffeeTable.AsEnumerable().Where(x => (x["Coffee_Type"] as string).ToLower() == "робуста").OrderBy(x => x["Coffee_Grams"]).CopyToDataTable();
                CoffeeModel.coffeeTableFound = temp.AsEnumerable().Reverse().Take(3).CopyToDataTable();

                Updater(dataGridView2);
            }
            catch (System.ArgumentException e)
            {
                MessageBox.Show("Заполните пустые клетки граммов кофе.");
            }
        }

        //Метод поиска топ-трёх кофе по граммам
        internal void FindTop3Gram(DataGridView dataGridView2)
        {
            try
            { 
                DataTable temp = CoffeeModel.coffeeTable.AsEnumerable().OrderBy(x => x["Coffee_Grams"]).CopyToDataTable();
                CoffeeModel.coffeeTableFound = temp.AsEnumerable().Reverse().Take(3).CopyToDataTable();

                Updater(dataGridView2);
            }
            catch (System.ArgumentException e)
            {
                MessageBox.Show("Заполните пустые клетки цен кофе.");
            }
        }

        //Метод поиска трёх самых дорогих кофе
        internal void FindTop3Expensive(DataGridView dataGridView2)
        {
            try
            { 
                DataTable temp = CoffeeModel.coffeeTable.AsEnumerable().OrderBy(x => x["Coffee_Price"]).CopyToDataTable();
                CoffeeModel.coffeeTableFound = temp.AsEnumerable().Reverse().Take(3).CopyToDataTable();

                Updater(dataGridView2);
            }
            catch (System.ArgumentException e)
            {
                MessageBox.Show("Заполните пустые клетки цен кофе.");
            }
        }

        //Метод клика кнопки "найти" в форме поиска
        internal void ButtonFind(int mode, SearchForm searchForm, DataGridView dataGridView2)
        {
            try
            {
                switch (mode)
                {
                    case 1:
                        {
                            //Не работало с float, хоть в БД колонка имеет тип float
                            double price1 = double.Parse(searchForm.Controls["textBox1"].Text);
                            double price2 = double.Parse(searchForm.Controls["textBox2"].Text);
                            if (price1 > price2)
                            {
                                double temp = price1;
                                price1 = price2;
                                price2 = temp;
                            }

                            CoffeeModel.coffeeTableFound = CoffeeModel.coffeeTable.AsEnumerable()
                                .Where(x => x["Coffee_Price"] as double? >= price1 && x["Coffee_Price"] as double? <= price2)
                                .CopyToDataTable();
                            break;
                        }
                    case 2:
                        {
                            int gram1 = int.Parse(searchForm.Controls["numericUpDown1"].Text);
                            int gram2 = int.Parse(searchForm.Controls["numericUpDown2"].Text);
                            if (gram1 > gram2)
                            {
                                int temp = gram1;
                                gram1 = gram2;
                                gram2 = temp;
                            }

                            CoffeeModel.coffeeTableFound = CoffeeModel.coffeeTable.AsEnumerable()
                                .Where(x => x["Coffee_Grams"] as int? >= gram1 && x["Coffee_Grams"] as int? <= gram2)
                                .CopyToDataTable();
                            break;
                        }
                    case 3:
                        {
                            CoffeeModel.coffeeTableFound = CoffeeModel.coffeeTable.AsEnumerable()
                                .Where(x => (x["Coffee_Country"] as string).ToLower() == ((searchForm.Controls["comboBox1"] as ComboBox).SelectedItem as string))
                                .CopyToDataTable();
                            break;
                        }
                    case 4:
                        {
                            DataTable temp = CoffeeModel.coffeeTable.AsEnumerable()
                                .Where(x => (x["Coffee_Type"] as string).ToLower() == ((searchForm.Controls["comboBox2"] as ComboBox).SelectedItem as string))
                                .OrderBy(y => y["Coffee_Price"])
                                .Reverse()
                                .CopyToDataTable();

                            CoffeeModel.coffeeTableFound = temp.AsEnumerable().Take(3).CopyToDataTable();
                            break;
                        }
                    case 5:
                        {
                            DataTable temp = CoffeeModel.coffeeTable.AsEnumerable()
                                .Where(x => (x["Coffee_Type"] as string).ToLower() == ((searchForm.Controls["comboBox2"] as ComboBox).SelectedItem as string))
                                .OrderBy(y => y["Coffee_Price"])
                                .CopyToDataTable();

                            CoffeeModel.coffeeTableFound = temp.AsEnumerable().Take(3).CopyToDataTable();
                            break;
                        }
                }
            } catch (InvalidOperationException e) { }

            Updater(dataGridView2);
            searchForm.Dispose();
        }
    }
}
