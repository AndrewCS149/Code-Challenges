using System;

namespace ReverseWordInString
{
    internal class Program
    {
        // https://leetcode.com/problems/reverse-words-in-a-string-iii/
        private static void Main(string[] args)
        {
            string s = "Let's take LeetCode contest";
            Console.WriteLine(ReverseWords(s));
        }

        public static string ReverseWords(string s)
        {
            string[] words = s.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                string reverse = "";
                foreach (char ch in words[i])
                    reverse = ch + reverse;

                words[i] = reverse;
            }

            return string.Join(" ", words);
        }
    }
}