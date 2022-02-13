using System;

namespace MinimumTime
{
    // link https://leetcode.com/problems/minimum-time-visiting-all-points/

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[][] jagArr =
            {
                new int[] {1, 1 },
                new int[] {3, 4 },
                new int[] {-1, 0 }
            };

            Console.WriteLine(MinTimeToVisitAllPoints(jagArr));
        }

        public static int MinTimeToVisitAllPoints(int[][] points)
        {
            // ONLINES SOLUTION
            int seconds = 0;
            for (int i = 1; i < points.Length; i++)
            {
                int[] cur = points[i], prev = points[i - 1];
                seconds += Math.Max(Math.Abs(cur[0] - prev[0]), Math.Abs(cur[1] - prev[1]));
            }

            return seconds;
        }
    }
}