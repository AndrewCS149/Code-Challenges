using System;
using System.Collections.Generic;

namespace AlternatingCharacters
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/alternating-characters/problem
        private static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = alternatingCharacters(s);

                Console.WriteLine(result);
            }
        }

        private static int alternatingCharacters(string s)
        {
            if (s.Length == 1) return 0;

            int count = 0;
            for (int i = 1; i < s.Length; i++)
                if (s[i] == s[i - 1]) count++;

            return count;
        }
    }
}