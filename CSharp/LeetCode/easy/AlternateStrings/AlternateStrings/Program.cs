using System;

namespace AlternateStrings
{
    // https://leetcode.com/problems/merge-strings-alternately/submissions/
    class Program
    {
        static void Main(string[] args)
        {
            //            
            
            // output -> "cadf"

            Console.WriteLine(MergeAlternately("cdf", "a"));    
        }

        public static string MergeAlternately(string word1, string word2)
        {
            string newWord = "";

            int i;
            for (i = 0; i < Math.Min(word1.Length, word2.Length); i++)
                newWord += $"{word1[i]}{word2[i]}";

            if (i < word1.Length)
                newWord += word1.Substring(i);
            else if (i < word2.Length)
                newWord += word2.Substring(i);

            return newWord;
        }
    }
}
