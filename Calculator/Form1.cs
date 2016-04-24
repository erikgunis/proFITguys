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
        //Mathlib kniznica = new Mathlib();

        public static class Globals
        {
            public static char operand;
            public static bool negativeNumber = false;
            public static bool potentialNegative = false;
            public static bool operandset = false;
            public static bool enterPressed = false;
            public static float baseNumber = 0;
            public static float secondNumber = 0;
            public static float intNumber = '\0';
            public static bool labelFirstNumber = false;
            public static bool resultSet = false;

        }
        public void addCharToTextbox(char a)
        {
            
            if (Globals.operandset)//clear textbox to insert second number
            {
                Globals.enterPressed = false;
                Globals.potentialNegative = true;
                Globals.operandset = false;
                textBox1.Clear();
                if (Globals.resultSet && !Globals.enterPressed)
                {
                    Globals.baseNumber = '\0';
                    setDefaults();
                }
            }
            if (a != 'k')//If input is a button
            {
                if (a == '.' && textBox1.Text.IndexOf('.') > -1)
                {
                    return;
                }
                else
                {
                    textBox1.Text += a;
                    textBox1.SelectionStart = textBox1.Text.Length;
                    textBox1.Focus();
                }
            }
            
        }
        public void clearFunction()
        {
            setDefaults();
            textBox1.Clear();
            Globals.baseNumber = 0;
            Globals.secondNumber = 0;
            Globals.intNumber = 0;
            label_operations.Text = "\0";
        }
        public void equalsFunction()
        {
            float answer = 0;
            if (Globals.negativeNumber)
            {
                if (!Globals.enterPressed)
                    Globals.secondNumber = Globals.secondNumber * -1;
            }
            if (Globals.operand == '+')
            {
                answer = Mathlib.addition(Globals.baseNumber, Globals.secondNumber);
            }
            else if (Globals.operand == '-')
            {
                answer = Mathlib.subtraction(Globals.baseNumber, Globals.secondNumber);
            }
            else if (Globals.operand == '*')
            {
                answer = Mathlib.multiplication(Globals.baseNumber, Globals.secondNumber);
            }
            else if (Globals.operand == '/')
            {
                answer = Mathlib.divide(Globals.baseNumber, Globals.secondNumber);
            }
            else if (Globals.operand == 'f')
            {
                answer = Mathlib.factorial(Globals.baseNumber);
                Globals.operand = '!';
            }
            else if (Globals.operand == 'm')
            {
                answer = Mathlib.modulo(Globals.baseNumber, Globals.secondNumber);
            }
            else if (Globals.operand == 'e')
            {
                answer = Mathlib.exponent(Globals.baseNumber, Globals.secondNumber);
            }


            Globals.operandset = true;

            Globals.potentialNegative = false;
            label_operations.Text = Convert.ToString(Globals.baseNumber) + ' ' + Convert.ToString(Globals.operand) + ' ' + Convert.ToString(Globals.secondNumber) + " =" + Convert.ToString(answer);
            Globals.baseNumber = answer;
            Globals.resultSet = true;
            Globals.enterPressed = true;
            textBox1.Text = Convert.ToString(Globals.baseNumber);
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.Focus();
        }
        public void setOperator(char op)
        {
            setThings();
            Globals.operand = op;
        }
        public void setThings()
        {
            setDefaults();
            Globals.operandset = true;
            Globals.potentialNegative = true;
            
        }
        public void setDefaults()
        {
            Globals.resultSet = false;
            Globals.operandset = false;
            Globals.operand = '\0';
            Globals.negativeNumber = false;
            Globals.potentialNegative = false;
            Globals.secondNumber = '\0';
            Globals.enterPressed = false;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Globals.resultSet && !Globals.enterPressed)
            {
                Globals.baseNumber = '\0';
                setDefaults();
            }
            if ((Globals.operand == '\0'))
            {
                if (!(String.IsNullOrEmpty(textBox1.Text)))
                {
                    Globals.baseNumber = float.Parse(textBox1.Text);
                }
            }
            if (!(Globals.operand == '\0'))
            {
                if (!(string.IsNullOrEmpty(textBox1.Text)) && (!Globals.enterPressed))
                {
                    Globals.secondNumber = float.Parse(textBox1.Text);
                   
                }
            }
        }

        private void Form1_Press(object sender, KeyPressEventArgs e)
        {
            if (!(ActiveControl.GetType() == typeof(TextBox)))
            {
               addCharToTextbox(e.KeyChar);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {//https://msdn.microsoft.com/en-us/library/aa243025(v=vs.60).aspx

            if (Globals.operandset && (e.KeyValue >= 48 && e.KeyValue <= 57))
            {
                addCharToTextbox('k');
            }
           
            
            int key = e.KeyValue;
            if ( key == 67 )
            {//C = clear
                clearFunction();
            }
            if (key == 107)
            {
                setOperator('+');
            }
            if (key == 109)
            {
                if (Globals.potentialNegative)
                {
                    Globals.potentialNegative = false;
                    Globals.negativeNumber = true;
                } else {
                    setOperator('-');
                }
            }
            if (key == 106)
            {
                setOperator('*');
            }
            if (key == 111)
            {
                setOperator('/');
            }
            if (key == 70)
            {
                setOperator('f');
            }
            if (key == 77)
            {
                setOperator('m');
            }
            if (key == 69)
            {
                setOperator('e');
                textBox1.Clear();
            }
            
            if (key == 13) {//enter pressed
                equalsFunction();
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

    

        

        private void button_n0_Click(object sender, EventArgs e)
        {
            addCharToTextbox('0');
        }

        private void button_n1_Click(object sender, EventArgs e)
        {
            addCharToTextbox('1');
        }

        private void button_n2_Click(object sender, EventArgs e)
        {
            addCharToTextbox('2');
        }

        private void button_n3_Click(object sender, EventArgs e)
        {
            addCharToTextbox('3');
        }

        private void button_n4_Click(object sender, EventArgs e)
        {
            addCharToTextbox('4');
        }

        private void button_n5_Click(object sender, EventArgs e)
        {
            addCharToTextbox('5');
        }

        private void button_n6_Click(object sender, EventArgs e)
        {
            addCharToTextbox('6');
        }
        private void button_n7_Click(object sender, EventArgs e)
        {
            addCharToTextbox('7');
        }

        private void button_n8_Click(object sender, EventArgs e)
        {
            addCharToTextbox('8');    
        }

        private void button_n9_Click(object sender, EventArgs e)
        {
            addCharToTextbox('9');
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            equalsFunction();
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            addCharToTextbox('.');
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            setOperator('+');
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (Globals.potentialNegative)
                {
                    Globals.potentialNegative = false;
                    Globals.negativeNumber = true;
                } else {
                    setOperator('-');
                }
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            setOperator('*');
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            setOperator('/');
        }

        private void button_modulo_Click(object sender, EventArgs e)
        {
            setOperator('m');
        }

        private void button_exp_Click(object sender, EventArgs e)
        {
            setOperator('e');
            textBox1.Clear();
        }

        private void button_fact_Click(object sender, EventArgs e)
        {
            setOperator('f');
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            clearFunction();
        }
    }
}
