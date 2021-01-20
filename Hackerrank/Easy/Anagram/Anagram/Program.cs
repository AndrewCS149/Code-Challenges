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
            int count = 0;
            string str1 = s.Substring(0, s.Length / 2);
            string str2 = s.Substring(s.Length / 2);

            string alpha = "abcdefghijklmnopqrstuvwxyz";
            int[] arr = new int[26];

            foreach (char ch in str1)
                arr[alpha.IndexOf(ch)]++;

            foreach (char ch in str2)
            {
                int idx = alpha.IndexOf(ch);
                if (arr[idx] > 0) arr[idx]--;
                else count++;
            }
            return count;
        }
    }
}