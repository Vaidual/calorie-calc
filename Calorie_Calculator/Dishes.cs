using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calorie_Calculator
{
    public partial class Dishes : Form
    {
        public Dishes()
        {
            InitializeComponent();
        }

        private void Dishes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calorie_СalculatorDataSet.Dish' table. You can move, or remove it, as needed.
            this.dishTableAdapter.Fill(this.calorie_СalculatorDataSet.Dish);

            mainTable.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            mainTable.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddDishForm();
            form.ShowDialog();
            dishTableAdapter.Fill(calorie_СalculatorDataSet.Dish);
            calorie_СalculatorDataSet.AcceptChanges();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var form = new AddDishForm(
                Convert.ToInt32(mainTable.SelectedRows[0].Cells["dish_id"].Value),
                mainTable.SelectedRows[0].Cells["name"].Value.ToString(),
                mainTable.SelectedRows[0].Cells["description"].Value.ToString());
            form.ShowDialog();
            dishTableAdapter.Fill(calorie_СalculatorDataSet.Dish);
            calorie_СalculatorDataSet.AcceptChanges();
        }

        private void btnDeleteDish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви дійсно хочете видалити страву?", "Підтвердження", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            int id = Convert.ToInt32(mainTable.SelectedRows[0].Cells["dish_id"].Value);
            dishTableAdapter.Delete(id);
            dishTableAdapter.Fill(calorie_СalculatorDataSet.Dish);
            calorie_СalculatorDataSet.AcceptChanges();
        }

        private void Dishes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1240rTSDlfHPX2hG6Z-3lm1YdYGk--jwq/view");
        }
    }
}
