using System;

namespace Day3_IntroConditionalStatements
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/30-conditional-statements/problem
        private static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            if (N % 2 == 1 || (N % 2 == 0 && N >= 6 && N <= 20))
                Console.WriteLine("Weird");
            else if (N >= 2 && N <= 5 || N > 20)
                Console.WriteLine("Not Weird");
        }
    }
}