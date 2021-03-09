using System;
using System.Collections.Generic;
using System.Linq;

namespace SumOfOddSubarrays
{
    // link - https://leetcode.com/problems/sum-of-all-odd-length-subarrays/
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = { 1, 4, 2, 5, 3 };
            Console.WriteLine(SumOddLengthSubarrays(arr));
        }

        public static int SumOddLengthSubarrays(int[] arr)
        {
            int sum = 0;
            for (int i = 1; i <= arr.Length; i += 2)
            {
                int tmpSum = 0;
                for (int k = 0; k <= arr.Length - i; k++)
                    tmpSum += arr.ToList().GetRange(k, i).Sum();

                sum += tmpSum;
            }

            return sum;
        }
    }
}