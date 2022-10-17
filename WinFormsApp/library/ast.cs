﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Properties;

namespace WinFormsApp.library
{
    internal class ast : PictureBox
    {
        public int Gravity = 5;
        public ast()
        {
            this.BackgroundImage = Resources.ast;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Top = 150;
            this.Left = 150;
            this.Width = 25;
            this.Height = 25;

        }

        public void Fall()
        {
            this.Top += Gravity;
            if(this.Top > 500)
            {
                this.Top = 0;
            }
        }
    }
}
