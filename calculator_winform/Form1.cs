using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_winform
{
    public partial class Form1 : Form
    {
        public int currentLabel = 1;
        public int operation = 0;
        public double num1 = 0;
        public double num2 = 0;
        public double result = 0;
        public string s1 = "";
        public string s2 = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            currentLabel = 1;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            currentLabel = 3;
        }



        private void Add_Click(object sender, EventArgs e)
        {
            label2.Text = "+";
            operation = 1;
            currentLabel = 3;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            label2.Text = "-";
            operation = 2; 
            currentLabel = 3;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            label2.Text = "*";
            operation = 3;
            currentLabel = 3;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            label2.Text = "/";
            operation = 4;
            currentLabel = 3;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (currentLabel == 1)
            {
                s1 += "1";
                label1.Text = s1;
            }
            else
            {
                s2 += "1";
                label3.Text = s2;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (currentLabel == 1)
            {
                s1 += "2";
                label1.Text = s1;
            }
            else
            {
                s2 += "2";
                label3.Text = s2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (currentLabel == 1)
            {
                s1 += "3";
                label1.Text = s1;
            }
            else
            {
                s2 += "3";
                label3.Text = s2;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (currentLabel == 1)
            {
                s1 += "4";
                label1.Text = s1;
            }
            else
            {
                s2 += "4";
                label3.Text = s2;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (currentLabel == 1)
            {
                s1 += "5";
                label1.Text = s1;
            }
            else
            {
                s2 += "5";
                label3.Text = s2;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (currentLabel == 1)
            {
                s1 += "6";
                label1.Text = s1;
            }
            else
            {
                s2 += "6";
                label3.Text = s2;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (currentLabel == 1)
            {
                s1 += "7";
                label1.Text = s1;
            }
            else
            {
                s2 += "7";
                label3.Text = s2;
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (currentLabel == 1)
            {
                s1 += "8";
                label1.Text = s1;
            }
            else
            {
                s2 += "8";
                label3.Text = s2;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (currentLabel == 1)
            {
                s1 += "9";
                label1.Text = s1;
            }
            else
            {
                s2 += "9";
                label3.Text = s2;
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (currentLabel == 1)
            {
                s1 += "0";
                label1.Text = s1;
            }
            else
            {
                s2 += "0";
                label3.Text = s2;
            }
        }
        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (currentLabel == 1)
            {
                s1 += ".";
                label1.Text = s1;
            }
            else
            {
                s2 += ".";
                label3.Text = s2;
            }
        }
        private void equal_Click(object sender, EventArgs e) 
        {
            if(s1 != "" && s2 != "")
            {
                try 
                {
                    num1 = Double.Parse(s1);
                    num2 = Double.Parse(s2); 
                }
                catch (Exception exception)
                {
                    label4.Text = "Invalid input";
                    return;
                }
                
                if (operation == 1)
                    label4.Text = "= " + (num1 + num2).ToString();
                else if (operation == 2)
                    label4.Text = "= " + (num1 - num2).ToString();
                else if (operation == 3)
                    label4.Text = "= " + (num1 * num2).ToString();
                else if (operation == 4)
                {
                    if (num2 == 0)
                        label4.Text = "Error";
                    else label4.Text = "= " + (num1 / num2).ToString();
                }
            }
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (currentLabel == 1 && s1.Length > 0)
            {
                s1 = s1.Substring(0, s1.Length - 1);
                label1.Text = s1;
            }
            else if (currentLabel == 3 && s2.Length > 0)
            {
                s2 = s2.Substring(0, s2.Length - 1);
                label3.Text = s2;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            s1 = "";
            s2 = "";
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            operation = 1;
            currentLabel = 1;
        }
    }
}
