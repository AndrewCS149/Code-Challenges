using System;

namespace IceCreamParlor
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/icecream-parlor/problem
        private static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int m = Convert.ToInt32(Console.ReadLine());

                int n = Convert.ToInt32(Console.ReadLine());

                int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
                ;
                int[] result = icecreamParlor(m, arr);

                Console.WriteLine(string.Join(" ", result));
            }
        }

        private static int[] icecreamParlor(int m, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    if (arr[i] + arr[k] == m && i != k)
                        return new int[] { ++i, ++k };
                }
            }
            return new int[] { -1, -1 };
        }
    }
}