using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfUniqueElements
{
    // https://leetcode.com/problems/sum-of-unique-elements/submissions/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int SumOfUnique(int[] nums)
        {
            var dict = new Dictionary<int, int>();

            foreach (int n in nums)
            {
                if (dict.ContainsKey(n))
                    dict[n] = ++dict[n];
                else
                    dict.Add(n, 1);
            }

            return dict.Select(x => x.Key).Where(x => dict[x] == 1).Sum();
        }
    }
}