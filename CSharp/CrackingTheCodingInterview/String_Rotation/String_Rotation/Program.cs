using System;

namespace String_Rotation
{
    internal class Program
    {
        /*
        Assume that you have a method that checks to see if one string is a substring of another.
        Write a method that check if two strings are substrings of one another given one rotation.

        Example:
            input -> "waterbottle", "erbottlewat"
            output -> true
        */

        private static void Main(string[] args)
        {
            Console.WriteLine(StringRotation("waterbottle", "erbottlewat"));
            Console.WriteLine(StringRotation("waterbttole", "erbottlewat"));
        }

        public static bool IsSubstring(string subStr, string str)
        {
            return str.Contains(subStr) ? true : false;
        }

        public static bool StringRotation(string str1, string str2)
        {
            for (int i = 0; i < str2.Length; i++)
            {
                var tmp = str2[0];
                str2 = str2.Remove(0, 1);
                str2 += tmp;

                if (str1 == str2) return true;
            }

            return false;
        }

        /*
        input -> "waterbottle", "erbottlewat"
        output -> true

        for i < str.Len
            str.Insert(str.Len - i)
                if str = str2
                    return true

        return false
        */
    }
}