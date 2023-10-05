using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {
        // Код программной части создает случайный объект 
        Random randomizer = new Random();
        // Сложение
        int addend1;
        int addend2;
        // Вычитание
        int minuend;
        int subtrahend;
        // Умножение
        int multiplicand;
        int multiplier;
        // Деление
        int dividend;
        int divisor;
        // Время
        int timeLeft;

        // Этот метод использует метод объекта Random Next() для создания случайных чисел для меток
        public void StartTheQuiz()
        {
            // Сложение
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            // Конвертация для отображения
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            sum.Value = 0;
            // Вычитание
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;
            // Умножение
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;
            // Деление
            divisor = randomizer.Next(2, 11);
            int temporaryQuitent = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuitent;
            dividedLeftLabel.Text = dividend.ToString();
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;
            // Запуск таймера
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }

        // Метод определяет ответы на арифметические примеры
        // и сравнивает результаты со значениями в элементах управления NumericUpDown.
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        // Кнопка запуска
        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

       // Подведение итогов
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // Если true
                timer1.Stop();
                MessageBox.Show("Вы правильно ответили на все вопрсоы!", "Поздравляем!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft--;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // Если время вышло
                timer1.Stop();
                timeLabel.Text = "Время вышло!";
                MessageBox.Show("Вы не закончили вовремя.", "Извините!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
        }

        // Обработчик событий
        // Код будет выделять и удалять текущее значение в каждом элементе управления NumericUpDown,
        // как только игрок выберет элемент управления и начнет вводить другое значение
        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;
            if (answerBox != null)
            {
                int lenghtOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lenghtOfAnswer);
            }
        }

        private void timeLabel_Click_1(object sender, EventArgs e)
        {

        }
    }
}

