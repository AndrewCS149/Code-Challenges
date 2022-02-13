using System;
using System.Collections;

namespace CheckPermutation
{
    internal class Program
    {
        /*
         Check Permutation
        Given two strings, determine if one is a permutation of the other
         */

        private static void Main(string[] args)
        {
            Console.WriteLine(IsPermutation("aaab", "aaax"));
            Console.WriteLine(IsPermutation("dad", "dda"));
            Console.WriteLine(IsPermutation("aaab", "aaba"));
            Console.WriteLine(IsPermutation("abc", "abd"));
            Console.WriteLine(IsPermutation("x", "x"));
            Console.WriteLine(IsPermutation("aaabbcccdaabcd", "dcbaadccccbbaaa"));
            Console.WriteLine(IsPermutation("abcdefghijklmnopqrstuvwxyzabcdefghijklmnopqrstuvwxyz", "zyxwvutsrqponmlkjihgfedcbazyxwvutsrqponmlkjihgfedcba"));
        }

        public static bool IsPermutation(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;

            //var arr1 = str1.ToCharArray();
            //Array.Sort(arr1);

            //var arr2 = str2.ToCharArray();
            //Array.Sort(arr2);

            //return new string(arr1) != new string(arr2) ? false : true;

            Stack stack = new Stack(str1.ToCharArray());
            foreach (char ch in str1)
                if (str2.Contains(ch)) stack.Pop();

            return stack.Count == 0 ? true : false;
        }
    }
}