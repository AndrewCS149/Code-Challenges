using System;

//https://leetcode.com/problems/queries-on-number-of-points-inside-a-circle/
namespace NumberOfQueries
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[][] points = new int[][]
            {
                new int[] {1,3 },
                new int[] {3,3 },
                new int[] {5, 3 },
                new int[] {2,2}
            };

            int[][] queries = new int[][]
            {
                new int[]{2,3,1 } ,
                new int[]{4,3,1},
                new int[]{3,2,2}
            };

            int[] result = CountPoints(points, queries);

            Array.ForEach(result, x => Console.Write(x + " "));

        }

        private static int[] CountPoints(int[][] points, int[][] queries)
        {
            int[] result = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                for (int j = 0; j < points.Length; j++)
                {
                    int px = points[j][0];
                    int py = points[j][1];

                    int qx = queries[i][0];
                    int qy = queries[i][1];
                    int radius = queries[i][2];

                    if (Math.Abs(px - qx) <= radius && Math.Abs(py - qy) <= radius)
                        result[i]++;
                }
            }

            return result;
        }
    }
}
