/*
 Write a program that takes a phone number as input and prints out all the letter
combinations corresponding to that number. For example, if 227-8255 is the input, one of 
the printed combinations will be "CAR-TALK"
 */

using System;

namespace LetterCombinations
{
    public class Program
    {
        private static void Main(string[] args)
        {
            LetterCombos("1(815)-995-2241");
        }

        public static void LetterCombos(string digits, string[] keymap = null, int idx = 0, string curStr = "")
        {
            char[] validKeys = { '2', '3', '4', '5', '6', '7', '8', '9' };
            if (curStr.Length == digits.Length)
            {
                Console.WriteLine(curStr);
                return;
            }

            char key = digits[idx];
            while (!validKeys.Contains(key))
            {
                curStr += key;
                idx++;

                if (curStr.Length == digits.Length)
                {
                    Console.WriteLine(curStr);
                    return;
                }

                key = digits[idx];
            }


            if (keymap == null)
                keymap = new string[] { "", "", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };

            string curKeys = keymap[(int)char.GetNumericValue(key)];

            for (int i = 0; i < curKeys.Length; i++)
                LetterCombos(digits, keymap, idx + 1, curStr + curKeys[i]);
        }
    }
}
