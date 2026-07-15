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
            Title = new Label();
            Rock = new PictureBox();
            Paper = new PictureBox();
            Scissors = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Rock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Paper).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Scissors).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(375, 20);
            Title.Name = "Title";
            Title.Size = new Size(50, 20);
            Title.TabIndex = 3;
            Title.Text = "label1";
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
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(Scissors);
            Controls.Add(Paper);
            Controls.Add(Rock);
            Controls.Add(Title);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Game";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Rock).EndInit();
            ((System.ComponentModel.ISupportInitialize)Paper).EndInit();
            ((System.ComponentModel.ISupportInitialize)Scissors).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Title;
        private PictureBox Rock;
        private PictureBox Paper;
        private PictureBox Scissors;
    }
}
