using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.library;

namespace WinFormsApp
{
    public partial class starship : Form
    {
        List<ast> asts = new List<ast>();
        krigare k = new krigare();
        ast a = new ast();
        
        public starship()
        {
            InitializeComponent();
            Random r = new Random();
            for(int i = 0; i<10; i++)
            {
              
                this.Controls.Add(a);
                a.Top = 0;
                a.Left = r.Next(1, 801);
                a.Gravity = r.Next(7, 18);
                asts.Add(a);
            }

            this.Controls.Add(k);
            k.Top = 350;
            k.Left = 250;
            
            

        

        }

        private void starship_Load(object sender, EventArgs e)
        {

        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            foreach (ast a in asts)
            {
                a.Fall();
            }

           
            if (k.Bounds.IntersectsWith(a.Bounds))
            {
                Application.Exit();
            }

            Stopping();
        }

        private void starship_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W)
            {
                k.Top -= 20;
            }

            if(e.KeyCode == Keys.D)
            {
                k.Left += 20;
            }

            if(e.KeyCode == Keys.A)
            {
                k.Left -= 20;
            }

            if(e.KeyCode == Keys.S)
            {
                k.Top += 20;
            }

        }
    }
}
