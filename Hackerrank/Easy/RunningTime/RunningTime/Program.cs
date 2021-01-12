using System;

namespace RunningTime
{
    // easy
    // link to challenge - https://www.hackerrank.com/challenges/runningtime/problem
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = runningTime(arr);
        }

        // THIS SOLUTION WAS PARTIALLY DERIVED FROM AN ONLINE SOURCE
        private static int runningTime(int[] arr)
        {
            int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                    count++;
                }
                arr[j + 1] = key;
            }

            return count;
        }
    }
}