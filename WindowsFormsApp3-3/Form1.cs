using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;

            if (n <= 9 && textBox1.Text != "")
            {
                listBox1.Items.Add(Convert.ToInt32(textBox1.Text));
            }
            else
                MessageBox.Show("Добавлять числа нельзя, т.к. список уже содержит 10 чисел", "Ввод запрещен", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            textBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;
            if (n < 9)
            {
                MessageBox.Show("Проверить список нельзя, т.к. список содержит менее 10 чисел", "Введите недостающие числа", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
                for (int i = 0; i < n; i++)
                    if (Convert.ToInt32(listBox1.Items[i]) > 15)
                    {
                        listBox1.Items[i] = 15;

                    }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Введите число в текстовый блок", "Введите заменяемое число", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                listBox1.Items[listBox1.SelectedIndex] = Convert.ToInt32(textBox1.Text);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }
    }
}
