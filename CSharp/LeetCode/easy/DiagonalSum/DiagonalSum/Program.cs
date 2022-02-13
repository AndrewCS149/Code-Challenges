using System;

namespace DiagonalSum
{
    // link - https://leetcode.com/problems/matrix-diagonal-sum/submissions/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int DiagonalSum(int[][] mat)
        {
            int sum = 0;
            for (int i = 0; i < mat.Length; i++)
            {
                sum += mat[i][i];
                if (i == mat.Length / 2 && mat.Length % 2 == 1) continue;
                sum += mat[i][mat.Length - (i + 1)];
            }

            return sum;
        }
    }
}