// https://practice.geeksforgeeks.org/problems/sort-an-array-of-0s-1s-and-2s4231/1

using System;

namespace Sort012
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Array.ForEach(Sort(new int[] { 0, 2, 1, 2, 0 }), n => Console.Write(n + " "));
        }

        private static int[] Sort(int[] arr)
        {
            // no built in methods
            //if (arr.Length <= 1)
            //    return arr;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[j] < arr[i])
            //        {
            //            int tmp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = tmp;
            //        }
            //    }
            //}

            //return arr;

            // built in methods
            var sorted = arr.ToList();
            sorted.Sort();
            return sorted.ToArray();
        }
    }
}
