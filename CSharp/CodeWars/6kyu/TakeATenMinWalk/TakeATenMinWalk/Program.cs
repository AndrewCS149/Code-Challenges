// https://www.codewars.com/kata/54da539698b8a2ad76000228/train/csharp

using System;

  namespace TakeATenMinWalk
  {
      public class Program 
      {
          private static void Main(string[] args) 
          {
			Console.WriteLine(IsValidWalk(new string[] {"n", "s", "n", "s", "n", "s", "n", "s", "n", "s"}));
			Console.WriteLine(IsValidWalk(new string[] {"w", "e", "w", "e", "w", "e", "w", "e", "w", "e", "w", "e"}));
			Console.WriteLine(IsValidWalk(new string[] {"w"}));						
			Console.WriteLine(IsValidWalk(new string[] {"n", "n", "n", "s", "n", "s", "n", "s", "n", "s"}));
          }

          public static bool IsValidWalk(string[] walk) 
          {
			if(walk.Length != 10) return false;
          
          	int NS = 0;
          	int EW = 0;

          	foreach(string dir in walk) 
          	{
          		switch(dir) 
          		{
          			case "n": 
          				NS++;
          				break;
         			case "s":
         				NS--;
         				break;
        			case "e":
        				EW++;
        				break;
       				default:
       					EW--;
       					break;
          		}
          	}

          	return NS == 0 && EW == 0 ? true : false;
          }
      }
  }
