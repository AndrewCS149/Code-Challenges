using System;
using System.Collections.Generic;
using System.Linq;

namespace Day26_NestedLogic
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/30-nested-logic/problem?utm_campaign=30_days_of_code_continuous&utm_medium=email&utm_source=daily_reminder
        private static void Main(string[] args)
        {
            int[] returnDate = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] expectedDate = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            int fine = 0;
            if (returnDate[2] < expectedDate[2])
                fine = 0;
            else
            {
                if (returnDate[2] > expectedDate[2])
                    fine = 10000;
                else if (returnDate[1] > expectedDate[1])
                    fine = 500 * (returnDate[1] - expectedDate[1]);
                else if (returnDate[0] > expectedDate[0])
                    fine = 15 * (returnDate[0] - expectedDate[0]);
            }

            Console.WriteLine(fine);
        }
    }
}