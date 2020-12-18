using System;

namespace JumpingOnTheClouds2
{
    internal class Program
    {
        // Easy
        // link to challenge - https://www.hackerrank.com/challenges/jumping-on-the-clouds/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int result = jumpingOnClouds(c);

            Console.WriteLine(result);
        }

        private static int jumpingOnClouds(int[] c)
        {
            int count = 0;
            for (int i = 0; i < c.Length - 1; i++, count++)
                if (i + 2 < c.Length)
                    if (c[i + 2] == 0) i++;

            return count;
        }
    }
}