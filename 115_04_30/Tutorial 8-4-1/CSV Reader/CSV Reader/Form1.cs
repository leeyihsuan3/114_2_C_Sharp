using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSV_Reader
    {
    // 表單類別宣告（使用 partial 與設計器產生的部份合併）
    public partial class Form1 : Form
    {
        // 建構子：初始化表單與元件
        public Form1()
        {
            InitializeComponent();
        }

        // 讀取分數按鈕事件處理器
        // TODO: 在此實作從 CSV 讀取分數並顯示於 averagesListBox 的邏輯
        private void getScoresButton_Click(object sender, EventArgs e)
        {
            // 範例：暫留位置給實作程式碼
        }

        // 離開按鈕事件處理器
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單視窗
            this.Close();
        }
    }
}
