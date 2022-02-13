using System;
using System.Collections.Generic;

namespace Missing_Number
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = new int[99];
            for (int i = 0, k = 1; i < 99; i++, k++)
            {
                if (i == 45) k++;
                arr[i] = k;
            }

            int result = MissingNum(arr);
            Console.WriteLine(result);
        }

        public static int MissingNum(int[] arr)
        {
            int[] tmp = new int[100];

            for (int i = 0; i < arr.Length; i++)
                tmp[arr[i] - 1] = 1;

            return Array.IndexOf(tmp, 0) + 1;
        }
    }
}