using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Properties;

namespace WinFormsApp.library
{
    internal class laser: PictureBox
    {
        public laser()
        {
            this.BackgroundImage = Resources.laser;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Top = 150;
            this.Left = 150;
            this.Width = 25;
            this.Height = 17;
        }

    }
}
