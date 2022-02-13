// https://practice.geeksforgeeks.org/problems/missing-number-in-array1416/1

using System;

namespace MissingNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] test1 = { 1, 2, 3, 5 };
            int[] test2 = { 6, 1, 2, 8, 3, 4, 7, 10, 5 };

            Console.WriteLine(MissingNumber(test1));
            Console.WriteLine(MissingNumber(test2));


        }

        private static int MissingNumber(int[] arr)
        {

            int[] arr2 = new int[arr.Length + 1];

            foreach (int num in arr)
                arr2[num - 1]++;

            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i] == 0)
                    return i + 1;
            }

            return -1;
        }
    }
}
