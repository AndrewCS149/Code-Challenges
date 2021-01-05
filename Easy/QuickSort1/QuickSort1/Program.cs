using System;
using System.Collections.Generic;

namespace QuickSort1
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/quicksort1/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int[] result = quickSort(arr);

            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] quickSort(int[] arr)
        {
            int pivot = arr[0];
            List<int> first = new List<int>();
            List<int> last = new List<int>();
            Array.ForEach(arr, x =>
            {
                if (x <= pivot) first.Add(x);
                else last.Add(x);
            });

            first.AddRange(last);
            arr = first.ToArray();
            return arr;
        }
    }
}