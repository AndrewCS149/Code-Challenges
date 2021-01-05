using System;
using System.Collections.Generic;

namespace CountingSort1
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/countingsort1/problem
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
            int[] newArr = new int[100];
            Array.ForEach(arr, x => newArr[x]++);
            return newArr;
        }
    }
}