using System;
using System.Collections.Generic;

namespace CountingSort2
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/countingsort2/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] result = countingSort(arr);

            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] countingSort(int[] arr)
        {
            int[] range = new int[100];
            Array.ForEach(arr, x => range[x]++);
            List<int> list = new List<int>();

            for (int i = 0; i < range.Length; i++)
            {
                for (int k = 0; k < range[i]; k++)
                {
                    list.Add(i);
                }
            }

            return list.ToArray();
        }
    }
}