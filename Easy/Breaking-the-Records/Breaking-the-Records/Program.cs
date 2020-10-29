using System;
using System.Linq;

namespace Breaking_the_Records
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp))
            ;
            int[] result = breakingRecords(scores);

            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] breakingRecords(int[] scores)
        {
            int min = scores[0], max = scores[0];
            int[] count = { 0, 0 };
            for (int i = 1; i < scores.Count(); i++)
            {
                if (scores[i] > max)
                {
                    count[0]++;
                    max = scores[i];
                }
                else if (scores[i] < min)
                {
                    count[1]++;
                    min = scores[i];
                }
            }
            return count;
        }
    }
}