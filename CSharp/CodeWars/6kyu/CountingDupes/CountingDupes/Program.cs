// https://www.codewars.com/kata/54bf1c2cd5b56cc47f0007a1/train/csharp
using System;
namespace CountingDupes
{
    public class Program 
    {
        private static void Main(string[] args) 
        {
			Console.WriteLine(DuplicateCount(""));// 0
			Console.WriteLine(DuplicateCount("abcde"));//0
			Console.WriteLine(DuplicateCount("aabbcde"));//2
			Console.WriteLine(DuplicateCount("aabBcde"));//2
			Console.WriteLine(DuplicateCount("Indivisibility"));//1
			Console.WriteLine(DuplicateCount("Indivisibilities"));//2
        }

        public static int DuplicateCount(string str) 
        {
        	int count = 0;
			var dict = new Dictionary<string, int>();

			foreach(char c in str) 
			{
				string ch = c.ToString().ToLower();
				if(dict.ContainsKey(ch))
					dict[ch]++;
				else
					dict.Add(ch, 1);
			}

			foreach(var obj in dict.Keys) 
				if(dict[obj] > 1) count++;
			
        	return count;
        }
    }
}
