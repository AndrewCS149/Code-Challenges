//https://leetcode.com/problems/n-th-tribonacci-number/

using System;

namespace TribonacciNumber
{
    public class Program 
    {
        private static void Main(string[] args) 
        {

        }

        public static long Trib(int n, Dictionary<int, long> memo = null) 
        {
        	if(n == 0) return 0;
        	if(n <= 2) return 1;
        	if(memo == null) memo = new Dictionary<int, long>();
        	else if(memo.ContainsKey(n)) return memo[n];

			memo[n] = Trib(n - 1, memo) + Trib(n - 2, memo) + Trib(n - 3, memo);
        	return memo[n];
        }
    }
}
