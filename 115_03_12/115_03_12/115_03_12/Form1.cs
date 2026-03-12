using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;

namespace _115_03_12
{
    public partial class Form1 : Form
    {
        // 如果 Designer 檔案尚未宣告這些控制項，為避免編譯錯誤
        // 在此提供欄位宣告並在執行時建立預設介面
        private TextBox txtNum1;
        private TextBox txtNum2;
        private TextBox txtNum3;
        private TextBox txtNum4;
        private Button btnGenerate;
        private Button btnDraw;
        private Button btnExit;
        private RichTextBox rtbOutput;

        private readonly Random _rand = new Random();

        public Form1()
        {
            InitializeComponent();

            // 如果 InitializeComponent 沒有建立這些控制項，就在程式碼中建立（避免 Designer 欄位缺失導致編譯或執行失敗）
            if (txtNum1 == null || txtNum2 == null || txtNum3 == null || txtNum4 == null || rtbOutput == null || btnGenerate == null || btnDraw == null || btnExit == null)
            {
                CreateFallbackControls();
            }
        }

        private void CreateFallbackControls()
        {
            // 佈局參數（簡單實作，與範例截圖外觀相仿）
            this.SuspendLayout();

            int topY = 22;
            int leftStart = 36;
            int gap = 165;
            int boxWidth = 96;
            int boxHeight = 34;

            txtNum1 = new TextBox
            {
                Location = new Point(leftStart + (gap * 0), topY),
                Size = new Size(boxWidth, boxHeight),
                ReadOnly = true,
                Font = new Font("Segoe UI", 12F),
                TextAlign = HorizontalAlignment.Center
            };

            txtNum2 = new TextBox
            {
                Location = new Point(leftStart + (gap * 1), topY),
                Size = new Size(boxWidth, boxHeight),
                ReadOnly = true,
                Font = new Font("Segoe UI", 12F),
                TextAlign = HorizontalAlignment.Center
            };

            txtNum3 = new TextBox
            {
                Location = new Point(leftStart + (gap * 2), topY),
                Size = new Size(boxWidth, boxHeight),
                ReadOnly = true,
                Font = new Font("Segoe UI", 12F),
                TextAlign = HorizontalAlignment.Center
            };

            txtNum4 = new TextBox
            {
                Location = new Point(leftStart + (gap * 3), topY),
                Size = new Size(boxWidth, boxHeight),
                ReadOnly = true,
                Font = new Font("Segoe UI", 12F),
                TextAlign = HorizontalAlignment.Center
            };

            int btnTop = 82;
            int btnWidth = 200;
            int btnHeight = 62;
            int btnGap = 28;
            int btnLeftStart = 36;

            btnGenerate = new Button
            {
                Location = new Point(btnLeftStart + (btnWidth + btnGap) * 0, btnTop),
                Size = new Size(btnWidth, btnHeight),
                Font = new Font("Segoe UI", 18F),
                Text = "產生號碼",
                UseVisualStyleBackColor = true
            };
            btnGenerate.Click += btnGenerate_Click;

            btnDraw = new Button
            {
                Location = new Point(btnLeftStart + (btnWidth + btnGap) * 1, btnTop),
                Size = new Size(btnWidth, btnHeight),
                Font = new Font("Segoe UI", 18F),
                Text = "開獎號碼",
                UseVisualStyleBackColor = true
            };
            btnDraw.Click += btnDraw_Click;

            btnExit = new Button
            {
                Location = new Point(btnLeftStart + (btnWidth + btnGap) * 2, btnTop),
                Size = new Size(btnWidth, btnHeight),
                Font = new Font("Segoe UI", 18F),
                Text = "離開",
                UseVisualStyleBackColor = true
            };
            btnExit.Click += btnExit_Click;

            var lblTitle = new Label
            {
                AutoSize = true,
                Location = new Point(36, 164),
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                Text = "本期開獎號碼："
            };

            rtbOutput = new RichTextBox
            {
                Location = new Point(36, 186),
                Size = new Size(680, 204),
                Font = new Font("Segoe UI", 12F),
                ReadOnly = true,
                BackColor = SystemColors.Window,
                ScrollBars = RichTextBoxScrollBars.Vertical
            };

            // 將控制項加入表單
            this.Controls.Add(txtNum1);
            this.Controls.Add(txtNum2);
            this.Controls.Add(txtNum3);
            this.Controls.Add(txtNum4);
            this.Controls.Add(btnGenerate);
            this.Controls.Add(btnDraw);
            this.Controls.Add(btnExit);
            this.Controls.Add(lblTitle);
            this.Controls.Add(rtbOutput);

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // 產生 4 個不重複的號碼，範圍 1~49，並排序
            var nums = Enumerable.Range(1, 49)
                                 .OrderBy(x => _rand.Next())
                                 .Take(4)
                                 .OrderBy(x => x)
                                 .ToArray();

            txtNum1.Text = nums.Length > 0 ? nums[0].ToString() : string.Empty;
            txtNum2.Text = nums.Length > 1 ? nums[1].ToString() : string.Empty;
            txtNum3.Text = nums.Length > 2 ? nums[2].ToString() : string.Empty;
            txtNum4.Text = nums.Length > 3 ? nums[3].ToString() : string.Empty;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            // 使用 RichTextBox 輸出，數字部分以粗體顯示
            // 若 rtbOutput 為 null（非常不常見），改用 MessageBox 顯示
            if (rtbOutput == null)
            {
                var valuesFallback = new[] { txtNum1?.Text, txtNum2?.Text, txtNum3?.Text, txtNum4?.Text };
                string msg = "本期開獎號碼：\n" + string.Join("\n", valuesFallback.Select((v, i) => $"第{ i + 1 }個號碼: {(string.IsNullOrWhiteSpace(v) ? "-" : v)}"));
                MessageBox.Show(msg, "開獎號碼", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            rtbOutput.Clear();

            rtbOutput.SelectionFont = new Font(rtbOutput.Font, FontStyle.Regular);
            rtbOutput.AppendText("本期開獎號碼：\n");

            var values = new[] { txtNum1.Text, txtNum2.Text, txtNum3.Text, txtNum4.Text };
            for (int i = 0; i < values.Length; i++)
            {
                var numText = string.IsNullOrWhiteSpace(values[i]) ? "-" : values[i];

                // 前段文字（一般字型）
                rtbOutput.SelectionFont = new Font(rtbOutput.Font, FontStyle.Regular);
                rtbOutput.AppendText($"第{ i + 1 }個號碼: ");

                // 數字用粗體
                rtbOutput.SelectionFont = new Font(rtbOutput.Font, FontStyle.Bold);
                rtbOutput.AppendText($"{ numText }\n");
            }

            // 捲動到底部
            rtbOutput.SelectionStart = rtbOutput.Text.Length;
            rtbOutput.ScrollToCaret();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
