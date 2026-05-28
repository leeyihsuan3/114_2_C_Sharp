using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsoleApp1
{
    partial class MessageForm
    {
        private System.ComponentModel.IContainer? components = null;
        private TableLayoutPanel? tableLayoutPanel1;
        private Label? messageLabel;
        private Button? closeButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new TableLayoutPanel();
            this.messageLabel = new Label();
            this.closeButton = new Button();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.messageLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.closeButton, 0, 1);
            // 
            // messageLabel
            // 
            this.messageLabel.Dock = DockStyle.Fill;
            this.messageLabel.Text = "祝你有愉快的一天";
            this.messageLabel.TextAlign = ContentAlignment.MiddleCenter;
            this.messageLabel.Font = new Font("Microsoft JhengHei", 28F, FontStyle.Regular, GraphicsUnit.Point);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Anchor = AnchorStyles.None;
            this.closeButton.Text = "關閉";
            this.closeButton.Padding = new Padding(8, 4, 8, 4);
            this.closeButton.Click += new EventHandler(this.closeButton_Click);
            // 
            // MessageForm
            // 
            this.ClientSize = new Size(700, 220);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Text = "給你的訊息";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }
    }
}