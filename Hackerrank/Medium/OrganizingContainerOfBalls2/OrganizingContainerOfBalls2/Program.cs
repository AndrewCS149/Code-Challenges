using System;
using System.Collections.Generic;
using System.Linq;

namespace OrganizingContainerOfBalls2
{
    internal class Program
    {
        // link - https://www.hackerrank.com/challenges/organizing-containers-of-balls/problem
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

        private static string organizingContainers(int[][] container)
        {
            HashSet<int> containers = new HashSet<int>();
            HashSet<int> colors = new HashSet<int>();
            for (int i = 0; i < container.Length; i++)
            {
                int balls = 0, size = 0;
                for (int k = 0; k < container[i].Length; k++)
                {
                    balls += container[k][i];
                    size += container[i][k];
                }
                containers.Add(size);
                colors.Add(balls);
            }

            return containers.SetEquals(colors) ? "Possible" : "Impossible";
        }
    }
}