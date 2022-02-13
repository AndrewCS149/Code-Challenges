using System;
using System.Collections.Generic;
using System.Linq;

namespace _2D_Arrays
{
    internal class Program
    {
        // link - https://www.hackerrank.com/challenges/2d-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        private static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int result = hourglassSum(arr);

            Console.WriteLine(result);
        }

        private static int hourglassSum(int[][] arr)
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 1; k <= 4; k++)
                {
                    int top = arr[i - 1][k - 1] + arr[i - 1][k] + arr[i - 1][k + 1];
                    int mid = arr[i][k];
                    int btm = arr[i + 1][k - 1] + arr[i + 1][k] + arr[i + 1][k + 1];
                    list.Add(top + mid + btm);
                }
            }

            return list.Max();
        }
    }
}