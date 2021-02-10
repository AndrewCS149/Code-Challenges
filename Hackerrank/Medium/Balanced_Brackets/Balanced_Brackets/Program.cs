using System;
using System.Collections.Generic;

namespace Balanced_Brackets
{
    internal class Program
    {
        // link - https://www.hackerrank.com/challenges/balanced-brackets/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=stacks-queues
        private static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string s = Console.ReadLine();

                string result = isBalanced(s);

                Console.WriteLine(result);
            }
        }

        private static string isBalanced(string s)
        {
            /*
                    0  1  2
             open = {, [, (

                    0  1  2
            close = }, ], )

             */

            // ONLINE SOLUTION
            bool restart = true;
            while (restart)
            {
                if (s.Contains("{}"))
                    s = s.Replace("{}", "");
                else if (s.Contains("()"))
                    s = s.Replace("()", "");
                else if (s.Contains("[]"))
                    s = s.Replace("[]", "");
                else
                    restart = false;
            }

            return s.Length == 0 ? "YES" : "NO";

            // MY SOLUTION
            //Stack<char> stack = new Stack<char>();
            //foreach (char ch in s)
            //{
            //    if (stack.Count == 0)
            //        stack.Push(ch);
            //    else
            //    {
            //        switch (stack.Peek())
            //        {
            //            case '{':
            //                if (ch == '}') stack.Pop();
            //                else stack.Push(ch);
            //                break;

            //            case '[':
            //                if (ch == ']') stack.Pop();
            //                else stack.Push(ch);
            //                break;

            //            case '(':
            //                if (ch == ')') stack.Pop();
            //                else stack.Push(ch);
            //                break;

            //            default:
            //                stack.Push(ch);
            //                break;
            //        }
            //    }
            //}

            //return stack.Count == 0 ? "YES" : "NO";
        }
    }
}