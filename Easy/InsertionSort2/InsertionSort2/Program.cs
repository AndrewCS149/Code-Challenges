using System;

namespace InsertionSort2
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/insertionsort2/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            insertionSort2(n, arr);
        }

        private static void insertionSort2(int n, int[] arr)
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