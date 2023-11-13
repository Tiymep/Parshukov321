using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Метод для подсчета символов, принимает два аргумента:
        строку и символ, и возвращает количество символов в строке */
        private int NumberSymbols(string stroka, char symbol)
        {
            // Переменная которая хранит кол-во символов
            int k = 0;
            // Затем переходит при помощи цикла по каждому символу в строке
             for (int i = 0; i < stroka.Length; i++)
             {
                // Если строка равна символу значение увеличивается на 1
                 if (stroka[i] == symbol)
                 {
                     k += 1;
                 }
             }
             // Возврат цикла
             return k;
        }

        /* Метод для подсчета символов, принимает один аргумент - строку, 
           и возвращает количество подстрок "ма" в строке */
        private int NumberMA(string stroka)
         {
            // Переменная которая хранит кол-во символов
            int ma = 0;
            // Затем переходит при помощи цикла по каждому символу в строке
            for (int i = 0; i < txtString.Text.Length - 1; i++)
             {
                // Если в строке символ равен М и А значение ma увеличивается на 1
                if (txtString.Text[i] == 'м' && txtString.Text[i + 1] == 'а')
                 {
                     ma++;
                 }
             }
             return ma;
         }

        private void scet1_Click(object sender, EventArgs e)
        {
            string inputText = textBox3.Text;

            /* Если введено "а", вызывается метод NumberSymbols 
               для подсчета количества символов 'а' в строке txtString.Text*/
            if (inputText == "а")
            {
                // и результат выводится в элемент TextBox txtKolvo
                txtKolvo.Text = NumberSymbols(txtString.Text, 'а').ToString();
            }
            /* Если введено "ма", вызывается метод NumberMA 
               для подсчета количества подстрок "ма" в строке txtString.Text */
            else if (inputText == "ма")
            {
                // и результат выводится в элемент TextBox txtKolvo
                txtKolvo.Text = NumberMA(txtString.Text).ToString();
            }
            // Если введено "Форма 2", создается и отображается Form2 текущая форма скрывается 
            else if (inputText == "Форма 2")
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            else
            {
                // Если введены не те значения, то выводится сообщение
                MessageBox.Show("Других вариков быть не может!", "Прошу покинуть кабинет!");
                return;
            }
        }
    }
}

    