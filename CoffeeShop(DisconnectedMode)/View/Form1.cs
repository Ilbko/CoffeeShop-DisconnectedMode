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
    //Главная форма
    public partial class Form1 : Form
    {
        //Объект класса логики
        public Logic logic = new Logic();
        //Установка источников данных датаГридов (главного и поиска)
        public Form1()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = CoffeeModel.coffeeTable;
            this.dataGridView2.DataSource = CoffeeModel.coffeeTableFound;
            //Поскольку в первом датаГриде можно изменять записи, то нужно запретить изменять айди записи 
            //или вводить его вручную (БД сама выдаёт айди записи)
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => CoffeeModel.SaveChanges(this.dataGridView1);

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e) => CoffeeModel.isChanges = true;

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e) => CoffeeModel.isChanges = true;
    }
}
