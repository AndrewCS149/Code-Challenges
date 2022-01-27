//https://leetcode.com/problems/longest-substring-without-repeating-characters/

using System;

namespace LongestSubstring
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string test1 = "abcabcbb";
            string test2 = "pwwkew";
            string test3 = "bbbbbb";
            string test4 = "a";


            Console.WriteLine(LengthOfLongestSubstring(test1));
            Console.WriteLine(LengthOfLongestSubstring(test2));
            Console.WriteLine(LengthOfLongestSubstring(test3));
            Console.WriteLine(LengthOfLongestSubstring(test4));

        }

        public static int LengthOfLongestSubstring(string s)
        {
            int max = 0;
            var dict = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (!dict.ContainsKey(s[i]))
                    dict.Add(s[i], i);
                else
                {
                    i = dict[s[i]];
                    dict.Clear();
                }

                if (dict.Count > max)
                    max = dict.Count;
            }

            return max;
        }
    }

    /*
     
     
    "pwwkew"

    3

    p w a w k e w
              ^         
    4
    a2
    w3
    k4
    e5
     intput -> "abcabcbb"
     outuput <- 3 (abc)
      
    int res = 3

     [bb]
    
    a b c a b c b b
    ^ ^ ^ ^ ^ ^ ^ ^

    return res
     */
}
