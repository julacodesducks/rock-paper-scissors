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
            resultLabel = new Label();
            Rock = new PictureBox();
            Paper = new PictureBox();
            Scissors = new PictureBox();
            scoreLabel = new Label();
            livesLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)Rock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Paper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Scissors).BeginInit();
            SuspendLayout();
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Berlin Sans FB", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultLabel.Location = new Point(326, 110);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(147, 56);
            resultLabel.TabIndex = 3;
            resultLabel.Text = "label1";
            // 
            // Rock
            // 
            Rock.BackColor = Color.Black;
            Rock.Location = new Point(100, 290);
            Rock.Name = "Rock";
            Rock.Size = new Size(115, 115);
            Rock.SizeMode = PictureBoxSizeMode.StretchImage;
            Rock.TabIndex = 4;
            Rock.TabStop = false;
            Rock.Click += pictureBox1_Click;
            // 
            // Paper
            // 
            Paper.BackColor = Color.Black;
            Paper.Location = new Point(342, 290);
            Paper.Name = "Paper";
            Paper.Size = new Size(115, 115);
            Paper.SizeMode = PictureBoxSizeMode.StretchImage;
            Paper.TabIndex = 5;
            Paper.TabStop = false;
            Paper.Click += pictureBox2_Click;
            // 
            // Scissors
            // 
            Scissors.BackColor = Color.Black;
            Scissors.Location = new Point(585, 290);
            Scissors.Name = "Scissors";
            Scissors.Size = new Size(115, 115);
            Scissors.SizeMode = PictureBoxSizeMode.StretchImage;
            Scissors.TabIndex = 6;
            Scissors.TabStop = false;
            Scissors.Click += pictureBox3_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreLabel.Location = new Point(12, 9);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(80, 31);
            scoreLabel.TabIndex = 7;
            scoreLabel.Text = "label1";
            // 
            // livesLabel
            // 
            livesLabel.AutoSize = true;
            livesLabel.Font = new Font("Berlin Sans FB", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            livesLabel.Location = new Point(135, 9);
            livesLabel.Name = "livesLabel";
            livesLabel.Size = new Size(80, 31);
            livesLabel.TabIndex = 8;
            livesLabel.Text = "label1";
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(livesLabel);
            Controls.Add(scoreLabel);
            Controls.Add(Scissors);
            Controls.Add(Paper);
            Controls.Add(Rock);
            Controls.Add(resultLabel);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Game";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Rock).EndInit();
            ((System.ComponentModel.ISupportInitialize)Paper).EndInit();
            ((System.ComponentModel.ISupportInitialize)Scissors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label resultLabel;
        private PictureBox Rock;
        private PictureBox Paper;
        private PictureBox Scissors;
        private Label scoreLabel;
        private Label livesLabel;
    }
}
