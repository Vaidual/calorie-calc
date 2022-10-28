using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Calorie_Calculator
{
    public partial class AddDishForm : Form
    {
        bool edit = false;
        int id;
        string con = @"Data Source=DESKTOP-KFD9I43\SQLEXPRESS;Initial Catalog=Сalorie_Сalculator;Persist Security Info=True;User ID=Vaidual;Password=1234";
        public AddDishForm()
        {
            InitializeComponent();

            edit = false;
            btnCreateOrChangeDish.Text = "Створити";
            lbTitle.Text = "Створення страви";
            this.Text = "Додавання страви";
        }

        public AddDishForm(int id, string name, string description) : this()
        {
            this.id = id;
            edit = true;
            tableDishIngredient.Columns.Clear();
            using (SqlConnection sqlconn = new SqlConnection(con))
            {
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter(
                    "SELECT Ingredient.ingredient_id, Ingredient.name as 'Назва', " +
                    "Dish_Ingredient.ingredient_weight as 'Вага' " +
                    "FROM Dish_Ingredient INNER JOIN Ingredient " +
                    "ON Ingredient.ingredient_id = Dish_Ingredient.ingredient_id " +
                    "where Dish_Ingredient.dish_id = " + id, sqlconn);
                DataTable dataTable = new DataTable();
                oda.Fill(dataTable);
                dataTable.Columns["Назва"].ColumnName = "name";
                dataTable.Columns["Вага"].ColumnName = "weight";
                tableDishIngredient.DataSource = dataTable;
                tableDishIngredient.Columns["ingredient_id"].Visible = false;
                sqlconn.Close();
            }
            tbName.Text = name;
            tbDescription.Text = description;
            btnCreateOrChangeDish.Text = "Зберегти зміни";
            lbTitle.Text = "Редагування страви";
            SetDishInfo();

            this.Text = "Редагування страви";
        }

        private void AddDishForm_Load(object sender, EventArgs e)
        {
            ingredientTableAdapter.Fill(calorie_СalculatorDataSet.Ingredient);
        }

        private void btnAddIngridient_Click(object sender, EventArgs e)
        {
            if (tableAddIngredients.SelectedRows.Count == 0)
            {
                MessageBox.Show("Жодного інгридієнту не вибрано", "Помилка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = (int)tableAddIngredients.SelectedRows[0].Cells[0].Value;
            foreach (DataGridViewRow row in tableDishIngredient.Rows)
            {
                if (row.Cells["ingredient_id"].Value.ToString() == id.ToString())
                {
                    string new_weight = (Convert.ToInt32(tableDishIngredient["weight", row.Index].Value) + 
                        Convert.ToInt32(tbWeight.Text)).ToString();
                    tableDishIngredient["weight", row.Index].Value = new_weight;
                    SetDishInfo();
                    return;
                }
            }
            if (edit == true)
            {
                DataTable dataTable = (DataTable)tableDishIngredient.DataSource;
                DataRow drToAdd = dataTable.NewRow();

                drToAdd["ingredient_id"] = id;
                drToAdd["name"] = tableAddIngredients.SelectedRows[0].Cells[1].Value;
                drToAdd["weight"] = tbWeight.Text;

                dataTable.Rows.Add(drToAdd);
                dataTable.AcceptChanges();
            }
            else
            {
                tableDishIngredient.Rows.Add(
                    id,
                    tableAddIngredients.SelectedRows[0].Cells[1].Value,
                    tbWeight.Text);
            }
            tbWeight.Text = "100";

            SetDishInfo();
        }

        private void btnCreateDish_Click(object sender, EventArgs e)
        {
            if (edit == true)
            {
                dishTableAdapter.Update(tbName.Text, tbDescription.Text, id);
                for (int i = 0; i < tableDishIngredient.RowCount; i++)
                {
                    if (dish_IngredientTableAdapter.IsThereIngredient(Convert.ToInt32(tableDishIngredient["ingredient_id", i].Value), id) == 0)
                    dish_IngredientTableAdapter.Insert(id,
                        Convert.ToInt32(tableDishIngredient["ingredient_id", i].Value),
                        Convert.ToInt32(tableDishIngredient["weight", i].Value));
                }
            }
            else
            {
                dishTableAdapter.Insert(tbName.Text, tbDescription.Text);
                int id = (int)dishTableAdapter.GetMaxId();
                for (int i = 0; i < tableDishIngredient.RowCount; i++)
                {
                    dish_IngredientTableAdapter.Insert(id,
                        Convert.ToInt32(tableDishIngredient["ingredient_id", i].Value),
                        Convert.ToInt32(tableDishIngredient["weight", i].Value));
                }
            }
            this.Close();
        }

        private void tableDishIngredient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити інгрідієнт?", "Підтвердження", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            if (edit == true &&
                dish_IngredientTableAdapter.IsThereIngredient(Convert.ToInt32(
                tableDishIngredient["ingredient_id", e.RowIndex].Value), id) == 1)
            {
                dish_IngredientTableAdapter.DeleteIngredient(id, Convert.ToInt32(
                tableDishIngredient["ingredient_id", e.RowIndex].Value));
            }
            tableDishIngredient.Rows.RemoveAt(e.RowIndex);
            SetDishInfo();
        }

        void SetDishInfo()
        {
            double weight_sum = 0;
            double calories_sum = 0;
            double proteins_sum = 0;
            double fats_sum = 0;
            double carbohydrates_sum = 0;
            Calorie_СalculatorDataSet.IngredientDataTable dt =
                new Calorie_СalculatorDataSet.IngredientDataTable();
            for (int i = 0; i < tableDishIngredient.RowCount; i++)
            {
                int weight = Convert.ToInt32(
                    tableDishIngredient["weight", i].Value);
                weight_sum += weight;
                int id = Convert.ToInt32(
                    tableDishIngredient["ingredient_id", i].Value);
                ingredientTableAdapter.Fill(dt);
                var tmp = dt.Where(x => x.ingredient_id == id).ElementAt(0);
                double weight_for_calc = Convert.ToInt32(tmp.weight);
                calories_sum += Convert.ToInt32(tmp.calories) / weight_for_calc * weight;
                proteins_sum += Convert.ToInt32(tmp.proteins) / weight_for_calc * weight;
                fats_sum += Convert.ToInt32(tmp.fats) / weight_for_calc * weight;
                carbohydrates_sum += Convert.ToInt32(tmp.carbohydrates) / weight_for_calc * weight;


            }
            lbWeightSum.Text = weight_sum.ToString();
            lbCaloriesSum.Text = calories_sum.ToString();
            lbProteinsSum.Text = proteins_sum.ToString();
            lbFatsSum.Text = fats_sum.ToString();
            lbCarbohydratesSum.Text = carbohydrates_sum.ToString();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string key = tbSearch.Text.ToString().ToLower();
            int count = 0;
            CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[tableAddIngredients.DataSource];
            currencyManager1.SuspendBinding();
            for (int i = 0; i < tableAddIngredients.Rows.Count; i++)
            {
                if (tableAddIngredients["nameDataGridViewTextBoxColumn", i].Value.ToString().ToLower().Contains(key))
                {
                    tableAddIngredients.Rows[i].Visible = true;
                    count++;
                }
                else
                    tableAddIngredients.Rows[i].Visible = false;
                currencyManager1.ResumeBinding();
            }
            if (count == 0)
                MessageBox.Show("Жодного інгрідієнту не знайдено", "Інформація", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tableAddIngredients.Rows.Count; i++)
            {
                 tableAddIngredients.Rows[i].Visible = true;
            }
            tbSearch.Text = "";
        }

        private void AddDishForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1240rTSDlfHPX2hG6Z-3lm1YdYGk--jwq/view");
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnSearch_Click(btnSearch, e);
            }
            if (e.KeyData == Keys.Delete)
            {
                btnClearSearch_Click(btnClearSearch, e);
            }
            if (e.KeyData == Keys.Down)
            {
                for (int i = 0; i < tableAddIngredients.SelectedRows.Count; i++)
                {
                    tableAddIngredients.SelectedRows[i].Selected = false;
                }
                for (int i = 0; i < tableAddIngredients.Rows.Count; i++)
                {
                    if (tableAddIngredients.Rows[i].Visible == true)
                    {
                        tableAddIngredients.Rows[i].Selected = true;
                        break;
                    }
                }
            }
        }
    }
}
