using System;
using System.Linq;

namespace StringBreakString
{
    // https://leetcode.com/problems/check-if-a-string-can-break-another-string/submissions/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(CheckIfCanBreak("abe", "acd"));
        }

        public static bool CheckIfCanBreak(string s1, string s2)
        {
            s1 = String.Concat(s1.OrderBy(c => c));
            s2 = String.Concat(s2.OrderBy(c => c));

            bool lessThan = true, greaterThan = true;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s2[i] < s1[i])
                    lessThan = false;
                if (s1[i] < s2[i])
                    greaterThan = false;
            }

            return lessThan || greaterThan ? true : false;
        }
    }
}