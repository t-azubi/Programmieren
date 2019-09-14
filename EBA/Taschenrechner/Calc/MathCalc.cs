using System;
using System.Collections.Generic;

namespace Taschenrechner
{
    public class MathCalc
    {
        /// <summary>
        /// Calc the Power of the Num by the Pow
        /// </summary>
        public double Power(double num, double pow)
        {
            if (pow % 1 == 0)
            {
                double result = 1;
                if (pow > 0)
                {
                    for (double i = 1; i <= pow; ++i)
                    {
                        result *= num;
                    }
                }
                else if (pow < 0)
                {
                    for (double i = -1; i >= pow; --i)
                    {
                        result /= num;
                    }
                }
                return result;
            }
            var bf = splitExp(pow).Item1;
            var bi = splitExp(pow).Item2;
            var fractionTop = DoubleToFraction(bi).Item1;
            var fractionBottom = DoubleToFraction(bi).Item2;
            return Power(num, bf) * root(fractionBottom, Power(num, fractionTop));
        }
        /// <summary>
        /// Find all PrimeNumber between Bottom and Top Border.
        /// Test if i is divisible between 2 and i -1 if yes then its not a primenumber
        /// </summary>
        /// <param name="bottom border"></param>
        /// <param name="top border"></param>
        /// <returns>List of int with all Primenumbers between botom and top</returns>
        public List<int> Primenumber(int bottom, int top)
        {
            var flag = 1;
            List<int> output = new List<int>();
            for (int i = bottom; i < top; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                flag = 1;

                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    output.Add(i);
                }
            }
            return output;
        }
        /// <summary>
        /// Do 500 itteration and try to get close to the root 
        /// 
        /// </summary>
        public double root(int exp, double rad)
        {
            double guess = ((1) > (rad / exp) ? (1) : (rad / exp));

            for (int i = 0; i < 500; i++)
                guess -= (Power(guess, exp) - rad) / (exp * Power(guess, exp - 1));

            return guess;
        }
        /// <summary>
        /// Splits the Inputted Number in natural number and remaining float 
        /// </summary>
        public (int, double) splitExp(double exp)
        {
            var Y = exp.ToString();
            if (Y.IndexOf(',') == -1)
            {
                Y += ",0";
            }
            var X = Y.Split(',');
            return (Convert.ToInt32(X[0]), Convert.ToDouble("0," + X[1]));

        }
        /// <summary>
        /// Calculates the natural Logarythm of the Input
        /// </summary>
        public double LN(double X)
        {
            var x = Convert.ToDouble(X);
            double f = 0f, fOld = 0f;
            int i = 0;
            do
            {
                fOld = f;
                f = f + Power((x - 1) / (x + 1), 2 * i + 1) / (2 * i + 1);
                i++;
            } while ((fOld != f));
            return f * 2;
        }
        public double LOG(double Exponent, double Base)
        {
            return LN(Exponent) / LN(Base);
        }
        /// <summary>
        /// Calculates the factorial from the Input
        /// </summary>
        public int factorial(int X)
        {
            if (X == 0)
            {
                return 1;
            }
            return X * factorial(X - 1);
        }

        //      /// <summary>
        //      ///  Converts a float point number into a fraction
        //      ///  You only need to input num
        //      /// </summary>
        //      /// <returns> 2 Integers </returns>
        //      public (int, int) asd(double num, double epsilon = 0.0001, int maxIterations = 50)
        //      {
        //          double[] d = new double[maxIterations + 2];
        //          d[1] = 1;
        //          double z = num;
        //          double n = 1;
        //          int t = 1;
        //
        //          int wholeNumberPart = (int)num;
        //          double decimalNumberPart = num - Convert.ToDouble(wholeNumberPart);
        //
        //          var x = ABS(n / d[t] - num);
        //          while (t < maxIterations &&  x > epsilon)
        //          {
        //              t++;
        //              z = 1 / (z - (int)z);
        //              d[t] = d[t - 1] * (int)z + d[t - 2];
        //              n = (int)(decimalNumberPart * d[t] + 0.5);
        //              x = ABS(n / d[t] - num);
        //          }
        //          return (Convert.ToInt32(n), Convert.ToInt32(d[t]));
        //      }


        public (int, int, int) DoubleToFraction(double num)
        {
            var x = splitExp(num);
            int wholenum = x.Item1;
            double decimalnum = x.Item2;
            long denominator = 10;
            var numerator = (decimalnum * (double)denominator);
            while (numerator % 1 != 0)
            {
                denominator *= 10;
                numerator *= 10;
            }
            long gcd;
            GreatestCommonD(ref numerator, ref denominator, out gcd);
            return (wholenum, (int)numerator, (int)denominator);
        }
        void GreatestCommonD(ref double Numerator, ref long Denominator, out long greatestCommonD)
        {
            greatestCommonD = 0;
            for (int x = 1; x <= Denominator; x++)
            {
                if ((Numerator % x == 0) && (Denominator % x == 0))
                    greatestCommonD = x;
            }
            if (greatestCommonD == 0)
            {
                return;
            }
            else
            {
                Numerator = Numerator / greatestCommonD;
                Denominator = Denominator / greatestCommonD;

            }
        }
        /// <summary>
        /// Return the Absolute of X
        /// </summary>
        /// 


        public int RoundDown(double numberToRound)
        {
            int result = 0;
            if(numberToRound < 0)
            {
                return -1;
            }
            else
            {
                while (result < numberToRound)
                {
                    result++;
                }
                return result;
            }
        }
        public double ABS(double X)
        {
            if (X < 0)
            {
                return X * -1;
            }
            else
                return X;
        }
    }
    public class Konstanten
    {
        /// <summary>
        /// 2,71828
        /// </summary>
        public double e = new Grundrechner().CalcConst("410105312 / 150869313");
        /// <summary>
        /// 3,14159
        /// </summary>
        public double pi = new Grundrechner().CalcConst("21053343141 / 6701487259");
        /// <summary>
        /// 1,61803
        /// </summary>
        public double φ = new Grundrechner().CalcConst("( 1 + " + new MathCalc().root(2, 5).ToString() + ") / 2 ");
    }
}

