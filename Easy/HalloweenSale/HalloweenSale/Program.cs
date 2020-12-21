using System;

namespace HalloweenSale
{
    internal class Program
    {
        // easy

        // link to challenge - https://www.hackerrank.com/challenges/halloween-sale/problem
        private static void Main(string[] args)
        {
            string[] pdms = Console.ReadLine().Split(' ');

            int p = Convert.ToInt32(pdms[0]);

            int d = Convert.ToInt32(pdms[1]);

            int m = Convert.ToInt32(pdms[2]);

            int s = Convert.ToInt32(pdms[3]);

            int answer = howManyGames(p, d, m, s);

            Console.WriteLine(answer);
        }

        private static int howManyGames(int p, int d, int m, int s)
        {
            int games = 0;
            while (s >= p)
            {
                games++;
                s -= p;
                p = Math.Max(p - d, m);
            }
            return games;
        }
    }
}