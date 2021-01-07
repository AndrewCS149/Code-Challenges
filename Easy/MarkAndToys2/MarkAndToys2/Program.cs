using System;

namespace MarkAndToys2
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
            Array.Sort(prices);
            int spent = 0, count = 0;
            while (spent < k)
            {
                spent += prices[count];
                if (spent > k) break;
                count++;
            }

            for (int i = 0; i < prices.Length; i++)
            {
                spent += prices[i];
                if (spent > k) break;
                count++;
            }
            return count;
        }
    }
}