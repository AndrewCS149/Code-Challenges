//https://leetcode.com/problems/fibonacci-number/

using System;

namespace FibonacciNumber
{
    public class Program 
    {
        private static void Main(string[] args) 
        {
			Console.WriteLine(Fib(50));
        }

		public static long Fib(int n, Dictionary<int, long> memo = null) 
		{
			if(n == 0) return 1;
			if(n <= 2) return 1;
			if(memo == null) memo = new Dictionary<int, long>();
			else if(memo.ContainsKey(n)) return memo[n];
			
			memo[n] = Fib(n - 1, memo) + Fib(n - 2, memo);
			return memo[n];
		}        
    }
}
