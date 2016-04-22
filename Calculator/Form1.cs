using System; using System.Collections.Generic; using System.ComponentModel; using System.Data; using System.Drawing; using System.Linq; using System.Text; using System.Threading.Tasks; using System.Windows.Forms;   namespace Calculator {     public partial class Form1 : Form     {                 public Form1()         {             InitializeComponent();         }         //Mathlib kniznica = new Mathlib();          public static class Globals         {             public static char operand;             public static bool negativeNumber = false;             public static bool potentialNegative = false;             public static bool operandset = false;             public static bool enterPressed = false;             public static float baseNumber = 0;             public static float secondNumber = 0;             public static float intNumber = '\0';             public static bool labelFirstNumber = false;
            public static bool resultSet = false;
         }         public void setThings()
        {
            setDefaults();
            Globals.operandset = true;
            Globals.potentialNegative = true;
            
        }         public void setDefaults()
        {
            Globals.resultSet = false;
            Globals.operandset = false;
            Globals.operand = '\0';
            Globals.negativeNumber = false;
            Globals.potentialNegative = false;
            Globals.secondNumber = '\0';
            Globals.enterPressed = false;
        }            private void textBox1_TextChanged(object sender, EventArgs e)         {             if (Globals.resultSet && !Globals.enterPressed)
            {
                Globals.baseNumber = '\0';
                setDefaults();             }             if ((Globals.operand == '\0'))             {
                if (!(String.IsNullOrEmpty(textBox1.Text)))                 {                     Globals.baseNumber = float.Parse(textBox1.Text);
                }             }             if (!(Globals.operand == '\0'))             {                 if (!(string.IsNullOrEmpty(textBox1.Text)) && (!Globals.enterPressed))                 {                     Globals.secondNumber = float.Parse(textBox1.Text);
                   
                }             }         }          private void Form1_Press(object sender, KeyPressEventArgs e)         {             if (!(ActiveControl.GetType() == typeof(TextBox)))             {                 textBox1.Text += e.KeyChar;                 textBox1.SelectionStart = textBox1.Text.Length;                 textBox1.Focus();             }         }          private void Form1_KeyDown(object sender, KeyEventArgs e)         {//https://msdn.microsoft.com/en-us/library/aa243025(v=vs.60).aspx


            /*if (Globals.resultSet && !Globals.enterPressed)
            {
                             }*/
            if (Globals.operandset && (e.KeyValue >= 48 && e.KeyValue <= 57))             {                 Globals.enterPressed = false;                 Globals.potentialNegative = true;                 Globals.operandset = false;                 textBox1.Clear();                 if(Globals.resultSet && !Globals.enterPressed)
                {
                    Globals.baseNumber = '\0';
                    setDefaults();
                }             }                                      int key = e.KeyValue;             if ( key == 67 )
            {
                setDefaults();
                textBox1.Clear();
                Globals.baseNumber = 0;
                Globals.secondNumber = 0;
                Globals.intNumber = 0;
            }             if (key == 107)             {                 setThings();                 Globals.operand = '+';             }             if (key == 109)             {                 if (Globals.potentialNegative)                 {                     Globals.potentialNegative = false;                     Globals.negativeNumber = true;                 } else {
                    setThings();
                    Globals.operand = '-';                 }                 //MessageBox.Show(Convert.ToString(Globals.baseNumber) + ' ' + Convert.ToString(Globals.secondNumber) + Globals.operand);             }             if (key == 106)             {
                setThings();
                Globals.operand = '*';             }             if (key == 111)             {
                setThings();
                Globals.operand = '/';             }             if (key == 70)             {                 setThings();                 Globals.operand = 'f';             }             if (key == 77)             {                 setThings();                 Globals.operand = 'm';             }             if (key == 69)             {                 setThings();                 Globals.operand = 'e';                 textBox1.Clear();             }             /*if ((key == 107 || key == 109 || key == 106 || key == 111 || key == 70 || key == 77 || key == 69) && Globals.intNumber != '\0' && Globals.operandset && !Globals.enterPressed)             {                 Globals.secondNumber = Globals.intNumber;                 float answer = 0;                 if (Globals.negativeNumber)                 {                     Globals.secondNumber = Globals.secondNumber * -1;                 }                 if (Globals.operand == '+')                 {                     answer = Mathlib.addition(Globals.baseNumber, Globals.secondNumber);                 }                 else if (Globals.operand == '-')                 {                     answer = Mathlib.subtraction(Globals.baseNumber, Globals.secondNumber);                 }                 else if (Globals.operand == '*')                 {                     answer = Mathlib.multiplication(Globals.baseNumber, Globals.secondNumber);                 }                 else if (Globals.operand == '/')                 {                     answer = Mathlib.divide(Globals.baseNumber, Globals.secondNumber);                 }                 else if (Globals.operand == 'f')                 {                     answer = Mathlib.factorial(Globals.baseNumber);                     Globals.operand = '!';                 }                 else if (Globals.operand == 'm')                 {                     answer = Mathlib.modulo(Globals.baseNumber, Globals.secondNumber);                 }
                else if (Globals.operand == 'e')                 {                     answer = Mathlib.exponent(Globals.baseNumber, Globals.secondNumber);                 }


                
                if (!Globals.labelFirstNumber) label_operations.Text += Convert.ToString(Globals.baseNumber);                 label_operations.Text +=  Convert.ToString(Globals.operand) + ' ' +  Convert.ToString(Globals.intNumber);
                //MessageBox.Show(Convert.ToString(Globals.baseNumber));
                Globals.intNumber = 0;
                Globals.labelFirstNumber = true;                 Globals.baseNumber = answer;                 textBox1.Text = Convert.ToString(Globals.baseNumber);
                //label_operations.Text += ' ' + Globals.operand;
                Globals.operandset = true;                 textBox1.SelectionStart = textBox1.Text.Length;                 textBox1.Focus();             }*/             if (key == 13) {//enter pressed
                float answer = 0;
                if (Globals.negativeNumber)                 {                     if(!Globals.enterPressed)                     Globals.secondNumber = Globals.secondNumber * -1;                 }                 if (Globals.operand == '+')                 {                     answer = Mathlib.addition(Globals.baseNumber, Globals.secondNumber);                 }                 else if (Globals.operand == '-')                 {                     answer = Mathlib.subtraction(Globals.baseNumber, Globals.secondNumber);                 }                 else if (Globals.operand == '*')                 {                     answer = Mathlib.multiplication(Globals.baseNumber, Globals.secondNumber);                 }                 else if (Globals.operand == '/')                 {                     answer = Mathlib.divide(Globals.baseNumber, Globals.secondNumber);                 }                 else if (Globals.operand == 'f')                 {                     answer = Mathlib.factorial(Globals.baseNumber);                     Globals.operand = '!';                 }                 else if (Globals.operand == 'm')                 {                     answer = Mathlib.modulo(Globals.baseNumber, Globals.secondNumber);                 }
                else if (Globals.operand == 'e')                 {                     answer = Mathlib.exponent(Globals.baseNumber, Globals.secondNumber);                 }

                
                Globals.operandset = true;
                              Globals.potentialNegative = false;             
                label_operations.Text = Convert.ToString(Globals.baseNumber) + ' ' + Convert.ToString(Globals.operand) + ' ' + Convert.ToString(Globals.secondNumber) + " =" + Convert.ToString(answer);
                Globals.baseNumber = answer;
                Globals.resultSet = true;
                Globals.enterPressed = true;                 textBox1.Text = Convert.ToString(Globals.baseNumber);                 textBox1.SelectionStart = textBox1.Text.Length;                 textBox1.Focus();             }         }          private void textBox1_KeyPress(object sender, KeyPressEventArgs e)         {             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))             {                 e.Handled = true;             }              // only allow one decimal point             if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))             {                 e.Handled = true;             }         }     } } 