using System;

namespace Day29_BitwiseAND
{
    internal class Program
    {
        // medium
        // link to challenge - https://www.hackerrank.com/challenges/30-bitwise-and/problem?utm_campaign=30_days_of_code_continuous&utm_medium=email&utm_source=daily_reminder
        private static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int max = 0;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (i == j) continue;
                        var num = i & j;
                        if (num < k && num > max) max = num;
                    }
                }
                Console.WriteLine(max);
            }
        }
    }
}