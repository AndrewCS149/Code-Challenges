// https://www.codewars.com/kata/55bf01e5a717a0d57e0000ec/train/csharp
using System;

  namespace PersistentBugger
  {
      public class Program 
      {
          private static void Main(string[] args) 
          {

			Console.WriteLine(Persistence(39));
			Console.WriteLine(Persistence(4));
			Console.WriteLine(Persistence(25));
			Console.WriteLine(Persistence(999));
												
          }

          public static int Persistence(long n) 
          {
			int count = 0;

			while(n > 9) 
			{
				long tmp = n;
				n = 1;
				while(tmp > 0) 
				{
					n *= (tmp % 10);
					tmp /= 10;
				}
				
				count++;
			}
          
          	return count;
          }
      }
  }
