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
            // Получаем значения из текстовых полей и преобразуем их в тип double
            double Xmin = double.Parse(txtMin.Text);
            double Xmax = double.Parse(txtMax.Text);
            double Step = double.Parse(txtStep.Text);
            double b = double.Parse(txtB.Text);

            // Вычисляем количество точек, которые будут отображены на графике
            int count = (int)Math.Ceiling((Xmax - Xmin) / Step)
                + 1;

            // Создаем массивы для хранения значений x
            double[] x = new double[count];
            // Создаем массивы для хранения значений y1 и y2
            double[] y1 = new double[count];
            double[] y2 = new double[count];

            // Заполняем массивы значениями в соответствии с формулами
            for (int i = 0; i < count; i++)
            {
                x[i] = Xmin + Step * i;

                // Вычисляем значения для y1 и y2 на основе заданных формул
                y1[i] = 9 * (Math.Pow(x[i], 3) + Math.Pow(b, 3)) * Math.Tan(x[i]);
                y2[i] = Math.Sin(x[i]);
            }
            // Настройка осей и интервалов на графике
            chart1.ChartAreas[0].AxisX.Minimum = Xmin;
            chart1.ChartAreas[0].AxisX.Maximum = Xmax;

            // Определаем шаг сетки
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

            // Добавляем вычисленные значения в графики
            chart1.Series[0].Points.DataBindXY(x, y1);
            chart1.Series[1].Points.DataBindXY(x, y2);
        }
    }

    
}
