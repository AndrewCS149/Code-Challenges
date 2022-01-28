// https://leetcode.com/problems/longest-palindromic-substring/

using System;

namespace LongestPalindromicSubstring
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //string tmp = "a";
            string tmp2 = "babad";

            //Console.WriteLine(LongestPalindrome(tmp));
            Console.WriteLine(LongestPalindrome(tmp2));

        }

        public static string PalindromeCheck(int left, int right, string s, string palindrome)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                if (right - left + 1 > palindrome.Length)
                    palindrome = s.Substring(left, right + 1);

                left--;
                right++;
            }

            return palindrome;
        }



        public static string LongestPalindrome(string s)
        {
            // solution inspired from https://www.youtube.com/watch?v=XYQecbcd6_c
            string palindrome = "";

            for (int i = 0; i < s.Length; i++)
            {
                palindrome = PalindromeCheck(i, i, s, palindrome);
                palindrome = PalindromeCheck(i, i + 1, s, palindrome);
            }

            return palindrome;

            // my solution
            // O(n3)
            // Slow!
            //string palindrome = "";

            //for (int i = 0; i < s.Length; i++)
            //{
            //    for (int j = i; j < s.Length; j++)
            //    {
            //        bool isPalindrome = true;
            //        string tmp = s.Substring(i, j + 1 - i);

            //        for (int k = 0; k < tmp.Length / 2; k++)
            //        {
            //            if (tmp[k] != tmp[tmp.Length - 1 - k])
            //            {
            //                isPalindrome = false;
            //                break;
            //            }
            //        }


            //        if (isPalindrome)
            //        {
            //            if (tmp.Length > palindrome.Length)
            //                palindrome = tmp;
            //        }
            //    }
            //}

            //return palindrome;
        }
    }
}

/*
 
input -> "doodfor"
output <- "dood"

d o o d f o r

 
*/
