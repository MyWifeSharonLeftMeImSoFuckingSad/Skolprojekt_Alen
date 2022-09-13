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


        public game()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void game_Load(object sender, EventArgs e)
        {

        }

        private void game_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A)
            {

            }
        }
    }
}
