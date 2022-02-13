using System;

namespace MaxNestingDepth
{
    // link - https://leetcode.com/problems/maximum-nesting-depth-of-the-parentheses/submissions/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int MaxDepth(string s)
        {
            int count = 0, tmp = 0;
            foreach (char ch in s)
            {
                if (ch == '(') tmp++;
                if (tmp > count) count = tmp;
                if (ch == ')') tmp--;
            }

            return count;
        }
    }
}
