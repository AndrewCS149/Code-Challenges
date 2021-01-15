using System;
using System.Collections.Generic;

namespace Is_Unique
{
    public class Program
    {
        /*
         Create a method to determine if a given string has all unique characters.
         What if you cant use additional data structures???

         */

        public static void Main(string[] args)
        {
            Console.WriteLine(IsUnique("dad"));
            Console.WriteLine(IsUnique("andrew"));
            Console.WriteLine(IsUnique("courtney"));
            Console.WriteLine(IsUnique("abcdefghijklmnopqrstuvwxyz"));
            Console.WriteLine(IsUnique("abcdefghijklmnopqrstuvwxyza"));
        }

        // USING A DATA STRUCTURE
        //public static bool IsUnique(string str)
        //{
        //    HashSet<char> set = new HashSet<char>();
        //    foreach (char ch in str)
        //        if (!set.Add(ch)) return false;

        //    return true;
        //}

        // NOT USING A DATA STRUCTURE
        public static bool IsUnique(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                for (int k = 0; k < str.Length; k++)
                {
                    if (i == k) continue;

                    if (str[i] == str[k]) return false;
                }
            }

            return true;
        }
    }
}