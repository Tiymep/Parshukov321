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
        // Переменная "Возврата"
        private bool pctMove = false; 
        private void tmr_Tick(object sender, EventArgs e)
        {// Правая сторона картинки не привышает  значение ширины окна
            if (pct.Right + 20 <= ClientSize.Width)
            {
                pct.Left += 20; 
            }
            else
            {
                // Ограничивание позиции
                pct.Left = ClientSize.Width - pct.Width;
                // Остановка таймера, когда достигнут правый край и переименновываем кнопку
                tmr.Enabled = false; 
                btnStart.Text = "Старт";
                pctMove = false; 
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (pctMove) 
            {
                // Выкл таймера
                tmr.Enabled = false; 
                pctMove = false; 
                btnStart.Text = "Старт"; 
            }
            else 
            {
                // Вкл таймера
                tmr.Enabled = true; 
                pctMove = true; 
                tmr.Interval = 50; 
                btnStart.Text = "Стоп"; 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            /* Самая сложная часть кода, думали всей компанией Microsoft, как же закрыть
             * это форму крутым образом, ничего кромена как нажать на "Крестик" на ум не приходило*/
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(); 
            f.Show();
            this.Hide();
        }
    }
}
