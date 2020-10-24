using System;
using System.Globalization;

namespace Day11_2dArrays
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/30-2d-arrays/problem
        private static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    int tempSum = 0;
                    tempSum += arr[i][k] + arr[i][k + 1] + arr[i][k + 2];
                    tempSum += arr[i + 1][k + 1];
                    tempSum += arr[i + 2][k] + arr[i + 2][k + 1] + arr[i + 2][k + 2];
                    if (tempSum > sum || i == 0 && k == 0) sum = tempSum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}