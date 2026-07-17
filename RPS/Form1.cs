using System.Media;

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
            if (playerLives > 0) { 
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

            await Task.Delay(2000);
            if (playerLives <= 0)
            {
                resultLabel.Text = "Game Over! Score: " + score;
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            setChoice("Rock");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            setChoice("Paper");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            setChoice("Scissors");
        }
    }
}
