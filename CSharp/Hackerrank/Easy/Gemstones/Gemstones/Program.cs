using System;
using System.Collections.Generic;

namespace Gemstones
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/gem-stones/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] arr = new string[n];

            for (int i = 0; i < n; i++)
            {
                string arrItem = Console.ReadLine();
                arr[i] = arrItem;
            }

            int result = gemstones(arr);

            Console.WriteLine(result);
        }

        private static int gemstones(string[] arr)
        {
            int count = 0;
            string minStr = arr[0];
            HashSet<char> set = new HashSet<char>();

            Array.ForEach(arr, ar => { if (ar.Length < minStr.Length) minStr = ar; });

            foreach (var ch in minStr)
            {
                bool isGem = true;
                if (!set.Add(ch)) continue;

                foreach (var str in arr)
                {
                    if (str == minStr) continue;
                    if (!str.Contains(ch)) isGem = false;
                }
                if (isGem) count++;
            }

            return count;
        }
    }
}