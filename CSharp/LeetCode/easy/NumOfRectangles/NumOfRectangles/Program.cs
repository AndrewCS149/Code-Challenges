using System;
using System.Collections.Generic;
using System.Linq;

namespace NumOfRectangles
{
    // link - https://leetcode.com/problems/number-of-rectangles-that-can-form-the-largest-square/submissions/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int CountGoodRectangles(int[][] rectangles)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < rectangles.Length; i++)
            {
                int tmp = Math.Min(rectangles[i][0], rectangles[i][1]);

                if (dict.ContainsKey(tmp))
                    dict[tmp] += 1;
                else
                    dict.Add(tmp, 1);
            }

            return dict[dict.Keys.Max()];
        }
    }
}