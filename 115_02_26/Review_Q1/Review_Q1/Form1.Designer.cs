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

            // 事件註冊（Designer 未綁定時在此綁定）
            this.Load += Form1_Load;
            stoneButton.Click += stoneButton_Click;
            paperButton.Click += paperButton_Click;
            scissorButton.Click += scissorButton_Click;
            exitButton.Click += exitButton_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 初始化表單：清空圖片與結果顯示
            compChoice = Choice.None;
            playerChoice = Choice.None;
            playerWins = 0;
            compWins = 0;
            draws = 0;

            resultLabel.Text = string.Empty;

            computerPictureBox.Image = null;
            playerPictureBox.Image = null;
            computerPictureBox.Visible = false;
            playerPictureBox.Visible = false;
        }

        private void getCompChoice()
        {
            compChoice = (Choice)rnd.Next(0, 3);
        }

        private void showComputerImage()
        {
            // 假設資源命名為 {rock,paper,scissor}_computer 與 {rock,paper,scissor}_player
            switch (compChoice)
            {
                case Choice.Rock:
                    computerPictureBox.Image = Properties.Resources.stone_computer;
                    break;
                case Choice.Paper:
                    computerPictureBox.Image = Properties.Resources.paper_computer;
                    break;
                case Choice.Scissors:
                    computerPictureBox.Image = Properties.Resources.scissor_computer;
                    break;
                default:
                    computerPictureBox.Image = null;
                    break;
            }

            computerPictureBox.Visible = computerPictureBox.Image != null;
        }

        private void showPlayerImage()
        {
            switch (playerChoice)
            {
                case Choice.Rock:
                    playerPictureBox.Image = Properties.Resources.stone_player;
                    break;
                case Choice.Paper:
                    playerPictureBox.Image = Properties.Resources.paper_player;
                    break;
                case Choice.Scissors:
                    playerPictureBox.Image = Properties.Resources.scissor_player;
                    break;
                default:
                    playerPictureBox.Image = null;
                    break;
            }

            playerPictureBox.Visible = playerPictureBox.Image != null;
        }

        private void showWinner()
        {
            if (playerChoice == Choice.None || compChoice == Choice.None)
            {
                resultLabel.Text = string.Empty;
                return;
            }

            if (playerChoice == compChoice)
            {
                draws++;
                resultLabel.Text = "平手";
                return;
            }

            // 判斷玩家是否贏
            bool playerWinsRound =
                (playerChoice == Choice.Rock && compChoice == Choice.Scissors) ||
                (playerChoice == Choice.Paper && compChoice == Choice.Rock) ||
                (playerChoice == Choice.Scissors && compChoice == Choice.Paper);

            if (playerWinsRound)
            {
                playerWins++;
                resultLabel.Text = "玩家贏";
            }
            else
            {
                compWins++;
                resultLabel.Text = "電腦贏";
            }
        }

        private void stoneButton_Click(object sender, EventArgs e)
        {
            playerChoice = Choice.Rock;
            showPlayerImage();

            getCompChoice();
            showComputerImage();

            showWinner();
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            playerChoice = Choice.Paper;
            showPlayerImage();

            getCompChoice();
            showComputerImage();

            showWinner();
        }

        private void scissorButton_Click(object sender, EventArgs e)
        {
            playerChoice = Choice.Scissors;
            showPlayerImage();

            getCompChoice();
            showComputerImage();

            showWinner();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            string stats = $"統計結果：\n玩家：{playerWins} 勝\n電腦：{compWins} 勝\n平手：{draws} 次";
            MessageBox.Show(stats, "遊戲統計", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void computerPictureBox_Click(object sender, EventArgs e)
        {
            // 保留空的 click 處理器（Designer 可能綁定）
        }
    }
}

