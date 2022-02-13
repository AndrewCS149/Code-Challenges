using System;

namespace _3D_Surface_Area
{
    internal class Program
    {
        // link - https://www.hackerrank.com/challenges/3d-surface-area/problem
        private static void Main(string[] args)
        {
            string[] HW = Console.ReadLine().Split(' ');

            int H = Convert.ToInt32(HW[0]);

            int W = Convert.ToInt32(HW[1]);

            int[][] A = new int[H][];

            for (int i = 0; i < H; i++)
            {
                A[i] = Array.ConvertAll(Console.ReadLine().Split(' '), ATemp => Convert.ToInt32(ATemp));
            }

            int result = surfaceArea(A);

            Console.WriteLine(result);
        }

        private static int surfaceArea(int[][] A)
        {
            int total = 0;
            for (int i = 0; i < A.Length; i++)
            {
                int leftRight = A[i][0];
                int frontBack = A[0][i];
                for (int k = 1; k < A[i].Length; k++)
                {
                    if (A[k][i] > A[k - 1][i])
                        frontBack += Math.Abs(A[k][i] - A[k - 1][i]);

                    if (A[i][k] > A[i][k - 1])
                        leftRight += Math.Abs(A[i][k] - A[i][k - 1]);
                }
                total += leftRight + frontBack;
            }
            return total * 2 + (A.Length * A[0].Length * 2);
        }
    }
}