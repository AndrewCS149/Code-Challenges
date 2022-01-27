// https://leetcode.com/problems/longest-palindromic-substring/

using System;

namespace LongestPalindromicSubstring
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string tmp = "a";
            string tmp2 = "baboo";

            Console.WriteLine(LongestPalindrome(tmp));
            Console.WriteLine(LongestPalindrome(tmp2));

        }

        public static string LongestPalindrome(string s)
        {
            string palindrome = "";

            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    string tmp = s.Substring(i, j + 1 - i);
                    char[] arr = tmp.ToCharArray().Reverse().ToArray();
                    string tmpReverse = new string(arr);

                    if (tmp == tmpReverse)
                    {
                        if (tmp.Length > palindrome.Length)
                            palindrome = tmp;
                    }

                }
            }

            return palindrome;
        }
    }
}

/*
 
input -> "doodfor"
output <- "dood"

d o o d f o r

 
*/
