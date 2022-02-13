using System;

  namespace Keypad
  {
      public class Program 
      {
          private static void Main(string[] args) 
          {

          }

		  string[] keypad = {"", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};

          private static List<string> Combinations(int[] numbers, List<string> words = null) 
          {
			if(words == null)
				words = new List<string>();

			if(numbers.Length == 0) return words;

			foreach(int num in numbers) 
			{
				string tmp = keypad[num];
				string wrd = "";
				foreach(char ch in tmp) 
				{
					
				}
			}
			
          	return words;
          }
      }
  }


/*
  1    2    3
      abc  def
  4    5    6
 ghi  jkl  mno 
  7    8    9
 pqrs tuv  wxyz
       0

*/
