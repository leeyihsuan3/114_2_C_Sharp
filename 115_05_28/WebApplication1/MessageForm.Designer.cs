using System.Drawing;
using System.Windows.Forms;

namespace CustomDialogs
{
    partial class MessageForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelMessage;
        private Button buttonClose;

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
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.labelMessage.Font = new Font("Microsoft JhengHei", 24F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(136)));
            this.labelMessage.Location = new Point(12, 20);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new Size(560, 120);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "祝你有愉快的一天";
            this.labelMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = AnchorStyles.Bottom;
            this.buttonClose.Location = new Point((584 - 100) / 2, 150);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new Size(100, 34);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "關閉";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // MessageForm
            // 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(584, 200);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelMessage);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "MessageForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "給你的訊息";
            this.ResumeLayout(false);
        }
    }
}