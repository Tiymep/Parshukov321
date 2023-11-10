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
            // Вызов метода InitializeComponent(), который инициализирует компоненты формы
            InitializeComponent();
        }

        // Объявление и инициализация массива Arr размером 10
        private int[] Arr = new int[10];

        private void btnNewArr_Click(object sender, EventArgs e)
        {
            // Создание переменной n со значением 10
            int n = 10;
            /* Создание переменной a, которая получает значение, 
               введенное в текстовое поле txtMin, преобразованное в целое число */
            int a = int.Parse(txtMin.Text);
            /* Определение и инициализация переменной b, которая получает значение,
               введенное в текстовое поле txtMax, преобразованное в целое число */
            int b = int.Parse(txtMax.Text);
            /* Проверка условия if (a > b), если истина, 
               то выводится сообщение об ошибке с помощью MessageBox и метод возвращается */
            if (a > b)
            {
                MessageBox.Show("Ты дурак?? Нижняя граница должна быть меньше или равна Верхней границе.", "Неверные значения!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Создание переменной r класса Random для генерации случайных чисел.
            Random r = new Random();

            // Используется цикл for для заполнения массива Arr случайными числами в диапазоне от a до b.
            for (int i = 0; i < n; i++)
            {
                // Значение каждого элемента массива добавляется в текстовое поле lblArr.
                Arr[i] = r.Next(a, b);
                lblArr.Text += Arr[i];
                /* Если индекс i не равен n, то добавляется запятая
                   после каждого элемента массива в текстовое поле lblArr */
                if (i!=n) lblArr.Text += ", ";
            }
            // Активируется кнопка btnSort
            btnSort.Enabled = true;
            // Вызывается метод InsertionSort, передавая ему массив Arr в качестве аргумента
            InsertionSort(Arr);
        }

        // Выполняет сортировку массива методом вставки
        private void InsertionSort(int[] Arr)
        {
            // Используется цикл for для прохода по всем элементам массива Arr, начиная со второго элемента
            for (int i = 1; i < Arr.Length; i++)
            {
                int key = Arr[i];
                int j = i - 1;

                // Происходит цикл while, пока j >= 0 и значение Arr[j] больше значения key
                while (j >= 0 && Arr[j] > key)
                {
                    // Значение key присваивается Arr[j + 1]
                    Arr[j + 1] = Arr[j];
                    j--;
                }

                // Значение key присваивается Arr[j + 1]
                Arr[j + 1] = key;
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            /* Значение массива Arr преобразуется в строку с помощью метода string.Join
               и присваивается текстовому полю lblResult */
            lblResult.Text = string.Join(", ", Arr);
            // Кнопка btnSort становится неактивной
            btnSort.Enabled = false;
            
        }

        // Очищает текстовые поля lblArr и lblResult и делает кнопку btnSort неактивной
        private void ClearFields()
        {
            lblArr.Text = "";
            lblResult.Text = "";
            btnSort.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Думал, почему не работает??? А кто с... Поставит "Точка" между this & close()
            this.Close();
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            // Вызов метода отчистки
            ClearFields();
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {
            // Вызов метода отчистки
            ClearFields();
        }

        private void txtMax_TextChanged(object sender, EventArgs e)
        {
            // Вызов метода отчистки
            ClearFields();
        }
    }
}
