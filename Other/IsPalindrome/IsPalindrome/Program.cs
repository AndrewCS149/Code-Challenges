using System;

namespace IsPalindrome
{
    internal class Program
    {
        /*
        Write a method to determine whether a given string is or is not a palindrome.
        */

        private static void Main(string[] args)
        {
            string str = "1";

            while (str != "")
            {
                Console.WriteLine("Enter a string: ");
                str = Console.ReadLine();
                Console.WriteLine(IsPalindrome(str));
                Console.WriteLine();
            }
        }

        public static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
            {
                if (str[i] != str[str.Length - (1 + i)])
                    return false;
            }
            return true;
        }
    }
}