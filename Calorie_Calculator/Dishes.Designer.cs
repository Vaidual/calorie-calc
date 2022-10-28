
namespace Calorie_Calculator
{
    partial class Dishes
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
            this.mainTable = new System.Windows.Forms.DataGridView();
            this.dish_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dishBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calorie_СalculatorDataSet = new Calorie_Calculator.Calorie_СalculatorDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDeleteDish = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dishTableAdapter = new Calorie_Calculator.Calorie_СalculatorDataSetTableAdapters.DishTableAdapter();
            this.dish_IngredientTableAdapter = new Calorie_Calculator.Calorie_СalculatorDataSetTableAdapters.Dish_IngredientTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorie_СalculatorDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTable
            // 
            this.mainTable.AllowUserToAddRows = false;
            this.mainTable.AllowUserToDeleteRows = false;
            this.mainTable.AllowUserToResizeColumns = false;
            this.mainTable.AllowUserToResizeRows = false;
            this.mainTable.AutoGenerateColumns = false;
            this.mainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dish_id,
            this.name,
            this.description});
            this.mainTable.DataSource = this.dishBindingSource;
            this.mainTable.Location = new System.Drawing.Point(29, 72);
            this.mainTable.MultiSelect = false;
            this.mainTable.Name = "mainTable";
            this.mainTable.ReadOnly = true;
            this.mainTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mainTable.Size = new System.Drawing.Size(482, 199);
            this.mainTable.TabIndex = 0;
            // 
            // dish_id
            // 
            this.dish_id.DataPropertyName = "dish_id";
            this.dish_id.HeaderText = "dish_id";
            this.dish_id.Name = "dish_id";
            this.dish_id.ReadOnly = true;
            this.dish_id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Назва";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // description
            // 
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Опис";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.Width = 338;
            // 
            // dishBindingSource
            // 
            this.dishBindingSource.DataMember = "Dish";
            this.dishBindingSource.DataSource = this.bindingSource;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(196, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список страв";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(29, 298);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 47);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDeleteDish
            // 
            this.btnDeleteDish.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDeleteDish.FlatAppearance.BorderSize = 2;
            this.btnDeleteDish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDeleteDish.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDeleteDish.Location = new System.Drawing.Point(376, 298);
            this.btnDeleteDish.Name = "btnDeleteDish";
            this.btnDeleteDish.Size = new System.Drawing.Size(135, 47);
            this.btnDeleteDish.TabIndex = 3;
            this.btnDeleteDish.Text = "Видалити";
            this.btnDeleteDish.UseVisualStyleBackColor = true;
            this.btnDeleteDish.Click += new System.EventHandler(this.btnDeleteDish_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.PaleGreen;
            this.btnEdit.FlatAppearance.BorderSize = 2;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(193, 298);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(135, 47);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dishTableAdapter
            // 
            this.dishTableAdapter.ClearBeforeFill = true;
            // 
            // dish_IngredientTableAdapter
            // 
            this.dish_IngredientTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 62);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(189, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Список страв";
            // 
            // Dishes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 357);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDeleteDish);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainTable);
            this.KeyPreview = true;
            this.Name = "Dishes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Страви";
            this.Load += new System.EventHandler(this.Dishes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dishes_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dishBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorie_СalculatorDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDeleteDish;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.BindingSource bindingSource;
        private Calorie_СalculatorDataSet calorie_СalculatorDataSet;
        private System.Windows.Forms.BindingSource dishBindingSource;
        private Calorie_СalculatorDataSetTableAdapters.DishTableAdapter dishTableAdapter;
        private Calorie_СalculatorDataSetTableAdapters.Dish_IngredientTableAdapter dish_IngredientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dish_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}