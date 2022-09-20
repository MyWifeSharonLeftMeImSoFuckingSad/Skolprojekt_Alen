using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class game : Form
    {
        System.Windows.Forms.Timer GameTimer { get; set; } = new System.Windows.Forms.Timer();

        int p1Points = 0;
        int p2Points = 0;

        string p1Name = "Player 1";
        string p2Name = "Player 2";

        int p1Xspeed = 0;
        int p1Yspeed = 0;

        int p2Xspeed = 0;
        int p2Yspeed = 0;

        int playerTurn = 1;

        public game()
        {
            InitializeComponent();
            GameTimer.Tick += new EventHandler(GameUpdate);

            GameTimer.Interval = 100;
            lblPlayer1.Text = p1Name;
            lblPlayer2.Text = p2Name;
            ResetGame();
        }

        private void ResetGame()
        {
            SetPlayerStartPosition();
            SetPlayerTurn();
            p1Points = 0;
            p2Points = 0;
            RandomBallPosition();
        }

        private void RandomBallPosition()
        {
            Random r = new Random();
            Ball.Left = r.Next(100, 800);
            Ball.Top = r.Next(100, 550);

        }

        private void SetPlayerTurn()
        {
            if (playerTurn == 1)
            {
                playerTurn = 2;
                lblPlayer1.ForeColor = System.Drawing.Color.White; ;
                lblPlayer2.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                playerTurn = 1;
                lblPlayer1.ForeColor = System.Drawing.Color.Red;
                lblPlayer1.ForeColor = System.Drawing.Color.White;
            }
        }

        private void SetPlayerStartPosition()
        {
            Player1.Left = 200;
            Player1.Top = 50;

            Player2.Left = 830;
            Player2,Top = 50;

            p1Xspeed = 0;
            p1Yspeed = 0;

            p2Xspeed = 0;
            p2Yspeed = 0;
        }

        private void GameUpdate(object sender, EventArgs e)
        {
            Player1.Top += p1Xspeed;
            Player1.Left += p1Yspeed;

            Player2.Top += p2Xspeed;
            Player2.Left += p2Yspeed;

            if (Player1.Bounds.IntersectsWith(Player2.Bounds))
            {
                SetPlayerTurn();
                SetPlayerStarPosition();
            }

            if (Player1.Bounds.IntersectsWith(Ball.Bounds))
            {
                if(playerTurn != 1)
                {
                    p1Points += 1
                }
                else
                {
                    p1Points -= 1;
                }
            }

            lblPlayer1Points.Text = p1Points.ToString();
            lblPlayer2Points.Text = p2Points.ToString();

        }
        private void game_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {

            }
        }

    }
}
