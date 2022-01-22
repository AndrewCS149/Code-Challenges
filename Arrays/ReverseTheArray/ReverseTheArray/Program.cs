// https://practice.geeksforgeeks.org/problems/reverse-a-string/1
using System;

namespace ReverseTheArray
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] test1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Array.ForEach(ReverseArray(test1), num => Console.Write(num + " "));
            Console.WriteLine();

            Array.ForEach(ReverseArray(new int[] { }), num => Console.Write(num + " "));
        }

        private static int[] ReverseArray(int[] arr)
        {
            // check for empty array
            if (arr.Length == 0)
                return arr;

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int tmp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = tmp;
            }

            return arr;
        }
    }
}
