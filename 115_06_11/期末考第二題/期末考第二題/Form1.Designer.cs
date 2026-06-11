namespace 期末考第二題
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelList = new System.Windows.Forms.Label();
            this.employeeListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("新細明體", 24F);
            this.labelTitle.Location = new System.Drawing.Point(57, 32);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(308, 48);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "員工資料管理";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(65, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "新增員工";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(65, 194);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 35);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "刪除員工";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(65, 251);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(95, 33);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "修改員工";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(65, 313);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 34);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "查詢員工";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(65, 368);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 26);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "離開";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // labelList
            // 
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(213, 107);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(152, 18);
            this.labelList.TabIndex = 12;
            this.labelList.Text = "員工編號與姓名：";
            // 
            // employeeListBox
            // 
            this.employeeListBox.FormattingEnabled = true;
            this.employeeListBox.ItemHeight = 18;
            this.employeeListBox.Location = new System.Drawing.Point(205, 144);
            this.employeeListBox.Name = "employeeListBox";
            this.employeeListBox.Size = new System.Drawing.Size(543, 292);
            this.employeeListBox.TabIndex = 13;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1120, 591);
            this.Controls.Add(this.employeeListBox);
            this.Controls.Add(this.labelList);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelTitle);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "員工資料管理系統";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.ListBox employeeListBox;
    }
}

