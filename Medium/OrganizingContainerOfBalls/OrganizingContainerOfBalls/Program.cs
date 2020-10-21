using System;

namespace OrganizingContainerOfBalls
{
    internal class Program
    {
        // medium
        // link to challenge - https://www.hackerrank.com/challenges/organizing-containers-of-balls/problem
        private static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int[][] container = new int[n][];

                for (int i = 0; i < n; i++)
                {
                    container[i] = Array.ConvertAll(Console.ReadLine().Split(' '), containerTemp => Convert.ToInt32(containerTemp));
                }

                string result = organizingContainers(container);

                Console.WriteLine(result);
            }
        }

        // Complete the organizingContainers function below.
        private static string organizingContainers(int[][] container)
        {
        }
    }
}