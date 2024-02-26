using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            listBox1.Items.Clear();
            int n = Convert.ToInt32(textBox1.Text);
            int pol = 0;
            int otr = 0;
            int zer = 0;
            for (int i = 0; i < n; i++)
            {
                int a = rand.Next(-50, 50);
                listBox1.Items.Add(a);
                if (a == 0) zer++;
                if (a > 0) pol++;
                if (a < 0) otr++;
            }

            label2.Text = "Положительных чисел " + pol.ToString() + "\nОтрицательныйх чисел " + otr.ToString() + "\nКоличество чисел, раных нулю " + zer.ToString();
        }
    }
}
