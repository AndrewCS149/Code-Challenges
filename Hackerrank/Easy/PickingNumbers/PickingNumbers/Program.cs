using System;
using System.Collections.Generic;
using System.Linq;

namespace PickingNumbers
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/picking-numbers/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            int result = Result.pickingNumbers(a);

            Console.WriteLine(result);
        }
    }

    internal class Result
    {
        /*
         * Complete the 'pickingNumbers' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY a as parameter.
         */

        /*
        input -> 4, 4, 3, 3, 1
        output -> 4

        edge cases:
            - no subarray meets criteria?
        */

        public static int pickingNumbers(List<int> a)
        {
            int count = 1;
            a.Sort();
            for (int i = 0; i < a.Count; i++)
            {
                int tempCount = 1;
                for (int j = i + 1; j < a.Count; j++)
                    if (Math.Abs(a[i] - a[j]) <= 1) tempCount++;

                if (tempCount > count) count = tempCount;
            }
            return count;
        }
    }
}