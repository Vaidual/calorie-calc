
namespace Calorie_Calculator
{
    partial class mainForm
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
            this.btnUserProfile = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnCheckDishes = new System.Windows.Forms.Button();
            this.calorie_СalculatorDataSet = new Calorie_Calculator.Calorie_СalculatorDataSet();
            this.calorie_СalculatorDataSet1 = new Calorie_Calculator.Calorie_СalculatorDataSet();
            this.calorie_СalculatorDataSet2 = new Calorie_Calculator.Calorie_СalculatorDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.calorie_СalculatorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorie_СalculatorDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorie_СalculatorDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUserProfile
            // 
            this.btnUserProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnUserProfile.Location = new System.Drawing.Point(67, 77);
            this.btnUserProfile.Name = "btnUserProfile";
            this.btnUserProfile.Size = new System.Drawing.Size(213, 52);
            this.btnUserProfile.TabIndex = 1;
            this.btnUserProfile.Text = "Мій профіль";
            this.btnUserProfile.UseVisualStyleBackColor = true;
            this.btnUserProfile.Click += new System.EventHandler(this.btnUserProfile_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnStatistic.Location = new System.Drawing.Point(67, 220);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(213, 52);
            this.btnStatistic.TabIndex = 3;
            this.btnStatistic.Text = "Статистика";
            this.btnStatistic.UseVisualStyleBackColor = true;
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnCheckDishes
            // 
            this.btnCheckDishes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnCheckDishes.Location = new System.Drawing.Point(67, 150);
            this.btnCheckDishes.Name = "btnCheckDishes";
            this.btnCheckDishes.Size = new System.Drawing.Size(213, 52);
            this.btnCheckDishes.TabIndex = 2;
            this.btnCheckDishes.Text = "Переглянути страви";
            this.btnCheckDishes.UseVisualStyleBackColor = true;
            this.btnCheckDishes.Click += new System.EventHandler(this.btnCheckDishes_Click);
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
            // calorie_СalculatorDataSet2
            // 
            this.calorie_СalculatorDataSet2.DataSetName = "Calorie_СalculatorDataSet";
            this.calorie_СalculatorDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Головне меню";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 62);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Calorie_Calculator.Properties.Resources.statistics;
            this.pictureBox3.Location = new System.Drawing.Point(11, 222);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Calorie_Calculator.Properties.Resources.recipe;
            this.pictureBox2.Location = new System.Drawing.Point(11, 150);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calorie_Calculator.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(11, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 310);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCheckDishes);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.btnUserProfile);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головне меню";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.calorie_СalculatorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorie_СalculatorDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calorie_СalculatorDataSet2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUserProfile;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnCheckDishes;
        private Calorie_СalculatorDataSet calorie_СalculatorDataSet;
        private Calorie_СalculatorDataSet calorie_СalculatorDataSet1;
        private Calorie_СalculatorDataSet calorie_СalculatorDataSet2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}