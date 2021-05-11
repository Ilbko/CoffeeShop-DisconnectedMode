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
    }
}
