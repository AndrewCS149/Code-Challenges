// https://leetcode.com/problems/find-smallest-common-element-in-all-rows/
using System;

namespace SmallestCommonElement
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[][] test1 = { new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 4, 5, 8, 10 }, new int[] { 3, 5, 7, 9, 11 }, new int[] { 1, 3, 5, 7, 9 } };


            int[][] test2 =
            {
                new int[]{1,2,3 },
                new int[]{2,3,4 },
                new int[]{2,3,5 }
            };

            Console.WriteLine(SmallestCommonElement(test1));
            Console.WriteLine(SmallestCommonElement(test2));

        }
        public static int SmallestCommonElement(int[][] mat)
        {
            //for (int i = 0; i < mat[0].Length; i++)
            //{
            //    int min = mat[0][i];

            //    int j = 1;
            //    bool isCommon = true;
            //    while (isCommon && j < mat.Length)
            //    {
            //        if (!mat[j].Contains(min))
            //            isCommon = false;

            //        j++;
            //    };

            //    if (isCommon) return min;
            //}

            //return -1;

            // hold the count of every element in the matrix
            var dict = new Dictionary<int, int>();

            // iterate over every element start from [0][0]
            for (int i = 0; i < mat.Length; i++)
            {
                for (int j = 0; j < mat[i].Length; j++)
                {
                    int cur = mat[i][j];
                    if (dict.ContainsKey(cur))
                        dict[cur]++;
                    else
                        dict.Add(cur, 1);

                    // if a common element is found, return it
                    // the first common element will always be the smallest
                    if (dict[cur] == mat.Length) return cur;
                }
            }

            return -1;
        }
    }
}
