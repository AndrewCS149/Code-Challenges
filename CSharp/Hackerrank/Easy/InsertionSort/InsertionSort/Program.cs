using System;

namespace InsertionSort
{
    // easy
    // link to challenge - https://www.hackerrank.com/challenges/insertionsort1/problem
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            insertionSort1(n, arr);
        }

        private static void insertionSort1(int n, int[] arr)
        {
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
                Array.ForEach(arr, x => Console.Write(x + " "));
                Console.WriteLine();
            }
        }
    }
}