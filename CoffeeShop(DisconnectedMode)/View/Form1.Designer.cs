
namespace CoffeeShop_DisconnectedMode_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CostRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GramRangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ByCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Top3ExpensiveSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Top3CheapestSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоЗапросамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CherryCoffeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Top3CheapestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Top3ExpensiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Top3CountriesSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Top3CountriesGramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Top3ArabicaGramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Top3RobustaGramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Top3GramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.поискПоЗапросамToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(684, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CostRangeToolStripMenuItem,
            this.GramRangeToolStripMenuItem,
            this.ByCountryToolStripMenuItem,
            this.Top3ExpensiveSortToolStripMenuItem,
            this.Top3CheapestSortToolStripMenuItem});
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.поискToolStripMenuItem.Text = "Поиск";
            // 
            // CostRangeToolStripMenuItem
            // 
            this.CostRangeToolStripMenuItem.Name = "CostRangeToolStripMenuItem";
            this.CostRangeToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.CostRangeToolStripMenuItem.Text = "Себестоимость в диапазоне";
            // 
            // GramRangeToolStripMenuItem
            // 
            this.GramRangeToolStripMenuItem.Name = "GramRangeToolStripMenuItem";
            this.GramRangeToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.GramRangeToolStripMenuItem.Text = "Граммы в диапазоне";
            // 
            // ByCountryToolStripMenuItem
            // 
            this.ByCountryToolStripMenuItem.Name = "ByCountryToolStripMenuItem";
            this.ByCountryToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.ByCountryToolStripMenuItem.Text = "По странам";
            // 
            // Top3ExpensiveSortToolStripMenuItem
            // 
            this.Top3ExpensiveSortToolStripMenuItem.Name = "Top3ExpensiveSortToolStripMenuItem";
            this.Top3ExpensiveSortToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.Top3ExpensiveSortToolStripMenuItem.Text = "Топ-3 дорогих сортов";
            // 
            // Top3CheapestSortToolStripMenuItem
            // 
            this.Top3CheapestSortToolStripMenuItem.Name = "Top3CheapestSortToolStripMenuItem";
            this.Top3CheapestSortToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.Top3CheapestSortToolStripMenuItem.Text = "Топ-3 дешёвых сортов";
            // 
            // поискПоЗапросамToolStripMenuItem
            // 
            this.поискПоЗапросамToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CherryCoffeeToolStripMenuItem,
            this.Top3CheapestToolStripMenuItem,
            this.Top3ExpensiveToolStripMenuItem,
            this.Top3CountriesSortToolStripMenuItem,
            this.Top3CountriesGramToolStripMenuItem,
            this.Top3ArabicaGramToolStripMenuItem,
            this.Top3RobustaGramToolStripMenuItem,
            this.Top3GramToolStripMenuItem});
            this.поискПоЗапросамToolStripMenuItem.Name = "поискПоЗапросамToolStripMenuItem";
            this.поискПоЗапросамToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.поискПоЗапросамToolStripMenuItem.Text = "Поиск по запросам";
            // 
            // CherryCoffeeToolStripMenuItem
            // 
            this.CherryCoffeeToolStripMenuItem.Name = "CherryCoffeeToolStripMenuItem";
            this.CherryCoffeeToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.CherryCoffeeToolStripMenuItem.Text = "Кофе с вишней";
            this.CherryCoffeeToolStripMenuItem.Click += new System.EventHandler(this.CherryCoffeeToolStripMenuItem_Click);
            // 
            // Top3CheapestToolStripMenuItem
            // 
            this.Top3CheapestToolStripMenuItem.Name = "Top3CheapestToolStripMenuItem";
            this.Top3CheapestToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.Top3CheapestToolStripMenuItem.Text = "Три самых дешёвых сорта";
            this.Top3CheapestToolStripMenuItem.Click += new System.EventHandler(this.Top3CheapestToolStripMenuItem_Click);
            // 
            // Top3ExpensiveToolStripMenuItem
            // 
            this.Top3ExpensiveToolStripMenuItem.Name = "Top3ExpensiveToolStripMenuItem";
            this.Top3ExpensiveToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.Top3ExpensiveToolStripMenuItem.Text = "Три самых дорогих сорта";
            this.Top3ExpensiveToolStripMenuItem.Click += new System.EventHandler(this.Top3ExpensiveToolStripMenuItem_Click);
            // 
            // Top3CountriesSortToolStripMenuItem
            // 
            this.Top3CountriesSortToolStripMenuItem.Name = "Top3CountriesSortToolStripMenuItem";
            this.Top3CountriesSortToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.Top3CountriesSortToolStripMenuItem.Text = "Топ-3 стран по сортам";
            this.Top3CountriesSortToolStripMenuItem.Click += new System.EventHandler(this.Top3CountriesSortToolStripMenuItem_Click);
            // 
            // Top3CountriesGramToolStripMenuItem
            // 
            this.Top3CountriesGramToolStripMenuItem.Name = "Top3CountriesGramToolStripMenuItem";
            this.Top3CountriesGramToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.Top3CountriesGramToolStripMenuItem.Text = "Топ-3 стран по граммам";
            this.Top3CountriesGramToolStripMenuItem.Click += new System.EventHandler(this.Top3CountriesGramToolStripMenuItem_Click);
            // 
            // Top3ArabicaGramToolStripMenuItem
            // 
            this.Top3ArabicaGramToolStripMenuItem.Name = "Top3ArabicaGramToolStripMenuItem";
            this.Top3ArabicaGramToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.Top3ArabicaGramToolStripMenuItem.Text = "Топ-3 \"арабики\" по граммам";
            this.Top3ArabicaGramToolStripMenuItem.Click += new System.EventHandler(this.Top3ArabicaGramToolStripMenuItem_Click);
            // 
            // Top3RobustaGramToolStripMenuItem
            // 
            this.Top3RobustaGramToolStripMenuItem.Name = "Top3RobustaGramToolStripMenuItem";
            this.Top3RobustaGramToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.Top3RobustaGramToolStripMenuItem.Text = "Топ-3 \"робусты\" по граммам";
            this.Top3RobustaGramToolStripMenuItem.Click += new System.EventHandler(this.Top3RobustaGramToolStripMenuItem_Click);
            // 
            // Top3GramToolStripMenuItem
            // 
            this.Top3GramToolStripMenuItem.Name = "Top3GramToolStripMenuItem";
            this.Top3GramToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.Top3GramToolStripMenuItem.Text = "Топ-3 кофе по граммам";
            this.Top3GramToolStripMenuItem.Click += new System.EventHandler(this.Top3GramToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Все кофе";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(300, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(562, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Найденный кофе";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(372, 47);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(300, 150);
            this.dataGridView2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CostRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GramRangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ByCountryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Top3ExpensiveSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Top3CheapestSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоЗапросамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CherryCoffeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Top3CheapestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Top3ExpensiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Top3CountriesSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Top3CountriesGramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Top3ArabicaGramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Top3RobustaGramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Top3GramToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

