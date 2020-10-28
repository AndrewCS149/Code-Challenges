using System;

namespace Day16_Exceptions_StringToInteger
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/30-exceptions-string-to-integer/problem
        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(int.Parse(Console.ReadLine()));
            }
            catch
            {
                Console.WriteLine("Bad String");
            }
        }
    }
}