using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// kalkulacka
/// </summary>
namespace Calculator
{
    /// <summary>
    /// deklarace kalkulacky
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// zakladni nastaveni kalkulacky
        /// </summary>

        public Form1()
        {
            InitializeComponent();
        }
        //Mathlib kniznica = new Mathlib();

        /// <summary>
        /// nastaveni promnenych
        /// </summary>
        public static class Globals
        {//global variables
            public static char operand;
            public static bool potentialNegative = false;
            public static bool operandset = false;
            public static double TextBoxNumber = 0;
            public static bool resultSet = false;
            public static string example;
        }
        /// <summary>
        /// instance tridy globs
        /// </summary>
        globs numops = new globs();//an instance of the globs class

        /// <summary>
        /// cela trida pro pole operandu a cisel
        /// </summary>
        public class globs
        {//Class for the whole example, creates list for numbers and operands
            /// <summary>
            /// pole cisel
            /// </summary>
            public List<double> numbers = new List<double>();
            /// <summary>
            /// pole operandu
            /// </summary>
            public List<char> operands = new List<char>();
            // double num;
            int sizeNum;
            int sizeOp;
            /// <summary>
            /// napsani cisla do pole
            /// </summary>
            /// <param name="a"> napsani prvniho cisla ze vstupu </param>
            public void addNum(double a)
            {
                numbers.Add(a);
            }
            /// <summary>
            /// získani hodnoty cisla ze vstupu a ulozeni
            /// </summary>
            ///
            /// <returns> hodnotra cisla ze vstupu </returns>
            public int getNumSize()
            {
                sizeNum = numbers.Count();
                return sizeNum;
            }
            /// <summary>
            /// pocet prvku v poli
            /// </summary>
            ///
            /// <param name="item"> pozice prvku v poli </param>
            ///
            /// <returns> hodnota prvku v poli na pozadovane pozici </returns>
            public double getNumItem(int item)

