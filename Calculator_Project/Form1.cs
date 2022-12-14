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
        string ekran = "0";
        double sonuc = 0;
        string opx = "";
        public Form1()
        {
            InitializeComponent();
        }
        public void tus(string x)
        {
            if (ekran == "0")
            {
               ekran = x;
            }
            else
            {
                ekran += x;
            }
            textBox2.Text = ekran;
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
            // ','
            //, tuşu            
            //ifade içinde , karakteri yoksa
            string x =ekran;
            int flag = x.IndexOf(',');
            if (flag == -1)
            {
                ekran += ',';
            }
            textBox2.Text = ekran;
        }

        private void button12_Click(object sender, EventArgs e)
        {   // '+/-'
            //soldan ilk karakter - ise, eksi silme
            string a = ekran;
            if (a[0] == '-')
            {   // del the -
                string b = a.Substring(1);
                ekran = b;
            }
            else if (a[0] != '0')
            {
                //soldan ilk karakter - değil ise, eksi ekleme
                // add the -
                ekran = "-" + ekran;

            }
            textBox2.Text = ekran;
        }

        private void button18_Click(object sender, EventArgs e)
        {   // C 

            textBox2.Text = "0";
            textBox1.Text = "";
            ekran = "0";
            sonuc = 0;
            opx = "";
            

        }

        private void islem(string op)
        {
            if(opx != "")
            {
                //Daha önce bir operatöre tıklanmış, bu 2.,3.,... ise
                //bir önceki işlemin sonucu 
                string s2 = ekran;

                if (opx == "+") sonuc = sonuc + Convert.ToDouble(s2);
                else if (opx == "-") sonuc = sonuc - Convert.ToDouble(s2);
                else if (opx == "*") sonuc = sonuc * Convert.ToDouble(s2);
                else if (opx == "/") sonuc = sonuc / Convert.ToDouble(s2);// 0 a bolme durumu 
                /// 0 a bölme durumu

                textBox2.Text=sonuc.ToString();               
            }
            else
            {
                //ilk defa operatöre tıklanıyorsa
                sonuc = Convert.ToDouble(ekran);
                  
            }
            //5+3--> sonuc=8,  t1=8, s2, ekran =3, opx="+"
            if (opx == "=")
            {
                textBox1.Clear();
               
            }
            else
            {
                textBox1.Text = textBox1.Text + " " + ekran + " " + op;
                opx = op;
                ekran = "0";
            }   

        }
        private void button13_Click(object sender, EventArgs e)
        {  // + op
            islem("+");
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // - op
            islem("-");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // * op
            islem("*");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // / op
            islem("/");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // = op
            islem("=");
        }
    }
}
