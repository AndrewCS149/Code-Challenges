using System;
using System.Collections;
using System.Collections.Generic;

namespace GameOfThrones1
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/game-of-thrones/problem
        private static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = gameOfThrones(s);

            Console.WriteLine(result);
        }

        private static string gameOfThrones(string s)
        {
            // Create a dictionary to hold all unique
            // chars. The key being the
            // character and the value being
            // the amount of times that value appears
            // in the string
            Dictionary<char, int> table = new Dictionary<char, int>();
            foreach (char ch in s)
            {
                if (table.ContainsKey(ch)) table[ch]++;
                else table.Add(ch, 1);
            }

            // Then loop through the dictionaries
            // values and count the amount of odd
            // values there are.
            int odds = 0;
            foreach (int val in table.Values)
            {
                if (val % 2 == 1) odds++;
            }

            // if there is one or zero odds, it
            // can be a palindrome. This is because
            // a palindrome can be made if all
            // characters counts are even, and
            // also if there is only one odd
            // character count (it can be
            // placed in the middle
            // of the palindrome).
            return odds <= 1 ? "YES" : "NO";
        }
    }
}