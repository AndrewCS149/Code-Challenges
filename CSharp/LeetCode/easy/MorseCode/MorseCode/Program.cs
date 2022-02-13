using System;
using System.Collections.Generic;

namespace MorseCode
{
    class Program
    {

        // link - https://leetcode.com/problems/unique-morse-code-words/submissions/
        static void Main(string[] args)
        {
            string[] test = {"zocd","gjkl","hzqk","hzgq","gjkl"};
            Console.WriteLine(UniqueMorseRepresentations(test));
        }

        public static int UniqueMorseRepresentations(string[] words)
        {
            if (words.Length == 0) return 0;

            string[] alpha = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };

            int count = 1;
            string word = "";
            for (int i = 0; i < words[0].Length; i++)
                word += alpha[words[0][i] - 'a'];

            var list = new List<string>();
            list.Add(word);
            for (int i = 1; i < words.Length; i++)
            {
                string tmp = "";
                for (int j = 0; j < words[i].Length; j++)
                    tmp += alpha[words[i][j] - 'a'];

                if (!list.Contains(tmp))
                {
                    count++;
                    list.Add(tmp);
                }
            }

            return count;
        }
    }
}
