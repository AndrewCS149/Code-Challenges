using System;

namespace ChocolateFeast
{
    // easy
    // link to challenge - https://www.hackerrank.com/challenges/chocolate-feast/problem
    internal class Program
    {
        private static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] ncm = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(ncm[0]);

                int c = Convert.ToInt32(ncm[1]);

                int m = Convert.ToInt32(ncm[2]);

                int result = chocolateFeast(n, c, m);

                Console.WriteLine(result);
            }
        }

        private static int chocolateFeast(int n, int c, int m)
        {
            int wrappers = n / c;
            int bars = n / c;
            while (wrappers >= m)
            {
                bars += wrappers / m;
                wrappers = (wrappers % m) + (wrappers / m);
            }
            return bars;
        }
    }
}