// https://www.codewars.com/kata/52774a314c2333f0a7000688

using System;

namespace ValidParen
{
    public class Program 
    {
        private static void Main(string[] args) 
        {
			Console.WriteLine(ValidParentheses("()"));
			Console.WriteLine(ValidParentheses(")(()))"));
			Console.WriteLine(ValidParentheses("("));
			Console.WriteLine(ValidParentheses("(())((()())())"));
			Console.WriteLine(ValidParentheses(")(((("));
        }

        public static bool ValidParentheses(string input) 
        {
			int parens = 0;

			foreach(char c in input) 
			{
				if(c == '(') parens++;
				else if(c == ')' && parens == 0) return false;
				else if(c == ')' && parens > 0) parens--;
			}

        	return parens == 0;
        }

        /*

        
		( ( ) ) ( ( ( ) ( ) ) ( ) )   => true
        ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^ ^
		
 
		( ( ) ) )   => false
        ^ ^ ^ ^ ^

		
        
		
		

		


        */
    }
}
