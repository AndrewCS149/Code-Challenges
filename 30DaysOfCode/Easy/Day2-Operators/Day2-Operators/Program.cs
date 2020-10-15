using System;

namespace Day2_Operators
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/30-operators/problem
        private static void Main(string[] args)
        {
            solve(12, 20, 8);
        }

        private static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            decimal tip = (decimal)meal_cost * ((decimal)tip_percent / 100);
            decimal tax = (decimal)meal_cost * ((decimal)tax_percent / 100);
            decimal total = (decimal)meal_cost + tip + tax;
            Console.WriteLine(Math.Round(total));
        }
    }
}