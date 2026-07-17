namespace RPS
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            resultLabel = new Label();
            Rock = new PictureBox();
            Paper = new PictureBox();
            Scissors = new PictureBox();
            scoreLabel = new Label();
            livesLabel = new Label();
            PlayAgain = new Button();
            Quit = new Button();
            ((System.ComponentModel.ISupportInitialize)Rock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Paper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Scissors).BeginInit();
            SuspendLayout();
            // 
            // resultLabel
            // 
            resultLabel.Font = new Font("Berlin Sans FB", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.ForeColor = Color.FromArgb(154, 48, 48);
            resultLabel.Location = new Point(-4, -90);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(821, 466);
            resultLabel.TabIndex = 3;
            resultLabel.Text = "Rock Paper Scissors";
            resultLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Rock
            // 
            Rock.BackColor = Color.Transparent;
            Rock.Cursor = Cursors.Hand;
            Rock.Image = (Image)resources.GetObject("Rock.Image");
            Rock.Location = new Point(100, 290);
            Rock.Name = "Rock";
            Rock.Size = new Size(115, 115);
            Rock.SizeMode = PictureBoxSizeMode.StretchImage;
            Rock.TabIndex = 4;
            Rock.TabStop = false;
            Rock.Click += RockButton;
            // 
            // Paper
            // 
            Paper.BackColor = Color.Transparent;
            Paper.Cursor = Cursors.Hand;
            Paper.Image = (Image)resources.GetObject("Paper.Image");
            Paper.Location = new Point(342, 290);
            Paper.Name = "Paper";
            Paper.Size = new Size(115, 115);
            Paper.SizeMode = PictureBoxSizeMode.StretchImage;
            Paper.TabIndex = 5;
            Paper.TabStop = false;
            Paper.Click += PaperButton;
            // 
            // Scissors
            // 
            Scissors.BackColor = Color.Transparent;
            Scissors.Cursor = Cursors.Hand;
            Scissors.Image = (Image)resources.GetObject("Scissors.Image");
            Scissors.Location = new Point(585, 290);
            Scissors.Name = "Scissors";
            Scissors.Size = new Size(115, 115);
            Scissors.SizeMode = PictureBoxSizeMode.StretchImage;
            Scissors.TabIndex = 6;
            Scissors.TabStop = false;
            Scissors.Click += ScissorsButton;
            // 
            // scoreLabel
            // 
            scoreLabel.Font = new Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreLabel.ForeColor = Color.FromArgb(154, 48, 48);
            scoreLabel.Location = new Point(12, 9);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(203, 31);
            scoreLabel.TabIndex = 7;
            scoreLabel.Text = "Score";
            // 
            // livesLabel
            // 
            livesLabel.Font = new Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            livesLabel.ForeColor = Color.FromArgb(154, 48, 48);
            livesLabel.Location = new Point(223, 9);
            livesLabel.Name = "livesLabel";
            livesLabel.Size = new Size(234, 31);
            livesLabel.TabIndex = 8;
            livesLabel.Text = "Lives";
            // 
            // PlayAgain
            // 
            PlayAgain.BackColor = Color.FromArgb(154, 48, 48);
            PlayAgain.Cursor = Cursors.Hand;
            PlayAgain.Font = new Font("Berlin Sans FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayAgain.ForeColor = Color.Black;
            PlayAgain.Location = new Point(220, 193);
            PlayAgain.Name = "PlayAgain";
            PlayAgain.Size = new Size(116, 44);
            PlayAgain.TabIndex = 9;
            PlayAgain.Text = "Play again";
            PlayAgain.UseVisualStyleBackColor = false;
            PlayAgain.Visible = false;
            PlayAgain.Click += PlayAgainButton;
            // 
            // Quit
            // 
            Quit.BackColor = Color.FromArgb(154, 48, 48);
            Quit.Cursor = Cursors.Hand;
            Quit.Font = new Font("Berlin Sans FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quit.ForeColor = Color.Black;
            Quit.Location = new Point(462, 193);
            Quit.Name = "Quit";
            Quit.Size = new Size(116, 44);
            Quit.TabIndex = 10;
            Quit.Text = "Quit";
            Quit.UseVisualStyleBackColor = false;
            Quit.Visible = false;
            Quit.Click += QuitButton;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightCoral;
            ClientSize = new Size(800, 450);
            Controls.Add(Quit);
            Controls.Add(PlayAgain);
            Controls.Add(livesLabel);
            Controls.Add(scoreLabel);
            Controls.Add(Scissors);
            Controls.Add(Paper);
            Controls.Add(Rock);
            Controls.Add(resultLabel);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Game";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rock Paper Scissors";
            ((System.ComponentModel.ISupportInitialize)Rock).EndInit();
            ((System.ComponentModel.ISupportInitialize)Paper).EndInit();
            ((System.ComponentModel.ISupportInitialize)Scissors).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label resultLabel;
        private PictureBox Rock;
        private PictureBox Paper;
        private PictureBox Scissors;
        private Label scoreLabel;
        private Label livesLabel;
        private Button PlayAgain;
        private Button Quit;
    }
}
