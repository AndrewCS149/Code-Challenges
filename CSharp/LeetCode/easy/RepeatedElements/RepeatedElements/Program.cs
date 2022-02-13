using System;
using System.Collections.Generic;

namespace RepeatedElements
{
    // https://leetcode.com/problems/n-repeated-element-in-size-2n-array/submissions/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int RepeatedNTimes(int[] A)
        {
            var set = new HashSet<int>();
            foreach (int n in A)
                if (!set.Add(n)) return n;

            return -1;
        }
    }
}