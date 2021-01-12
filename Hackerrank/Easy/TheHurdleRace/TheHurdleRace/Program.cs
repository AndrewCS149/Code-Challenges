using System;
using System.Linq;

namespace TheHurdleRace
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/the-hurdle-race/problem
        private static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
            ;
            int result = hurdleRace(k, height);

            Console.WriteLine(result);
        }

        /*
        input -> 4, [3, 3, 3, 4, 5]
        output -> 1

        input -> 3, [2, 1, 1, 2, 3]
        output -> 0

        edge cases:
            - no empty arrays
        */

        private static int hurdleRace(int k, int[] height)
        {
            int max = height.Max();
            return max > k ? max - k : 0;
        }
    }
}