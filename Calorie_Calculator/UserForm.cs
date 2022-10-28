using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Calorie_Calculator
{
    public partial class UserForm : Form
    {
        private DateTime LastCloseTime = DateTime.Now;
        Calorie_СalculatorDataSet.UserDataTable user;
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            user = new Calorie_СalculatorDataSet.UserDataTable();
            userTableAdapter1.FillBy(user);
            cbGender.SelectedItem = user.Rows[0]["gender"].ToString();
            tbAge.Text = user.Rows[0]["age"].ToString();
            tbWeight.Text = user.Rows[0]["weight"].ToString();
            tbHeight.Text = user.Rows[0]["height"].ToString();
            tbAge.Select();
            cbGender.Select();
        }

        private void btnSaveProfile_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Зберегти зміни?", "Підтвердження", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
                return;
            userTableAdapter1.Update("user", cbGender.SelectedItem.ToString(), 
                Convert.ToInt32(tbAge.Text), Convert.ToInt32(tbWeight.Text),
                Convert.ToInt32(tbHeight.Text), Convert.ToInt32(user.Rows[0]["user_id"]));
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tb_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            try
            {
                if (tb.Name == "tbAge")
                    Convert.ToInt32(tb.Text);
                else
                    Convert.ToDouble(tb.Text);
            }
            catch
            {
                panel1.Visible = true;
                return;
            }
            panel1.Visible = false;
        }

        private void cbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // See if the list is already dropped.
                ComboBox cbo = sender as ComboBox;
                if (cbo.DroppedDown) return;

                // See if it has been at least 0.1 seconds since
                // the last time we closed a ComboBox.
                TimeSpan time_since_close = DateTime.Now - LastCloseTime;
                if (time_since_close.TotalSeconds < 0.1) return;

                // Drop the list.
                cbo.DroppedDown = true;
                e.Handled = true;
            }
        }

        private void cbGender_DropDownClosed(object sender, EventArgs e)
        {
            LastCloseTime = DateTime.Now;
        }

        private void tbWeight_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            try
            {
                if (tb.Name == "tbAge")
                    Convert.ToInt32(tb.Text);
                else
                    Convert.ToDouble(tb.Text);
            }
            catch
            {
                panel2.Visible = true;
                return;
            }
            panel2.Visible = false;
        }

        private void tbHeight_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            try
            {
                if (tb.Name == "tbAge")
                    Convert.ToInt32(tb.Text);
                else
                    Convert.ToDouble(tb.Text);
            }
            catch
            {
                panel3.Visible = true;
                return;
            }
            panel3.Visible = false;
        }

        private void tbAge_Enter(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void tbWeight_Enter(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void tbHeight_Enter(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void UserForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F2)
                System.Diagnostics.Process.Start("https://drive.google.com/file/d/1240rTSDlfHPX2hG6Z-3lm1YdYGk--jwq/view");
        }

        private void cbGender_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                // See if the list is already dropped.
                ComboBox cbo = sender as ComboBox;
                if (cbo.DroppedDown) return;

                // See if it has been at least 0.1 seconds since
                // the last time we closed a ComboBox.
                TimeSpan time_since_close = DateTime.Now - LastCloseTime;
                if (time_since_close.TotalSeconds < 0.1) return;

                // Drop the list.
                cbo.DroppedDown = true;
                e.Handled = true;
            }
        }
    }
}
