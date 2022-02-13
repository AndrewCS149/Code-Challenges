using System;

namespace ArrayPartition
{
    // https://leetcode.com/problems/array-partition-i/submissions/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int ArrayPairSum(int[] nums)
        {
            Array.Sort(nums);
            int max = 0;
            for (int i = nums.Length - 1; i > 0; i -= 2)
                max += Math.Min(nums[i], nums[i - 1]);

            return max;
        }
    }
}