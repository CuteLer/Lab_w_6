using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int oo (string text)
        {
            int count = 0;
            foreach (char c in text)
            {
                if (c >= 'а' && c <= 'я')
                    count++;
            }
            return count;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text += "В строке '" + textBox1.Text +"'" + Environment.NewLine + "Число строчных русских букв: " + oo(textBox1.Text) + Environment.NewLine;
            textBox1.Clear();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
