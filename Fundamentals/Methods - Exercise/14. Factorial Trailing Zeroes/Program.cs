using System;
using System.Numerics;
using System.Reflection.Metadata;

namespace _14._Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            int exit = NumberOfZeros(result);
            Console.WriteLine(exit);
        }

         static int NumberOfZeros(BigInteger num)
        {
            string number = num.ToString();
            int counter = 0;
            int lenth = number.Length - 1;
            for (int i = lenth ; i > 0; i--)
            {
                if (number[i]=='0')
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            return counter;
        }
    }
}
