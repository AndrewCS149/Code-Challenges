using System;

namespace FinalPrices
{
    // https://leetcode.com/problems/final-prices-with-a-special-discount-in-a-shop/submissions/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] FinalPrices(int[] prices)
        {
            for (int i = 0; i < prices.Length - 1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                {
                    if (prices[i] >= prices[j])
                    {
                        prices[i] -= prices[j];
                        break;
                    }
                }
            }

            return prices;
        }
    }
}