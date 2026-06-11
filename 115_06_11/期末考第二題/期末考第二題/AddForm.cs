using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace 期末考第二題
{
    public class AddForm : Form
    {
        private List<Employee> employees;

        TextBox txtId, txtName, txtDepartment, txtPosition;
        RichTextBox richTextBox1;

        public AddForm(List<Employee> employees)
        {
            this.employees = employees;
            BuildUI();
        }

        private void BuildUI()
        {
            Text = "新增員工";
            Size = new Size(760, 620);
            StartPosition = FormStartPosition.CenterParent;
            BackColor = Color.FromArgb(240, 240, 240);

            Label title = new Label();
            title.Text = "新增員工";
            title.Font = new Font("新細明體", 26, FontStyle.Bold);
            title.Location = new Point(45, 35);
            title.Size = new Size(250, 55);
            Controls.Add(title);

            AddLabel("員工編號：", 90, 130);
            txtId = AddTextBox(300, 125);

            AddLabel("姓名：", 90, 190);
            txtName = AddTextBox(300, 185);

            AddLabel("部門：", 90, 250);
            txtDepartment = AddTextBox(300, 245);

            AddLabel("職稱：", 90, 310);
            txtPosition = AddTextBox(300, 305);

            Button btnAdd = new Button();
            btnAdd.Text = "新增";
            btnAdd.Font = new Font("新細明體", 16);
            btnAdd.Location = new Point(300, 380);
            btnAdd.Size = new Size(130, 45);
            btnAdd.Click += BtnAdd_Click;
            Controls.Add(btnAdd);

            Button btnClose = new Button();
            btnClose.Text = "離開";
            btnClose.Font = new Font("新細明體", 16);
            btnClose.Location = new Point(480, 380);
            btnClose.Size = new Size(130, 45);
            btnClose.Click += (s, e) => Close();
            Controls.Add(btnClose);

            richTextBox1 = new RichTextBox();
            richTextBox1.Location = new Point(55, 465);
            richTextBox1.Size = new Size(640, 120);
            richTextBox1.ReadOnly = true;
            Controls.Add(richTextBox1);
        }

        private void AddLabel(string text, int x, int y)
        {
            Label label = new Label();
            label.Text = text;
            label.Font = new Font("新細明體", 18);
            label.Location = new Point(x, y);
            label.Size = new Size(160, 35);
            Controls.Add(label);
        }

        private TextBox AddTextBox(int x, int y)
        {
            TextBox textBox = new TextBox();
            textBox.Font = new Font("新細明體", 16);
            textBox.Location = new Point(x, y);
            textBox.Size = new Size(370, 35);
            Controls.Add(textBox);
            return textBox;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int id;

            if (!int.TryParse(txtId.Text.Trim(), out id))
            {
                MessageBox.Show("員工編號必須是數字");
                return;
            }

            if (txtName.Text.Trim() == "")
            {
                MessageBox.Show("請輸入姓名");
                return;
            }

            if (employees.Any(emp => emp.IdNumber == id))
            {
                MessageBox.Show("此員工編號已存在");
                return;
            }

            employees.Add(new Employee(
                txtName.Text.Trim(),
                id,
                txtDepartment.Text.Trim(),
                txtPosition.Text.Trim()
            ));

            richTextBox1.Text =
                "新增成功！\n\n" +
                "員工編號：" + id + "\n" +
                "姓名：" + txtName.Text + "\n" +
                "部門：" + txtDepartment.Text + "\n" +
                "職稱：" + txtPosition.Text;

            MessageBox.Show("新增成功");
        }
    }
}