using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveParens
{
    // link - https://leetcode.com/problems/remove-outermost-parentheses/submissions/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(RemoveOuterParentheses("(()())(())"));
        }

        public static string RemoveOuterParentheses(string S)
        {
            // MY SOLUTION
            //var myStack = new Stack<char>(S.Reverse());
            string parens = "";
            int i = 0;
            //while (myStack.Count > 0)
            //{
            //    char tmp = myStack.Pop();

            //    if (tmp == '(')
            //    {
            //        if (i++ == 0) continue;
            //        else parens += tmp;
            //    }
            //    else
            //    {
            //        if (i-- <= 1) continue;
            //        else parens += tmp;
            //    }
            //}

            // ONLINE SOLUTION
            foreach (char ch in S)
            {
                if (ch == '(' && i++ > 0) parens += ch;
                if (ch == ')' && i-- > 1) parens += ch;
            }

            return parens;
        }
    }
}