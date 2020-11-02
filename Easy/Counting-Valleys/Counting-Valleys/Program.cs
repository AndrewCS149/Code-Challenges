using System;

namespace Counting_Valleys
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/counting-valleys/problem
        private static void Main(string[] args)
        {
            int steps = Convert.ToInt32(Console.ReadLine().Trim());

            string path = Console.ReadLine();

            int result = Result.countingValleys(steps, path);

            Console.WriteLine(result);
        }
    }

    internal class Result
    {
        /*
         * Complete the 'countingValleys' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
         *  1. INTEGER steps
         *  2. STRING path
         */

        public static int countingValleys(int steps, string path)
        {
            int elev = 0, valleys = 0;
            bool inValley = false;
            foreach (var item in path)
            {
                elev = item == 'U' ? ++elev : --elev;

                if (elev < 0) inValley = true;
                else if (inValley == true && elev == 0)
                {
                    valleys++;
                    inValley = false;
                }
            }

            return valleys;
        }
    }
}