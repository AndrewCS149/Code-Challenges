using System;

namespace TaumAndBday
{
    internal class Program
    {
        // easy

        // link to challenge - https://www.hackerrank.com/challenges/taum-and-bday/problem
        private static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int b = Convert.ToInt32(firstMultipleInput[0]);

                int w = Convert.ToInt32(firstMultipleInput[1]);

                string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int bc = Convert.ToInt32(secondMultipleInput[0]);

                int wc = Convert.ToInt32(secondMultipleInput[1]);

                int z = Convert.ToInt32(secondMultipleInput[2]);

                long result = taumBday(b, w, bc, wc, z);

                Console.WriteLine(result);
            }
        }

        /*
         * Complete the 'taumBday' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER b
         *  2. INTEGER w
         *  3. INTEGER bc
         *  4. INTEGER wc
         *  5. INTEGER z
         */

        // HELP FROM DISCUSSION POST
        public static long taumBday(int b, int w, int bc, int wc, int z)
        {
            long black = bc < wc + z ? bc : wc + z;
            long white = wc < bc + z ? wc : bc + z;
            return (b * black) + (w * white);
        }
    }
}