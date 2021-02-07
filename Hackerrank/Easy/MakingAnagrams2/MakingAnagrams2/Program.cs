using System;

namespace MakingAnagrams2
{
    internal class Program
    {
        // link - https://www.hackerrank.com/challenges/ctci-making-anagrams/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=strings
        // Complete the makeAnagram function below.
        private static int makeAnagram(string a, string b)
        {
            int count = 0;
            int[] idxs = new int[26];
            char[] abc = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            foreach (var ch in a)
                idxs[Array.IndexOf(abc, ch)]++;

            foreach (var ch in b)
                idxs[Array.IndexOf(abc, ch)]--;

            Array.ForEach(idxs, x => count += Math.Abs(x));

            return count;
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