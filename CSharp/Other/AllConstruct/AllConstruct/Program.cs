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
					Console.Write(word + ", ");

				Console.WriteLine();
			}
        }

		private static List<List<string>> AllConstuctSolution(string target, string[] wordBank) 
		{
			
		}
    }
}
