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
        private void Updater(DataGridView grid)
        {
            grid.DataSource = Communication.coffeeTableFound;
            grid.Update();
        }

        private void Updater(TextBox box, Dictionary<string, int?> dict)
        {
            box.Text = string.Empty;
            foreach(var item in dict)
            {
                box.Text += $"{item.Key} : {item.Value}\r\n";
            }
        }

        internal void TextHandler(TextBox sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !char.IsDigit(e.KeyChar) && !(e.KeyChar == '.' && !sender.Text.Contains(".")))
                e.Handled = true;
        }

        internal void FindCherry(DataGridView dataGridView2)
        {
            Communication.coffeeTableFound = Communication.coffeeTable.AsEnumerable()
                .Where(x => (x["Coffee_Info"] as string).Contains("вишн")).CopyToDataTable();

            Updater(dataGridView2);
        }

        internal void FindTop3CheapestSort(DataGridView dataGridView2)
        {
            DataTable temp = Communication.coffeeTable.AsEnumerable().OrderBy(x => x["Coffee_Price"]).CopyToDataTable();
            Communication.coffeeTableFound = temp.AsEnumerable().Take(3).CopyToDataTable();

            Updater(dataGridView2);
        }

        internal void FindTop3CountriesSort(TextBox InfoTextBox)
        {
            Dictionary<string, int?> countries = new Dictionary<string, int?>();
            foreach(DataRow item in Communication.coffeeTable.Rows)
            {
                if (!countries.Any(x => x.Key == (item["Coffee_Country"] as string).ToLower()))
                    countries.Add(item["Coffee_Country"] as string, 1);
                else
                    countries[item["Coffee_Country"] as string]++;
            }
            countries = countries.OrderBy(x => x.Value).Reverse().Take(3).ToDictionary(y => y.Key, y => y.Value);

            Updater(InfoTextBox, countries);
        }

        internal void FindTop3CountriesGram(TextBox InfoTextBox)
        {
            Dictionary<string, int?> countries = new Dictionary<string, int?>();
            foreach(DataRow item in Communication.coffeeTable.Rows)
            {
                if (!countries.Any(x => x.Key == (item["Coffee_Country"] as string).ToLower()))
                    countries.Add(item["Coffee_Country"] as string, item["Coffee_Grams"] as int?);
                else
                    countries[item["Coffee_Country"] as string] += item["Coffee_Grams"] as int?;
            }
            countries = countries.OrderBy(x => x.Value).Reverse().Take(3).ToDictionary(y => y.Key, y => y.Value);

            Updater(InfoTextBox, countries);
        }

        internal void FindTop3ArabicaGram(DataGridView dataGridView2)
        {
            DataTable temp = Communication.coffeeTable.AsEnumerable().Where(x => (x["Coffee_Type"] as string).ToLower() == "арабика").OrderBy(x => x["Coffee_Grams"]).CopyToDataTable();
            Communication.coffeeTableFound = temp.AsEnumerable().Reverse().Take(3).CopyToDataTable();

            Updater(dataGridView2);
        }

        internal void FindTop3RobustaGram(DataGridView dataGridView2)
        {
            DataTable temp = Communication.coffeeTable.AsEnumerable().Where(x => (x["Coffee_Type"] as string).ToLower() == "робуста").OrderBy(x => x["Coffee_Grams"]).CopyToDataTable();
            Communication.coffeeTableFound = temp.AsEnumerable().Reverse().Take(3).CopyToDataTable();

            Updater(dataGridView2);
        }

        internal void FindTop3Gram(DataGridView dataGridView2)
        {
            DataTable temp = Communication.coffeeTable.AsEnumerable().OrderBy(x => x["Coffee_Grams"]).CopyToDataTable();
            Communication.coffeeTableFound = temp.AsEnumerable().Reverse().Take(3).CopyToDataTable();

            Updater(dataGridView2);
        }

        internal void FindTop3Expensive(DataGridView dataGridView2)
        {
            DataTable temp = Communication.coffeeTable.AsEnumerable().OrderBy(x => x["Coffee_Price"]).CopyToDataTable();
            Communication.coffeeTableFound = temp.AsEnumerable().Reverse().Take(3).CopyToDataTable();

            Updater(dataGridView2);
        }

        internal void ButtonFind(int mode, SearchForm searchForm, DataGridView dataGridView2)
        {
            try
            {
                switch (mode)
                {
                    case 1:
                        {
                            double price1 = double.Parse(searchForm.Controls["textBox1"].Text);
                            double price2 = double.Parse(searchForm.Controls["textBox2"].Text);
                            if (price1 > price2)
                            {
                                double temp = price1;
                                price1 = price2;
                                price2 = temp;
                            }

                            Communication.coffeeTableFound = Communication.coffeeTable.AsEnumerable()
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

                            Communication.coffeeTableFound = Communication.coffeeTable.AsEnumerable()
                                .Where(x => x["Coffee_Grams"] as int? >= gram1 && x["Coffee_Grams"] as int? <= gram2)
                                .CopyToDataTable();
                            break;
                        }
                    case 3:
                        {
                            Communication.coffeeTableFound = Communication.coffeeTable.AsEnumerable()
                                .Where(x => (x["Coffee_Country"] as string).ToLower() == ((searchForm.Controls["comboBox1"] as ComboBox).SelectedItem as string))
                                .CopyToDataTable();
                            break;
                        }
                    case 4:
                        {
                            DataTable temp = Communication.coffeeTable.AsEnumerable()
                                .Where(x => (x["Coffee_Type"] as string).ToLower() == ((searchForm.Controls["comboBox2"] as ComboBox).SelectedItem as string))
                                .OrderBy(y => y["Coffee_Price"])
                                .Reverse()
                                .CopyToDataTable();

                            Communication.coffeeTableFound = temp.AsEnumerable().Take(3).CopyToDataTable();
                            break;
                        }
                    case 5:
                        {
                            DataTable temp = Communication.coffeeTable.AsEnumerable()
                                .Where(x => (x["Coffee_Type"] as string).ToLower() == ((searchForm.Controls["comboBox2"] as ComboBox).SelectedItem as string))
                                .OrderBy(y => y["Coffee_Price"])
                                .CopyToDataTable();

                            Communication.coffeeTableFound = temp.AsEnumerable().Take(3).CopyToDataTable();
                            break;
                        }
                }
            } catch (InvalidOperationException e) { }

            Updater(dataGridView2);
            searchForm.Dispose();
        }
    }
}
