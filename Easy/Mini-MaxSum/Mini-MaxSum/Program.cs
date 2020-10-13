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
            long[] tempArr = new long[5];
            long min, max;

            for (int i = 0; i < arr.Length; i++)
            {
                long tempSum = 0;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        continue;
                    tempSum += arr[j];
                }
                tempArr[i] = tempSum;
            }

            min = tempArr[0];
            max = tempArr[0];

            foreach (long num in tempArr)
            {
                if (num < min) min = num;
                else max = num;
            }

            Console.WriteLine($"{min} {max}");
        }
    }
}