using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BeautifulDaysAtTheMovies
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem
        private static void Main(string[] args)
        {
            string[] ijk = Console.ReadLine().Split(' ');

            int i = Convert.ToInt32(ijk[0]);

            int j = Convert.ToInt32(ijk[1]);

            int k = Convert.ToInt32(ijk[2]);

            int result = beautifulDays(i, j, k);

            Console.WriteLine(result);
        }

        private static int beautifulDays(int first, int last, int div)
        {
            int count = 0;
            for (int i = first; i <= last; i++)
            {
                if (Math.Abs(Reverse(i) - i) % div == 0) count++;
            }

            return count;
        }

        private static int Reverse(int n)
        {
            int reverse = 0;
            while (n > 0)
            {
                reverse = reverse * 10 + n % 10;
                n = n / 10;
            }
            return reverse;
        }
    }
}