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
    public partial class Lab5 : Form
    {
        public Lab5()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            /* Получаем значения из текстовых полей txtX1, txtX2, txtY1, txtY2
             и преобразуем их в целочисленный тип */
            int fromX = int.Parse(txtX1.Text);
            int toX = int.Parse(txtX2.Text);
            int fromY = int.Parse(txtY1.Text);
            int toY = int.Parse(txtY2.Text);

            // Проверяем условие, если fromX больше toX
            if (fromX > toX)
            {
                // Выводим сообщение об ошибке
                MessageBox.Show("Интервал должен быть от меньшего к большему");
                // Очищаем текстовые поля txtX1 и txtX2
                txtX1.Text = "";
                txtX2.Text = "";
            }

            // Выполняем цикл от fromX до toX
            for (int x = fromX; x <= toX; x++)
            {
                // Проверяем условие, если fromY больше toY
                if (fromY > toY)
                {
                    // Выводим сообщение об ошибке
                    MessageBox.Show("Интервал должен быть от меньшего к большему");

                    // Очищаем текстовые поля txtY1 и txtY2
                    txtY1.Text = "";
                    txtY2.Text = "";
                }

                // Выполняем цикл от fromY до toY
                for (int y = fromY; y <= toY; y++)
                {
                    // Добавляем элемент в список listResult с использованием строкового форматирования
                    listResult.Items.Add($"z(x,y) = {x} - {y} = {x - y}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Переход с Какой-то математической штуки на Таймер
            Lab5_2 form2 = new Lab5_2();
            form2.Show();
            this.Hide();
        }
    }
}
