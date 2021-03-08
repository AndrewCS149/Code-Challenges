using System;

namespace AllowedChars
{
    internal class Program
    {
        // link - https://leetcode.com/problems/count-the-number-of-consistent-strings/submissions/
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int CountConsistentStrings(string allowed, string[] words)
        {
            int count = 0;
            foreach (string item in words)
            {
                bool valid = true;
                foreach (char ch in item)
                    if (!allowed.Contains(ch)) valid = false;

                if (valid) count++;
            }

            return count;
        }
    }
}