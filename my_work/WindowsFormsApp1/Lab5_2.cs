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
    public partial class Lab5_2 : Form
    {
        public Lab5_2()
        {
            InitializeComponent();
            Data.Start();
        }

        // Задаю переменные для ячеек таймера
        private int sec = 0;
        private int min = 0;
        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            // Увеличение переменной "Секунды" на 1
            sec += 1;
            // Отображение переменной в ячейке для секунд
            txtSeconds.Text = sec.ToString();

            // Если прошло 59 секунд, увеличиваем переменную минуты и сбрасываем секунды
            if (sec == 59)
            {
                sec = 0;
                min++;
                // Отображение переменной в ячейке для минут
                txtMinutes.Text = min.ToString();
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {

            if (tmrSecundomer.Enabled)
            {
                //  Если выключен, то текст кнопки меняется на "Старт"
                tmrSecundomer.Stop();
                btnStart.Text = "Старт";
            }
            else
            {
                // Если включен, то текст на кнопке меняется на "Стоп"
                tmrSecundomer.Start();
                btnStart.Text = "Стоп";
            }

        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            // Переход с Таймера на Какую-то математическую штуку
            Lab5 form1 = new Lab5();
            form1.Show();
            this.Hide();
        }

        private void Data_Tick(object sender, EventArgs e)
        {
            // Отображение текущей даты в поле Дата
            txtData.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            // остановка таймера и присвоение полям Секунды и Минуты число 0
            tmrSecundomer.Stop();
            txtSeconds.Text = "0";
            txtMinutes.Text = "0";
        }
    }
}
