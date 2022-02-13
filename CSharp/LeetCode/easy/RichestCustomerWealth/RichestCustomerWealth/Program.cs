using System;

namespace RichestCustomerWealth
{
    internal class Program
    {
        // easy
        // link to challenge - https://leetcode.com/problems/richest-customer-wealth/
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int MaximumWealth(int[][] accounts)
        {
            int sum = 0;
            Array.ForEach(accounts, arr =>
            {
                int tempSum = 0;
                Array.ForEach(arr, bank => tempSum += bank);

                if (tempSum > sum) sum = tempSum;
            });
            return sum;
        }
    }
}