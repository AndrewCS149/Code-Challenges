using System;
using System.Collections.Generic;
using System.Linq;

namespace Bill_division
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/bon-appetit/problem
        private static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

            int b = Convert.ToInt32(Console.ReadLine().Trim());

            bonAppetit(bill, k, b);
        }

        private static void bonAppetit(List<int> bill, int k, int b)
        {
            int splitBill = bill.Where((x, i) => i != k).Sum() / 2;

            if (splitBill == b) Console.WriteLine("Bon Appetit");
            else Console.WriteLine(b - splitBill);
        }
    }
}