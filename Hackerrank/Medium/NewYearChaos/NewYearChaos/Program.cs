using System;

namespace NewYearChaos
{
    internal class Program
    {
        // link - https://www.hackerrank.com/challenges/new-year-chaos/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays
        private static void minimumBribes(int[] q)
        {
            for (int i = 0; i < q.Length; i++)
            {
                if (q[i] - (i + 1) > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
            }

            int counter = 0;
            for (int i = 0; i < q.Length - 1; i++)
            {
                for (int k = 0; k < q.Length - (i + 1); k++)
                {
                    if (q[k] > q[k + 1])
                    {
                        int tmp = q[k];
                        q[k] = q[k + 1];
                        q[k + 1] = tmp;
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }

        private static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
                ;
                minimumBribes(q);
            }
        }
    }
}