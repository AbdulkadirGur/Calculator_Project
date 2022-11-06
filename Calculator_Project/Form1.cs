using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void tus(string x)
        {
            if (textBox2.Text == "0")
            {
                textBox2.Text = x;
            }
            else
            {
                textBox2.Text += x;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Button 1
            tus("1");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Button 2
            tus("2");
        }

        private void button4_Click(object sender, EventArgs e)
        {

            // Button 3
            tus("3");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Button 4
            tus("4");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Button 5
            tus("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Button 6
            tus("6");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            // Button 7
            tus("7");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Button 8
            tus("8");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            // Button 9
            tus("9");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // Button 0
            tus("0");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string a = textBox2.Text;
            if (a[0] == '-')
            {   // del the -
                string b = a.Substring(1);
                textBox2.Text = b;

            }
            else if (a[0] != '0')
            {  // add the -
                textBox2.Text = "-" + textBox2.Text;

            }
        }
    }
}
