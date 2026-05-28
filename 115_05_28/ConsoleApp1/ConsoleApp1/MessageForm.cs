using System;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object? sender, EventArgs e)
        {
            Close();
        }
    }
}