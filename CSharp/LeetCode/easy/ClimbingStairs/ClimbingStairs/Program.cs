// https://leetcode.com/problems/climbing-stairs/


using System;

namespace ClimbingStairs
{
    public class Program 
    {
        private static void Main(string[] args) 
        {

        }

        public static int ClimbStairs(int n, Dictionary<int, int> memo = null) 
        {
        	if(n == 0) return 1;
        	if(n < 0) return 0;
        	if(memo == null) memo = new Dictionary<int, int>();
        	else if(memo.ContainsKey(n)) return memo[n];
        	
        	memo[n] = ClimbStairs(n - 1, memo) + ClimbStairs(n - 2, memo);
        	return memo[n];
        }
    }
}