            {
                return numbers[item];
            }
            /// <summary>
            /// prevest cislo na pozadovane pozici vystupni hodnotu
            /// </summary>
            ///
            /// <param name="i"> pozadovana pozice cisla </param>
            /// <param name="value"> hodnota na pozadovane pozici </param>
            public void setValue(int i, double value)
            {
                numbers[i] = value;
            }
            /// <summary>
            /// pridani hodnoty operandu
            /// </summary>
            ///
            /// <param name="op"> hodnoa operandu </param>
            public void addOp(char op)
            {
                operands.Add(op);
            }
            /// <summary>
            /// ziskani hodnoty operandu
            /// </summary>
            ///
            /// <returns> hodnota operandu </returns>
            public int getOpSize()
            {
                sizeOp = operands.Count();
                return sizeOp;
            }
            /// <summary>
            /// vraceni pozadovaneho operandu s hodnotou item
            /// </summary>
            ///
            /// <param name="item"> hodnota parametru pro operand </param>
            ///
            /// <returns>< operand na pozici item ></returns>
            public char getOpItem(int item)
            {
                return operands[item];
            }
        }
        /// <summary>
        /// kontrola a pridani do znaku textboxu
        /// </summary>
        ///
        /// <param name="a"> pridavany znak </param>
        public void addCharToTextbox(char a)
        {//checks and adds a charracter to Textbox
            if (Globals.operandset)//clear textbox to insert second number
            {
                Globals.potentialNegative = true;
                Globals.operandset = false;
            }

            if (Globals.resultSet && !Globals.operandset)
            {
                clearFunction();
            }

            if (a != 'k')//If input is a button
            {
                if (a == '.' && textBox1.Text.IndexOf('.') > -1)//forbids more dots 
                    return;
                else if (a == '-' && (textBox1.Text.IndexOf('-') > -1 || !Globals.potentialNegative))//forbids more minuses
                    return;
                else
                {//input is a number from button
                 // MessageBox.Show(Convert.ToString(a));
                    if (a == '-') ;// MessageBox.Show("BFFF");
                    textBox1.Text += a;
                    textBox1.SelectionStart = textBox1.Text.Length;
                    textBox1.Focus();
                }
            }
        }
        /// <summary>
        /// vycisteni celeho pole a textboxu
        /// </summary>
        public void clearFunction()
        {//clear everything
            Globals.TextBoxNumber = 0;
            textBox1.Text = "0";
            label_operations.Text = "\0";
            Globals.example = "\0";
            Globals.operand = '\0';
            Globals.operandset = false;
            Globals.resultSet = false;
            while ((numops.getNumSize()) > 0) numops.numbers.RemoveAt(0);
            while ((numops.getOpSize()) > 0) numops.operands.RemoveAt(0);
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.Focus();
        }
        /// <summary>
        /// nastaveni hodnoty pocitanych cisel smazani ostatnich pokud uz byli pouzity
        /// </summary>
        ///
        /// <param name="y"> pozice prvku ke kteremu se pricita </param>
        /// <param name="value"> hodnota, ktera se ulozi do prvku na pozici 'y' </param>
        public void setValue(int y, double value)
        {//Sets value of computed numbers, deletes the other one, deletes operand that's been used
            numops.numbers.RemoveAt(y + 1);
            numops.setValue(y, value);
            numops.operands.RemoveAt(y);

        }
        /// <summary>
        /// nastaveni vstupu z klavesnice
        /// </summary>
        public void equalsFunction()
        {//enter pressed
            double answer = 0;
            numops.addNum(Globals.TextBoxNumber);
            Globals.example += ' ' + Convert.ToString(Globals.TextBoxNumber);

            int sizenum = numops.getNumSize();
            int sizeop = numops.getOpSize();
            // MessageBox.Show(Convert.ToString(sizeop));
            double[] num = numops.numbers.ToArray();
            char[] op = numops.operands.ToArray();
            //MessageBox.Show(Convert.ToString(sizenum +" " + sizeop));

            for (int y = 0; y < sizeop; y++)
            {//factorial
                switch (op[y])
                {
                    case 'f':
                        MessageBox.Show(Convert.ToString(numops.getNumSize() + " " + numops.getOpSize()));
                        num[y] = Mathlib.factorial(num[y]);
                        //numops.setValue(y, num[y]);
                        //numops.operands.RemoveAt(y);
                        setValue(y, num[y]);
                        MessageBox.Show(Convert.ToString(numops.getNumSize() + " " + numops.getOpSize()));
                        sizeop = numops.getOpSize();
                        op = numops.operands.ToArray();
                        num = numops.numbers.ToArray();
                        y = -1;
                        break;
                }
            }
            for (int y = 0; y < sizeop; y++)
            {//exponent
                //for (int a = 0; a < sizeop; a++) { MessageBox.Show(Convert.ToString(op[a])); }
                switch (op[y])
                {
                    case 'e':
                        // MessageBox.Show("E");
                        num[y] = Mathlib.exponent(num[y], num[y + 1]);
                        setValue(y, num[y]);
                        sizeop = numops.getOpSize();
                        op = numops.operands.ToArray();
                        num = numops.numbers.ToArray();
                        y = -1;
                        break;
                }
            }
            for (int y = 0; y < sizeop; y++)
            {//multiplication modulo division
                switch (op[y])
                {
                    case '*':
                        //MessageBox.Show("*");
                        num[y] = Mathlib.multiplication(num[y], num[y + 1]);
                        setValue(y, num[y]);
                        sizeop = numops.getOpSize();
                        op = numops.operands.ToArray();

                        num = numops.numbers.ToArray();
                        y = -1;
                        break;
                    case '/':
                        num[y] = Mathlib.divide(num[y], num[y + 1]);
                        setValue(y, num[y]);
                        sizeop = numops.getOpSize();
                        op = numops.operands.ToArray();
                        num = numops.numbers.ToArray();
                        y = -1;
                        break;
                    case 'm':
                        num[y] = Mathlib.modulo(num[y], num[y + 1]);
                        setValue(y, num[y]);
                        sizeop = numops.getOpSize();
                        op = numops.operands.ToArray();
                        num = numops.numbers.ToArray();
                        y = -1;
                        break;
                }
            }
            for (int y = 0; y < sizeop; y++)
            {//adition subtraction

                switch (op[y])
                {
                    case '+':
                        num[y] = Mathlib.addition(num[y], num[y + 1]);
                        setValue(y, num[y]);
                        sizeop = numops.getOpSize();
                        num = numops.numbers.ToArray();
                        y = -1;
                        break;
                    case '-':
                        num[y] = Mathlib.subtraction(num[y], num[y + 1]);
                        setValue(y, num[y]);
                        sizeop = numops.getOpSize();
                        num = numops.numbers.ToArray();
                        y = -1;
                        break;
                }
            }
            answer = num[0];
            numops.setValue(0, answer);
            Globals.operandset = false;

            Globals.potentialNegative = false;
            label_operations.Text = Globals.example + " = " + Convert.ToString(answer);
            Globals.resultSet = true;
            textBox1.Text = Convert.ToString(answer);
            textBox1.SelectionStart = textBox1.Text.Length;
            textBox1.Focus();
        }
        /// <summary>
        /// nastaveni operatoru
        /// </summary>
        ///
        /// <param name="op"> hodnota operatoru </param>
        public void setOperator(char op)
        {
            if (!(Globals.operandset) && numops.getNumSize() == 0 && op == '-')
            {
                textBox1.Text += op;
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.Focus();
            }
            else
            {
                if (Globals.operandset && op != '-') return;
                else
                {
                    textBox1.Clear();
                    if ((op == '-' && Globals.operandset && textBox1.Text.IndexOf('-') < 0))
                    {//setting a negative number

                        textBox1.Clear();
                        Globals.potentialNegative = false;
                        textBox1.SelectionStart = 0;
                        textBox1.Text += op;
                        textBox1.SelectionStart = textBox1.Text.Length;
                        textBox1.Focus();
                    }
                    if (Globals.resultSet)
                    {//if result is saved
                        numops.addOp(op);
                        label_operations.Text = "\0";
                        Globals.resultSet = false;
                        Globals.example = "\0";
                        Globals.operandset = false;
                        int size = numops.getNumSize();
                        int sizeop = numops.getOpSize();
                        label_operations.Text += ' ' + Convert.ToString(numops.getNumItem(size - 1)) + ' ' + Convert.ToString(numops.getOpItem(sizeop - 1));
                        Globals.example += ' ' + Convert.ToString(numops.getNumItem(size - 1)) + ' ' + Convert.ToString(numops.getOpItem(sizeop - 1));
                    }
                    else
                    {//normal flow

                        if (!(op == '-' && Globals.operandset))
                        {
                            numops.addNum(Globals.TextBoxNumber);
                            numops.addOp(op);
                            int size = numops.getNumSize();
                            int sizeop = numops.getOpSize();
                            if (op != 'f')
                            {
                                label_operations.Text += ' ' + Convert.ToString(numops.getNumItem(size - 1)) + ' ' + Convert.ToString(numops.getOpItem(sizeop - 1));
                                Globals.example += ' ' + Convert.ToString(numops.getNumItem(size - 1)) + ' ' + Convert.ToString(numops.getOpItem(sizeop - 1));
                            }
                            else
                            {
                                label_operations.Text += ' ' + Convert.ToString(numops.getNumItem(size - 1)) + " " + "!";
                                Globals.example += ' ' + Convert.ToString(numops.getNumItem(size - 1)) + " " + "!";
                            }

                        }
                    }
                    Globals.operand = op;
                    Globals.operandset = true;
                }
            }
        }

