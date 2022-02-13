using System;

namespace Zero_Matrix
{
    internal class Program
    {
        /*
        Write a method that takes in a matrix and everytime a '0' is found, change that entire column and row to zeros.
        */

        private static void Main(string[] args)
        {
            int[,] arr = new int[,]
            {
                {1, 2, 3, 5, 5, 5, 4, 3, 2, 1, 3 },
                {2, 0, 4, 5, 5, 5, 6, 7, 8, 9, 5 },
                {5, 4, 3, 3, 4, 5, 6, 7, 8, 9, 9 },
                {5, 4, 3, 2, 1, 2, 3, 4, 5, 4, 3 },
                {6, 5, 6, 7, 8, 7, 6, 5, 4, 3, 2 },
                {5, 4, 3, 2 ,1 ,2, 3, 4 ,5, 6, 7 },
                {5, 4, 3, 2, 1, 1, 1 ,2, 3, 4, 5 },
                {6, 5, 4, 4, 4, 5, 9, 5, 5, 6, 6 },
                {5, 4, 3, 3, 3, 2, 2, 0, 2, 1, 1 },
                {5, 6, 7, 7, 7, 6, 6, 6, 5, 4, 3 },
                {5, 6, 7, 6, 5, 4, 3, 2, 1, 2, 3 }
            };

            arr = ZeroMatrix(arr);

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int k = 0; k < arr.GetLength(1); k++)
                    Console.Write(arr[i, k] + " ");
                Console.WriteLine();
            }
        }

        public static int[,] ZeroMatrix(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            int[,] copy = (int[,])arr.Clone();

            for (int i = 0; i < rows; i++)
            {
                for (int k = 0; k < cols; k++)
                {
                    if (copy[i, k] == 0)
                        arr = ZeroColRow(arr, i, k);
                }
            }

            return arr;
        }

        public static int[,] ZeroColRow(int[,] arr, int targetRow, int targetCol)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
                arr[targetRow, i] = 0;

            for (int i = 0; i < arr.GetLength(1); i++)
                arr[i, targetCol] = 0;

            return arr;
        }
    }
}