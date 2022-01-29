// https://leetcode.com/problems/container-with-most-water/

using System;

namespace ContainerWithMostWater
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] test1 = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int[] test2 = { 1, 2, 3, 4 };
            int[] test3 = { 1, 0, 0, 0, 0, 0, 0, 2, 2 };
            int[] test4 = { 2, 3, 10, 5, 7, 8, 9 };

            Console.WriteLine(MaxArea(test1));
            Console.WriteLine(MaxArea(test2));
            Console.WriteLine(MaxArea(test3));
            Console.WriteLine(MaxArea(test4));

        }

        public static int MaxArea(int[] height)
        {
            if (height.Length < 2)
                return 0;

            int water = 0;
            int p1 = 0;
            int p2 = height.Length - 1;

            for (int i = 0; i < height.Length; i++)
            {
                int tmp = Math.Min(height[p1], height[p2]) * (height.Length - i - 1);

                if (tmp > water)
                    water = tmp;

                if (height[p1] > height[p2])
                    p2--;
                else
                    p1++;
            }

            return water;

            // O(n^2)
            //int water = 0;

            //for (int i = 0; i < height.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < height.Length; j++)
            //    {
            //        int tmp = Math.Min(height[i], height[j]) * (j - i);
            //        if (tmp > water)
            //            water = tmp;
            //    }
            //}

            //return water;
        }
    }
}
