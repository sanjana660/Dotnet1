using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorRadio
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        double result = 0;
        string op = "";
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            op = "+";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            op = "+";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            op = "-";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            op = "*";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            op = "/";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool num1ok = double.TryParse(textBox1.Text, out num1);
            bool num2ok = double.TryParse(textBox2.Text, out num2);
            if (num1ok && num2ok)
            {
                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        textBox3.Text = result.ToString();
                        break;
                    case "-":
                        result = num1 - num2;
                        textBox3.Text = result.ToString();
                        break;
                    case "*":
                        result = num1 * num2;
                        textBox3.Text = result.ToString();
                        break;
                    case "/":
                       
                            result = num1 / num2;
                            textBox3.Text = result.ToString("0.00");

                        break;
                }
            }
            else
            {
                MessageBox.Show("Data Invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
