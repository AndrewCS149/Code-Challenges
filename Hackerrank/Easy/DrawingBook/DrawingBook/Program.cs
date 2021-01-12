using System;

namespace DrawingBook
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/drawing-book/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int p = Convert.ToInt32(Console.ReadLine());

            int result = pageCount(n, p);

            Console.WriteLine(result);
        }

        /*
        Input -> 5, 3
        Output -> 1

        Input -> 5, 4
        Output -> 0

        INT front
        INT back
        BOOL isEven = n.isEven

        if isEven
            FOR i <= n + 1; i + 2
                front++

            FOR j >= n - 1; j - 2
                back++

        return min value
         */

        private static int pageCount(int n, int p)
        {
            // this fulfills all test cases
            //int totalPages = n / 2;
            //int frontTurns = p / 2;
            //int backTurns = totalPages - frontTurns;;
            //return frontTurns < backTurns ? frontTurns : backTurns;

            // this does not fullfill test case 26.
            return (n - p) > p ? p / 2 : (n - p) / 2;
        }
    }
}