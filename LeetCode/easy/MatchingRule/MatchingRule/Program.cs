using System;
using System.Collections.Generic;

namespace MatchingRule
{
    internal class Program
    {
        // link - https://leetcode.com/problems/count-items-matching-a-rule/submissions/
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int target;
            int count = 0;

            if (ruleKey == "type") target = 0;
            else if (ruleKey == "color") target = 1;
            else target = 2;

            foreach (var arr in items)
                if (arr[target] == ruleValue) count++;

            return count;
        }
    }
}