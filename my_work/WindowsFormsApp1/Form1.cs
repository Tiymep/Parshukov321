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

        private void showButton_Click(object sender, EventArgs e)
        {
            // Показываем диалог открытия. Если нажать "ОК" то выведет изображение
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            // Показываем диалог открытия выбора цвета. Если нажать "ОК" то сменится фон
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Отчистить форму
            pictureBox1.Image = null;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // Закрыть форму
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Расширяем изображение во все окно
            if (!checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode |= PictureBoxSizeMode.Normal;
        }
    }
}
