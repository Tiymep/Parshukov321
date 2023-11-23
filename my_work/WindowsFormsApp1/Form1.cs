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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void Form1_Print(object sender, PaintEventArgs e)
        {
             Graphics g = e.Graphics;

            // Создание массива вершин треугольника
            Point[] vertices = new Point[3];
            vertices[0] = new Point(100, 100);
            vertices[1] = new Point(200, 100);
            vertices[2] = new Point(150, 120);

            // Рисование верхней грани
            g.DrawPolygon(Pens.Black, vertices);
            g.FillPolygon(Brushes.Red, vertices);

            // Создание массива вершин нижней грани треугольника
            Point[] bottomVertices = new Point[3];
            for (int i = 0; i < 3; i++)
            {
                bottomVertices[i] = new Point(vertices[i].X, vertices[i].Y + 100);
            }
            // Рисование нижней грани треугольника
            g.DrawPolygon(Pens.Black, bottomVertices);
            g.FillPolygon(Brushes.Red, bottomVertices);

            // Рисование боковых ребер
            for (int i = 0; i < 3; i++)
            {
                g.DrawLine(Pens.Black, vertices[i], bottomVertices[i]);


            }
            // Создание пера для рисования пунктирной линии и рисование линии с использованием этого пера
            Pen punktLine = new Pen(Color.Black, 2);
            punktLine.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            g.DrawLine(punktLine, 100, 200, 200, 200);
        }
    }
}
