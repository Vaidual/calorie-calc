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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }   

        private void btnUserProfile_Click(object sender, EventArgs e)
        {
            var form = new UserForm();
            this.Hide();
            form.ShowDialog();
            this.Show();
            calorie_СalculatorDataSet.AcceptChanges();
        }

        private void btnCheckDishes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new Dishes();
            this.Show();
            form.ShowDialog();
            calorie_СalculatorDataSet.AcceptChanges();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new StatisticForm();
            this.Show();
            form.ShowDialog();
            calorie_СalculatorDataSet.AcceptChanges();
        }

        private void mainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1240rTSDlfHPX2hG6Z-3lm1YdYGk--jwq/view");
        }
    }
}
