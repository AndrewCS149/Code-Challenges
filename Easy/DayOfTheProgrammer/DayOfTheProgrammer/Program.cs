using System;

namespace DayOfTheProgrammer
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/day-of-the-programmer/problem
        private static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine().Trim());

            string result = dayOfProgrammer(year);

            Console.WriteLine(result);
        }

        private static string dayOfProgrammer(int year)
        {
            string date = "";
            if (year < 1918)
            {
                if (year % 4 == 0)
                {
                    date = $"13.09.{year}";
                }
                else
                {
                    date = $"13.08.{year}";
                }
            }
            else if (year > 1918)
            {
                if (year % 400 == 0)
                {
                    date = $"13.09.{year}";
                }
                else if (year % 4 == 0 && year % 100 != 0)
                {
                    date = $"13.09.{year}";
                }
                else
                {
                    date = $"13.09.{year}";
                }
            }
            else
            {
                date = $"26.09.{year}";
            }
            return date;
        }
    }
}