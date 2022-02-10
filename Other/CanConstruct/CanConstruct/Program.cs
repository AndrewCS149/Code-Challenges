/*
 Write a function CanConstruct(target, wordBank) that accepts a string and an array of strings

The function should return a boolean indicating whether or not the target can be constructed by concatenating elements of the wordBank array

you may reuse elements of workBank as many times as needed.
 */

using System;
using System.Diagnostics;

namespace CanConstruct
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //string[] test1 = { "wo", "ea", "ber", "dr", "rd" };
            //Console.WriteLine(Construct("word", test1));

            //Console.WriteLine(Construct("abcdef", new string[] { "ab", "abc", "cd", "def", "abcd" }));
            //Console.WriteLine(Construct("stakeboard", new string[] { "bo", "rd", "ate", "t", "ska", "sk", "board" }));

            //Console.WriteLine(Construct("enterpotentpot", new string[] { "a", "p", "ent", "enter", "ot", "o", "t" }));

            Console.WriteLine(Construct("applepenapple", new string[] { "apple", "pen" }));

            Console.WriteLine(Construct("ccbb", new string[] { "bc", "cb" }));

            var watch = new Stopwatch();

            watch.Start();
            Console.WriteLine(Construct("eeeeeeeeeeeeeeeeeeeeeeeeeeeeeef", new string[] { "e", "ee", "eee", "eeee", "eeeee", "eeeeee" }));
            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
        }

        //private static bool Construct(string target, string[] wordBank, string word = "")
        //{
        //    if (word == target) return true;
        //    if (word.Length > target.Length) return false;

        //    foreach (string str in wordBank)
        //        if (Construct(target, wordBank, word + str)) return true;

        //    return false;
        //}

        private static bool Construct(string target, string[] wordBank, Dictionary<string, bool> memo = null)
        {
            if (memo == null) memo = new Dictionary<string, bool>();

            if (memo.ContainsKey(target)) return memo[target];
            if (target == "") return true;

            foreach (string word in wordBank)
            {
                if (target.IndexOf(word) == 0)
                {
                    if (Construct(target.Substring(word.Length), wordBank, memo))
                    {
                        memo[target] = true;
                        return true;
                    }
                }
                memo[target] = false;
            }

            return false;
        }
    }
}
