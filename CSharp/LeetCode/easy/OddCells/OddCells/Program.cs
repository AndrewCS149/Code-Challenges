using System;

namespace OddCells
{
    // link - https://leetcode.com/problems/cells-with-odd-values-in-a-matrix/
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = 2;
            int m = 3;
            int[][] indices =
            {
                new int[] {0, 1},
                new int[] {1, 1}
            };

            Console.WriteLine(OddCells(n, m, indices));
        }
        // [0, 1] [1, 1]
        public static int OddCells(int n, int m, int[][] indices)
        {
            int odds = 0;
            int[,] matrix = new int[n, m];

            for (int i = 0; i < indices.Length; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[indices[i][0], j] += 1;
                    odds += matrix[indices[i][0], j] % 2 == 1 ? 1 : -1;

                }

                for (int k = 0; k < n; k++)
                {
                    matrix[k, indices[i][1]] += 1;
                    odds += matrix[k, indices[i][1]] % 2 == 1 ? 1 : -1;
                }
            }

            return odds;
        }
    }
}

