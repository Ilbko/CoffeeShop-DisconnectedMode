using CoffeeShop_DisconnectedMode_.Control;
using CoffeeShop_DisconnectedMode_.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop_DisconnectedMode_
{
    public partial class Form1 : Form
    {
        public Logic logic = new Logic();
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = Communication.coffeeTable;
            this.dataGridView2.DataSource = Communication.coffeeTableFound;
            this.dataGridView1.Columns[0].ReadOnly = true;
        }

        private void CherryCoffeeToolStripMenuItem_Click(object sender, EventArgs e) => logic.FindCherry(this.dataGridView2);

        private void Top3CheapestToolStripMenuItem_Click(object sender, EventArgs e) => logic.FindTop3CheapestSort(this.dataGridView2);

        private void Top3CountriesSortToolStripMenuItem_Click(object sender, EventArgs e) => logic.FindTop3CountriesSort(this.InfoTextBox);

        private void Top3CountriesGramToolStripMenuItem_Click(object sender, EventArgs e) => logic.FindTop3CountriesGram(this.InfoTextBox);

        private void Top3ArabicaGramToolStripMenuItem_Click(object sender, EventArgs e) => logic.FindTop3ArabicaGram(this.dataGridView2);

        private void Top3RobustaGramToolStripMenuItem_Click(object sender, EventArgs e) => logic.FindTop3RobustaGram(this.dataGridView2);

        private void Top3GramToolStripMenuItem_Click(object sender, EventArgs e) => logic.FindTop3Gram(this.dataGridView2);

        private void Top3ExpensiveToolStripMenuItem_Click(object sender, EventArgs e) => logic.FindTop3Expensive(this.dataGridView2);

        private void CostRangeToolStripMenuItem_Click(object sender, EventArgs e) => new SearchForm(1, dataGridView2).ShowDialog();

        private void GramRangeToolStripMenuItem_Click(object sender, EventArgs e) => new SearchForm(2, dataGridView2).ShowDialog();

        private void ByCountryToolStripMenuItem_Click(object sender, EventArgs e) => new SearchForm(3, dataGridView2).ShowDialog();

        private void Top3ExpensiveSortToolStripMenuItem_Click(object sender, EventArgs e) => new SearchForm(4, dataGridView2).ShowDialog();

        private void Top3CheapestSortToolStripMenuItem_Click(object sender, EventArgs e) => new SearchForm(5, dataGridView2).ShowDialog();
    }
}
