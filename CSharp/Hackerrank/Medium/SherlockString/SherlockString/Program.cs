using System;
using System.Collections;

namespace SherlockString
{
    internal class Program
    {
        // link - https://www.hackerrank.com/challenges/sherlock-and-valid-string/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
        private static string isValid(string s)
        {
            // not my solution
            if (s.Length == 0) return "NO";
            if (s.Length <= 3) return "YES";

            int[] slots = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                slots[s[i] - 'a']++;
            }

            Array.Sort(slots);

            int idx = 0;
            while (slots[idx] == 0)
                idx++;

            int min = slots[idx];
            int max = slots[25];
            if (min == max) return "YES";
            else
            {
                if (((max - min == 1) && (max > slots[24])) ||
                   (min == 1) && (slots[idx + 1] == max))
                    return "YES";
            }
            return "NO";
        }

        private static int FindMin(Hashtable table, int len)
        {
            int min = len;
            foreach (var val in table.Values)
                if ((int)val < min) min = (int)val;

            return min;
        }

        private static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = isValid(s);

            Console.WriteLine(result);
        }

        /*
                     Hashtable table = new Hashtable();
            foreach (var ch in s)
            {
                if (table.Contains(ch))
                    table[ch] = (int)table[ch] + 1;
                else
                    table.Add(ch, 1);
            }

            // find min val from table
            int min = s.Length;
            foreach (var val in table.Values)
                if ((int)val < min) min = (int)val;

            bool canDecrement = true;
            foreach (var val in table.Values)
            {
                if ((int)val == min) continue;

                if (canDecrement)
                {
                    if ((int)val - 1 > min) return "NO";
                    canDecrement = false;
                    continue;
                }

                if ((int)val > min) return "NO";
            }

            return "YES";
         */
    }
}