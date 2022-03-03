// https://www.codewars.com/kata/520b9d2ad5c005041100000f/train/csharp

using System;

namespace SimplePigLatin
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(PigIt("Pig latin is cool"));
        }

        public static string PigIt(string str)
        {
            string[] strArr = str.Split(' ');

            for (int i = 0; i < strArr.Length; i++)
            {
                if (strArr[i].Length > 1)
                    strArr[i] = strArr[i].Substring(1) + strArr[i][0] + "ay";
            }

            return string.Join(" ", strArr);
        }
    }
}


