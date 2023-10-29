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

        private void bntCalc_Click(object sender, EventArgs e)
        {
            int counter = 0;
            double sum = 0;
            double summand = 0.0;
            double x;
            double precision;

            bool f = false;

            if (double.TryParse(txtPrecision.Text, out precision)) // Если получается вытащить precision
            {
                f = true;
            }

            do
            {
                counter++;
                if (double.TryParse(txtX.Text, out x)) // Если получается вытащить х
                {
                    summand = double.Parse(txtX.Text) / counter; // то делаем вычисления
                }
                sum += summand;
            } while (f && Math.Abs(summand) > precision); // Проверяем f.
                                                          // Если true и слагаемое больше приращения,
                                                          // можем продолжить выполнение тела цикла

            if (f)
            {
                lblResult.Text = "Сумма = " + sum + ", количество = " + counter; // Меняет метку
            }
            else
            {
                MessageBox.Show("Введите числовое значение!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }
    }
}
