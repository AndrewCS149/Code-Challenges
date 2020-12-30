using System;
using System.Text;

namespace CavityMap
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/cavity-map/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string[] grid = new string[n];

            for (int i = 0; i < n; i++)
            {
                string gridItem = Console.ReadLine();
                grid[i] = gridItem;
            }

            string[] result = cavityMap(grid);
            Console.WriteLine(string.Join("\n", result));
        }

        private static string[] cavityMap(string[] grid)
        {
            for (int i = 1; i < grid.Length - 1; i++)
            {
                for (int k = 1; k < grid[i].Length - 1; k++)
                {
                    if (grid[i][k] > grid[i - 1][k] &&
                       grid[i][k] > grid[i + 1][k] &&
                       grid[i][k] > grid[i][k - 1] &&
                       grid[i][k] > grid[i][k + 1])
                    {
                        var sb = new StringBuilder(grid[i]);
                        sb[k] = 'X';
                        grid[i] = sb.ToString();
                    }
                }
            }
            return grid;
        }
    }
}