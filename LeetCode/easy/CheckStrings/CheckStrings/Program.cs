using System;

namespace CheckStrings
{
    // link - https://leetcode.com/problems/check-if-two-string-arrays-are-equivalent/
    internal class Program
    {
        private static void Main(string[] args)
        {
            var arr = new string[] { "abc", "def" };

            Console.WriteLine(string.Join(",", arr));
        }

        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            return string.Join(",", word1) == string.Join(",", word2) ? true : false;
        }
    }
}