        /// <summary>
        /// potvrzeni pro zadani operatoru a moznost zaporneho cisla
        /// </summary>
        public void setThings()
        {
            setDefaults();
            Globals.operandset = true;
            Globals.potentialNegative = true;

        }
        /// <summary>
        /// nastaveni vychoziho stavu
        /// </summary>
        public void setDefaults()
        {
            Globals.resultSet = false;
            Globals.operandset = false;
            Globals.operand = '\0';
            Globals.potentialNegative = false;
        }
        /// <summary>
        /// zmena textu v tabulce
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if ((Globals.operand == '\0'))
            {
                if (!(String.IsNullOrEmpty(textBox1.Text)) && !(textBox1.Text == "-"))
                {
                    Globals.TextBoxNumber = double.Parse(textBox1.Text);
                }
            }
            if (!(Globals.operand == '\0'))
            {
                if (!(string.IsNullOrEmpty(textBox1.Text)) && !(textBox1.Text == "-"))
                {
                    Globals.TextBoxNumber = double.Parse(textBox1.Text);

                }
            }
        }
        /// <summary>
        /// povoleni pristupu psani do zadku pro vpisovani
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void Form1_Press(object sender, KeyPressEventArgs e)
        {
            if (!(ActiveControl.GetType() == typeof(TextBox)))
            {
                addCharToTextbox(e.KeyChar);
            }
        }
        /// <summary>
        /// ziska hodnotu klavesy ktera byla stlacena
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {//https://msdn.microsoft.com/en-us/library/aa243025(v=vs.60).asxp

            //if (Globals.operandset && (e.KeyValue >= 48 && e.KeyValue <= 57))
            if ((e.KeyValue >= 48 && e.KeyValue <= 57))
            {//keyboard number pressed
                addCharToTextbox('k');
            }


            int key = e.KeyValue;//keyboard button value
            if (key == 81)
            {//q - Quit keyboard pressed
                Application.Exit();
            }
            if (key == 67)
            {//C - Clear keyboard pressed
                clearFunction();
            }
            if (key == 107)
            {//addition keyboard pressed
                setOperator('+');
            }
            if (key == 109)
            {//substraction keyboard pressed         

                setOperator('-');
                //addCharToTextbox('-');
            }
            if (key == 106)
            {//multiplication keyboard pressed
                setOperator('*');
            }
            if (key == 111)
            {//division keyboard pressed
                setOperator('/');
            }
            if (key == 70)
            {//fact keyboard pressed
                setOperator('f');
            }
            if (key == 77)
            {//mod keyboard pressed
                setOperator('m');
            }
            if (key == 69)
            {//e keyboard pressed
                setOperator('e');
                textBox1.Clear();
            }

            if (key == 13)
            {//enter pressed
                equalsFunction();
            }
        }
        /// <summary>
        /// kotra pridani pro vstup (napr. pokud je jedna tecka, neprida se dalsi)
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {//numbers to textBox1 check
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }




        /// <summary>
        /// chovani pri stlaceni tlacika '0'
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_n0_Click(object sender, EventArgs e)
        {
            addCharToTextbox('0');
        }
        /// <summary>
        /// chovani pri stlaceni tlacika '1'
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_n1_Click(object sender, EventArgs e)
        {
            addCharToTextbox('1');
        }
        /// <summary>
        /// chovani pri stlaceni tlacika '2'
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_n2_Click(object sender, EventArgs e)
        {
            addCharToTextbox('2');
        }
        /// <summary>
        /// chovani pri stlaceni tlacika '3'
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_n3_Click(object sender, EventArgs e)
        {
            addCharToTextbox('3');
        }
        /// <summary>
        /// chovani pri stlaceni tlacika '4'
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_n4_Click(object sender, EventArgs e)
        {
            addCharToTextbox('4');
        }
        /// <summary>
        /// chovani pri stlaceni tlacika '5'
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_n5_Click(object sender, EventArgs e)
        {
            addCharToTextbox('5');
        }
        /// <summary>
        /// chovani pri stlaceni tlacika '6'
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_n6_Click(object sender, EventArgs e)
        {
            addCharToTextbox('6');
        }
        /// <summary>
        /// chovani pri stlaceni tlacika '7'
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_n7_Click(object sender, EventArgs e)
        {
            addCharToTextbox('7');
        }
        /// <summary>
        /// chovani pri stlaceni tlacika '8'
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_n8_Click(object sender, EventArgs e)
        {
            addCharToTextbox('8');
        }
        /// <summary>
        /// chovani pri stlaceni tlacika '9'
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_n9_Click(object sender, EventArgs e)
        {
            addCharToTextbox('9');
        }
        /// <summary>
        /// chovani pri stlaceni tlacika 'enter'
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_equals_Click(object sender, EventArgs e)
        {
            equalsFunction();
        }
        /// <summary>
        /// chovani pri stlaceni tlacika '.'
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_dot_Click(object sender, EventArgs e)
        {
            addCharToTextbox('.');
        }
        /// <summary>
        /// chovani pri stlaceni tlacika '+'
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_plus_Click(object sender, EventArgs e)
        {
            setOperator('+');
        }
        /// <summary>
        /// chovani pri stlaceni tlacika '-'
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_minus_Click(object sender, EventArgs e)
        {
            if (Globals.potentialNegative)
            {
                Globals.potentialNegative = false;
            }
            else
            {
                setOperator('-');
            }
            addCharToTextbox('-');
        }
        /// <summary>
        /// chovani pri stlaceni tlacika '*'
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_mul_Click(object sender, EventArgs e)
        {
            setOperator('*');
        }
        /// <summary>
        /// chovani pri stlaceni tlacika '/'
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_div_Click(object sender, EventArgs e)
        {
            setOperator('/');
        }
        /// <summary>
        /// chovani pri stlaceni tlacika 'm' (modulo)
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_modulo_Click(object sender, EventArgs e)
        {
            setOperator('m');
        }
        /// <summary>
        /// chovani pri stlaceni tlacika 'e' (exponent)
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_exp_Click(object sender, EventArgs e)
        {
            setOperator('e');
            textBox1.Clear();
        }
        /// <summary>
        /// chovani pri stlaceni tlacika 'f' (faktorial)
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_fact_Click(object sender, EventArgs e)
        {
            setOperator('f');
        }
        /// <summary>
        /// chovani pri stlaceni tlacika 'c' (clean)
        /// </summary>
        ///
        /// <param name="sender"> nepouzivana promnena </param>
        /// <param name="e"> parametr pristupu k hodnote </param>
        private void button_c_Click(object sender, EventArgs e)
        {
            clearFunction();
        }




    }
}
