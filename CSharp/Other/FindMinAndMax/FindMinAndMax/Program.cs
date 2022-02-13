// https://practice.geeksforgeeks.org/problems/find-minimum-and-maximum-element-in-an-array4428/1

using System;

namespace FindMinAndMax
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] test = new int[] { 3, 2, 1, 56, 10000, 167 };
            int[] test2 = new int[] { 1, 345, 234, 21, 56789 };
            int[] result = FindMinAndMaxElements(test);
            int[] result2 = FindMinAndMaxElements(test2);


            Array.ForEach(result, num => Console.WriteLine(num));
            Array.ForEach(result2, num => Console.WriteLine(num));

        }

        // return int[] { min, max } 
        // return { -1, -1 } if empty
        private static int[] FindMinAndMaxElements(int[] arr)
        {
            if (arr.Length == 0)
                return new int[] { -1, -1 };
            else if (arr.Length == 1)
                return new int[] { arr[0], arr[0] };

            int[] minMax = new int[2];
            minMax[0] = arr[0];
            minMax[1] = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minMax[0])
                    minMax[0] = arr[i];
                else if (arr[i] > minMax[1])
                    minMax[1] = arr[i];
            }

            return minMax;
        }
    }
}
