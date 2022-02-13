using System;
using System.Collections.Generic;

namespace MarksCakewalk
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/marcs-cakewalk/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] calorie = Array.ConvertAll(Console.ReadLine().Split(' '), calorieTemp => Convert.ToInt32(calorieTemp))
            ;
            long result = marcsCakewalk(calorie);

            Console.WriteLine(result);
        }

        private static long marcsCakewalk(int[] calorie)
        {
            List<int> list = new List<int>();
            long min = 0;

            list.AddRange(calorie);
            list.Sort();

            for (int i = list.Count - 1, k = 0; i >= 0; i--, k++)
                min += (long)Math.Pow(2, k) * list[i];

            return min;
        }
    }
}