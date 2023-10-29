using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        int timeLeft;
     
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " секунд";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("SERVER: \\82.112.52.137 Временно не доступен!",
                                   "ERROR CONNECTIONS");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            timeLeft = 15;
            timeLabel.Text = "15 секунд";
            timer1.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }    
}
