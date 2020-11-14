using System;
using System.Collections.Generic;
using System.Globalization;

namespace FindDigits
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/find-digits/problem
        private static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = findDigits(n);

                Console.WriteLine(result);
            }
        }

        private static int findDigits(int n)
        {
            int divisors = 0;
            foreach (var item in n.ToString().ToCharArray())
            {
                int num = (int)CharUnicodeInfo.GetNumericValue(item);
                if (num == 0) continue;

                if (n % num == 0) divisors++;
            }
            return divisors;
        }
    }
}