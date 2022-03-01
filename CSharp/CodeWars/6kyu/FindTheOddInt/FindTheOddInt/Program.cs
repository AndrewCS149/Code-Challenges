// https://www.codewars.com/kata/54da5a58ea159efa38000836/train/csharp

using System;

namespace FindTheOddInt
{
    public class Program 
    {
        private static void Main(string[] args) 
        {
			Console.WriteLine(FindIt(new int[]{7}));
			Console.WriteLine(FindIt(new int[]{0}));
			Console.WriteLine(FindIt(new int[]{1,1,2}));
			Console.WriteLine(FindIt(new int[]{0,1,0,1,0}));
			Console.WriteLine(FindIt(new int[]{1,2,2,3,3,3,4,3,3,3,2,2,1}));
        }

        public static int FindIt(int[] seq) 
        {
			// var table = new Dictionary<int, int>();
			// int res = seq[0];
	// 
			// foreach(int num in seq)
			// {
				// if(table.ContainsKey(num))
					// table[num] += 1;
				// else
					// table.Add(num, 1);
			// }
// 
			// foreach(var key in table.Keys)
				// if(table[key] % 2 ==1) res = key;
// 
        	// return res;

        	int found = 0; 

        	foreach(int num in seq)
        		found ^= num;

       		return found;
        }
    }
}
