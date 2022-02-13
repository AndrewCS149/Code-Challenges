using System;
using System.Linq;
using System.Threading;

namespace ShuffleArray
{
    // link - https://leetcode.com/problems/shuffle-the-array/submissions/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] Shuffle(int[] nums, int n)
        {
            int[] res = new int[nums.Length];
            for (int i = 0, k = 0; k < n; i += 2, k++)
            {
                res[i] = nums[k];
                res[i + 1] = nums[n + k];
            }

            return res;
        }
    }
}