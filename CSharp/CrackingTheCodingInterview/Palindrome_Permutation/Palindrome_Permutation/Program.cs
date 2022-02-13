using System;
using System.Collections;

namespace Palindrome_Permutation
{
    internal class Program
    {
        /*
         Write a method that determines whether a given string is a permutation of a palindrome
         */

        private static void Main(string[] args)
        {
            Console.WriteLine(IsPermutation("dda"));
            Console.WriteLine(IsPermutation("cato tac"));
            Console.WriteLine(IsPermutation("ccat tacd"));
            Console.WriteLine(IsPermutation("da"));
        }

        public static bool IsPermutation(string str)
        {
            //Hashtable table = new Hashtable();
            //foreach (char ch in str)
            //{
            //    if (ch == ' ') continue;

            //    if (table.Contains(ch))
            //        table[ch] = (int)table[ch] + 1;
            //    else
            //        table.Add(ch, 1);
            //}

            //int odds = 0;
            //foreach (var val in table.Values)
            //    if ((int)val % 2 == 1) odds++;

            //return odds > 1 ? false : true;

            // No built in methods or data structures
            int odds = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ') continue;
                int tmpCount = 0;
                for (int k = 0; k < str.Length; k++)
                {
                    if (str[k] == ' ') continue;
                    if (str[k] == str[i]) tmpCount++;
                }
                if (tmpCount % 2 == 1) odds++;
            }
            return odds > 1 ? false : true;
        }
    }
}