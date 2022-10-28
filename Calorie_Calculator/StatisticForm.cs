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
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Net;

namespace Calorie_Calculator
{
    public partial class StatisticForm : Form
    {
        double norm;
        string con = @"Data Source=DESKTOP-KFD9I43\SQLEXPRESS;Initial Catalog=Сalorie_Сalculator;Persist Security Info=True;User ID=Vaidual;Password=1234";
        public StatisticForm()
        {
            InitializeComponent();

            Calorie_СalculatorDataSet.UserDataTable user =
                new Calorie_СalculatorDataSet.UserDataTable();
            userTableAdapter.Fill(user);
            int coef = 5;
            if (user[0].gender == "жінка")
                coef = -161;
            norm = user[0].weight * 10 + user[0].height * 6.25 - 5 * user[0].age + coef;

            lbNorm.Text = norm.ToString();
            chartGraphic2.Titles.Add("Статистика за день");
            chartGraphic2.Titles[0].Font = new Font("Microsoft Sans Serif", 12, FontStyle.Regular);

        }

        private void StatisticForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'calorie_СalculatorDataSet1.GetDishInfo' table. You can move, or remove it, as needed.
            this.getDishInfoTableAdapter.Fill(this.calorie_СalculatorDataSet1.GetDishInfo);
            // TODO: This line of code loads data into the 'calorie_СalculatorDataSet1.GetDishInfo' table. You can move, or remove it, as needed.
            this.getDishInfoTableAdapter.Fill(this.calorie_СalculatorDataSet1.GetDishInfo);
            // TODO: This line of code loads data into the 'calorie_СalculatorDataSet1.GetDishInfo' table. You can move, or remove it, as needed.
            this.getDishInfoTableAdapter.Fill(this.calorie_СalculatorDataSet.GetDishInfo);
            dishTableAdapter.Fill(this.calorie_СalculatorDataSet.Dish);
            CreateDateIfNeed(dtpSelectDate.Value.Date);
            ReDrawTable(dtpSelectDate.Value.Date.ToString("yyyy-MM-dd"));
            ReDrawGraphicLine();
            ReDrawGraphicPie();

        }

        void ReDrawTable(string date)
        {
            DataTable table;
            using (SqlConnection sqlconn = new SqlConnection(con))
            {
                sqlconn.Open();
                SqlDataAdapter oda = new SqlDataAdapter("SELECT * FROM GetDishesOnDate(" + day_StatisticTableAdapter
                    .GetIdByDate(dtpSelectDate.Value.ToString("yyyy-MM-dd")) + ")", sqlconn);
                table = new DataTable();
                oda.Fill(table);
                sqlconn.Close();
            }
            mainTable.DataSource = table;
            mainTable.DataSource = table;
            double cal = 0;
            for (int i = 0; i < mainTable.Rows.Count; i++)
            {
                  cal += Convert.ToInt32(mainTable["caloriesDataGridViewTextBoxColumn", i].Value);
            }
            lbGeined.Text = cal.ToString();
        }

        private void dtpSelectDate_ValueChanged(object sender, EventArgs e)
        {
            CreateDateIfNeed(dtpSelectDate.Value.Date);
            ReDrawTable(dtpSelectDate.Value.Date.ToString("yyyy-MM-dd"));
            ReDrawGraphicLine();
            ReDrawGraphicPie();
        }
        void CreateDateIfNeed(DateTime dt)
        {
            if (day_StatisticTableAdapter.CheckISThereDate(dt) == 0)
            {
                day_StatisticTableAdapter.Insert(dt, 0, 0, 0, 0);
            }
        }

        private void btnAddDish_Click(object sender, EventArgs e)
        {
            bool check = false;
            for (int i = 0; i < mainTable.Rows.Count; i++)
            {
                if (mainTable["nameDataGridViewTextBoxColumn", i].Value.ToString() == cbDishes.Text)
                {
                    int weight = Convert.ToInt32(mainTable["weightDataGridViewTextBoxColumn", i].Value);
                    check = true;
                    dish_Day_StatisticTableAdapter.UpdateWeight(Convert.ToInt32(tbDishWeight.Text) + weight,
                        Convert.ToInt32(dishTableAdapter.GetIdByName(cbDishes.Text)),
                        Convert.ToInt32(day_StatisticTableAdapter.GetIdByDate(dtpSelectDate.Value.ToString("yyyy-MM-dd"))));
                }
            }
            if (check == false)
            dish_Day_StatisticTableAdapter.Insert(Convert.ToInt32(cbDishes.SelectedValue),
                Convert.ToInt32(day_StatisticTableAdapter.GetIdByDate
                (dtpSelectDate.Value.ToString("yyyy-MM-dd"))),
                Convert.ToInt32(tbDishWeight.Text));
            getDishInfoTableAdapter.Fill(calorie_СalculatorDataSet.GetDishInfo);
            calorie_СalculatorDataSet.AcceptChanges();
            ReDrawTable(dtpSelectDate.Value.Date.ToString("yyyy-MM-dd"));
            double cal = 0, prot = 0, fats = 0, car = 0;
            for (int i = 0; i < mainTable.Rows.Count; i++)
            {
                cal += Convert.ToInt32(mainTable["caloriesDataGridViewTextBoxColumn", i].Value);
                prot += Convert.ToInt32(mainTable["proteinsDataGridViewTextBoxColumn", i].Value);
                fats += Convert.ToInt32(mainTable["fatsDataGridViewTextBoxColumn", i].Value);
                car += Convert.ToInt32(mainTable["carbohydratesDataGridViewTextBoxColumn", i].Value);
            }
            day_StatisticTableAdapter.UpdateCharacteristics(cal, prot, fats, car,
                dtpSelectDate.Value.Date.ToShortDateString().Replace(".", "-"));
            ReDrawGraphicLine();
            ReDrawGraphicPie();
            tbDishWeight.Text = "100";
        }

