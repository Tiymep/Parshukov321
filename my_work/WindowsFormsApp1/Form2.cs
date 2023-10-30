using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Добавляем текст из txt в лист выше
            lst.Items.Add(txt.Text); 
            txt.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Путь к файлу
            string fileName = txtFileName.Text;
            if (File.Exists(fileName))
            {
                // Если файл существует - СНОСИМ К ****(фигам), ну или проусто удаляем
                File.Delete(fileName);
            }
            // Класс для работы с файлами
            using (FileStream fs = File.Create(fileName, 1024))
            // Класс для работы с данными файла в двоичном виде
            using (BinaryWriter bw = new BinaryWriter(fs))
            {
                // Пока не конец списка
                for (var i = 0; i < lst.Items.Count; i++) 
                {
                    // Записываем в файл каждый пункт
                    bw.Write(lst.Items[i].ToString()); 
                }
                bw.Close();
                fs.Close();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text;
            lstFromfile.Items.Clear();
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            using (BinaryReader br = new BinaryReader(fs))
            {
                /* ПиикЧар (как в дисней) возвращает следующий прочитанный символ,
                   если симолов нет - возвращается -1*/
                while (br.PeekChar() != -1)
                {
                    // А тут Ленин перевернулся, ведь мы добавляем в строку очередную прочитанную строку
                    lstFromfile.Items.Add(br.ReadString());
                }
                br.Close();
                fs.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /* Я бы пошутил, но уже не смешно, после ваших вопросов появляется депрессия... */
            Close();
        }
    }
}
