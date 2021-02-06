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
            int total = (A.Length * A.Length) * 2;
            for (int i = 1; i < A.Length; i++)
            {
                for (int k = 1; k < A[i].Length; k++)
                {
                    total += Math.Max(0, A[i][k] - A[i - 1][k]);
                    total += Math.Max(0, A[i][k] - A[i + 1][k]);
                    total += Math.Max(0, A[i][k] - A[i][k - 1]);
                    total += Math.Max(0, A[i][k] - A[i][k + 1]);

                    //if (A[k][i] > A[k - 1][i])
                    //    frontBack += Math.Abs(A[k][i] - A[k - 1][i]);

                    //if (A[i][k] > A[i][k - 1])
                    //    leftRight += Math.Abs(A[i][k] - A[i][k - 1]);
                }
                //total += leftRight + frontBack;
            }
            return total;
        }
    }
}