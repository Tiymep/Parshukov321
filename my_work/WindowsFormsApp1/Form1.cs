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

        private int NumberSymbols(string stroka, char symbol)
        {
            int k = 0;
             for (int i = 0; i < stroka.Length; i++)
             {
                 if (stroka[i] == symbol)
                 {
                     k += 1;
                 }
             }
             return k;
        }

        

         private int NumberMA(string stroka)
         {
             int ma = 0;
             for (int i = 0; i < txtString.Text.Length - 1; i++)
             {
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

            if (inputText == "а")
            {
                txtKolvo.Text = NumberSymbols(txtString.Text, 'а').ToString();
            }
            else if (inputText == "ма")
            {
                txtKolvo.Text = NumberMA(txtString.Text).ToString();
            }
            else if (inputText == "Форма 2")
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Других вариков быть не может, иди погуляй!", "Прошу покинуть кабинет!");
                return;
            }
        }
    }
}

    