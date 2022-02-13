using System;

namespace DecryptString
{
    class Program
    {
        // https://leetcode.com/problems/decrypt-string-from-alphabet-to-integer-mapping/submissions/
        static void Main(string[] args)
        {
            Console.WriteLine(FreqAlphabets("10#11#12"));
        }

        public static string FreqAlphabets(string s)
        {
            string word = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 2 < s.Length && s[i + 2] == '#')
                {
                    int tmp = int.Parse($"{s[i++]}{s[i++]}");
                    word += (char)('a' + tmp - 1);
                    continue;
                }

                word += (char)('a' + int.Parse($"{s[i]}") - 1);
            }

            return word;
        }
    }
}
