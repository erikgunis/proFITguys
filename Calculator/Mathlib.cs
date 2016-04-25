using System;
using System.Windows.Forms;



public static class Mathlib
{
    public static double addition(double a, double b) //SCITANIE
    {
        if (((a + b) > double.MaxValue) || ((a + b) < double.MinValue))
        {
            MessageBox.Show("Overflow", "Warning");         // overflow
            return 0;
        }
        else
            return (a + b);
    }

    public static double subtraction(double a, double b) //ODCITANIE
    {
        if ((a - b > double.MaxValue) || (a - b < double.MinValue))
        {
            MessageBox.Show("Overflow", "Warning");         // overflow
            return 0;
        }
        else
            return (a - b);
    }

    public static double multiplication(double a, double b) //NASOBENIE
    {

        if ((a * b > double.MaxValue) || (a * b < double.MinValue))
        {
            MessageBox.Show("Overflow", "Warning");         // overflow
            return 0;
        }
        else
            return (a * b);
    }

    public static double divide(double a, double b) //DELENIE
    {
        if (b == 0)
        {
            MessageBox.Show("Invalid format (Divide by zero)", "Warning");         // delenie nulou
            return 0;
        }
        else
        {
            if ((a * b > double.MaxValue) || (a * b < double.MinValue))
            {
                MessageBox.Show("Overflow", "Warning");         // overflow
                return 0;
            }
            else
                return (a / b);
        }
    }

    public static double modulo(double a, double b)  // DELENIE MODULO
    {
        ulong aa = Convert.ToUInt64(a);
        ulong bb = Convert.ToUInt64(b);
        ulong x = aa;
        ulong y = bb;
        // MessageBox.Show("b,bb:" + b+ " " + bb);
        if (!((a - aa == 0) && (b - bb == 0)))  //test ci je parameter cele cislo
        {
            MessageBox.Show("Invalid format (real number)", "Warning");         //zly vstup - realne cislo
            return 0;
        }
        if (y == 0)
        {
            MessageBox.Show("Invalid format (Divide by zero)", "Warning");          //zly vstup - delenie nulou
            return 0;
        }
        else
        {
            ulong z = x / y;
            return Convert.ToSingle(x - (y * z));
        }
    }


    public static double factorial(double f)  //FAKTORIAL
    {
        if (f < 0)
        {
            MessageBox.Show("Invalid format (less than zero)", "Warning");               // zly vstup - menej ako 0
            return 0;
        }

        ulong x = Convert.ToUInt64(f);


        if (!(f - (Convert.ToUInt64(f)) == 0))              //test ci je parameter cele cislo
        {
            MessageBox.Show("Invalid format (real number)", "Warning");        //zly vstup - realne cislo
            return 0;
        }


        else
        {
            if (x == 0)       // faktorial 0 je 1
            {
                x = 1;
            }
            else
            {
                for (ulong i = (x - 1); i > 0; i--)
                {
                    x *= i;
                }
            }
        }
        if (x > double.MaxValue)
        {
            MessageBox.Show("Overflow", "Warning");         // overflow
            return 0;
        }
        else
            return Convert.ToDouble(x);
    }

    public static double exponent(double a, double c) //MOCNINA - EXPONENT
    {
        if (c < 0)
        {
            MessageBox.Show("Invalid format (real number)", "Warning");        //zly vstup - realne cislo
            return 0;
        }

        ulong b = Convert.ToUInt64(c);
        if (!(c - b == 0))              //test ci je parameter cele cislo
        {
            MessageBox.Show("Invalid format (real number)", "Warning");        //zly vstup - realne cislo
            return 0;
        }

        if (b == 0)
        {
            return 1; //exponent je 0    
        }

        if (b > 0)
        {
            double x = a;
            for (ulong i = (b - 1); i > 0; i--)
            {
                a *= x;
            }
            if ((a <= double.MaxValue) && (a >= double.MinValue))
            {
                return a;
            }
            else
            {
                MessageBox.Show("Overflow", "Warning");
                return 0;
            }
        }
        else
        {
            MessageBox.Show("Invalid format (exponent is less than zero)", "Warning");         // zly exponent
            return 0;
        }
    }
}