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

        public static int OddCells(int n, int m, int[][] indices)
        {
            int odds = 0;
            int[,] matrix = new int[n, m];
            for (int i = 0; i < indices.Length; i++)
            {
                int row = indices[i][0];
                int col = indices[i][1];

                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[row, j]++;

                for (int k = 0; k < matrix.Rank; k++)
                    matrix[k, col]++;
            }

            for (int i = 0; i < matrix.Rank; i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] % 2 == 1) odds++;
            }

            return odds;
        }
    }
}