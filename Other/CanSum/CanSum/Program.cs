
/*
 Write a function CanSum(targetSum, numbers) that takes in a targetSum and an arary of numbers as arguments.
The function should return a boolean indicating whether or not it is possible to generate 
the targetSum using numbers from the array.

You may use an element of the array as many time as needed

You may assume that all input numbers are non-negative.
 */


using System;
using System.Diagnostics;

namespace CanSum
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] test1 = { 2, 3 };
            int[] test2 = { 5, 3, 4, 7 };
            int[] test3 = { 2, 4 };
            int[] test4 = { 2, 3, 5 };
            int[] test5 = { 7, 14 };

            int targetSum1 = 7;
            int targetSum2 = 7;
            int targetSum3 = 7;
            int targetSum4 = 8;
            int targetSum5 = 1000;


            Console.WriteLine(CSum(targetSum1, test1));
            Console.WriteLine(CSum(targetSum2, test2));
            Console.WriteLine(CSum(targetSum3, test3));
            Console.WriteLine(CSum(targetSum4, test4));
            Console.WriteLine(CSum(targetSum5, test5));
        }

        private static bool CSum(int targetSum, int[] numbers, Dictionary<int, bool> memo = null)
        {
            if (memo == null) memo = new Dictionary<int, bool>();

            // base cases
            if (memo.ContainsKey(targetSum)) return memo[targetSum];
            if (targetSum == 0) return true;
            if (targetSum < 0) return false;

            foreach (int num in numbers)
            {
                if (CSum(targetSum - num, numbers, memo))
                {
                    memo[targetSum] = true;
                    return true;
                }

                memo[targetSum] = false;
            }

            return false;
        }
    }
}
