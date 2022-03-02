using System;

namespace BestSumTabulation
{
    public class Program 
    {
        private static void Main(string[] args) 
        {
			foreach(var n in BestSum(7, new int[]{5,3,4,7})) Console.Write(n + ", ");
			Console.WriteLine();

			foreach(var n in BestSum(8, new int[]{2,3,5})) Console.Write(n + ", ");
			Console.WriteLine();

			foreach(var n in BestSum(8, new int[]{1,4,5})) Console.Write(n + ", ");
			Console.WriteLine();

			foreach(var n in BestSum(100, new int[]{50, 25, 5, 10})) Console.Write(n + ", ");
			Console.WriteLine();
        }

        public static List<int> BestSum(int target, int[] nums) 
        {
        	var table = new List<int>[target + 1];
        	table[0] = new List<int>();

			var smallest = new List<int>();
			for(int i = 0; i < table.Length; i++) 
			{
				if(table[i] != null) 
				{
					foreach(int num in nums) 
					{
						if(i + num < table.Length)
						{
							var combination = new List<int>(table[i]);
							combination.Add(num);

							if(table[i + num] is null || combination.Count < table[i + num].Count)
								table[i + num] = combination;
						}
					}
				}
			}

        	return table[table.Length - 1];
        }
    }
}
