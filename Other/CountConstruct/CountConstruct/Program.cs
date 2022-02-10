/*
Write a function that accpets a target string and an array of strings

the function should return the number of ways that the target can be constructed by concatenating elements
of the wordBank array

you may reuse elements of wordBank as many times as needed
*/

using System;

  namespace CountConstruct
  {
      public class Program 
      {
          private static void Main(string[] args) 
          {

          	string[] test1 = {"wo", "rd", "w", "ord", "wor"};
			Console.WriteLine(Construct("word", test1));			
          }

          private static int Construct(string target, string[] wordBank, Dictionary<string, int> memo = null) 
          {
          	if(memo == null) memo = new Dictionary<string, int>():

          	if(memo.ContainsKey(target)) return memo[target];
			if(target == "") return 1;

			int count = 0;
			foreach(string word in wordBank) 
			{
				if(target.IndexOf(word) == 0) 
				{
					if(Construct(target.Substring(word.Length), wordBank, memo) == 1)
					{
						memo[target] = 1;
						count++;
					}
				}
			}
          
          	return count;
          }          
      }
  }
