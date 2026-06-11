using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace 期末考第二題
{
    public class SearchForm : Form
    {
        private List<Employee> employees;

        TextBox txtId;
        RichTextBox richTextBox1;

        public SearchForm(List<Employee> employees)
        {
            this.employees = employees;
            BuildUI();
        }

        private void BuildUI()
        {
            Text = "查詢員工";
            Size = new Size(650, 430);
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Color.FromArgb(240, 240, 240);

            Label title = new Label();
            title.Text = "查詢員工";
            title.Font = new Font("新細明體", 26, FontStyle.Bold);
            title.Location = new Point(40, 30);
            title.Size = new Size(250, 55);
            Controls.Add(title);

            Label lblId = new Label();
            lblId.Text = "員工編號：";
            lblId.Font = new Font("新細明體", 16);
            lblId.Location = new Point(90, 110);
            lblId.Size = new Size(140, 35);
            Controls.Add(lblId);

            txtId = new TextBox();
            txtId.Font = new Font("新細明體", 16);
            txtId.Location = new Point(250, 105);
            txtId.Size = new Size(280, 35);
            Controls.Add(txtId);

            Button btnSearch = new Button();
            btnSearch.Text = "查詢";
            btnSearch.Font = new Font("新細明體", 16);
            btnSearch.Location = new Point(250, 170);
            btnSearch.Size = new Size(110, 45);
            btnSearch.Click += BtnSearch_Click;
            Controls.Add(btnSearch);

            Button btnClose = new Button();
            btnClose.Text = "離開";
            btnClose.Font = new Font("新細明體", 16);
            btnClose.Location = new Point(410, 170);
            btnClose.Size = new Size(110, 45);
            btnClose.Click += (s, e) => Close();
            Controls.Add(btnClose);

            richTextBox1 = new RichTextBox();
            richTextBox1.Font = new Font("新細明體", 14);
            richTextBox1.Location = new Point(70, 250);
            richTextBox1.Size = new Size(500, 110);
            richTextBox1.ReadOnly = true;
            Controls.Add(richTextBox1);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtId.Text.Trim(), out id))
            {
                MessageBox.Show("請輸入有效的員工編號");
                return;
            }

            Employee emp = employees.FirstOrDefault(x => x.IdNumber == id);

            if (emp == null)
            {
                richTextBox1.Text = "找不到員工";
                return;
            }

            richTextBox1.Text =
                "員工編號：" + emp.IdNumber + "\n" +
                "姓名：" + emp.Name + "\n" +
                "部門：" + emp.Department + "\n" +
                "職位：" + emp.Position;
        }
    }
}