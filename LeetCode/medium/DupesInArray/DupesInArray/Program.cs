using System;
using System.Collections.Generic;

namespace DupesInArray
{
    // https://leetcode.com/problems/find-all-duplicates-in-an-array/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static IList<int> FindDuplicates(int[] nums)
        {
            var list = new List<int>();
            var hSet = new HashSet<int>();
            foreach (int n in nums)
                if (!hSet.Add(n)) list.Add(n);

            return list;
        }
    }
}
