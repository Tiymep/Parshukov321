using System;
using System.Windows.Forms;

namespace ParshukovPR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
                lstNames.Items.Add(txtName.Text);
            Cursor.Position = PointToScreen(btnDel.Location);
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                MessageBox.Show($"From.KeyPress: '{e.KeyChar}' pressed");
                switch (e.KeyChar)
                {
                    case (char)49:
                    case (char)52:
                    case (char)55:
                        MessageBox.Show($"From.KeyPress: '{e.KeyChar}' consumed");
                        e.Handled = true;
                        break;
                }
            }
        }

       
        private void button1_Click_1(object sender, EventArgs e)
        {
            string selectedName = lstNames.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedName))
            {
                lstNames.Items.Remove(selectedName);
            }
            Cursor.Position = PointToScreen(btnAdd.Location);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void btnDel_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void btnDel_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

           }
}

   