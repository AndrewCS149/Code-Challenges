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

			foreach(var n in BestSum(100, new int[]{1,2,5,25})) Console.Write(n + ", ");
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
					for(int j = 0; j < nums.Length; j++) 
					{
						if(i + nums[j] < table.Length) 
						{
							table[i + nums[j]] = new List<int>(table[i]);
							table[i + nums[j]].Add(nums[j]);
						}
					}

					if(smallest.Count == 0 || table[i].Sum() == target && table[i].Count < smallest.Count)
						smallest = table[i];
				}
			}
	

        	return smallest;
        }
    }
}
