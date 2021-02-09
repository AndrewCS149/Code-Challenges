using System;
using System.Collections;
using System.Linq;

namespace RansomNote
{
    internal class Program
    {
        // link - https://www.hackerrank.com/challenges/ctci-ransom-note/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=dictionaries-hashmaps
        private static void checkMagazine(string[] magazine, string[] note)
        {
            Hashtable table = new Hashtable();

            foreach (var word in note)
            {
                if (table.Contains(word))
                    table[word] = (int)table[word] + 1;
                else
                    table.Add(word, 1);
            }

            foreach (var word in magazine)
            {
                if (table.Contains(word))
                    table[word] = (int)table[word] - 1;
            }

            if (table.Values.Cast<int>().All(n => n <= 0))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }

        private static void Main(string[] args)
        {
            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            string[] magazine = Console.ReadLine().Split(' ');

            string[] note = Console.ReadLine().Split(' ');

            checkMagazine(magazine, note);
        }
    }
}