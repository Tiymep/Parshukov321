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
        }
        private int sec = 0;
        private int min = 0;
        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            sec++;

            // Если прошло 60 секунд, увеличиваем минуты и сбрасываем секунды
            if (sec == 60)
            {
                min++;
                sec = 0;
            }

            // Обновляем отображение на форме
            UpdateTimerDisplay();
        }

        private void UpdateTimerDisplay()
        {
            // Обновляем отображение минут и секунд на форме
            txtMinutes.Text = $"{min:D2}";
            txtSeconds.Text = $"{sec:D2}";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if (tmrSecundomer.Enabled)
            {
                tmrSecundomer.Stop();
                btnStart.Text = "Старт";
            }
            else
            {
               tmrSecundomer.Start();
                btnStart.Text = "Стоп";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab5 form1 = new Lab5();
            form1.Show();
            this.Hide();
        }
    }
}
