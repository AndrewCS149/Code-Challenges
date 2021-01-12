using System;

namespace MarkAndToys
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/mark-and-toys/problem
        private static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp))
            ;
            int result = maximumToys(prices, k);

            Console.WriteLine(result);
        }

        private static int maximumToys(int[] prices, int k)
        {
        }
    }
}