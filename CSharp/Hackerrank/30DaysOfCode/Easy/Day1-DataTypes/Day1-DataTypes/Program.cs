using System;

namespace Day1_DataTypes
{
    internal class Program
    {
        // Day 1 - Easy
        // Link to challenge - https://www.hackerrank.com/challenges/30-data-types/problem
        private static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";

            // Declare second integer, double, and String variables.
            int newInt;
            double newDouble;
            string newStr;

            // Read and save an integer, double, and String to your variables.
            newInt = Int32.Parse(Console.ReadLine());
            newDouble = Double.Parse(Console.ReadLine());
            newStr = Console.ReadLine();

            // Print the sum of both integer variables on a new line.
            Console.WriteLine(newInt + i);

            // Print the sum of the double variables on a new line.
            Console.WriteLine("{0:F1}", newDouble + d);

            // Concatenate and print the String variables on a new line
            Console.WriteLine(s + newStr);

            // The 's' variable above should be printed first.
        }
    }
}