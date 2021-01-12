using System;
using System.Collections.Generic;

namespace Pangrams
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/pangrams/problem
        private static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = pangrams(s);

            Console.WriteLine(result);
        }

        private static string pangrams(string s)
        {
            //string str = "pangram";
            //s = s.ToLower();
            //foreach (char ch in "abcdefghijklmnopqrstuvwxyz")
            //{
            //    if (!s.Contains(ch))
            //    {
            //        str = "not pangram";
            //        break;
            //    }
            //}

            HashSet<char> hSet = new HashSet<char>();
            s = s.Replace(" ", "").ToLower();
            foreach (char ch in s)
                hSet.Add(ch);

            Console.WriteLine(hSet.Count);
            return hSet.Count == 26 ? "pangram" : "not pangram";
        }
    }
}