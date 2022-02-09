// https://leetcode.com/problems/word-break/

using System;

namespace WordBreakProblem
{
    public class Program
    {
        private static void Main(string[] args)
        {

        }

        public static bool WordBreak(string s, IList<string> wordDict, Dictionary<string, bool> memo = null)
        {
            if (memo == null) memo = new Dictionary<string, bool>();

            if (memo.ContainsKey(s)) return memo[s];
            if (s == "") return true;

            foreach (string word in wordDict)
            {
                if (s.IndexOf(word) == 0)
                {
                    if (WordBreak(s.Substring(word.Length), wordDict, memo))
                    {
                        memo[s] = true;
                        return true;
                    }
                }
                memo[s] = false;
            }

            return false;
        }
    }
}
