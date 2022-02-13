using System;
using System.Collections.Generic;

namespace CompareTheTriplets
{
    internal class Program
    {
        /*
         Link to challenge - https://www.hackerrank.com/challenges/compare-the-triplets/problem
         */

        private static void Main(string[] args)
        {
            int[] arrA = { 1, 2, 3 };
            int[] arrB = { 3, 2, 1 };
            List<int> a = new List<int>(arrA);
            List<int> b = new List<int>(arrB);

            List<int> scores = compareTriplets(a, b);

            foreach (var item in scores)
            {
                Console.Write(item + ", ");
            }
        }

        private static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> scores = new List<int>();
            scores.Add(0);
            scores.Add(0);

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] < b[i])
                    scores[1]++;
                else if (a[i] > b[i])
                    scores[0]++;
            }

            return scores;
        }
    }
}