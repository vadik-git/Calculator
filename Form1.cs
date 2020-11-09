using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Калькулятор : Form
    {
        public Калькулятор()
        {
            InitializeComponent();
        }
        float a, b;
        int operation = 0;
        bool plusMinus = true;
        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void buttonTochka_Click(object sender, EventArgs e)
        {
            if(!textBox1.Text.Contains('.'))
            textBox1.Text = textBox1.Text + ".";
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            
            if (plusMinus == true)
            {
                textBox1.Text = "-" + textBox1.Text;
                plusMinus = false;
            }
            else if (plusMinus == false)
            {
                textBox1.Text = textBox1.Text.Replace("-", "");
                plusMinus = true;
            }
        }
        private void calc()
        {
            switch (operation)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 5:
                    double c = Convert.ToDouble(a);
                    double s = Math.Sin(c);
                    textBox1.Text = s.ToString();
                    break;
            }


        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            calc();
            label1.Text = "";
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 2;
            label1.Text = a.ToString() + "-";
            plusMinus = true;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 3;
            label1.Text = a.ToString() + "*";
            plusMinus = true;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 4;
            label1.Text = a.ToString() + "/";
            plusMinus = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void Калькулятор_Load(object sender, EventArgs e)
        {
            this.Text = "Калькулятор";
        }

        private void buttonCLE_Click(object sender, EventArgs e)
        {
            int length = textBox1.TextLength - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for(int i = 0; i < length; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 5;
            plusMinus = true;

        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            operation = 1;
            label1.Text = a.ToString() + "+";
            plusMinus = true;

        }
    }
}
