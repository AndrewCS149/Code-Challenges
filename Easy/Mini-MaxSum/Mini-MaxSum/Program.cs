using System;
using System.Dynamic;

namespace Mini_MaxSum
{
    internal class Program
    {
        // Easy
        // Link to challenge - https://www.hackerrank.com/challenges/mini-max-sum/problem
        private static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
;
            miniMaxSum(arr);
        }

        // Complete the miniMaxSum function below.
        private static void miniMaxSum(int[] arr)
        {
            long min = arr[0], max = arr[0], totalSum = 0, maxSum, minSum;

            foreach (int num in arr)
            {
                if (num < min) min = num;
                if (num > max) max = num;

                totalSum += num;
            }

            minSum = totalSum - max;
            maxSum = totalSum - min;

            Console.WriteLine($"{minSum} {maxSum}");
        }
    }
}