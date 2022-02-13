using System;

namespace URL_ify
{
    internal class Program
    {
        /*
         URLify

        Write a method to replace all spaces in a string with %20
         */

        private static void Main(string[] args)
        {
            Console.WriteLine(URLify("hello world! "));
        }

        public static string URLify(string str)
        {
            //return str.Replace(" ", "%20");

            // No built in method
            string newStr = "";
            foreach (char ch in str)
            {
                if (ch == ' ') newStr += "%20";
                else newStr += ch;
            }

            return newStr;
        }
    }
}