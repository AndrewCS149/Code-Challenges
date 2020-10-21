using System;

namespace Day9_Recursion_3
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/30-recursion/problem?h_r=email&unlock_token=492b07119dd8221d0b1c0d85b9fbe9f9d855d664&utm_campaign=30_days_of_code_continuous&utm_medium=email&utm_source=daily_reminder
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);

            Console.WriteLine(result);
        }

        // Complete the factorial function below.
        private static int factorial(int n)
        {
            return n <= 1 ? n : n * factorial(n - 1);
        }
    }
}