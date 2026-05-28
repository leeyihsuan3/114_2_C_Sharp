using System;
using System.Windows.Forms;

namespace CustomDialogs
{
    public partial class MessageForm : Form
    {
        public MessageForm() : this(string.Empty) { }

        public MessageForm(string message)
        {
            InitializeComponent();
            labelMessage.Text = string.IsNullOrEmpty(message) ? "祝你有愉快的一天" : message;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}