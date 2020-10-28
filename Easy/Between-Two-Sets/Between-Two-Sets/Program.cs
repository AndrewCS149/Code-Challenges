using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Between_Two_Sets
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/between-two-sets/problem
        private static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = Result.getTotalX(arr, brr);

            Console.WriteLine(total);
        }
    }

    internal class Result
    {
        /*
         * Complete the 'getTotalX' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts following parameters:
iu gu i          *  2. INTEGER_ARRAY b
         */

        public static int getTotalX(List<int> a, List<int> b)
        {
            int count = 0;
            for (int i = a.Last(); i <= b.First(); i++)
                count += Factor(i, a, b);

            return count;
        }

        public static int Factor(int num, List<int> list1, List<int> list2)
        {
            foreach (int val in list2)
                if (val % num != 0) return 0;

            foreach (int val in list1)
                if (num % val != 0) return 0;

            return 1;
        }
    }
}