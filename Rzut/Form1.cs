using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rzut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            g.DrawLine(Pens.Black, 10, 300, 300, 300);

            g.DrawLine(Pens.Black, 10, 300, 10, 10);
            for (int i = 0; i <= 3; i++)
            {
                g.DrawString(i.ToString(), Font, Brushes.Black, i * 96 + 10, 310);
                if (i != 0)
                {
                    g.DrawLine(Pens.Blue, i * 96 + 10, 300, i * 96 + 10, 10);
                }
                g.DrawString(i.ToString(), Font, Brushes.Black, 0, 290 - (i * 96));
                if (i != 3)
                {
                    g.DrawLine(Pens.Blue, 10, i * 96 + 10, 300, i * 96 + 10);
                }
            }
            g.DrawRectangle(Pens.Brown, 96, 96, 96, 96);
            g.DrawRectangle(Pens.Brown, 144, 50, 96, 96);
            g.DrawLine(Pens.Brown, 96, 96, 144, 50);
            g.DrawLine(Pens.Brown, 192, 96, 238,50);
            g.DrawLine(Pens.Brown, 96, 192, 144, 146);
            g.DrawLine(Pens.Brown, 192, 192, 238, 146);
        }
    }
}
