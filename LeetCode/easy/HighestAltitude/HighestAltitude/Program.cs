using System;
using System.Linq;

namespace HighestAltitude
{
    // link - https://leetcode.com/problems/find-the-highest-altitude/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(LargestAltitude(new int[] { -5, 1, 5, 0, -7 }));
        }

        public static int LargestAltitude(int[] gain)
        {
            int high = 0, runningSum = 0;
            foreach (int num in gain)
            {
                runningSum += num;
                if (runningSum > high) high = runningSum;
            }

            return high;
        }
    }
}