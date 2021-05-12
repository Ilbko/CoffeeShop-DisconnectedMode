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

namespace CoffeeShop_DisconnectedMode_.View
{
    //Форма поиска
    public partial class SearchForm : Form
    {
        //Режим поиска, логика и "ссылка" на датаГрид поиска
        private int mode;
        Logic logic = new Logic();
        DataGridView dataGridView2;
        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(int mode, DataGridView dataGridView2)
        {
            InitializeComponent();
            this.mode = mode;
            this.dataGridView2 = dataGridView2;
            //В зависимости от режима включаются элементы окна
            switch (mode)
            {
                case 1:
                    {
                        this.label2.Enabled = true;
                        this.textBox1.Enabled = true;
                        this.textBox2.Enabled = true;
                        break;
                    }
                case 2:
                    {
                        this.label5.Enabled = true;
                        this.numericUpDown1.Enabled = true;
                        this.numericUpDown2.Enabled = true;
                        break;
                    }
                case 3:
                    {
                        this.label8.Enabled = true;
                        this.comboBox1.Enabled = true;

                        //Для заполнения комбоБоксов создаётся хешСет (только уникальные значения), наполняющийся значениями определённых полей с таблицы
                        //который потом заполняет комбоБокс
                        HashSet<string> countries = new HashSet<string>();
                        foreach (DataRow item in CoffeeModel.coffeeTable.Rows)
                        {
                            countries.Add((item["Coffee_Country"] as string).ToLower());
                        }
                        comboBox1.Items.AddRange(countries.ToArray());
                        break;
                    }
                case 4:
                    {
                        this.label9.Enabled = true;
                        this.comboBox2.Enabled = true;

                        HashSet<string> types = new HashSet<string>();
                        foreach (DataRow item in CoffeeModel.coffeeTable.Rows)
                        {
                            types.Add((item["Coffee_Type"] as string).ToLower());
                        }
                        comboBox2.Items.AddRange(types.ToArray());
                        break;
                    }
                case 5:
                    {
                        this.label9.Enabled = true;
                        this.comboBox2.Enabled = true;

                        HashSet<string> types = new HashSet<string>();
                        foreach (DataRow item in CoffeeModel.coffeeTable.Rows)
                        {
                            types.Add((item["Coffee_Type"] as string).ToLower());
                        }
                        comboBox2.Items.AddRange(types.ToArray());
                        break;
                    }
            }

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e) => logic.TextHandler(sender as TextBox, e);

        private void button1_Click(object sender, EventArgs e) => logic.ButtonFind(mode, this, dataGridView2);
    }
}
