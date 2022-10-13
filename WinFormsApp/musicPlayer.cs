using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class musicPlayer : Form
    {
        class Mp3Player
        {
            [DllImport("winmm.dll")]
            private static extern long mciSendString(string lpstrCommand, StringBuilder lpstrReturnString, int uReturnLength, int hwdCallBack);

            public void open(string File)
            {
                string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
                string command = string.Format(Format, File);
                mciSendString(command, null, 0, 0);
            }

            public void play()
            {
                string command = "play MediaFile";
                mciSendString(command, null, 0, 0);
            }
            public void stop()
            {
                string command = "stop MediaFile";
                mciSendString(command, null, 0, 0);
            }
        }

        private Mp3Player mp3Player = new Mp3Player();
        public musicPlayer()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnFiler_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Mp3 Files|*.mp3";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    mp3Player.open(ofd.FileName);
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            mp3Player.play();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            mp3Player.stop();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
