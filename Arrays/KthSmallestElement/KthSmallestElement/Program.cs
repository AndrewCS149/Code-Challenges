// https://practice.geeksforgeeks.org/problems/kth-smallest-element5635/1

using System;

namespace KthSmallestElement
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] test = new int[] { 7, 10, 4, 3, 20, 15 };
            Console.WriteLine(KthSmallest(test, 3));
        }

        private static int KthSmallest(int[] arr, int k)
        {
            if (k >= arr.Length)
                return -1;

            // wihtout built in methods
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

            //    if (i == k)
            //        return arr[i - 1];
            //}

            // using built in methods
            var sorted = arr.ToList();
            sorted.Sort();
            return sorted[k - 1];

            //return 0;
        }
    }
}
