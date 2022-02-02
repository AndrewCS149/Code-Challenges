// https://leetcode.com/problems/count-square-submatrices-with-all-ones/
using System;

namespace CountSubmatrices
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[][] test1 =
            {
                new int[] { 1, 0, 1 },
                new int[] { 1, 1, 0 },
                new int[] { 1, 1, 0 }
            };

            Console.WriteLine(CountSquares(test1));
        }

        public static int CountSquares(int[][] matrix)
        {
            int count = 0;
            int[,] vals = new int[matrix.Length, matrix[0].Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                count += matrix[i][0];
                vals[i, 0] = matrix[i][0];
            }

            for (int i = 1; i < matrix[0].Length; i++)
            {
                count += matrix[0][i];
                vals[0, i] = matrix[0][i];
            }

            for (int i = 1; i < matrix.Length; i++)
            {
                for (int j = 1; j < matrix[0].Length; j++)
                {
                    if (matrix[i][j] == 1)
                    {
                        int left = vals[i, j - 1];
                        int up = vals[i - 1, j];
                        int upLeft = vals[i - 1, j - 1];

                        vals[i, j] = new int[] { left, up, upLeft }.Min() + 1;
                        count += vals[i, j];
                    }
                }
            }

            return count;


            // WAY TOO SLOW
            //int count = 0, size = 0;

            //while (size < matrix.Length && size < matrix[0].Length)
            //{
            //    for (int i = 0; i < matrix.Length - size; i++)
            //    {
            //        for (int j = 0; j < matrix[i].Length - size; j++)
            //        {
            //            bool found = true;
            //            int tmpSize = size;

            //            for (int k = i; k <= i + tmpSize; k++)
            //            {
            //                for (int m = j; m <= j + tmpSize; m++)
            //                {
            //                    if (matrix[k][m] != 1)
            //                    {
            //                        found = false;
            //                        break;
            //                    }
            //                }

            //            }

            //            if (found) count++;
            //        }
            //    }
            //    size++;
            //}

            //return count;
        }
    }
}
