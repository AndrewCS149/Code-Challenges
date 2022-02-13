using System;
using System.Collections;
using System.Collections.Generic;

namespace Anagram
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/anagram/problem
        private static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = Anagram(s);

                Console.WriteLine(result);
            }
        }

        private static int Anagram(string s)
        {
            if (s.Length % 2 == 1) return -1;

            string str1 = s.Substring(0, s.Length / 2);
            string str2 = s.Substring(str1.Length + 1);

            List<char> list = new List<char>(str1);
            foreach (char ch in str2)
                if (list.Contains(ch)) list.Remove(ch);

            return list.Count;
        }
    }
}