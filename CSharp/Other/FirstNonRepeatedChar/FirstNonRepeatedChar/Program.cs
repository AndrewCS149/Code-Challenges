using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstNonRepeatedChar
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(NonRepeatedChar("abccard"));
        }

        public static char NonRepeatedChar(string str)
        {
            HashSet<char> charSet = new HashSet<char>();
            List<char> charList = new List<char>();

            foreach (char ch in str)
            {
                if (charList.Contains(ch))
                    charList.Remove(ch);
                else
                    charList.Add(ch);
            }

            //foreach (char ch in str)
            //{
            //    if (!charSet.Add(ch))
            //        charSet.Remove(ch);
            //}

            return charList[0];
        }
    }
}