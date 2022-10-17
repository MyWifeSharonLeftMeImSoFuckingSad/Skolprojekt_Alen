using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Properties;

namespace WinFormsApp.library
{
    internal class krigare : PictureBox
    {
        public krigare()
        {
            this.BackgroundImage = Resources.elias_afen;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Width = 50;
            this.Height = 50;
            this.Top = 300;
            this.Left = 250;
        }

        
        public void Stopping()
        {
            if(this.Top == 0)
            {
                this.Top = +20;
            }
        }
   
    }
}
