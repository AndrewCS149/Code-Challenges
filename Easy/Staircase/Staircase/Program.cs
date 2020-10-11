using System;

namespace Staircase
{
    internal class Program
    {
        // link to challenge - https://www.hackerrank.com/challenges/staircase/problem?h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
        private static void Main(string[] args)
        {
            staircase(5);
        }

        private static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
                Console.WriteLine(new string('#', i).PadLeft(5, ' '));
        }

        /*
         Solution derived from online forums
         */
    }
}