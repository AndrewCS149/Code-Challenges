using System;

namespace SherlockAndSquares
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/sherlock-and-squares/problem
        private static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] ab = Console.ReadLine().Split(' ');

                int a = Convert.ToInt32(ab[0]);

                int b = Convert.ToInt32(ab[1]);

                int result = squares(a, b);

                Console.WriteLine(result);
            }
        }

        private static int squares(int a, int b)
        {
            int count = 0;
            //for (int i = a; i <= b; i++)
            //{
            //    for (int k = 1; k <= i / 2; k++)
            //        if (k * k == i) count++;
            //}

            // NOT MY SOLUTION
            int start = (int)Math.Ceiling(Math.Sqrt(a));
            int end = (int)Math.Floor(Math.Sqrt(b));
            return end - start + 1;
        }
    }
}