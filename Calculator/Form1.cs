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

        public static class Globals
        {
            public static char operand;
            public static float baseNumber = 0;
            public static float secondNumber = 0;
        }
        private float add(float first, float second)
        {
            float result;
            result = first + second;
            return result;
        }

        private float subtract(float first, float second)
        {
            float result;
            result = first - second;
            return result;
        }

        private float multiply(float first, float second)
        {
            float result;
            result = first * second;
            return result;
        }

        private float divide(float first, float second)
        {
            float result;
            result = first / second;
            return result;
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((Globals.operand == '\0'))
            { 
                if (!(String.IsNullOrEmpty(textBox1.Text))) {
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void button_n0_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Press(object sender, KeyPressEventArgs e)
        {
            if (!(ActiveControl.GetType() == typeof(TextBox)))
            {
                textBox1.Text += e.KeyChar;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.Focus();
            }
                
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int key = e.KeyValue;
            if(e.KeyCode == Keys.D0)
            {
               // MessageBox.Show("0 pressed");
            }

            if (key == 107)
            {
                Globals.operand = '+';
                textBox1.Clear();
            }
            if (key == 109)
            {
                Globals.operand = '-';
                textBox1.Clear();
            }
            if (key == 106)
            {
                Globals.operand = '*';
                textBox1.Clear();
            }
            if (key == 111)
            {
                
                Globals.operand = '/';
                textBox1.Clear();
            }
            if (e.KeyCode == Keys.Enter)
            {
                float answer = 0;
                if (Globals.operand == '+')
                {
                    answer = add(Globals.baseNumber, Globals.secondNumber);
                    Globals.operand = '\0';
                    textBox1.Text = Convert.ToString(answer);
                }
                else if (Globals.operand == '-')
                {
                    answer = subtract(Globals.baseNumber, Globals.secondNumber);
                    Globals.operand = '\0';
                    textBox1.Text = Convert.ToString(answer);
                }
                else if (Globals.operand == '*')
                {
                    answer = multiply(Globals.baseNumber, Globals.secondNumber);
                    Globals.operand = '\0';
                    textBox1.Text = Convert.ToString(answer);
                }
                else if (Globals.operand == '/')
                {

                    answer = divide(Globals.baseNumber, Globals.secondNumber);
                    Globals.operand = '\0';
                    textBox1.Name = Convert.ToString(answer);
                    
                }


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
