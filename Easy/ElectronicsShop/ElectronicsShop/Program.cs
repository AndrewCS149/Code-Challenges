using System;
using System.Collections.Generic;
using System.Linq;

namespace ElectronicsShop
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/electronics-shop/problem
        private static void Main(string[] args)
        {
            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
            ;

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
            ;
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = getMoneySpent(keyboards, drives, b);

            Console.WriteLine(moneySpent);
        }

        /*
         input -> 30, [16, 20, 12], [10, 8]
         output -> 30

        edge cases:
            - always will be at least one item in each array
            - Arrays will not always have the same amount of items
            - Items will always be greater than zero
         */

        private static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            List<int> sums = new List<int>();

            foreach (var num1 in keyboards)
            {
                foreach (var num2 in drives)
                {
                    int sum = num1 + num2;
                    if (sum <= b) sums.Add(sum);
                }
            }

            return sums.Count > 0 ? sums.Max() : -1;
        }
    }
}