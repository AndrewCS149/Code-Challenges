using System;

namespace Day5_Loops
{
    internal class Program
    {
        // easy
        // link to challenge https://www.hackerrank.com/challenges/30-loops/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}