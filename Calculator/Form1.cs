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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        Mathlib kniznica = new Mathlib();

        public static class Globals
        {
            public static char operand;
            public static bool negativeNumber = false;
            public static bool operandset = false;
            public static float baseNumber = 0;
            public static float secondNumber = 0;
        }
       

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((Globals.operand == '\0'))
            { 
                if (!(String.IsNullOrEmpty(textBox1.Text)))
                {
                    Globals.baseNumber = float.Parse(textBox1.Text);
                }
            }
            if (!(Globals.operand == '\0'))
            {

                if (!(String.IsNullOrEmpty(textBox1.Text)))
                {
                    Globals.secondNumber = float.Parse(textBox1.Text);
                }
            }
        }

        private void Form1_Press(object sender, KeyPressEventArgs e)
        {
            if (!(ActiveControl.GetType() == typeof(TextBox)))
            {
                textBox1.Text += e.KeyChar;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.Focus();
            }
            if(e.KeyChar != (Char)Keys.Enter)
            {
                label_operations.Text += " " + e.KeyChar;
            }
 

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Globals.operandset)
            {
                Globals.operandset = false;
                textBox1.Clear();
            }
           
            
            int key = e.KeyValue;

            if (key == 107)
            {
                Globals.operand = '+';
                Globals.operandset = true;
            }
            if (key == 109)
            {
                if (Globals.operandset)
                {
                    Globals.negativeNumber = true;
                } else {
                    Globals.operand = '-';
                    Globals.operandset = true;
                }
                
            }
            if (key == 106)
            {
                Globals.operand = '*';
                Globals.operandset = true;
            }
            if (key == 111)
            {
                Globals.operand = '/';
                Globals.operandset = true;
            }
            if (key == 70)
            {
                Globals.operand = 'f';
                Globals.operandset = true;
            }
            if (key == 77)
            {
                Globals.operand = 'm';
                Globals.operandset = true;
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (Globals.negativeNumber)
                {
                    Globals.secondNumber = Globals.secondNumber * -1;
                }
                float answer = 0;
                if (Globals.operand == '+')
                {
                    answer = kniznica.addition(Globals.baseNumber, Globals.secondNumber);
                    Globals.operand = '\0';
                    textBox1.Text = Convert.ToString(answer);
                }
                else if (Globals.operand == '-')
                {
                    answer = kniznica.subtraction(Globals.baseNumber, Globals.secondNumber);
                    Globals.operand = '\0';
                    textBox1.Text = Convert.ToString(answer);
                }
                else if (Globals.operand == '*')
                {
                    answer = kniznica.multiplication(Globals.baseNumber, Globals.secondNumber);
                    Globals.operand = '\0';
                    textBox1.Text = Convert.ToString(answer);
                }
                else if (Globals.operand == '/')
                {
                    answer = kniznica.divide(Globals.baseNumber, Globals.secondNumber);
                    Globals.operand = '\0';
                    textBox1.Text = Convert.ToString(answer);
                }
                else if (Globals.operand == 'f')
                {
                    answer = kniznica.factorial(Globals.baseNumber);
                    Globals.operand = '\0';
                    textBox1.Text = Convert.ToString(answer);
                }
                else if (Globals.operand == 'm')
                {
                    answer = kniznica.modulo(Globals.baseNumber, Globals.secondNumber);
                    Globals.operand = '\0';
                    textBox1.Text = Convert.ToString(answer);
                }

                Globals.operandset = true;
                Globals.negativeNumber = false;
                Globals.secondNumber = '\0';
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
