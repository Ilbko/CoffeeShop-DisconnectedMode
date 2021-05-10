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
        internal void Updater(DataGridView grid)
        {
            grid.DataSource = Communication.coffeeTableFound;
            grid.Update();
        }

        internal void FindCherry(DataGridView dataGridView2)
        {
            Communication.coffeeTableFound = Communication.coffeeTable.AsEnumerable()
                .Where(x => (x["Coffee_Info"] as string).Contains("вишн")).CopyToDataTable();

            Updater(dataGridView2);
        }

        internal void FindTop3CheapestSort(DataGridView dataGridView2)
        {
            DataTable temp;

            temp = Communication.coffeeTable.AsEnumerable().OrderBy(x => x["Coffee_Price"] as int?).CopyToDataTable();
            Communication.coffeeTable.AsEnumerable().Take(3);

            Updater(dataGridView2);
        }

        internal void FindTop3CountriesSort(DataGridView dataGridView2)
        {
            throw new NotImplementedException();
        }

        internal void FindTop3CountriesGram(DataGridView dataGridView2)
        {
            throw new NotImplementedException();
        }

        internal void FindTop3ArabicaGram(DataGridView dataGridView2)
        {
            throw new NotImplementedException();
        }

        internal void FindTop3RobustaGram(DataGridView dataGridView2)
        {
            throw new NotImplementedException();
        }

        internal void FindTop3Gram(DataGridView dataGridView2)
        {
            throw new NotImplementedException();
        }

        internal void Top3Expensive(DataGridView dataGridView2)
        {
            throw new NotImplementedException();
        }
    }
}
