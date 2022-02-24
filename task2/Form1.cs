using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        double a, b, c;
        char d;

        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }

        public double Mut(double a, double b)
        {
            return a * b;
        }

        public double Div(double a, double b)
        {
            return a / b;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox2.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            d = Convert.ToChar(comboBox1.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (d)
            {
                case '+':
                    c = Add(a, b);
                    break;

                case '-':
                    c = Sub(a, b);
                    break;

                case '×':
                    c = Mut(a, b);
                    break;

                case '÷':
                    c = Div(a, b);
                    break;

                default:
                    break;
            }

            label6.Text = Convert.ToString(c);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
        }
    }
}
