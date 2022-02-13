/*
 Write a function HowSum(targetSum, numbers) that takes in a targetSUm and an array of numbers as arguments. 

The function should return an array containing any combination of elements that add up to 
exactly the targetSum. If there is no combination that adds up to the targetSum, then return null
 
 */

using System;

namespace HowSum
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var res = HSum(7, new int[] { 3, 2, 2 });
            PrintList(res);
            var res2 = HSum(7, new int[] { 5, 3, 4, 7 });
            PrintList(res2);

            var res3 = HSum(7, new int[] { 2, 4 });
            PrintList(res3);

            var res4 = HSum(8, new int[] { 2, 3, 5 });
            PrintList(res4);

            var res5 = HSum(300, new int[] { 7, 14 });
            PrintList(res5);





        }

        private static void PrintList(List<int> list)
        {
            if (list == null) Console.Write("null");
            else
                foreach (int num in list) { Console.Write(num + ", "); }
            Console.WriteLine();
        }

        private static List<int> HSum(int targetSum, int[] numbers, Dictionary<int, List<int>> memo = null)
        {
            if (memo == null) memo = new Dictionary<int, List<int>>();

            if (memo.ContainsKey(targetSum))
                return memo[targetSum];

            if (targetSum == 0) return new List<int>();
            if (targetSum < 0) return null;

            foreach (int num in numbers)
            {
                var result = HSum(targetSum - num, numbers, memo);
                if (result != null)
                {
                    result.Add(num);
                    memo[targetSum] = result;
                    return memo[targetSum];
                }

                memo[targetSum] = null;
            }

            return null;
        }
    }
}
