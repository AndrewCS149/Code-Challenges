using System;
using System.Collections.Generic;

namespace SplitBalancedString
{
    // link - https://leetcode.com/problems/split-a-string-in-balanced-strings/

    internal class Program
    {
        private static void Main(string[] args)
        {
        }

        public int BalancedStringSplit(string s)
        {
            int count = 0;
            var stack = new Stack<char>();
            stack.Push(s[0]);

            for (int i = 1; i < s.Length; i++)
            {
                if (stack.Count == 0 || s[i] == stack.Peek())
                    stack.Push(s[i]);
                else stack.Pop();

                if (stack.Count == 0) count++;
            }

            return count;
        }
    }
}