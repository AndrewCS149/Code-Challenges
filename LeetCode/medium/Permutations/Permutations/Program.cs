// https://leetcode.com/problems/permutations/

using System;

namespace Permutations
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var test1 = new List<int>() { 1, 2, 3 };

            var result = Permute(test1);

            foreach (var item in result)
            {
                foreach (var n in item)
                    Console.Write(n + " ");
                Console.WriteLine();
            }
        }

        public static IList<List<int>> Permute(List<int> nums)
        {
            var result = new List<List<int>>();

            if (nums.Count == 1)
            {
                return new List<List<int>>()
                {
                    nums
                };
            }

            for (int i = 0; i < nums.Count; i++)
            {
                int n = nums.FirstOrDefault();
                nums.RemoveAt(0);
                var perms = Permute(nums);

                foreach (var perm in perms)
                {
                    perm.Append(n);
                }

                foreach (var perm in perms)
                {
                    result.Add(perm);
                }

                nums.Append(n);
            }

            return result;
        }
    }
}
