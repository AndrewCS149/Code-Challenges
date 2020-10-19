using System;
using System.Collections.Generic;

namespace Day6_LetsReview
{
    internal class Program
    {
        // easy
        // link to challenge https://www.hackerrank.com/challenges/30-review-loop/problem
        private static void Main(string[] args)
        {
            int count = Int32.Parse(Console.ReadLine());
            List<string> words = new List<string>();

            while (count-- > 0)

            {
                string str = Console.ReadLine();
                string word = PrintWords(str);
                words.Add(word);
            }

            foreach (string str in words)
                Console.WriteLine(str);
        }

        public static string PrintWords(string str)
        {
            string even = "";
            string odd = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0)
                    even += str[i];
                else
                    odd += str[i];
            }

            return even + " " + odd;
        }
    }
}