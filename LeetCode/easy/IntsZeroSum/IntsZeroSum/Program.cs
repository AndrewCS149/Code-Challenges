using System;

namespace IntsZeroSum
{
    // https://leetcode.com/problems/find-n-unique-integers-sum-up-to-zero/submissions/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] SumZero(int n)
        {
            int mid = n / 2;
            int[] arr = new int[n];

            for (int i = 0; i < mid; i++)
            {
                arr[i] = i - mid;
                arr[n - 1 - i] = mid - i;
            }

            return arr;
        }
    }
}
