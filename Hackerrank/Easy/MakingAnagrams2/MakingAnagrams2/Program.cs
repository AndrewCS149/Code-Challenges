using System;
using System.Linq;

namespace MakingAnagrams2
{
    internal class Program
    {
        // link - https://www.hackerrank.com/challenges/ctci-making-anagrams/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
        // Complete the makeAnagram function below.
        private static int makeAnagram(string a, string b)
        {
            int[] idxs = new int[26];

            for (int i = 0; i < a.Length; i++)
                idxs[a[i] - 'a']++;

            for (int i = 0; i < b.Length; i++)
                idxs[b[i] - 'a']--;

            return idxs.Select(i => Math.Abs(i)).Sum();
        }

        private static void Main(string[] args)
        {
            string a = Console.ReadLine();

            string b = Console.ReadLine();

            int res = makeAnagram(a, b);

            Console.WriteLine(res);
        }
    }
}