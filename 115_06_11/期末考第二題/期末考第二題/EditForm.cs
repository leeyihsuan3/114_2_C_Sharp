using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace 期末考第二題
{
    public class EditForm : Form
    {
        List<Employee> employees;
        Employee currentEmployee;

        // controls (designer replaced)
        private TextBox txtId, txtName, txtDepartment, txtPosition;
        private RichTextBox resultBox;

        public EditForm(List<Employee> employees)
        {
            this.employees = employees;
            BuildUI();
        }

        private void BuildUI()
        {
            Text = "修改員工資料";
            Size = new Size(600, 550);
            StartPosition = FormStartPosition.CenterParent;

            Label title = new Label();
            title.Text = "修改員工資料";
            title.Font = new Font("新細明體", 24, FontStyle.Bold);
            title.Location = new Point(40, 30);
            title.Size = new Size(300, 50);
            Controls.Add(title);

            AddLabel("員工編號：", 60, 110);
            txtId = AddTextBox(180, 110);

            Button btnSearch = new Button();
            btnSearch.Text = "查詢";
            btnSearch.Location = new Point(230, 150);
            btnSearch.Size = new Size(100, 40);
            btnSearch.Click += BtnSearch_Click;
            Controls.Add(btnSearch);

            AddLabel("姓名：", 60, 210);
            txtName = AddTextBox(180, 210);

            AddLabel("部門：", 60, 260);
            txtDepartment = AddTextBox(180, 260);

            AddLabel("職稱：", 60, 310);
            txtPosition = AddTextBox(180, 310);

            Button btnSave = new Button();
            btnSave.Text = "儲存";
            btnSave.Location = new Point(180, 370);
            btnSave.Size = new Size(100, 40);
            btnSave.Click += BtnSave_Click;
            Controls.Add(btnSave);

            Button btnClose = new Button();
            btnClose.Text = "離開";
            btnClose.Location = new Point(320, 370);
            btnClose.Size = new Size(100, 40);
            btnClose.Click += (s, e) => Close();
            Controls.Add(btnClose);

            resultBox = new RichTextBox();
            resultBox.Location = new Point(60, 430);
            resultBox.Size = new Size(460, 60);
            resultBox.Text = "請輸入員工編號後按查詢。";
            Controls.Add(resultBox);
        }

        private void AddLabel(string text, int x, int y)
        {
            Label label = new Label();
            label.Text = text;
            label.Location = new Point(x, y);
            label.Size = new Size(100, 30);
            Controls.Add(label);
        }

        private TextBox AddTextBox(int x, int y)
        {
            TextBox box = new TextBox();
            box.Location = new Point(x, y);
            box.Size = new Size(300, 30);
            Controls.Add(box);
            return box;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtId.Text.Trim(), out id))
            {
                MessageBox.Show("員工編號必須是數字");
                return;
            }

            currentEmployee = employees.FirstOrDefault(x => x.IdNumber == id);

            if (currentEmployee == null)
            {
                MessageBox.Show("找不到員工");
                return;
            }

            txtName.Text = currentEmployee.Name;
            txtDepartment.Text = currentEmployee.Department;
            txtPosition.Text = currentEmployee.Position;
            resultBox.Text = "已找到員工，可修改資料。";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (currentEmployee == null)
            {
                MessageBox.Show("請先查詢員工");
                return;
            }

            currentEmployee.Name = txtName.Text.Trim();
            currentEmployee.Department = txtDepartment.Text.Trim();
            currentEmployee.Position = txtPosition.Text.Trim();

            MessageBox.Show("修改成功");
            Close();
        }
    }
}