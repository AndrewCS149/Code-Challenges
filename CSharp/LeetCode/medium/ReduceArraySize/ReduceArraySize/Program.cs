using System;
using System.Collections.Generic;
using System.Linq;

namespace ReduceArraySize
{
    // https://leetcode.com/problems/reduce-array-size-to-the-half/submissions/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int MinSetSize(int[] arr)
        {
            var dict = new Dictionary<int, int>();
            foreach (int n in arr)
            {
                if (dict.ContainsKey(n)) dict[n]++;
                else dict.Add(n, 1);
            }

            int[] newArr = dict.Values.OrderByDescending(x => x).ToArray();
            int sum = 0;
            for (int i = 1; i <= newArr.Length; i++)
            {
                sum += newArr[i - 1];
                if (sum >= arr.Length / 2)
                    return i;
            }

            return -1;
        }
    }
}