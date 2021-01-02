using System;

namespace BeautifulBinaryString
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/beautiful-binary-string/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            string b = Console.ReadLine();

            int result = beautifulBinaryString(b);

            Console.WriteLine(result);
        }

        private static int beautifulBinaryString(string b)
        {
            if (!b.Contains("010")) return 0;

            int count = b.Length - b.Replace("010", "").Length / 3;\
            return count;
        }
    }
}