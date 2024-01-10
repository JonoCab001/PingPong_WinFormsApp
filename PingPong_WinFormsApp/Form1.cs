using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong_WinFormsApp
{
    public partial class Form1 : Form
    {
        // Location Variables
        int CPUDirection = 5;
        int ballXPosition = 5;
        int ballYPosition = 5;

        // Score Variables
        int playerScore = 0;
        int CPUScore = 0;

        // Size Variables
        int bottomBoundary;
        int centerPoint;
        int midXPoint;
        int midYPoint;

        // Declaration Variables
        bool playerDetectedUp;
        bool playerDetectedDown;

        // Special Key Variables
        int spaceBarPressed = 0;

        public Form1()
        {
            InitializeComponent();
            bottomBoundary = ClientSize.Height - Player.Height;
            midXPoint = ClientSize.Width / 2;
            midYPoint = ClientSize.Width / 2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot  = newBallSpot.Next(100, ClientSize.Height - 1);

            // This is for adjusting where the ball is
            PongBall.Top -= ballYPosition;
            PongBall.Left -= ballXPosition;

            // For making the CPU Player move
            CPU.Top += CPUDirection;

            // This is to check if the CPU player have reached the top or bottom
            if (CPU.Top < 0 || CPU.Top > bottomBoundary) 
            { 
               CPUDirection = -CPUDirection; 
            }

            // This is to check if the ball has exited the left side of the screen
            if (PongBall.Left < 0)
            {
                PongBall.Left = midXPoint;
                PongBall.Top = newSpot;
                ballXPosition = -ballXPosition;
                CPUScore++;
                CPUScoreLabel.Text = CPUScore.ToString();
            }

            // This is to check if the ball has exited the right side of the screen
            if (PongBall.Left + PongBall.Width > ClientSize.Width)
            {
                PongBall.Left = midXPoint;
                PongBall.Top = newSpot;
                ballXPosition = -ballXPosition;
                playerScore++;
                playerScoreLabel.Text = playerScore.ToString();
            }

            // To make sure the ball is within the boundaries of the screen
            if (PongBall.Top < 0 || PongBall.Top + PongBall.Height > ClientSize.Height) 
            { 
                ballYPosition = -ballYPosition;
            }

            // This is to check if the ball hits either the player or CPU paddle
            if (PongBall.Bounds.IntersectsWith(Player.Bounds) || PongBall.Bounds.IntersectsWith(CPU.Bounds))
            {
                // To send the ball opposite direction
                ballXPosition = -ballXPosition;
            }

            // Move the player up
            if (playerDetectedUp == true && Player.Top > 0)
            {
                Player.Top -= 10;
            }

            // Move the player down
            if (playerDetectedDown == true && Player.Top < bottomBoundary)
            {
                Player.Top += 10;
            }

            // To check for the winner
            if (playerScore >= 10)
            {
                GameTimer.Stop();
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // If player has pressed the up key, then the paddle will move upwards
            if (e.KeyCode == Keys.Up)
            {
                playerDetectedUp = false;
            }

            // If player has pressed the down key, then the paddle will move downwards
            if (e.KeyCode == Keys.Down)
            {
                playerDetectedDown = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // If player has pressed the up key, then the paddle will move upwards
            if (e.KeyCode == Keys.Up)
            {
                playerDetectedUp = true;
            }

            // If player has pressed the down key, then the paddle will move downwards
            if (e.KeyCode == Keys.Down)
            {
                playerDetectedDown = true;
            }

            // If player presses the space key, then this will pause the game
            if (e.KeyCode == Keys.Space)
            {
                if (spaceBarPressed % 2 == 0)
                {
                    GameTimer.Stop();
                }
                else
                {
                    GameTimer.Start();
                }

                spaceBarPressed++;
            }
        }
    }
}
