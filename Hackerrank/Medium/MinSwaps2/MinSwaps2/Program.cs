using System;

namespace MinSwaps2
{
    internal class Program
    {
        // link - https://www.hackerrank.com/challenges/minimum-swaps-2/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        private static int minimumSwaps(int[] arr)
        {
            // NOT MY SOLUTION, ONLINE
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (i + 1 != arr[i])
                {
                    int t = i;
                    while (arr[t] != i + 1)
                        t++;

                    int tmp = arr[t];
                    arr[t] = arr[i];
                    arr[i] = tmp;
                    count++;
                }
            }
            return count;
        }

        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int res = minimumSwaps(arr);

            Console.WriteLine(res);
        }
    }
}