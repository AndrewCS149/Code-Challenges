// https://practice.geeksforgeeks.org/problems/find-the-frequency/1

using System;

namespace FindTheFrequency
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(FindFrequency(new int[] { }, 1));
        }

        private static int FindFrequency(int[] arr, int x)
        {
            // no built in methods
            //int count = 0;
            //Array.ForEach(arr, n => { if (n == x) count++; });

            //return count;

            //built in method
            return arr.Count(n => n == x);
        }
    }
}
