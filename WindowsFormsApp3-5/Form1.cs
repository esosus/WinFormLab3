using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double sum = a;
            int i = 1;
            double c = 1;
            while (i <= 12)
            {
                c = a * (double)(b / 100);
                sum += c;
                listBox1.Items.Add($"Сумма вклада на {i} месяц - {sum}");
                i++;
            }


        }
    }
}
