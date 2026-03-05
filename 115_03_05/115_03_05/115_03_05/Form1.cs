using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace _115_03_05
{
    public partial class Form1 : Form
    {
        // 常數
        private const decimal OIL_CHANGE = 780m;
        private const decimal LUBE = 540m;
        private const decimal RADIATOR = 900m;
        private const decimal TRANSMISSION = 2400m;
        private const decimal INSPECTION = 450m;
        private const decimal MUFFLER = 3000m;
        private const decimal TIRE_ROTATE = 600m;
        private const decimal LABOR_RATE_PER_HOUR = 600m;
        private const decimal TAX_RATE = 0.06m;

        private readonly CultureInfo ci = CultureInfo.GetCultureInfo("zh-TW");

        public Form1()
        {
            InitializeComponent();
        }

        private void txtServiceAndLabor_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxLube_CheckedChanged(object sender, EventArgs e)
        {

        }

        // 計算各類服務費用
        private decimal OilLubeCharges()
        {
            decimal total = 0m;
            if (checkBoxOilChange.Checked) total += OIL_CHANGE;
            if (checkBoxLube.Checked) total += LUBE;
            return total;
        }

        private decimal FlushCharges()
        {
            decimal total = 0m;
            if (checkBoxRadiatorFlush.Checked) total += RADIATOR;
            if (checkBoxTransmissionFlush.Checked) total += TRANSMISSION;
            return total;
        }

        private decimal MiscCharges()
        {
            decimal total = 0m;
            if (checkBoxInspection.Checked) total += INSPECTION;
            if (checkBoxMuffler.Checked) total += MUFFLER;
            if (checkBoxTireRotate.Checked) total += TIRE_ROTATE;
            return total;
        }

        private bool TryGetPartsAndHours(out decimal partsFee, out decimal hours, out string errorMessage)
        {
            partsFee = 0m; hours = 0m; errorMessage = null;
            if (!string.IsNullOrWhiteSpace(textBoxParts.Text))
            {
                if (!decimal.TryParse(textBoxParts.Text, NumberStyles.Number, ci, out partsFee))
                {
                    errorMessage = "零件費用格式錯誤，請輸入數字。";
                    return false;
                }
                if (partsFee < 0m)
                {
                    errorMessage = "零件費用不可為負數。";
                    return false;
                }
            }
            if (!string.IsNullOrWhiteSpace(textBoxHours.Text))
            {
                if (!decimal.TryParse(textBoxHours.Text, NumberStyles.Number, ci, out hours))
                {
                    errorMessage = "工時數格式錯誤，請輸入數字。";
                    return false;
                }
                if (hours < 0m)
                {
                    errorMessage = "工時不可為負數。";
                    return false;
                }
            }
            return true;
        }

        private decimal TaxCharges(decimal partsFee)
        {
            return Math.Round(partsFee * TAX_RATE, 2);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 解析零件與工時輸入
            if (!TryGetPartsAndHours(out decimal partsFee, out decimal hours, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal services = OilLubeCharges() + FlushCharges() + MiscCharges();
            decimal labor = Math.Round(hours * LABOR_RATE_PER_HOUR, 2);
            decimal serviceAndLabor = services + labor;
            decimal tax = TaxCharges(partsFee);
            decimal total = serviceAndLabor + partsFee + tax;

            txtServiceAndLabor.Text = serviceAndLabor.ToString("C", ci);
            txtPartsFee.Text = partsFee.ToString("C", ci);
            txtTax.Text = tax.ToString("C", ci);
            txtTotal.Text = total.ToString("C", ci);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearOilLube()
        {
            checkBoxOilChange.Checked = false;
            checkBoxLube.Checked = false;
        }

        private void ClearFlushes()
        {
            checkBoxRadiatorFlush.Checked = false;
            checkBoxTransmissionFlush.Checked = false;
        }

        private void ClearMisc()
        {
            checkBoxInspection.Checked = false;
            checkBoxMuffler.Checked = false;
            checkBoxTireRotate.Checked = false;
        }

        private void ClearOther()
        {
            textBoxParts.Text = string.Empty;
            textBoxHours.Text = string.Empty;
        }

        private void ClearFees()
        {
            txtServiceAndLabor.Text = string.Empty;
            txtPartsFee.Text = string.Empty;
            txtTax.Text = string.Empty;
            txtTotal.Text = string.Empty;
        }

        // 儲存報表到檔案，回傳是否成功 (true)；使用者取消或發生錯誤視為 false
        private bool SaveServiceDetailsToFile()
        {
            if (!TryGetPartsAndHours(out decimal partsFee, out decimal hours, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            decimal oilLube = OilLubeCharges();
            decimal flush = FlushCharges();
            decimal misc = MiscCharges();
            decimal labor = Math.Round(hours * LABOR_RATE_PER_HOUR, 2);
            decimal serviceAndLabor = oilLube + flush + misc + labor;
            decimal tax = TaxCharges(partsFee);
            decimal total = serviceAndLabor + partsFee + tax;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("汽車維修服務明細");
            sb.AppendLine($"日期時間: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            sb.AppendLine(new string('-', 50));
            sb.AppendLine("選取的服務：");
            if (checkBoxOilChange.Checked) sb.AppendLine($" - 更換機油: {OIL_CHANGE.ToString("C", ci)}");
            if (checkBoxLube.Checked) sb.AppendLine($" - 潤滑保養: {LUBE.ToString("C", ci)}");
            if (checkBoxRadiatorFlush.Checked) sb.AppendLine($" - 水箱清洗: {RADIATOR.ToString("C", ci)}");
            if (checkBoxTransmissionFlush.Checked) sb.AppendLine($" - 變速箱清洗: {TRANSMISSION.ToString("C", ci)}");
            if (checkBoxInspection.Checked) sb.AppendLine($" - 檢驗: {INSPECTION.ToString("C", ci)}");
            if (checkBoxMuffler.Checked) sb.AppendLine($" - 更換消音器: {MUFFLER.ToString("C", ci)}");
            if (checkBoxTireRotate.Checked) sb.AppendLine($" - 輪胎換位: {TIRE_ROTATE.ToString("C", ci)}");
            sb.AppendLine();
            sb.AppendLine("費用明細：");
            sb.AppendLine($"服務與工資總額: {serviceAndLabor.ToString("C", ci)}");
            sb.AppendLine($"零件費用: {partsFee.ToString("C", ci)}");
            sb.AppendLine($"稅金 (6%): {tax.ToString("C", ci)}");
            sb.AppendLine($"總費用: {total.ToString("C", ci)}");
            sb.AppendLine(new string('-', 50));
            sb.AppendLine("計算過程：");
            sb.AppendLine($"服務小計: {(oilLube + flush + misc).ToString("C", ci)}");
            sb.AppendLine($"工時: {hours} 小時 x {LABOR_RATE_PER_HOUR.ToString("C", ci)} = {labor.ToString("C", ci)}");
            sb.AppendLine($"稅率: {TAX_RATE:P0}");

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "文字檔 (*.txt)|*.txt|所有檔案 (*.*)|*.*";
                sfd.DefaultExt = "txt";
                sfd.FileName = $"Maintenance_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                if (sfd.ShowDialog() != DialogResult.OK) return false;
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName, false, new UTF8Encoding(false)))
                    {
                        sw.Write(sb.ToString());
                    }
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"儲存檔案失敗: {ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("是否在離開前儲存維修明細?", "儲存確認", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
            if (result == DialogResult.Yes)
            {
                bool saved = SaveServiceDetailsToFile();
                if (!saved)
                {
                    // 如果使用者在儲存對話框取消或儲存失敗，取消關閉
                    e.Cancel = true;
                }
            }
        }
    }
}
