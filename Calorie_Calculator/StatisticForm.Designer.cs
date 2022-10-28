
namespace Calorie_Calculator
{
    partial class StatisticForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.mainTable = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteinsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbohydratesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getDishesOnDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calorie_СalculatorDataSet = new Calorie_Calculator.Calorie_СalculatorDataSet();
            this.calorie_СalculatorDataSet1 = new Calorie_Calculator.Calorie_СalculatorDataSet();
            this.dtpSelectDate = new System.Windows.Forms.DateTimePicker();
            this.dishTableAdapter = new Calorie_Calculator.Calorie_СalculatorDataSetTableAdapters.DishTableAdapter();
            this.dishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbDishWeight = new System.Windows.Forms.TextBox();
            this.cbDishes = new System.Windows.Forms.ComboBox();
            this.day_StatisticTableAdapter = new Calorie_Calculator.Calorie_СalculatorDataSetTableAdapters.Day_StatisticTableAdapter();
            this.getDishInfoTableAdapter = new Calorie_Calculator.Calorie_СalculatorDataSetTableAdapters.GetDishInfoTableAdapter();
            this.calorie_СalculatorDataSet2 = new Calorie_Calculator.Calorie_СalculatorDataSet();
            this.dish_Day_StatisticTableAdapter = new Calorie_Calculator.Calorie_СalculatorDataSetTableAdapters.Dish_Day_StatisticTableAdapter();
            this.btnDeleteDish = new System.Windows.Forms.Button();
            this.chartGraphic1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.userTableAdapter = new Calorie_Calculator.Calorie_СalculatorDataSetTableAdapters.UserTableAdapter();
            this.chartGraphic2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNorm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGeined = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.getDishesOnDateTableAdapter = new Calorie_Calculator.Calorie_СalculatorDataSetTableAdapters.GetDishesOnDateTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDishesOnDateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorie_СalculatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorie_СalculatorDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorie_СalculatorDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddDish
            // 
            this.btnAddDish.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddDish.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddDish.FlatAppearance.BorderSize = 0;
            this.btnAddDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAddDish.ForeColor = System.Drawing.Color.White;
            this.btnAddDish.Location = new System.Drawing.Point(644, 84);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(168, 35);
            this.btnAddDish.TabIndex = 4;
            this.btnAddDish.Text = "Додати страву";
            this.btnAddDish.UseVisualStyleBackColor = false;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // mainTable
            // 
            this.mainTable.AllowUserToAddRows = false;
            this.mainTable.AllowUserToDeleteRows = false;
            this.mainTable.AutoGenerateColumns = false;
            this.mainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.caloriesDataGridViewTextBoxColumn,
            this.proteinsDataGridViewTextBoxColumn,
            this.fatsDataGridViewTextBoxColumn,
            this.carbohydratesDataGridViewTextBoxColumn});
            this.mainTable.DataSource = this.getDishesOnDateBindingSource;
            this.mainTable.Location = new System.Drawing.Point(12, 172);
            this.mainTable.Name = "mainTable";
            this.mainTable.ReadOnly = true;
            this.mainTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainTable.Size = new System.Drawing.Size(343, 202);
            this.mainTable.TabIndex = 5;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Вага";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caloriesDataGridViewTextBoxColumn
            // 
            this.caloriesDataGridViewTextBoxColumn.DataPropertyName = "calories";
            this.caloriesDataGridViewTextBoxColumn.HeaderText = "Калорії";
            this.caloriesDataGridViewTextBoxColumn.Name = "caloriesDataGridViewTextBoxColumn";
            this.caloriesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proteinsDataGridViewTextBoxColumn
            // 
            this.proteinsDataGridViewTextBoxColumn.DataPropertyName = "proteins";
            this.proteinsDataGridViewTextBoxColumn.HeaderText = "proteins";
            this.proteinsDataGridViewTextBoxColumn.Name = "proteinsDataGridViewTextBoxColumn";
            this.proteinsDataGridViewTextBoxColumn.ReadOnly = true;
            this.proteinsDataGridViewTextBoxColumn.Visible = false;
            // 
            // fatsDataGridViewTextBoxColumn
            // 
            this.fatsDataGridViewTextBoxColumn.DataPropertyName = "fats";
            this.fatsDataGridViewTextBoxColumn.HeaderText = "fats";
            this.fatsDataGridViewTextBoxColumn.Name = "fatsDataGridViewTextBoxColumn";
            this.fatsDataGridViewTextBoxColumn.ReadOnly = true;
            this.fatsDataGridViewTextBoxColumn.Visible = false;
            // 
            // carbohydratesDataGridViewTextBoxColumn
            // 
            this.carbohydratesDataGridViewTextBoxColumn.DataPropertyName = "carbohydrates";
            this.carbohydratesDataGridViewTextBoxColumn.HeaderText = "carbohydrates";
            this.carbohydratesDataGridViewTextBoxColumn.Name = "carbohydratesDataGridViewTextBoxColumn";
            this.carbohydratesDataGridViewTextBoxColumn.ReadOnly = true;
            this.carbohydratesDataGridViewTextBoxColumn.Visible = false;
            // 
            // getDishesOnDateBindingSource
            // 
            this.getDishesOnDateBindingSource.DataMember = "GetDishesOnDate";
            this.getDishesOnDateBindingSource.DataSource = this.bindingSource;
            // 
            // bindingSource
            // 
            this.bindingSource.DataSource = this.calorie_СalculatorDataSet;
            this.bindingSource.Position = 0;
            // 
            // calorie_СalculatorDataSet
            // 
            this.calorie_СalculatorDataSet.DataSetName = "Calorie_СalculatorDataSet";
            this.calorie_СalculatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calorie_СalculatorDataSet1
            // 
            this.calorie_СalculatorDataSet1.DataSetName = "Calorie_СalculatorDataSet";
            this.calorie_СalculatorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dtpSelectDate
            // 
            this.dtpSelectDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpSelectDate.Location = new System.Drawing.Point(167, 92);
            this.dtpSelectDate.Name = "dtpSelectDate";
            this.dtpSelectDate.Size = new System.Drawing.Size(197, 20);
            this.dtpSelectDate.TabIndex = 1;
            this.dtpSelectDate.ValueChanged += new System.EventHandler(this.dtpSelectDate_ValueChanged);
            // 
            // dishTableAdapter
            // 
            this.dishTableAdapter.ClearBeforeFill = true;
            // 
            // dishBindingSource
            // 
            this.dishBindingSource.DataMember = "Dish";
            this.dishBindingSource.DataSource = this.calorie_СalculatorDataSet;
            // 
            // tbDishWeight
            // 
            this.tbDishWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbDishWeight.Location = new System.Drawing.Point(536, 87);
            this.tbDishWeight.Name = "tbDishWeight";
            this.tbDishWeight.Size = new System.Drawing.Size(92, 29);
            this.tbDishWeight.TabIndex = 3;
            this.tbDishWeight.Text = "100";
            // 
            // cbDishes
            // 
            this.cbDishes.DataSource = this.dishBindingSource;
            this.cbDishes.DisplayMember = "name";
            this.cbDishes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbDishes.FormattingEnabled = true;
            this.cbDishes.Location = new System.Drawing.Point(398, 89);
            this.cbDishes.Name = "cbDishes";
            this.cbDishes.Size = new System.Drawing.Size(132, 26);
            this.cbDishes.TabIndex = 2;
            this.cbDishes.ValueMember = "dish_id";
            // 
            // day_StatisticTableAdapter
            // 
            this.day_StatisticTableAdapter.ClearBeforeFill = true;
            // 
            // getDishInfoTableAdapter
            // 
            this.getDishInfoTableAdapter.ClearBeforeFill = true;
            // 
            // calorie_СalculatorDataSet2
            // 
            this.calorie_СalculatorDataSet2.DataSetName = "Calorie_СalculatorDataSet";
            this.calorie_СalculatorDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dish_Day_StatisticTableAdapter
            // 
            this.dish_Day_StatisticTableAdapter.ClearBeforeFill = true;
            // 
            // btnDeleteDish
            // 
            this.btnDeleteDish.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDeleteDish.FlatAppearance.BorderSize = 2;
            this.btnDeleteDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDeleteDish.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDeleteDish.Location = new System.Drawing.Point(644, 126);
            this.btnDeleteDish.Name = "btnDeleteDish";
            this.btnDeleteDish.Size = new System.Drawing.Size(168, 35);
            this.btnDeleteDish.TabIndex = 5;
            this.btnDeleteDish.Text = "Видалити страву";
            this.btnDeleteDish.UseVisualStyleBackColor = true;
            this.btnDeleteDish.Click += new System.EventHandler(this.btnDeleteDish_Click);
            // 
            // chartGraphic1
            // 
            chartArea1.Name = "ChartArea1";
            this.chartGraphic1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartGraphic1.Legends.Add(legend1);
            this.chartGraphic1.Location = new System.Drawing.Point(12, 392);
            this.chartGraphic1.Name = "chartGraphic1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Отримані калорії за день";
            series1.Name = "main";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.LegendText = "Нижня рекомендована границя";
            series2.Name = "bot";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.LegendText = "Верхня рекомендована границя";
            series3.Name = "top";
            this.chartGraphic1.Series.Add(series1);
            this.chartGraphic1.Series.Add(series2);
            this.chartGraphic1.Series.Add(series3);
            this.chartGraphic1.Size = new System.Drawing.Size(800, 313);
            this.chartGraphic1.TabIndex = 11;
            this.chartGraphic1.Text = "chart1";
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // chartGraphic2
            // 
            this.chartGraphic2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartGraphic2.BorderSkin.BackColor = System.Drawing.Color.Black;
            this.chartGraphic2.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chartGraphic2.BorderSkin.BorderWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.chartGraphic2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGraphic2.Legends.Add(legend2);
            this.chartGraphic2.Location = new System.Drawing.Point(378, 172);
            this.chartGraphic2.Name = "chartGraphic2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "main";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartGraphic2.Series.Add(series4);
            this.chartGraphic2.Size = new System.Drawing.Size(434, 202);
            this.chartGraphic2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(28, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Сьогодні отримано калорій:";
            // 
            // lbNorm
            // 
            this.lbNorm.AutoSize = true;
            this.lbNorm.BackColor = System.Drawing.SystemColors.Control;
            this.lbNorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbNorm.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbNorm.Location = new System.Drawing.Point(552, 135);
            this.lbNorm.Name = "lbNorm";
            this.lbNorm.Size = new System.Drawing.Size(18, 20);
            this.lbNorm.TabIndex = 15;
            this.lbNorm.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(375, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Денна норма (кклал):";
            // 
            // lbGeined
            // 
            this.lbGeined.AutoSize = true;
            this.lbGeined.BackColor = System.Drawing.SystemColors.Control;
            this.lbGeined.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbGeined.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbGeined.Location = new System.Drawing.Point(238, 135);
            this.lbGeined.Name = "lbGeined";
            this.lbGeined.Size = new System.Drawing.Size(18, 20);
            this.lbGeined.TabIndex = 17;
            this.lbGeined.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(28, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Вибраний день:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Calorie_Calculator.Properties.Resources.question_sign;
            this.pictureBox1.Location = new System.Drawing.Point(388, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 62);
            this.panel1.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(237, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Моніторинг отриманих речовин";
            // 
            // getDishesOnDateTableAdapter
            // 
            this.getDishesOnDateTableAdapter.ClearBeforeFill = true;
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 717);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGeined);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNorm);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chartGraphic2);
            this.Controls.Add(this.chartGraphic1);
            this.Controls.Add(this.btnDeleteDish);
            this.Controls.Add(this.cbDishes);
            this.Controls.Add(this.tbDishWeight);
            this.Controls.Add(this.dtpSelectDate);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.btnAddDish);
            this.KeyPreview = true;
            this.Name = "StatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.StatisticForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StatisticForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getDishesOnDateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorie_СalculatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorie_СalculatorDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorie_СalculatorDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraphic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.DataGridView mainTable;
        private System.Windows.Forms.DateTimePicker dtpSelectDate;
        private System.Windows.Forms.BindingSource dishBindingSource;
        private Calorie_СalculatorDataSet calorie_СalculatorDataSet;
        private Calorie_СalculatorDataSetTableAdapters.DishTableAdapter dishTableAdapter;
        private System.Windows.Forms.TextBox tbDishWeight;
        private System.Windows.Forms.ComboBox cbDishes;
        private Calorie_СalculatorDataSetTableAdapters.Day_StatisticTableAdapter day_StatisticTableAdapter;
        private Calorie_СalculatorDataSetTableAdapters.GetDishInfoTableAdapter getDishInfoTableAdapter;
        private Calorie_СalculatorDataSet calorie_СalculatorDataSet2;
        private Calorie_СalculatorDataSetTableAdapters.Dish_Day_StatisticTableAdapter dish_Day_StatisticTableAdapter;
        private Calorie_СalculatorDataSet calorie_СalculatorDataSet1;
        private System.Windows.Forms.Button btnDeleteDish;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphic1;
        private Calorie_СalculatorDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraphic2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNorm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbGeined;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteinsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbohydratesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource getDishesOnDateBindingSource;
        private System.Windows.Forms.BindingSource bindingSource;
        private Calorie_СalculatorDataSetTableAdapters.GetDishesOnDateTableAdapter getDishesOnDateTableAdapter;
    }
}