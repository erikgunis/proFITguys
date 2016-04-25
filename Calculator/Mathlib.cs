using System;
using System.Windows.Forms;



public static class Mathlib
    {
    	/// <summary>
    	/// Secteni prvniho a druheho cisla
    	/// </summary>
    	///
    	/// <param name="a"> hodnota prvniho cisla </param>
    	/// <param name="b"> hodnota druheho cisla </param>
    	///
    	/// <returns> vraceni hodnoty secteni prvniho a druheho cisla </returns>
        public static float addition(float a, float b) //SCITANIE
        {
            return (a + b);
        }
		/// <summary>
		/// Odecteni prvniho a druheho cisla
		/// </summary>
		///
		/// <param name="a"> hodnota prvniho cisla </param>
		/// <param name="b"> hodnota druheho cisla </param>
		///
		/// <returns> vraceni hodnoty odecteni prvniho a druheho cisla </returns>
        public static float subtraction(float a, float b) //ODCITANIE
        {
            return (a - b);
        }
        /// <summary>
        /// Nasobeni prvniho a druheho cisla
        /// </summary>
        ///
        /// <param name="a"> hodnota prvniho cisla </param>
        /// <param name="b"> hodnota druheho cislaiption </param>
        ///
        /// <returns> vrceni hodnoty nasobeni prvniho a druheho cisla  </returns>
        public static float multiplication(float a, float b) //NASOBENIE
        {
            return (a * b);
        }
		/// <summary>
		/// Deleni prvniho cisla druhym a osetreni pro deleni nulou
		/// </summary>
		///
		/// <param name="a"> hodnota prvniho cisla </param>
		/// <param name="b"> hodnota druheho cisla </param>
		///
		/// <returns> vraceni hodnoty prvniho cisla vydelene druhym cislem pokud druho cislo nebylo 0 </returns>
        public static float divide(float a, float b) //DELENIE
        {
            if (b == 0)
            {
                MessageBox.Show("Invalid format(Divide by zero)", "Warning");         // delenie nulou
                return 0;
            }
            else
            {
                return (a / b);
            }
        }
        /// <summary>
        /// modulo dvou cisel a osetreni pro deleni nulou, osetreni vstupu pouze pro cela cisla
        /// </summary>
        ///
        /// <param name="a"> hodnota prvniho cisla </param>
        /// <param name="b"> hodnota druheho cisla </param>
        ///
        /// <returns> vraceni hodnoty prvniho cisla modulo druhym cislem </returns>
        public static float modulo(float a, float b)  // DELENIE MODULO
        {
            ulong aa = Convert.ToUInt64(a);
            ulong bb = Convert.ToUInt64(b);
            ulong x = aa;
            ulong y = bb;
       // MessageBox.Show("b,bb:" + b+ " " + bb);
        if (!((a - aa == 0) && (b - bb == 0)))  //test ci je parameter cele cislo
            {
                MessageBox.Show("Invalid format(real number)", "Warning");         //zly vstup - realne cislo
                return 0;
            }
            if (y == 0)
            {
                MessageBox.Show("Invalid format(Divide by zero)", "Warning");          //zly vstup - delenie nulou
                return 0;
            }
            else
            {
                ulong z = x / y;
                return Convert.ToSingle(x - (y * z));
            }
        }
        /// <summary>
        /// vypocet faktorialu a osetreni zaporneho faktorialu, faktorialu realneho cisla
        /// </summary>
        ///
        /// <param name="f"> hodnota cisla ze vstupu </param>
        ///
        /// <returns>< vraceni hodnoty faktorial vstupniho cisla ></returns>

        public static float factorial(float f)  //FAKTORIAL
        {
        if (f < 0)
        {
            MessageBox.Show("Invalid format(less than zero)", "Warning");               // zly vstup - menej ako 0
            return 0;
        } 
        
            ulong x = Convert.ToUInt64(f);
        

        if (!(f - (Convert.ToUInt64(f)) == 0))              //test ci je parameter cele cislo
            { 
                MessageBox.Show("Invalid format(real number)", "Warning");        //zly vstup - realne cislo
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
            return Convert.ToSingle(x);
        }
        /// <summary>
        /// vypocet umocneni, osetreni proti preteceni
        /// </summary>
        ///
        /// <param name="a"> mocnene cislo </param>
        /// <param name="c"> exponent </param>
        ///
        /// <returns> vraceni hodnoty umocneneho cisla na zadany exponent </returns>
        public static float exponent(double a, double c) //MOCNINA - EXPONENT
        {
            ulong b = Convert.ToUInt32(c);
            if (b > 0)
            {
                for (ulong i = (b - 1); i > 0; i--)
                {
                    a *= a;
                }
                if (a <= float.MaxValue)
                {
                    return Convert.ToSingle(a);
                }
                else
                {
                    MessageBox.Show("Invalid format(Overflow)", "Warning");
                    return 0;
                }
            }
            else
            {
                MessageBox.Show("Invalid format(exponent is less than zero)", "Warning");         // zly exponent
                return 0;
            }
        }





    }
