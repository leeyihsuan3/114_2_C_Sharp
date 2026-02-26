using System;
using System.Windows.Forms;

namespace Review_Q1
{
    public partial class Form1 : Form
    {
        private enum Choice
        {
            None = -1,
            Rock = 0,
            Paper = 1,
            Scissors = 2
        }

        private readonly Random rnd = new();
        private Choice compChoice = Choice.None;
        private Choice playerChoice = Choice.None;
        private int playerWins = 0;
        private int compWins = 0;
        private int draws = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            compChoice = Choice.None;
            playerChoice = Choice.None;
            playerWins = 0;
            compWins = 0;
            draws = 0;

            resultLabel.Text = "請選擇：石頭、布、剪刀";
            computerPictureBox.Image = null;
            playerPictureBox.Image = null;
        }

        private void GetCompChoice()
        {
            compChoice = (Choice)rnd.Next(0, 3);
        }

        private void ShowComputerImage()
        {
            switch (compChoice)
            {
                case Choice.Rock:
                    computerPictureBox.Text = "✊";
                    computerPictureBox.BackColor = System.Drawing.Color.LightGray;
                    break;
                case Choice.Paper:
                    computerPictureBox.Text = "✋";
                    computerPictureBox.BackColor = System.Drawing.Color.LightBlue;
                    break;
                case Choice.Scissors:
                    computerPictureBox.Text = "✌️";
                    computerPictureBox.BackColor = System.Drawing.Color.LightGreen;
                    break;
                default:
                    computerPictureBox.Text = "";
                    break;
            }
        }

        private void ShowPlayerImage()
        {
            switch (playerChoice)
            {
                case Choice.Rock:
                    playerPictureBox.Text = "✊";
                    playerPictureBox.BackColor = System.Drawing.Color.LightGray;
                    break;
                case Choice.Paper:
                    playerPictureBox.Text = "✋";
                    playerPictureBox.BackColor = System.Drawing.Color.LightBlue;
                    break;
                case Choice.Scissors:
                    playerPictureBox.Text = "✌️";
                    playerPictureBox.BackColor = System.Drawing.Color.LightGreen;
                    break;
                default:
                    playerPictureBox.Text = "";
                    break;
            }
        }

        private void ShowWinner()
        {
            if (playerChoice == Choice.None || compChoice == Choice.None)
            {
                resultLabel.Text = string.Empty;
                return;
            }

            if (playerChoice == compChoice)
            {
                draws++;
                resultLabel.Text = $"平手！ 玩家：{playerWins}勝 | 電腦：{compWins}勝 | 平手：{draws}次";
                return;
            }

            bool playerWinsRound =
                (playerChoice == Choice.Rock && compChoice == Choice.Scissors) ||
                (playerChoice == Choice.Paper && compChoice == Choice.Rock) ||
                (playerChoice == Choice.Scissors && compChoice == Choice.Paper);

            if (playerWinsRound)
            {
                playerWins++;
                resultLabel.Text = $"玩家贏！ 玩家：{playerWins}勝 | 電腦：{compWins}勝 | 平手：{draws}次";
            }
            else
            {
                compWins++;
                resultLabel.Text = $"電腦贏！ 玩家：{playerWins}勝 | 電腦：{compWins}勝 | 平手：{draws}次";
            }
        }

        private void StoneButton_Click(object sender, EventArgs e)
        {
            playerChoice = Choice.Rock;
            ShowPlayerImage();

            GetCompChoice();
            ShowComputerImage();

            ShowWinner();
        }

        private void PaperButton_Click(object sender, EventArgs e)
        {
            playerChoice = Choice.Paper;
            ShowPlayerImage();

            GetCompChoice();
            ShowComputerImage();

            ShowWinner();
        }

        private void ScissorButton_Click(object sender, EventArgs e)
        {
            playerChoice = Choice.Scissors;
            ShowPlayerImage();

            GetCompChoice();
            ShowComputerImage();

            ShowWinner();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            string stats = $"統計結果：\n玩家：{playerWins} 勝\n電腦：{compWins} 勝\n平手：{draws} 次";
            MessageBox.Show(stats, "遊戲統計", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}