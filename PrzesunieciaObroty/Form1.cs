using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace PrzesunieciaObroty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool przesuwanie = false;
        private Point punkt;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            przesuwanie = true;
            punkt = e.Location;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            przesuwanie = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (przesuwanie) 
            {
                pictureBox1.Location = new Point(e.X + pictureBox1.Left - punkt.X,e.Y + pictureBox1.Top - punkt.Y);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bmp = pictureBox1.Image;
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var bmp = pictureBox1.Image;
            bmp.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Image = bmp;
        }

    }
}
