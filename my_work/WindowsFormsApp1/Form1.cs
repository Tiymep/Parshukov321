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

        private void scet1_Click(object sender, EventArgs e)
        {
            txtKolvo.Text = NumberSymbols(txtString.Text, 'а').ToString();
            txtKolvo.Text = NumberMA(txtString.Text).ToString();
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
    }
}

    