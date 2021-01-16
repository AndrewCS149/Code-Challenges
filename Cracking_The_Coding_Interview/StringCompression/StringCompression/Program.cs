using System;

namespace StringCompression
{
    internal class Program
    {
        /*
         Create a method to perrform basic string compression indicating the count of repeated characters.

        Examples:
            input -> "aabcccccaaa"
            output -> "a2b1c5a3"

         */

        private static void Main(string[] args)
        {
            Console.WriteLine(StrCompression("aaacccccddee"));
        }

        public static string StrCompression(string str)
        {
            string newStr = "";
            int count = 0;
            string tmp = str[0].ToString();

            foreach (char ch in str)
            {
                if (ch.ToString() == tmp) count++;
                else
                {
                    newStr += tmp + count;
                    count = 1;
                    tmp = ch.ToString();
                }
            }
            newStr += tmp + count;

            return newStr.Length < str.Length ? newStr : str;
        }

        /*
        str = ""
        count = 0
        tmp = str[0]
        for i < str.Len
            if str[i] = tmp
                count++
            else
                str += tmp + count
                count = 0
                tmp = str[i]

        return str
        */
    }
}