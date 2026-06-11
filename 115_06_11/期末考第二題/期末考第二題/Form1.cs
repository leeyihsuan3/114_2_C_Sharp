using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace 期末考第二題
{
    public partial class Form1 : Form
    {
        public List<Employee> employees = new List<Employee>();
        string filePath = "employees.txt";

        

        public Form1()
        {
            InitializeComponent();
            // 設計器產生的控制項存在於 Form1.Designer.cs
            // 綁定按鈕事件到現有的處理器
            this.btnAdd.Click += BtnAdd_Click;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnSearch.Click += BtnSearch_Click;
            this.btnExit.Click += BtnExit_Click;

            LoadEmployees();
            UpdateListBox();
        }

        // UI 由設計器（Form1.Designer.cs）管理

        private void LoadEmployees()
        {
            if (!File.Exists(filePath))
            {
                employees.Add(new Employee("Alice Chen", 1001, "Sales", "Manager"));
                employees.Add(new Employee("Bob Lin", 1002, "IT", "Engineer"));
                employees.Add(new Employee("Carol Wang", 1003, "HR", "Specialist"));
                SaveEmployees();
                return;
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] data = line.Split('|');

                if (data.Length == 4)
                {
                    int id;
                    if (int.TryParse(data[0], out id))
                    {
                        employees.Add(new Employee(data[1], id, data[2], data[3]));
                    }
                }
            }
        }

        public void SaveEmployees()
        {
            List<string> lines = new List<string>();

            foreach (Employee emp in employees)
            {
                lines.Add(emp.IdNumber + "|" + emp.Name + "|" + emp.Department + "|" + emp.Position);
            }

            File.WriteAllLines(filePath, lines);
        }

        public void UpdateListBox()
        {
            employeeListBox.Items.Clear();

            foreach (Employee emp in employees)
            {
                employeeListBox.Items.Add(emp.IdNumber + " " + emp.Name);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm(employees);
            form.ShowDialog();
            SaveEmployees();
            UpdateListBox();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteForm form = new DeleteForm(employees);
            form.ShowDialog();
            SaveEmployees();
            UpdateListBox();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditForm form = new EditForm(employees);
            form.ShowDialog();
            SaveEmployees();
            UpdateListBox();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm(employees);
            form.ShowDialog();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            SaveEmployees();
            Close();
        }

        
    }
}