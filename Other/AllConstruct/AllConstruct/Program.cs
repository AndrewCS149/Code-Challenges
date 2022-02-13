/*
Write a function that accepts a target string and an array of strings

the function should return a 2d array containing all of the ways that the target can 
be constructed by concatenating elements of the wordBank array

*/

using System;

namespace AllConstruct
{
    public class Program 
    {
        private static void Main(string[] args) 
        {
			string[] test1 = {"purp", "p", "ur", "le", "purpl"};
			var res = AllConstructSolution("purple", test1);

			foreach(var list in res) 
			{
				foreach(var word in list) 
				{
					Console.Write(word + ", ");
				}

				Console.WriteLine();
			}
        }

        private static List<List<string>> AllConstructSolution(string target, string[] wordBank) 
        {
        	if(target == "") return new List<List<string>>();

			var result = new List<List<string>>();
        	foreach(string word in wordBank) 
        	{
				if(target.IndexOf(word) == 0) 
				{
					string suffix = target.Substring(word.Length);
					var suffixWays = AllConstructSolution(suffix, wordBank);
					var targetWays = new List<List<string>>();
					
					foreach(var list in suffixWays) 
					{
						list.Insert(0, word);
						targetWays.Add(list);
					}

					foreach(var list in targetWays)
					{
						result.Add(list);
					}
				}
        	}

        	return result;
        }
    }
}
