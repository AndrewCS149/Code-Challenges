using System;

namespace VeryBigSum
{
    internal class Program
    {
        // link to challenge - https://www.hackerrank.com/challenges/a-very-big-sum/problem
        private static void Main(string[] args)
        {
        }

        private static long aVeryBigSum(long[] ar)
        {
            long sum = 0;
            foreach (long num in ar)
                sum += num;

            return sum;
        }
    }
}