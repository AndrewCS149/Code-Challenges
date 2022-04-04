//https://leetcode.com/problems/min-cost-climbing-stairs/

using System;

namespace MinCostClimbingStairs
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(MinCost(new int[] { 10, 15, 20 }));
            Console.WriteLine(MinCost(new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 }));
        }

        public static int MinCost(int[] cost, int i = -5, Dictionary<int, int> memo = null)
        {
        	if(i == -5) i = cost.Length;
        	if(i <= 1) return 0;
			if(memo == null) memo = new Dictionary<int, int>();
			else if(memo.ContainsKey(i)) return memo[i];

			int oneStep = cost[i - 1] + MinCost(cost, i - 1, memo);
			int twoStep = cost[i - 2] + MinCost(cost, i - 2, memo);

			memo.Add(i, Math.Min(oneStep, twoStep));
			return memo[i];
        }
    }
}
