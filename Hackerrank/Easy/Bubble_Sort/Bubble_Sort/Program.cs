using System;

namespace Bubble_Sort
{
    internal class Program
    {
        // link - https://www.hackerrank.com/challenges/ctci-bubble-sort/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=sorting
        // Complete the countSwaps function below.
        private static void countSwaps(int[] a)
        {
            int swaps = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int k = 0; k < a.Length - 1; k++)
                {
                    if (a[k + 1] < a[k])
                    {
                        int tmp = a[k];
                        a[k] = a[k + 1];
                        a[k + 1] = tmp;
                        swaps++;
                    }
                }
            }

            Console.WriteLine($"Array is sorted in {swaps} swaps.\n" +
                               $"First Element: {a[0]}\n" +
                               $"Last Element: {a[a.Length - 1]}");
        }

        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            countSwaps(a);
        }
    }
}