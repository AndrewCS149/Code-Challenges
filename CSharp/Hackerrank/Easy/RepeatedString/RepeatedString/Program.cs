using System;

namespace RepeatedString
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string s = Console.ReadLine();

            long n = Convert.ToInt64(Console.ReadLine());

            long result = repeatedString(s, n);

            Console.WriteLine(result);
        }

        // SOLUTION DERIVED FROM MYSELF AND A DISCUSSION POST WITHIN THE CHALLENGE
        private static long repeatedString(string s, long n)
        {
            long count = 0, extra = 0;
            long len = s.Length;
            long div = n / len;
            long left = n - (len * div);
            foreach (char x in s)
                if (x == 'a') count++;

            for (int i = 0; i < left; i++)
                if (s[i] == 'a') extra++;

            return div * count + extra;
        }
    }
}