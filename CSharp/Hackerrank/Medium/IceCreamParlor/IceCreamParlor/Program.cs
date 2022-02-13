using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IceCreamParlor
{
    internal class Program
    {
        // link - https://www.hackerrank.com/challenges/ctci-ice-cream-parlor/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=search
        private static void whatFlavors(int[] cost, int money)
        {
            Dictionary<int, int> table = new Dictionary<int, int>();
            for (int i = 0; i < cost.Length; i++)
            {
                if (cost[i] > money) continue;

                int diff = money - cost[i];

                if (table.ContainsKey(diff))
                {
                    int min = Math.Min(i + 1, table[diff]);
                    int max = Math.Max(i + 1, table[diff]);

                    Console.WriteLine($"{min} {max}");
                    break;
                }
                else
                {
                    table.Add(cost[i], i + 1);
                }
            }
        }

        private static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int money = Convert.ToInt32(Console.ReadLine());

                int n = Convert.ToInt32(Console.ReadLine());

                //int[] cost = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), costTemp => Convert.ToInt32(costTemp))
                //;
                string[] arr_temp = Console.ReadLine().Trim().Split(' ');
                int[] cost = Array.ConvertAll(arr_temp, Int32.Parse);

                whatFlavors(cost, money);
            }
        }
    }
}