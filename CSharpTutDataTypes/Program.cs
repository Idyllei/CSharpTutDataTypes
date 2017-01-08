using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool canIVote = true;

            Console.WriteLine("Biggest Integer : {0}", int.MaxValue);
            Console.WriteLine("Smallest Integer : {0}", int.MinValue);

            Console.WriteLine("Biggest Long : {0}", long.MaxValue);
            Console.WriteLine("Smallest Long : {0}", long.MinValue);

            /// Decimals store 128-bit floating point numbers accurate to 28 digits.
            Console.WriteLine("Biggest Decimal : {0}", decimal.MaxValue);
            Console.WriteLine("Smallest Decimal : {0}", decimal.MinValue);
            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.0000000000000000000000000011M;
            Console.WriteLine("DEC : PI + bigNum = {0}", decPiVal + decBigNum);

            /// Doubles store 64-bit floating point numbers with 14 digit precision.
            Console.WriteLine("Biggest Double : {0}", double.MaxValue.ToString("#"));
            Console.WriteLine("Smallest Double : {0}", double.MinValue.ToString("#"));
            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.00000000000002;
            Console.WriteLine("DBL : PI + bigNum = {0}", dblPiVal + dblBigNum);

            /// Floats store 32-bit floating point numbers with half accuracy of doubles.
            /// You can work with 6 digits.
            Console.WriteLine("Biggest Float : {0}", float.MaxValue);
            Console.WriteLine("Smallest Float : {0}", float.MinValue);
            float fPiVal = 3.14159f;
            float fBigNum = 3.000002f;
            Console.WriteLine("FLT : PI + bigNum = {0}", fPiVal + fBigNum);

            /// To get a data type from a string, use the Parse method of that type.
            bool boolFromStr = bool.Parse("true");
            Console.WriteLine("After Parse-ing for a Bool : {0}", boolFromStr);
            int intFromStr = int.Parse("100");
            Console.WriteLine("After Parse-ing for an Integer : {0}", intFromStr);
            double dblFromStr = double.Parse("1.234");
            Console.WriteLine("After Parse-ing for a Double : {0}", dblFromStr);

            Console.ReadLine();
        }
    }
}
