// https://www.codewars.com/kata/54b42f9314d9229fd6000d9c/train/csharp

using System;

namespace DuplicateEncoder
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(DuplicateEncode("din"));
            Console.WriteLine(DuplicateEncode("recede"));
            Console.WriteLine(DuplicateEncode("Success"));
            Console.WriteLine(DuplicateEncode("(( @"));
        }

        public static string DuplicateEncode(string word)
        {
            string result = "";
            word = word.ToLower();

            foreach (char c in word)
                result += word.Count(x => x == c) > 1 ? ")" : "(";

            return result;
        }
    }
}
