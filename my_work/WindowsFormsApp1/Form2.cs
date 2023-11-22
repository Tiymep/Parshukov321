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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Print(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);
            Brush astronautBrush = new SolidBrush(Color.Gray);
            Brush helmetBrush = new SolidBrush(Color.LightGray);
            Brush visorBrush = new SolidBrush(Color.Black);

            // Тело космонавта
            g.FillEllipse(astronautBrush, 100, 100, 80, 130);

            // Голова космонавта
            g.FillEllipse(helmetBrush, 105, 50, 70, 70);
            g.FillEllipse(visorBrush, 115, 65, 50, 50);

            // Центральная ступня
            g.FillEllipse(astronautBrush, 100, 215, 80, 45);

            // Правая рука
            g.FillEllipse(astronautBrush, 75, 130, 30, 100);

            // Левая рука
             g.FillEllipse(astronautBrush, 175, 130, 30, 100);
         
            // Правая нога
            g.FillRectangle(astronautBrush, 95, 235, 35, 70);

            // Левая нога
            g.FillRectangle(astronautBrush, 150, 235, 35, 70);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }
    }
}
