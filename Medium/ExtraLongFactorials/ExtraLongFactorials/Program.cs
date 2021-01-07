using System;
using System.Numerics;

namespace ExtraLongFactorials
{
    internal class Program
    {
        // medium
        // link to challenge - https://www.hackerrank.com/challenges/extra-long-factorials/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            extraLongFactorials(n);
        }

        private static void extraLongFactorials(int n)
        {
            Console.WriteLine(Factorial(n));
        }

        private static BigInteger Factorial(int n)
        {
            return n == 1 ? 1 : n * Factorial(n - 1);
        }
    }
}