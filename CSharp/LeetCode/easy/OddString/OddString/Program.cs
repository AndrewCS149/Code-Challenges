using System;

namespace OddString
{
    class Program
    {
        // https://leetcode.com/problems/generate-a-string-with-characters-that-have-odd-counts/submissions/
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string GenerateTheString(int n)
        {
            string word = "";
            for (int i = 0; i < n; i++)
            {
                if (n % 2 == 0)
                {
                    if (i < n - 1) word += 'a';
                    else word += 'b';
                }
                else
                    word += 'a';
            }

            return word;
        }
    }
}
