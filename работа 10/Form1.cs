using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//граффик акций Wall Street 1901 года
namespace LP10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Point[] points = new Point[500];
        Pen pen = new Pen(Color.Black, 2);
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 500; i++)
            {
                int xPos;
                if (i % 10 == 0)
                {
                    xPos = 10;
                }
                else
                {
                    xPos = 500;
                }
                points[i] = new Point(xPos, 100 * i);
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
                Graphics g = e.Graphics;
                g.Clear(Color.White);
            for (int i = 0; i < 1; i++)
            {
                g.DrawLine(new Pen(Brushes.Black, 1),
                10, 4 * i - 20, 200, 4 * i + 20);
                g.DrawLines(pen, points);
            }
        }
    }
}
