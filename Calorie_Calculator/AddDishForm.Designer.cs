
namespace Calorie_Calculator
{
    partial class AddDishForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.tableDishIngredient = new System.Windows.Forms.DataGridView();
            this.ingredient_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableAddIngredients = new System.Windows.Forms.DataGridView();
            this.ingredientidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caloriesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proteinsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carbohydratesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calorie_СalculatorDataSet = new Calorie_Calculator.Calorie_СalculatorDataSet();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddIngridient = new System.Windows.Forms.Button();
            this.btnCreateOrChangeDish = new System.Windows.Forms.Button();
            this.ingredientTableAdapter = new Calorie_Calculator.Calorie_СalculatorDataSetTableAdapters.IngredientTableAdapter();
            this.dish_IngredientTableAdapter = new Calorie_Calculator.Calorie_СalculatorDataSetTableAdapters.Dish_IngredientTableAdapter();
            this.dishTableAdapter = new Calorie_Calculator.Calorie_СalculatorDataSetTableAdapters.DishTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCarbohydratesSum = new System.Windows.Forms.Label();
            this.lbFatsSum = new System.Windows.Forms.Label();
            this.lbProteinsSum = new System.Windows.Forms.Label();
            this.lbCaloriesSum = new System.Windows.Forms.Label();
            this.lbWeightSum = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClearSearch = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableDishIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAddIngredients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorie_СalculatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(24, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Назва";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbName.Location = new System.Drawing.Point(102, 78);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(215, 29);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(24, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Опис";
            // 
            // tbDescription
            // 
            this.tbDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tbDescription.Location = new System.Drawing.Point(102, 129);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(215, 70);
            this.tbDescription.TabIndex = 2;
            // 
            // tableDishIngredient
            // 
            this.tableDishIngredient.AllowUserToAddRows = false;
            this.tableDishIngredient.AllowUserToDeleteRows = false;
            this.tableDishIngredient.AllowUserToResizeColumns = false;
            this.tableDishIngredient.AllowUserToResizeRows = false;
            this.tableDishIngredient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDishIngredient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredient_id,
            this.name,
            this.weight});
            this.tableDishIngredient.Location = new System.Drawing.Point(42, 246);
            this.tableDishIngredient.Name = "tableDishIngredient";
            this.tableDishIngredient.ReadOnly = true;
            this.tableDishIngredient.Size = new System.Drawing.Size(244, 238);
            this.tableDishIngredient.TabIndex = 17;
            this.tableDishIngredient.TabStop = false;
            this.tableDishIngredient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDishIngredient_CellDoubleClick);
            // 
            // ingredient_id
            // 
            this.ingredient_id.HeaderText = "Column1";
            this.ingredient_id.Name = "ingredient_id";
            this.ingredient_id.ReadOnly = true;
            this.ingredient_id.Visible = false;
            // 
            // name
            // 
            this.name.HeaderText = "Назва";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // weight
            // 
            this.weight.HeaderText = "Вага";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            // 
            // tableAddIngredients
            // 
            this.tableAddIngredients.AllowUserToAddRows = false;
            this.tableAddIngredients.AllowUserToDeleteRows = false;
            this.tableAddIngredients.AllowUserToResizeColumns = false;
            this.tableAddIngredients.AllowUserToResizeRows = false;
            this.tableAddIngredients.AutoGenerateColumns = false;
            this.tableAddIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableAddIngredients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ingredientidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.caloriesDataGridViewTextBoxColumn,
            this.proteinsDataGridViewTextBoxColumn,
            this.fatsDataGridViewTextBoxColumn,
            this.carbohydratesDataGridViewTextBoxColumn});
            this.tableAddIngredients.DataSource = this.ingredientBindingSource;
            this.tableAddIngredients.Location = new System.Drawing.Point(361, 121);
            this.tableAddIngredients.MultiSelect = false;
            this.tableAddIngredients.Name = "tableAddIngredients";
            this.tableAddIngredients.ReadOnly = true;
            this.tableAddIngredients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tableAddIngredients.Size = new System.Drawing.Size(643, 544);
            this.tableAddIngredients.TabIndex = 18;
            this.tableAddIngredients.TabStop = false;
            // 
            // ingredientidDataGridViewTextBoxColumn
            // 
            this.ingredientidDataGridViewTextBoxColumn.DataPropertyName = "ingredient_id";
            this.ingredientidDataGridViewTextBoxColumn.HeaderText = "ingredient_id";
            this.ingredientidDataGridViewTextBoxColumn.Name = "ingredientidDataGridViewTextBoxColumn";
            this.ingredientidDataGridViewTextBoxColumn.ReadOnly = true;
            this.ingredientidDataGridViewTextBoxColumn.Visible = false;
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
            this.weightDataGridViewTextBoxColumn.HeaderText = "Маса";
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
            this.proteinsDataGridViewTextBoxColumn.HeaderText = "Білки";
            this.proteinsDataGridViewTextBoxColumn.Name = "proteinsDataGridViewTextBoxColumn";
            this.proteinsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fatsDataGridViewTextBoxColumn
            // 
            this.fatsDataGridViewTextBoxColumn.DataPropertyName = "fats";
            this.fatsDataGridViewTextBoxColumn.HeaderText = "Жири";
            this.fatsDataGridViewTextBoxColumn.Name = "fatsDataGridViewTextBoxColumn";
            this.fatsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // carbohydratesDataGridViewTextBoxColumn
            // 
            this.carbohydratesDataGridViewTextBoxColumn.DataPropertyName = "carbohydrates";
            this.carbohydratesDataGridViewTextBoxColumn.HeaderText = "Вуглеводи";
            this.carbohydratesDataGridViewTextBoxColumn.Name = "carbohydratesDataGridViewTextBoxColumn";
            this.carbohydratesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingredientBindingSource
            // 
            this.ingredientBindingSource.DataMember = "Ingredient";
            this.ingredientBindingSource.DataSource = this.calorie_СalculatorDataSet;
            // 
            // calorie_СalculatorDataSet
            // 
            this.calorie_СalculatorDataSet.DataSetName = "Calorie_СalculatorDataSet";
            this.calorie_СalculatorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbTitle.Location = new System.Drawing.Point(71, 20);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(177, 24);
            this.lbTitle.TabIndex = 19;
            this.lbTitle.Text = "Створення страви";
            // 
            // tbWeight
            // 
            this.tbWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbWeight.Location = new System.Drawing.Point(451, 684);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(148, 29);
            this.tbWeight.TabIndex = 4;
            this.tbWeight.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(363, 687);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 22;
            this.label4.Text = "Вага (г):";
            // 
            // btnAddIngridient
            // 
            this.btnAddIngridient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnAddIngridient.Location = new System.Drawing.Point(643, 679);
            this.btnAddIngridient.Name = "btnAddIngridient";
            this.btnAddIngridient.Size = new System.Drawing.Size(174, 40);
            this.btnAddIngridient.TabIndex = 5;
            this.btnAddIngridient.Text = "Додати";
            this.btnAddIngridient.UseVisualStyleBackColor = true;
            this.btnAddIngridient.Click += new System.EventHandler(this.btnAddIngridient_Click);
            // 
            // btnCreateOrChangeDish
            // 
            this.btnCreateOrChangeDish.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnCreateOrChangeDish.FlatAppearance.BorderSize = 0;
            this.btnCreateOrChangeDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateOrChangeDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnCreateOrChangeDish.ForeColor = System.Drawing.Color.White;
            this.btnCreateOrChangeDish.Location = new System.Drawing.Point(42, 680);
            this.btnCreateOrChangeDish.Name = "btnCreateOrChangeDish";
            this.btnCreateOrChangeDish.Size = new System.Drawing.Size(244, 40);
            this.btnCreateOrChangeDish.TabIndex = 6;
            this.btnCreateOrChangeDish.Text = "Створити";
            this.btnCreateOrChangeDish.UseVisualStyleBackColor = false;
            this.btnCreateOrChangeDish.Click += new System.EventHandler(this.btnCreateDish_Click);
            // 
            // ingredientTableAdapter
            // 
            this.ingredientTableAdapter.ClearBeforeFill = true;
            // 
            // dish_IngredientTableAdapter
            // 
            this.dish_IngredientTableAdapter.ClearBeforeFill = true;
            // 
            // dishTableAdapter
            // 
            this.dishTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(38, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Загальна вага (г):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(38, 535);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "Загальна калорійність:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label7.Location = new System.Drawing.Point(38, 570);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Кількість білків:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(38, 638);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "Кількість жирів:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label9.Location = new System.Drawing.Point(38, 605);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 24);
            this.label9.TabIndex = 29;
            this.label9.Text = "Кількість вуглеводів";
            // 
            // lbCarbohydratesSum
            // 
            this.lbCarbohydratesSum.AutoSize = true;
            this.lbCarbohydratesSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbCarbohydratesSum.Location = new System.Drawing.Point(263, 605);
            this.lbCarbohydratesSum.Name = "lbCarbohydratesSum";
            this.lbCarbohydratesSum.Size = new System.Drawing.Size(20, 24);
            this.lbCarbohydratesSum.TabIndex = 34;
            this.lbCarbohydratesSum.Text = "0";
            // 
            // lbFatsSum
            // 
            this.lbFatsSum.AutoSize = true;
            this.lbFatsSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbFatsSum.Location = new System.Drawing.Point(263, 638);
            this.lbFatsSum.Name = "lbFatsSum";
            this.lbFatsSum.Size = new System.Drawing.Size(20, 24);
            this.lbFatsSum.TabIndex = 33;
            this.lbFatsSum.Text = "0";
            // 
            // lbProteinsSum
            // 
            this.lbProteinsSum.AutoSize = true;
            this.lbProteinsSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbProteinsSum.Location = new System.Drawing.Point(263, 570);
            this.lbProteinsSum.Name = "lbProteinsSum";
            this.lbProteinsSum.Size = new System.Drawing.Size(20, 24);
            this.lbProteinsSum.TabIndex = 32;
            this.lbProteinsSum.Text = "0";
            // 
            // lbCaloriesSum
            // 
            this.lbCaloriesSum.AutoSize = true;
            this.lbCaloriesSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbCaloriesSum.Location = new System.Drawing.Point(263, 535);
            this.lbCaloriesSum.Name = "lbCaloriesSum";
            this.lbCaloriesSum.Size = new System.Drawing.Size(20, 24);
            this.lbCaloriesSum.TabIndex = 31;
            this.lbCaloriesSum.Text = "0";
            // 
            // lbWeightSum
            // 
            this.lbWeightSum.AutoSize = true;
            this.lbWeightSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lbWeightSum.Location = new System.Drawing.Point(263, 501);
            this.lbWeightSum.Name = "lbWeightSum";
            this.lbWeightSum.Size = new System.Drawing.Size(20, 24);
            this.lbWeightSum.TabIndex = 30;
            this.lbWeightSum.Text = "0";
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tbSearch.Location = new System.Drawing.Point(721, 75);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(144, 29);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label10.Location = new System.Drawing.Point(638, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 24);
            this.label10.TabIndex = 36;
            this.label10.Text = "Пошук:";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.PaleGreen;
            this.btnClearSearch.Image = global::Calorie_Calculator.Properties.Resources.cancel;
            this.btnClearSearch.Location = new System.Drawing.Point(945, 70);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(36, 36);
            this.btnClearSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClearSearch.TabIndex = 38;
            this.btnClearSearch.TabStop = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSearch.Image = global::Calorie_Calculator.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(889, 70);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 36);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSearch.TabIndex = 37;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 62);
            this.panel1.TabIndex = 39;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Location = new System.Drawing.Point(333, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 798);
            this.panel2.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(607, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 24);
            this.label12.TabIndex = 6;
            this.label12.Text = "Інгрідієнти";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(113, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "Страва";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel3.Location = new System.Drawing.Point(333, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 798);
            this.panel3.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(71, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 42;
            this.label3.Text = "Інгредієнти страви:";
            // 
            // AddDishForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 738);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbCarbohydratesSum);
            this.Controls.Add(this.lbFatsSum);
            this.Controls.Add(this.lbProteinsSum);
            this.Controls.Add(this.lbCaloriesSum);
            this.Controls.Add(this.lbWeightSum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateOrChangeDish);
            this.Controls.Add(this.btnAddIngridient);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbWeight);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tableAddIngredients);
            this.Controls.Add(this.tableDishIngredient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDescription);
            this.KeyPreview = true;
            this.Name = "AddDishForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Страва";
            this.Load += new System.EventHandler(this.AddDishForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddDishForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tableDishIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAddIngredients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorie_СalculatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.DataGridView tableDishIngredient;
        private System.Windows.Forms.DataGridView tableAddIngredients;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.BindingSource ingredientBindingSource;
        private Calorie_СalculatorDataSet calorie_СalculatorDataSet;
        private Calorie_СalculatorDataSetTableAdapters.IngredientTableAdapter ingredientTableAdapter;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddIngridient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredient_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.Button btnCreateOrChangeDish;
        private Calorie_СalculatorDataSetTableAdapters.Dish_IngredientTableAdapter dish_IngredientTableAdapter;
        private Calorie_СalculatorDataSetTableAdapters.DishTableAdapter dishTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbCarbohydratesSum;
        private System.Windows.Forms.Label lbFatsSum;
        private System.Windows.Forms.Label lbProteinsSum;
        private System.Windows.Forms.Label lbCaloriesSum;
        private System.Windows.Forms.Label lbWeightSum;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caloriesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proteinsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carbohydratesDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.PictureBox btnClearSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
    }
}