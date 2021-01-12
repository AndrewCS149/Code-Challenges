using System;

namespace SimpleArraySum
{
    internal class Program
    {
        // link to challenge - https://www.hackerrank.com/challenges/simple-array-sum/problem
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private static int simpleArraySum(int[] ar)
        {
            int sum = 0;
            foreach (int num in ar)
                sum += num;

            return sum;
        }
    }
}