using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class loopar : Form
    {
        public loopar()
        {
            InitializeComponent();
        }

       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSlumpa_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int num_1 = int.Parse(textNum1.Text);
            int num_2 = int.Parse(textNum_2.Text);
            int num_slumpa = int.Parse(textSlumpa.Text);
            int[] test = new int[num_slumpa];


            for (int i = 0; i < num_slumpa; i++)
            {
                int newNum = r.Next(num_1, num_2+1);
                if (test.Contains(newNum))
                {
                    i--;
                }
                else
                {
                    test[i] = newNum;
                }
            }
            foreach (int i in test)
            {
                textBox1.Text += i + " ";
            }



        }

        private void textSlumpa_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
