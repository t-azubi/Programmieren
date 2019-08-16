using System;
using System.Collections.Generic;

namespace Taschenrechner
{
    public class Informatikrechner
    {
        private string DecToHexa(int DecValue)
        {
            return DecimalToArbitrarySystem(DecValue, 16);
        }
        private string DecToBin(int DecValue)
        {
            return DecimalToArbitrarySystem(DecValue, 2);
        }
        private string DecToOctal(int DecValue)
        {
            return DecimalToArbitrarySystem(DecValue, 8);
        }
        /// <summary>
        /// Converts the given decimal number to the numeral system with the
        /// specified radix (in the range [2, 36]).
        /// </summary>
        /// <param name="decimalNumber">The number to convert.</param>
        /// <param name="radix">The radix of the destination numeral system (in the range [2, 36]).</param>
        /// <returns></returns>
        private static string DecimalToArbitrarySystem(long decimalNumber, int radix)
        {
            const int BitsInLong = 64;
            const string Digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            if (radix < 2 || radix > Digits.Length)
                throw new ArgumentException("The radix must be >= 2 and <= " + Digits.Length.ToString());

            if (decimalNumber == 0)
                return "0";

            int index = BitsInLong - 1;
            long currentNumber = Math.Abs(decimalNumber);
            char[] charArray = new char[BitsInLong];

            while (currentNumber != 0)
            {
                int remainder = (int)(currentNumber % radix);
                charArray[index--] = Digits[remainder];
                currentNumber = currentNumber / radix;
            }

            string result = new String(charArray, index + 1, BitsInLong - index - 1);
            if (decimalNumber < 0)
            {
                result = "-" + result;
            }

            return result;
        }
        private int BinToDec(string BinValue)
        {
            return Convert.ToInt32(BinValue, 2);
        }
        private int HexaToDec(string HexaValue)
        {
            return Convert.ToInt32(HexaValue, 2);
        }
        private int OctalToDec(string OctalValue)
        {
            return Convert.ToInt32(OctalValue, 2);
        }
        /// <summary>
        /// Gives Back a List where item 0 is the Bin
        /// </summary>
        /// <param name="BinValue"></param>
        /// <param name="OctalValue"></param>
        /// <param name="DecValue"></param>
        /// <param name="HexaValue"></param>
        /// <returns></returns>
        public List<string> MyConverter(string BinValue, string OctalValue, string DecValue, string HexaValue)
        {
            List<string> result = new List<string>();
            if (BinValue != string.Empty)
            {
               var DecInt = BinToDec(BinValue);
                result.Add(BinValue);
                result.Add(DecToOctal(DecInt));
                result.Add(DecInt.ToString());
                result.Add(DecToHexa(DecInt));
                return result;
            }
            if (OctalValue != string.Empty)
            {
                var DecInt = OctalToDec(OctalValue);
                result.Add(DecToBin(DecInt));
                result.Add(OctalValue);
                result.Add(DecInt.ToString());
                result.Add(DecToHexa(DecInt));
                return result;
            }
            if (DecValue != string.Empty)
            {
                var DecInt = Convert.ToInt32(DecValue);
                result.Add(DecToBin(DecInt));
                result.Add(DecToOctal(DecInt));
                result.Add(DecValue);
                result.Add(DecToHexa(DecInt));
                return result;
            }
            if (HexaValue != string.Empty)
            {
                var DecInt = HexaToDec(HexaValue);
                result.Add(DecToBin(DecInt));
                result.Add(DecToOctal(DecInt));
                result.Add(DecInt.ToString());
                result.Add(HexaValue);
                return result;
            }
            return result;
        }
    }
}
