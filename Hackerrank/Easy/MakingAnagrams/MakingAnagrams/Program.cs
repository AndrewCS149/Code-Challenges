using System;

namespace MakingAnagrams
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/making-anagrams/problem
        private static void Main(string[] args)
        {
            string s1 = Console.ReadLine();

            string s2 = Console.ReadLine();

            int result = makingAnagrams(s1, s2);

            Console.WriteLine(result);
        }

        private static int makingAnagrams(string s1, string s2)
        {
            int count = 0;
            string minStr = s1.Length < s2.Length ? s1 : s2;
            string maxStr = s2.Length > s1.Length ? s2 : s1;

            for (int i = 0; i < minStr.Length; i++)
            {
                if (maxStr.Contains(minStr[i]))
                {
                    maxStr = maxStr.Remove(maxStr.IndexOf(minStr[i]), 1);
                    count += 2;
                }
            }

            return s1.Length + s2.Length - count;
        }
    }
}