using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Food_Facts
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void displayButton_Click(object sender, EventArgs e)
        {
            FoodItem selectedFood = null;
            if (bananaRadioButton.Checked) selectedFood = new FoodItem( "一根香蕉", 100, 0.4,27);
else if (popcornRadioButton.Checked) selectedFood = new FoodItem("3杯爆米花",93, 1.1, 18);
else if (muffinRadioButton.Checked) selectedFood = new FoodItem("1个蓝莓松饼",385, 9, 67);
            if (selectedFood == null) { MessageBox.Show("請選擇食物"); return; }
            using (var nutriForm = new NutritionForm(selectedFood))
            {
                nutriForm.ShowDialog();
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}