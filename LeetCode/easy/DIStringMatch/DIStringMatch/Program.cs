using System;

namespace DIStringMatch
{
    // https://leetcode.com/problems/di-string-match/submissions/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] DiStringMatch(string S)
        {
            int[] arr = new int[S.Length + 1];
            int inc = 0, dec = arr.Length - 1;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'I')
                    arr[i] = inc++;
                else
                    arr[i] = dec--;
            }
            arr[arr.Length - 1] = inc;
            return arr;
        }
    }
}