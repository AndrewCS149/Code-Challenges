// https://leetcode.com/problems/remove-vowels-from-a-string/submissions/

using System;

namespace RemoveVowels
{
    public class Program 
    {
        private static void Main(string[] args) 
        {
			Console.WriteLine(RemoveVowels("leetcodeisacommunityforcoders"));
        }

        public static string RemoveVowels(string s) 
        {
        	foreach(char c in "aeiou") 
        		if(s.Contains(c))
        			s = s.Replace(c.ToString(), "");

        	return s;
        }
    }
}
