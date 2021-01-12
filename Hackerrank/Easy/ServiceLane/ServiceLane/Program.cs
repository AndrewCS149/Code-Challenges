using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLane
{
    // easy
    // link to challenge - https://www.hackerrank.com/challenges/service-lane/problem
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] nt = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nt[0]);

            int t = Convert.ToInt32(nt[1]);

            int[] width = Array.ConvertAll(Console.ReadLine().Split(' '), widthTemp => Convert.ToInt32(widthTemp))
            ;

            int[][] cases = new int[t][];

            for (int i = 0; i < t; i++)
            {
                cases[i] = Array.ConvertAll(Console.ReadLine().Split(' '), casesTemp => Convert.ToInt32(casesTemp));
            }

            int[] result = serviceLane(width, cases);
            Array.ForEach(result, x => Console.WriteLine(x));
            Console.WriteLine(result);
        }

        private static int[] serviceLane(int[] width, int[][] cases)
        {
            int[] answers = new int[cases.Length];
            for (int i = 0; i < cases.Length; i++)
                answers[i] = new ArraySegment<int>(width, cases[i][0], cases[i][1] - cases[i][0] + 1).Min();

            return answers;
        }
    }
}