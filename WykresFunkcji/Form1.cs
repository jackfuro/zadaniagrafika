using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WykresFunkcji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Paint += MainForm_Paint;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void MainForm_Paint(object sender, PaintEventArgs e)
        {

            int width = ClientSize.Width;//pobranie rozmiaru okna
            int height = ClientSize.Height;
            int padding = 40;
            int axisWidth = width - 2 * padding;
            int axisHeight = height - 2 * padding;

            Bitmap bitmap = new Bitmap(width, height);
            Graphics graphics = Graphics.FromImage(bitmap);


            graphics.DrawLine(Pens.Black, padding, padding + axisHeight / 2, padding + axisWidth, padding + axisHeight / 2);
            graphics.DrawLine(Pens.Black, padding + axisWidth / 2, padding, padding + axisWidth / 2, padding + axisHeight);


            int a = 1;
            int b = 1;
            int c = -1;
            float xScale = axisWidth / 20.0f;
            float yScale = axisHeight / 20.0f;

            PointF[] points = new PointF[axisWidth];
            for (int i = 0; i < axisWidth; i++)
            {
                float x = (i - axisWidth / 2) / xScale;
                float y = a * x * x + b * x + c;
                points[i] = new PointF(padding + i, padding + axisHeight / 2 - y * yScale);
            }

            graphics.DrawLines(Pens.Blue, points);


            e.Graphics.DrawImage(bitmap, 0, 0);
        }

    }
}
