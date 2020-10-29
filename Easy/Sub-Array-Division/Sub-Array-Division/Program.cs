using System;
using System.Collections.Generic;
using System.Linq;

namespace Sub_Array_Division
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/the-birthday-bar/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(dm[0]);

            int m = Convert.ToInt32(dm[1]);

            int result = birthday(s, d, m);

            Console.WriteLine(result);
        }

        private static int birthday(List<int> s, int d, int m)
        {
            int count = 0;
            for (int i = 0; i < s.Count; i++)
            {
                if (i + m > s.Count) break;

                int sum = 0;
                for (int j = i; j < i + m; j++)
                    sum += s[j];

                if (sum == d) count++;
            }
            return count;
        }
    }
}