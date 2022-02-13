/*
Write a function that accpets a target string and an array of strings

the function should return the number of ways that the target can be constructed by concatenating elements
of the wordBank array

you may reuse elements of wordBank as many times as needed
*/

using System;
using System.Diagnostics;

  namespace CountConstruct
  {
      public class Program 
      {
          private static void Main(string[] args) 
          {
			var watch = new Stopwatch();
			watch.Start();

			
          	string[] test1 = {"wo", "rd", "w", "ord", "wor"};
			string[] test2 = {"purp", "p", "ur", "le", "purpl"};
			string[] test3 = {"e", "ee", "eee", "eeee", "eeeee", "eeeeee"};
          	
			Console.WriteLine(Construct("word", test1));	
			Console.WriteLine(Construct("purple", test2));	
			Console.WriteLine(Construct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", test3));	
									
			// Console.WriteLine(Construct2("word", test1));



			// Console.WriteLine(watch.ElapsedMilliseconds);
					
			watch.Stop();		
						
          }

          private static int Construct(string target, string[] wordBank, Dictionary<string, int> memo = null) 
          {
          	if(memo == null) memo = new Dictionary<string, int>();

          	if(memo.ContainsKey(target)) return memo[target];
			if(target == "") return 1;

			int count = 0;
			foreach(string word in wordBank) 
			{
				if(target.IndexOf(word) == 0) 
					 count += Construct(target.Substring(word.Length), wordBank, memo);
					 
				memo[target] = count;
			}
          
          	return count;
          }          

          private static int Construct2(string target, string[] wordBank) 
          {
		  	if(target == "") return 1;

			int count = 0;
		  	foreach(string word in wordBank) 
		  	{
		  		if(target.IndexOf(word) == 0) 
		  			count += Construct2(target.Substring(word.Length), wordBank);
			}
		  	return count;
          }
      }
  }
