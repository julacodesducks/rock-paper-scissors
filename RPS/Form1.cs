using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace RPS
{
    public partial class Game : Form
    {
        private string playerChoice = "";
        private int playerLives = 3;
        private int score = 0;
        Random rand = new Random();

        private string AIMove()
        {
            int choice = rand.Next(1, 4);
            switch (choice)
            {
                case 1:
                    return "Rock";
                case 2:
                    return "Paper";
                case 3:
                    return "Scissors";
            }
            return "Rock"; //default
        }

        private async void setChoice(string choice) //game logic
        {
            string win = "";
            playerChoice = choice.ToLower();
            string aiChoice = AIMove().ToLower();
            if (playerLives > 0)
            {
                if (playerChoice == aiChoice)
                {
                    win = "Draw!";
                }
                else if ((playerChoice == "rock" && aiChoice == "scissors") ||
                         (playerChoice == "paper" && aiChoice == "rock") ||
                         (playerChoice == "scissors" && aiChoice == "paper"))
                {
                    win = "You Win!";
                    score++;
                }
                else
                {
                    win = "You Lose!";
                    playerLives--;
                }
            }
            resultLabel.Text = win;
            scoreLabel.Text = "Score: " + score;
            livesLabel.Text = "Lives: " + playerLives;

            await Task.Delay(1000);
            if (playerLives <= 0)
            {
                resultLabel.Text = "Game Over! Score: " + score;
                PlayAgain.Visible = true;
                Quit.Visible = true;
                BlockButtons();
            }
            else
            {
                resultLabel.Text = "Your move!";
            }
        }

        public Game()
        {
            InitializeComponent();
            resultLabel.Text = "Welcome to Rock Paper Scissors!";
            scoreLabel.Text = "Score: " + score;
            livesLabel.Text = "Lives: " + playerLives;

        }
        private async void RockButton(object sender, EventArgs e)
        {
            setChoice("Rock");
            BlockButtons();
            Rock.BorderStyle = BorderStyle.Fixed3D;
            await Task.Delay(1000);
            Rock.BorderStyle = BorderStyle.None;
            UnblockButtons();
        }

        private async void PaperButton(object sender, EventArgs e)
        {
            setChoice("Paper");
            BlockButtons();
            Paper.BorderStyle = BorderStyle.Fixed3D;
            await Task.Delay(1000);
            Paper.BorderStyle = BorderStyle.None;
            UnblockButtons();

        }

        private async void ScissorsButton(object sender, EventArgs e)
        {
            setChoice("Scissors");
            BlockButtons();
            Scissors.BorderStyle = BorderStyle.Fixed3D;
            await Task.Delay(1000);
            Scissors.BorderStyle = BorderStyle.None;
            UnblockButtons();

        }

        private void BlockButtons()
        {
            Rock.Enabled = false;
            Paper.Enabled = false;
            Scissors.Enabled = false;
        }

        private void UnblockButtons()
        {
            Rock.Enabled = true;
            Paper.Enabled = true;
            Scissors.Enabled = true;
        }

        private void PlayAgainButton(object sender, EventArgs e)
        {
            score = 0;
            playerLives = 3;
            scoreLabel.Text = "Score: " + score;
            livesLabel.Text = "Lives: " + playerLives;
            resultLabel.Text = "Your move!"; 
            PlayAgain.Visible = false;
            Quit.Visible = false;
            UnblockButtons();
        }

        private void QuitButton(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
