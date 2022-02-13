using System;
using System.Linq;

namespace MaxProduct
{
    // https://leetcode.com/problems/maximum-product-of-two-elements-in-an-array/submissions/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int MaxProduct(int[] nums)
        {
            //int max = nums.Max();
            //int max3 = nums.Where((n, i) => i != Array.IndexOf(nums, max)).Max();
            //return (--max) * (--max3);

            nums = nums.OrderByDescending(n => n).ToArray();
            return (nums[0] - 1) * (nums[1] - 1);

            //int max = nums.Max();
            //nums[Array.IndexOf(nums, max)] = 0;
            //int max2 = nums.Max();
            //return (--max) * (--max2);
        }
    }
}
