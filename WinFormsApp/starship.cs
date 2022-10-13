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
        public starship()
        {
            InitializeComponent();
            Random r = new Random();
            for(int i = 0; i<12; i++)
            {
                ast a = new ast();
                a.Top = 0;
                a.Left = r.Next(1, 801);
                this.Controls.Add(a);
                a.Gravity = r.Next(7, 27);
                asts.Add(a);
            }

            this.Controls.Add(k);
            k.Top = 350;
            k.Left = 250;
            
            

        

        }

        private void starship_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (ast a in asts)
            {
                a.Fall();
            }
        }
    }
}
