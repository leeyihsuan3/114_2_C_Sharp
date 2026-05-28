using System;
using System.Windows.Forms;

namespace ConsoleApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // 初始化 WinForms 應用設定（.NET 6+ 樣板）
            ApplicationConfiguration.Initialize();
            Application.Run(new MessageForm());
        }
    }
}
