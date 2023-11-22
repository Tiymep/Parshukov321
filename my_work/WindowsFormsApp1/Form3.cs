using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Print(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Нарисовать корпус ракеты
            g.FillRectangle(Brushes.Gray, 100, 200, 100, 150);

            // Нарисовать конус ракеты
            Point[] trianglePoints =
            {
        new Point(100, 200),
        new Point(150, 150),
        new Point(200, 200)
    };
            g.FillPolygon(Brushes.Red, trianglePoints);

            // Нарисовать огни ракеты
            g.FillEllipse(Brushes.Orange, 100, 345, 15, 35);
            g.FillEllipse(Brushes.Orange, 140, 345, 15, 35);
            g.FillEllipse(Brushes.Orange, 180, 345, 15, 35);

            // Нарисовать двери ракеты
            g.FillRectangle(Brushes.Black, 135, 300, 30, 45);

            // Нарисовать иллюминаторы ракеты
            Pen blueEllipse = new Pen(Color.Blue, 15);
            g.DrawEllipse(blueEllipse, 140, 225, 15, 15);

            Pen blueEllipse1 = new Pen(Color.Blue, 15);
            g.DrawEllipse(blueEllipse, 140, 265, 15, 15);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }
    }
}
