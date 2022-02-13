using System;
using System.Collections.Generic;

namespace Two_Strings
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/two-strings/problem
        private static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s1 = Console.ReadLine();

                string s2 = Console.ReadLine();

                string result = twoStrings(s1, s2);

                Console.WriteLine(result);
            }
        }

        private static string twoStrings(string s1, string s2)
        {
            HashSet<char> set = new HashSet<char>();
            foreach (char ch in s1)
                set.Add(ch);

            foreach (char ch in s2)
                if (set.Contains(ch)) return "YES";

            return "NO";
        }
    }
}