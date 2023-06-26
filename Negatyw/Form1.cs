using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negatyw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap ng = (Bitmap)pictureBox1.Image;
            int width = ng.Width;
            int height = ng.Height;

            //konwersja
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    //pobieranie koloru
                    Color p = ng.GetPixel(x, y);
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //wartosci negatywne
                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    //zmiana koloru
                    ng.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }

            //załadowanie
            pictureBox2.Image = ng;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/WPVA-khamsa.svg/170px-WPVA-khamsa.svg.png");
        }
    }

        
    }
