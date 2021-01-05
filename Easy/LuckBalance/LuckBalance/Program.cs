using System;
using System.Collections.Generic;
using System.Linq;

namespace LuckBalance
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/luck-balance/problem
        private static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[][] contests = new int[n][];

            for (int i = 0; i < n; i++)
            {
                contests[i] = Array.ConvertAll(Console.ReadLine().Split(' '), contestsTemp => Convert.ToInt32(contestsTemp));
            }

            int result = luckBalance(k, contests);

            Console.WriteLine(result);
        }

        private static int luckBalance(int k, int[][] contests)
        {
            List<int> list = new List<int>();
            int importants = 0, luckSum = 0;

            for (int i = 0; i < contests.Length; i++)
            {
                if (contests[i][1] == 1)
                {
                    importants++;
                    list.Add(contests[i][0]);
                }
                else luckSum += contests[i][0];
            }

            list.Sort();

            int diff = importants - k;
            bool lose = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (i >= diff) lose = true;

                if (lose) luckSum += list[i];
                else luckSum -= list[i];
            }

            return luckSum;
        }
    }
}