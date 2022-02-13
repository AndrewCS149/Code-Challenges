using System;

namespace ViralAdvertising
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/strange-advertising/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int result = viralAdvertising(n);

            Console.WriteLine(result);
        }

        private static int viralAdvertising(int n)
        {
            int count = 5, liked = 0;
            for (int i = 0; i < n; i++)
            {
                liked += count / 2;
                count = (count / 2) * 3;
            }
            return liked;
        }
    }
}