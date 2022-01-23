// https://practice.geeksforgeeks.org/problems/subarray-with-given-sum-1587115621/1

using System;

namespace SubarrayWithSum
{
    public class Program
    {
        private static void Main(string[] args)
        {
            SubarraySum(new int[] { 1, 2, 3, 7, 5 }, 12).ForEach(n => Console.Write(n + "  "));
        }

        private static List<int> SubarraySum(int[] arr, int s)
        {
            // nested loop
            //var result = new List<int>();

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int sum = 0;
            //    for (int j = i; j < arr.Length; j++)
            //    {
            //        sum += arr[j];
            //        if (sum == s)
            //        {
            //            result.Add(i + 1);
            //            result.Add(j + 1);
            //            return result;
            //        }
            //    }
            //}

            //result.Add(-1);
            //return result;

            // single loop
            int start = 0;
            int sum = arr[0];

            for (int i = 1; i <= arr.Length; i++)
            {
                while (sum > s && start < i - 1)
                    sum -= arr[start++];

                if (sum == s)
                    return new List<int> { ++start, i };

                if (i < arr.Length)
                    sum += arr[i];
            }

            return new List<int> { -1 };
        }
    }
}
