using System;

namespace Rotate_Matrix
{
    internal class Program
    {
        /*
        Given an image denoted as a matrix of integers representing the images pixel values, rotate the image 90 degrees to the right.
        Can you do this in place?
        */

        private static void Main(string[] args)
        {
            int[,] arr = new int[,]
            {
                {1, 1, 1, 1 },
                {2, 2, 2, 2 },
                {3, 3, 3, 3 },
                {4, 4, 4, 4 }
            };

            var newArr = RotateMatrix(arr);

            for (int i = 0; i < newArr.GetLength(0); i++)
            {
                for (int k = 0; k < newArr.GetLength(1); k++)
                    Console.Write(newArr[i, k] + " ");
                Console.WriteLine();
            }
        }

        public static int[,] RotateMatrix(int[,] arr)
        {
            //int rows = arr.GetLength(0);
            //int cols = arr.GetLength(1);
            //int[,] newArr = new int[cols, rows];

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int k = cols - 1; k >= 0; k--)
            //        newArr[i, (cols - 1) - k] = arr[k, i];
            //}

            //return newArr;
        }

        /*
        input -> 1, 2, 3
                 4, 5, 6
                 7, 8, 9

        output -> 7, 4, 1
                  8, 5, 2
                  9, 6, 3

        newArr[0][0] = origArr[2][0]
        newArr[0][1] = origArr[1][0]
        newArr[0][2] = origArr[0][0]
        newArr[1][0] = origArr[2][1]
        newArr[1][1] = origArr[1][1]
        newArr[1][2] = origArr[0][1]
        newArr[2][0] = origArr[2][2]
        newArr[2][1] = origArr[1][2]
        newArr[2][2] = origArr[0][2]

        newArr = [origArr.Len][origArr[0].Len]

        for i < origArr.Len; i++
            for k >= 0; k--
                newArr[i][k] = origArr[k][i]

        return newArr;

        */
    }
}
