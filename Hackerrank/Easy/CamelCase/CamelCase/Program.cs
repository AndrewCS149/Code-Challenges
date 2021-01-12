using System;
using System.Text.RegularExpressions;

namespace CamelCase
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/camelcase/problem
        private static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int result = camelcase(s);

            Console.WriteLine(result);
        }

        private static int camelcase(string s)
        {
            return Regex.Split(s, $"[A-Z]").Length;
        }
    }
}