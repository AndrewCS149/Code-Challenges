using System;
using System.Collections.Generic;

namespace DavisStaircase
{
    class Program
    {
        // link - https://www.hackerrank.com/challenges/ctci-recursive-staircase/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=recursion-backtracking

        private static Dictionary<int, int> cache = new Dictionary<int, int>();
        static int stepPerms(int n)
        {
            // NOT MY SOLUTION
            if (n < 0) return 0;
            if (n == 0) return 1;

            if (!cache.ContainsKey(n))
            {
                int count = stepPerms(n - 1) + stepPerms(n - 2) + stepPerms(n - 3);
                cache.Add(n, count);
            }
            return cache[n];
        }

        static void Main(string[] args)
        {
            int s = Convert.ToInt32(Console.ReadLine());

            for (int sItr = 0; sItr < s; sItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int res = stepPerms(n);

                Console.WriteLine(res);
            }
        }
    }
}
