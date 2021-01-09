using System;

namespace FlippingBits
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/flipping-bits/problem
        private static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                long n = Convert.ToInt64(Console.ReadLine());

                long result = flippingBits(n);

                Console.WriteLine(result);
            }
        }

        private static long flippingBits(long n)
        {
            // NOT MY SOLUTION
            return ~n;
        }
    }
}