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

        private void Form1_Load(object sender, EventArgs e)
        {
            // Создаем события для диалоговых окон и задаем фильтр для формата .jpg
            file1.Filter = "(*.jpg)|*.jpg";
            fileSave.Filter = "(*.jpg)|*.jpg";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            // Создаем переменную строкового типа
            string fname;
            // Открываем проводник
            file1.ShowDialog();
            // Используем переменную для хранения именни выбранного файла
            fname = file1.FileName;
            //  Загружаем файл в box
            pct.Image = Image.FromFile(fname);
            // Выводим переменную в текстовое окно
            lblName.Text = fname;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Открываем проводник
            fileSave.ShowDialog();
            // Сохраняем изображение 
            pct.Image.Save(fileSave.FileName); 
        }

        private void forma2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}
