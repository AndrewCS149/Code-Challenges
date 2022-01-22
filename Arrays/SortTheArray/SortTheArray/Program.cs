// https://practice.geeksforgeeks.org/problems/sort-the-array0055/1

using System;

namespace SortTheArray
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Array.ForEach(SortArray(new int[] { 1, 5, 3, 2 }), num => Console.Write(num + " "));
            Console.WriteLine();

            Array.ForEach(SortArray(new int[] { 10, 9, 8, 7, 6, 288, 22, 99, 3, 2, 1, 0, -1 }), num => Console.Write(num + " "));
            Console.WriteLine();
        }

        private static int[] SortArray(int[] arr)
        {
            if (arr.Length <= 1)
                return arr;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tmp;
                    }
                }
            }

            return arr;
        }
    }
}
