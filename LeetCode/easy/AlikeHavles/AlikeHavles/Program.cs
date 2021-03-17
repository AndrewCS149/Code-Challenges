using System;

namespace AlikeHavles
{
    class Program
    {
        //https://leetcode.com/problems/determine-if-string-halves-are-alike/submissions/
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool HalvesAreAlike(string s)
        {
            int vow1 = 0, vow2 = 0;
            for (int i = 0; i < s.Length / 2; i++)
            {
                if ("aeiouAEIOU".Contains(s[i])) vow1++;
                if ("aeiouAEIOU".Contains(s[s.Length - (i + 1)])) vow2++;
            }

            return vow1 == vow2 ? true : false;
        }
    }
}
