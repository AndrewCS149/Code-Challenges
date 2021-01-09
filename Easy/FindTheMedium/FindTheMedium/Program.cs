using System;

namespace FindTheMedium
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/find-the-median/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = findMedian(arr);

            Console.WriteLine(result);
        }

        private static int findMedian(int[] arr)
        {
            Array.Sort(arr);
            return arr[arr.Length / 2];
        }
    }
}