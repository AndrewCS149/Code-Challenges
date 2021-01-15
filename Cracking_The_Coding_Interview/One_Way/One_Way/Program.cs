using System;
using System.Collections;

namespace One_Way
{
    internal class Program
    {
        /*
         Write a method to determine if two strings are 1 or less edits away from being identical
         */

        private static void Main(string[] args)
        {
            Console.WriteLine(OneAway("pale", "ple"));
            Console.WriteLine(OneAway("pales", "pale"));
            Console.WriteLine(OneAway("pale", "bale"));
            Console.WriteLine(OneAway("pale", "bake"));
            Console.WriteLine(OneAway("dale", "rale"));
            Console.WriteLine(OneAway("dale", "rade"));
            Console.WriteLine(OneAway("andrew", "andrewcs"));
            Console.WriteLine(OneAway("andrew", " andrew"));
            Console.WriteLine(OneAway("laag", "raad"));
        }

        public static bool OneAway(string str1, string str2)
        {
            if (Math.Abs(str1.Length - str2.Length) > 1) return false;

            string lng = str1.Length >= str2.Length ? str1 : str2;
            string shrt = str1.Length < str2.Length ? str1 : str2;

            if (str1 == str2) return true;

            for (int i = 0; i < shrt.Length; i++)
            {
                if (shrt[i] != lng[i])
                {
                    if (shrt.Insert(i, lng[i].ToString()) == lng ||
                        lng.Remove(i, 1) == shrt ||
                        shrt.Remove(i, 1).Insert(i, lng[i].ToString()) == lng)
                    {
                        return true;
                    }
                }
            }

            return lng.Remove(lng.Length - 1) == shrt ? true : false;
        }
    }
}