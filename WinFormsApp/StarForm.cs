﻿using System;
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
    public partial class StarForm : Form
    {
        public StarForm()
        {
            InitializeComponent();
        }

        private void momsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            moms moms = new moms();
            moms.MdiParent = this;
            moms.Show();
            moms.Focus();
        }

        private void StarForm_Load(object sender, EventArgs e)
        {

        }

        private void looparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loopar loopar = new loopar();
            loopar.MdiParent = this;
            loopar.Show();
            loopar.Focus();
        }
    }
}
