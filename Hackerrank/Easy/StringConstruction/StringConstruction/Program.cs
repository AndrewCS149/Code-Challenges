using System;
using System.Collections.Generic;

namespace StringConstruction
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/string-construction/problem
        private static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = stringConstruction(s);

                Console.WriteLine(result);
            }
        }

        private static int stringConstruction(string s)
        {
            HashSet<char> set = new HashSet<char>();

            foreach (char ch in s)
            {
                set.Add(ch);
            }

            return set.Count;
        }
    }
}