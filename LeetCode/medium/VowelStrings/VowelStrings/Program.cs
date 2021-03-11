using System;

namespace VowelStrings
{
    // link - https://leetcode.com/problems/count-sorted-vowel-strings/submissions/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int CountVowelStrings(int n)
        {
            // not my solution.
            return (n + 1) * (n + 2) * (n + 3) * (n + 4) / 24;
        }
    }
}