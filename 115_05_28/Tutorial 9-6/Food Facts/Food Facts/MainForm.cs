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
            // 建立 NutritionForm 的實例（顯示詳盡營養資訊的對話視窗）。
            NutritionForm nutriForm = new NutritionForm();

            // 根據使用者選擇的單選按鈕，設定 NutritionForm 中顯示的文字內容。
            // 這裡將食物描述改為繁體中文；數值（熱量、脂肪、碳水）維持原樣（數字）不變。
            if (bananaRadioButton.Checked)
            {
                // 使用繁體中文描述「1 根香蕉」
                nutriForm.foodLabel.Text = "1 根香蕉";
                nutriForm.caloriesLabel.Text = "100";
                nutriForm.fatLabel.Text = "0.4";
                nutriForm.carbLabel.Text = "27";
            }
            else if (popcornRadioButton.Checked)
            {
                // 使用繁體中文描述空氣爆的爆米花
                nutriForm.foodLabel.Text = "1 杯空氣爆的爆米花";
                nutriForm.caloriesLabel.Text = "31";
                nutriForm.fatLabel.Text = "0.4";
                nutriForm.carbLabel.Text = "6";
            }
            else if (muffinRadioButton.Checked)
            {
                // 使用繁體中文描述藍莓瑪芬
                nutriForm.foodLabel.Text = "1 個大藍莓瑪芬";
                nutriForm.caloriesLabel.Text = "385";
                nutriForm.fatLabel.Text = "9";
                nutriForm.carbLabel.Text = "67";
            }

            // 顯示 NutritionForm 視窗（模式對話方塊）。
            nutriForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉主視窗
            this.Close();
        }
    }
}
