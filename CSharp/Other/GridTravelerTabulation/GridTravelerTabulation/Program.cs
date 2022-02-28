using System;

/*
Given the dimensions n x m of a grid, return the total number of ways someone can travel from the 
uppermost left square, to the bottom most right square.

The only possible way to move it right or down.
*/

namespace GridTravelerTabulation
{
    public class Program 
    {
        private static void Main(string[] args) 
        {
        	Console.WriteLine(GridTraveler(1,1));
        	Console.WriteLine(GridTraveler(2,3));
			Console.WriteLine(GridTraveler(3,2));

			Console.WriteLine(GridTraveler(3,3));
			Console.WriteLine(GridTraveler(18,18));
        }

        public static long GridTraveler(int m, int n) 
        {
			long[,] table = new long[m + 1, n + 1];
			table[1, 1] = 1;

			for(int i = 0; i <= m; i++) 
			{
				for(int j = 0; j <= n; j++) 
				{
					long cur = table[i, j];

					if(j + 1 <= n) table[i, j + 1] += cur;
					if(i + 1 <= m) table[i + 1, j] += cur;
				}
			}
			
        	return table[m, n];
        }
    }
}