        private void btnDeleteDish_Click(object sender, EventArgs e)
        {
            if (mainTable.Rows.Count == 0)
            {
                MessageBox.Show("Виделіть хоча б один запис", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
                
            if (MessageBox.Show("Ви дійсно хочете видалити страву?", "Підтвердження", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            dish_Day_StatisticTableAdapter.DeleteQuery(Convert.ToInt32(mainTable.SelectedRows[0].Cells["idDataGridViewTextBoxColumn"].Value), 
                Convert.ToInt32(day_StatisticTableAdapter.GetIdByDate(dtpSelectDate.Value.Date.ToString("yyyy-MM-dd"))));
            ReDrawTable(dtpSelectDate.Value.Date.ToString("yyyy-MM-dd"));
            ReDrawGraphicLine();
            ReDrawGraphicPie();
        }

        void ReDrawGraphicLine()
        {
            Calorie_СalculatorDataSet.UserDataTable user = 
                new Calorie_СalculatorDataSet.UserDataTable();
            userTableAdapter.Fill(user);
            double min_norm = norm * 0.8, max_norm = norm * 1.2;
            DateTime cur_day = dtpSelectDate.Value.AddDays(-6);
            chartGraphic1.Legends["Legend1"].MaximumAutoSize = 30;
            CreateDateIfNeed(cur_day);
            chartGraphic1.Series["main"].Points.Clear();
            chartGraphic1.Series["bot"].Points.Clear();
            chartGraphic1.Series["top"].Points.Clear();
            while (cur_day <= dtpSelectDate.Value)
            {
                Calorie_СalculatorDataSet.Dish_Day_StatisticDataTable tableAllDishesOnDate = 
                    new Calorie_СalculatorDataSet.Dish_Day_StatisticDataTable();
                dish_Day_StatisticTableAdapter.FillBy(tableAllDishesOnDate, cur_day.ToString("yyyy-MM-dd"));
                double cal = 0;
                Calorie_СalculatorDataSet.GetDishInfoDataTable tableDishesInfo =
                    new Calorie_СalculatorDataSet.GetDishInfoDataTable();
                getDishInfoTableAdapter.Fill(tableDishesInfo);
                for (int i = 0; i < tableAllDishesOnDate.Rows.Count; i++)
                {
                    int dish_id = Convert.ToInt32(
                        tableAllDishesOnDate.Rows[i]["dish_id"]),
                        weight = Convert.ToInt32(
                        tableAllDishesOnDate.Rows[i]["weight"]);
                    var dishInfoOne = tableDishesInfo.Where(x => x.id == dish_id).ElementAt(0);
                    cal += dishInfoOne.calories / dishInfoOne.weight * weight;
                }
                chartGraphic1.Series["main"].Points.AddXY(cur_day, cal);
                chartGraphic1.Series["bot"].Points.AddXY(cur_day, min_norm);
                chartGraphic1.Series["top"].Points.AddXY(cur_day, max_norm);
                cur_day = cur_day.AddDays(1);
            }
        }
        void ReDrawGraphicPie()
        {
            double prot = 0, fats = 0, car = 0;
            chartGraphic2.Series["main"].Points.Clear();
            for (int i = 0; i < mainTable.Rows.Count; i++)
            {
                prot += Convert.ToInt32(mainTable["proteinsDataGridViewTextBoxColumn", i].Value);
                fats += Convert.ToInt32(mainTable["fatsDataGridViewTextBoxColumn", i].Value);
                car += Convert.ToInt32(mainTable["carbohydratesDataGridViewTextBoxColumn", i].Value);
            }
            chartGraphic2.Series["main"].Points.AddXY(prot, prot);
            chartGraphic2.Series["main"].Points.AddXY(fats, fats);
            chartGraphic2.Series["main"].Points.AddXY(car, car);
            chartGraphic2.Series["main"].Points[0].LegendText = "Білки";
            chartGraphic2.Series["main"].Points[0].Color = Color.FromArgb(255, 255, 102);

            chartGraphic2.Series["main"].Points[1].LegendText = "Жири";
            chartGraphic2.Series["main"].Points[1].Color = Color.Coral;

            chartGraphic2.Series["main"].Points[2].LegendText = "Вуглеводи";
            chartGraphic2.Series["main"].Points[2].Color = Color.CornflowerBlue;

            foreach (DataPoint p in chartGraphic2.Series["main"].Points)
            {
                p.Label = "#PERCENT\n#VALX" + "г";
            }

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.Show("Рекомендується дотримуватись балансу 30–20–50. \nБілки повинні становити 30% від щоденного раціону, \nжири – 20%, а вуглеводи – 50%.", pictureBox1);
        }

        private void StatisticForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1240rTSDlfHPX2hG6Z-3lm1YdYGk--jwq/view");
        }
    }
}
