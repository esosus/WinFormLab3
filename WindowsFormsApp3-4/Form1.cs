using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp3_4
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
            if (n <= 6 && textBox1.Text != "")
            {
                listBox1.Items.Add(Convert.ToInt32(textBox1.Text));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = listBox1.Items.Count;
            for (int i = 0; i < n; i++)
            {
                if (Convert.ToInt32(listBox1.Items[i]) <= 125)
                {
                    listBox1.Items.Add($"Размер одежды {i + 1} гнома I");
                }
                else
                {
                    if (Convert.ToInt32(listBox1.Items[i]) <= 135)
                    {
                        listBox1.Items.Add($"Размер одежды {i + 1} гнома II");
                    }
                    else
                    {
                        listBox1.Items.Add($"Размер одежды {i + 1} гнома III");
                    }
                }

            }
        }
    }
}
        

