using CoffeeShop_DisconnectedMode_.Control;
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

        private void Top3CountriesSortToolStripMenuItem_Click(object sender, EventArgs e) => logic.FindTop3CountriesSort(this.dataGridView2);

        private void Top3CountriesGramToolStripMenuItem_Click(object sender, EventArgs e) => logic.FindTop3CountriesGram(this.dataGridView2);

        private void Top3ArabicaGramToolStripMenuItem_Click(object sender, EventArgs e) => logic.FindTop3ArabicaGram(this.dataGridView2);

        private void Top3RobustaGramToolStripMenuItem_Click(object sender, EventArgs e) => logic.FindTop3RobustaGram(this.dataGridView2);

        private void Top3GramToolStripMenuItem_Click(object sender, EventArgs e) => logic.FindTop3Gram(this.dataGridView2);

        private void Top3ExpensiveToolStripMenuItem_Click(object sender, EventArgs e) => logic.Top3Expensive(this.dataGridView2);
    }
}
