using System;
using System.Collections.Generic;
using System.Linq;

namespace ManasaAndStones
{
    // easy
    // link to challenge - https://www.hackerrank.com/challenges/manasa-and-stones/problem
    internal class Program
    {
        private static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int TItr = 0; TItr < T; TItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int a = Convert.ToInt32(Console.ReadLine());

                int b = Convert.ToInt32(Console.ReadLine());

                int[] result = stones(n, a, b);

                Console.WriteLine(string.Join(" ", result));
            }
        }

        private static int[] stones(int n, int a, int b)
        {
            List<int> list = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                int sum = a * (i - 1);
                sum += (n - i) * b;
                if (!list.Contains(sum)) list.Add(sum);
            }

            list.Sort();
            return list.ToArray();
        }
    }
}