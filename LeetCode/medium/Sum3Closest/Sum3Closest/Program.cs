// https://leetcode.com/problems/3sum-closest/

using System;

namespace Sum3Closest
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] test1 = { -1, 2, 1, -4 };
            Console.WriteLine(ThreeSumClosest(test1, 1));
        }
        public static int ThreeSumClosest(int[] nums, int target)
        {
            // not my solution. Solution derived from leetcode solution tab.
            Array.Sort(nums);
            int diff = Int32.MaxValue;

            for (int i = 0; i < nums.Length && diff != 0; i++)
            {
                int lo = i + 1;
                int hi = nums.Length - 1;

                while (lo < hi)
                {
                    int sum = nums[i] + nums[lo] + nums[hi];
                    if (Math.Abs(target - sum) < Math.Abs(diff))
                        diff = target - sum;

                    if (sum < target)
                        lo++;
                    else
                        hi--;
                }
            }

            return target - diff;
        }
    }
}
