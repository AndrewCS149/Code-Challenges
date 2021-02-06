using System;

namespace ArraysLeftRotation
{
    internal class Program
    {
        // link - https://www.hackerrank.com/challenges/ctci-array-left-rotation/problem?h_l=interview&playlist_slugs%5B%5D%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D%5B%5D=arrays
        private static int[] rotLeft(int[] a, int d)
        {
            // ONLINE SOLUTION
            int[] newArr = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
                newArr[(i + (a.Length - d)) % a.Length] = a[i];

            return newArr;
        }

        private static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int[] result = rotLeft(a, d);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}