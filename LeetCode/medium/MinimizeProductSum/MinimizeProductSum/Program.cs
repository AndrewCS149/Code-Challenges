//https://leetcode.com/problems/minimize-product-sum-of-two-arrays/

using System;

namespace MinimizeProductSum
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] test1 = { 5, 3, 4, 2 };
            int[] test2 = { 4, 2, 2, 5 };

            Console.WriteLine(MinProductSum(test1, test2));

        }

        public static int MinProductSum(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);

            int sum = 0;
            for (int i = 0, j = nums1.Length - 1; i < nums1.Length; i++, j--)
                sum += (nums1[i] * nums2[j]);

            return sum;
        }
    }
}
