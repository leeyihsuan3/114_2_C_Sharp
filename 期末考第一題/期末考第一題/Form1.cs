using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace 期末考第一題
{
    public partial class Form1 : Form
    {
        public struct MorseData
        {
            public char Letter;
            public string MorseCode;
        }

        private List<MorseData> morseTable = new List<MorseData>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            morseTable.Clear();

            StreamReader inputFile;
            inputFile = File.OpenText(@"C:\Users\m303\Desktop\114_2_C_Sharp\期末考第一題\期末考第一題\morse_code_table.md");

            while (!inputFile.EndOfStream)
            {
                string line = inputFile.ReadLine();

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                if (!line.StartsWith("|"))
                    continue;

                if (line.Contains("Character") || line.Contains(":---"))
                    continue;

                string[] parts = line.Split('|');

                for (int i = 1; i < parts.Length - 1; i += 2)
                {
                    string character = parts[i].Trim();
                    string code = parts[i + 1].Trim();

                    code = code.Replace("`", "");
                    code = code.Replace("*", "");

                    if (character == "space")
                        continue;

                    if (character == "comma")
                        character = ",";

                    if (character == "period")
                        character = ".";

                    if (character.Length == 1 && !string.IsNullOrWhiteSpace(code))
                    {
                        MorseData data;
                        data.Letter = char.ToUpper(character[0]);
                        data.MorseCode = code;

                        morseTable.Add(data);
                    }
                }
            }

            inputFile.Close();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            listBox1.Items.Clear();

            string input = textBox1.Text.ToUpper();
            StringBuilder result = new StringBuilder();

            foreach (char ch in input)
            {
                if (ch == ' ')
                {
                    if (result.Length > 0)
                        result.Append(" ");

                    result.Append("/");
                    listBox1.Items.Add("空白    /");
                    continue;
                }

                foreach (MorseData data in morseTable)
                {
                    if (data.Letter == ch)
                    {
                        if (result.Length > 0)
                            result.Append(" ");

                        result.Append(data.MorseCode);
                        listBox1.Items.Add(ch + "    " + data.MorseCode);
                        break;
                    }
                }
            }

            textBox2.Text = result.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            listBox1.Items.Clear();
        }
    }
}