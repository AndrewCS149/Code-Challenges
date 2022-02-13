using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberOfGoodPairs
{
    internal class Program
    {
        // easy
        // link to challenge - https://leetcode.com/problems/number-of-good-pairs/
        private static void Main(string[] args)
        {
            Console.WriteLine(NumIdenticalPairs(new int[] { 1, 2, 3, 1, 1, 3 }));
        }

        public static int NumIdenticalPairs(int[] nums)
        {
            // NOT MY SOLUTION
            int pairs = 0;
            int[] count = new int[101];
            foreach (int num in nums)
                pairs += count[num]++;

            return pairs;
        }
    }
}