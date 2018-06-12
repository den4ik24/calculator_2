using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (textBox1.Text == ",")
            {
                if(!textBox1.Text.Contains(","))
                    textBox1.Text += (sender as Button).Text;
            }
            else
            textBox1.Text += (sender as Button).Text;
        }

        double a = 0, b = 0, c = 0;

        

        char znak = '+';

       

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                znak = (sender as Button).Text[0];
                textBox1.Clear();
            }
            catch (Exception)
            {

            }
        }

       

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {


                b = Convert.ToDouble(textBox1.Text);
                switch (znak)
                {
                    case '+':
                        c = a + b;
                        break;
                    case '-':
                        c = a - b;
                        break;
                    case '*':
                        c = a * b;
                        break;
                    case '/':
                        c = a / b;
                        break;
                    case '^':
                        c = Math.Pow(a, b);
                        break;
                    case '√':
                        c = Math.Sqrt(a);//не пишет без второго числа
                        break;

                }
                textBox1.Text = c.ToString();
            }
            catch (Exception)
            {

            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button22_Click(object sender, EventArgs e)//знак
        {
            if (textBox1.Text != "")
                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                else textBox1.Text = '-' + textBox1.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
        }

    }
}
