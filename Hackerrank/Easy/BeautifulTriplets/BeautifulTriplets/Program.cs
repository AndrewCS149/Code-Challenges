using System;
using System.Collections.Generic;

namespace BeautifulTriplets
{
    // easy
    // link to challenge - https://www.hackerrank.com/challenges/beautiful-triplets/problem
    internal class Program
    {
        private static int beautifulTriplets(int d, int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                List<int> trip = new List<int>();
                trip.Add(arr[i]);
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > trip[trip.Count - 1] && arr[j] - trip[trip.Count - 1] == d)
                    {
                        trip.Add(arr[j]);
                        if (trip.Count == 3) count++;
                    }
                }
            }

            return count;
        }

        private static void Main(string[] args)
        {
            string[] nd = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nd[0]);

            int d = Convert.ToInt32(nd[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = beautifulTriplets(d, arr);

            Console.WriteLine(result);
        }
    }
}