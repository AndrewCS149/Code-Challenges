using System;
using System.Security.Cryptography.X509Certificates;

namespace Day10_BinaryNumbers
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/30-binary-numbers/problem
        private static void Main(string[] args)
        {
            int n = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int counter = 0, max = 0;

            while (n > 0)
            {
                int rem = n % 2;
                if (rem == 1) counter++;
                else counter = 0;

                max = Math.Max(counter, max);
                n /= 2;
            }
        }
    }
}