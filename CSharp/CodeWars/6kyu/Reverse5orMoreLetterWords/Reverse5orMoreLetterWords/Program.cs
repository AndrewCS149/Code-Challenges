// https://www.codewars.com/kata/5264d2b162488dc400000001/solutions/csharp

using System;

namespace Reverse5orMoreLetterWords
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(SpinWords("Welcome"));
        }

        public static string SpinWords(string sentence)
        {
            //string[] words = sentence.Split(' ');

            //for (int i = 0; i < words.Length; i++)
            //{
            //    if (words[i].Length >= 5)
            //    {
            //        char[] tmp = words[i].ToCharArray();
            //        Array.Reverse(tmp);
            //        words[i] = new string(tmp);
            //    }
            //}

            //return string.Join(" ", words);

            // online solution
            return string.Join(" ", sentence.Split(' ').Select(str => str.Length >= 5 ? new string(str.Reverse().ToArray()) : str));
        }
    }
}
