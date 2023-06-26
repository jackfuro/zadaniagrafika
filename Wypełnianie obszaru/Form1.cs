using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Wypełnianie_obszaru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)pictureBox1.Image;

            FillArea(25, 25, image);
        }
        private void FillArea(int x, int y, Bitmap image)
        {
            Color borderColor = image.GetPixel(0, 0);
            Color fillColor = Color.BlueViolet;

            if (x < 0 || x >= image.Width - 1 || y < 0 || y >= image.Height - 1)
            {
                return;
            }

            image.SetPixel(x, y, fillColor);
            //wykorzystanie funckji ToArgb() w celu ustawienia kolorów do tej samej wartosci, wczesniej wyskakiwały błędy
            if (image.GetPixel(x - 1, y).ToArgb() != borderColor.ToArgb() && image.GetPixel(x - 1, y).ToArgb() != fillColor.ToArgb())
            {
                FillArea(x - 1, y, image);
            }
            if (image.GetPixel(x + 1, y).ToArgb() != borderColor.ToArgb() && image.GetPixel(x + 1, y).ToArgb() != fillColor.ToArgb())
            {
                FillArea(x + 1, y, image);
            }
            if (image.GetPixel(x, y - 1).ToArgb() != borderColor.ToArgb() && image.GetPixel(x, y - 1).ToArgb() != fillColor.ToArgb())
            {
                FillArea(x, y - 1, image);
            }
            if (image.GetPixel(x, y + 1).ToArgb() != borderColor.ToArgb() && image.GetPixel(x, y + 1).ToArgb() != fillColor.ToArgb())
            {
                FillArea(x, y + 1, image);
            }

            pictureBox1.Image = image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)pictureBox2.Image;
            FillArea2(image);
        }
        private void FillArea2(Bitmap image) 
        {
            Color borderColor = image.GetPixel(36, 28);
            for(int i = 0; i < image.Width; i++) 
            {
                int z = 0;
                for(int j=0; j < image.Height; j++) 
                {
                    if (image.GetPixel(i,j)!= borderColor) 
                    {
                        z = 1;
                    }
                    else if(image.GetPixel(i, j) == borderColor && z==1) 
                    {
                        image.SetPixel(i, j, Color.Aqua);
                    }
                }
            }
            pictureBox2.Image = image;
        }
    }
}

