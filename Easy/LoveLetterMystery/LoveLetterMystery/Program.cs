using System;

namespace LoveLetterMystery
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/the-love-letter-mystery/problem
        private static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                int result = theLoveLetterMystery(s);

                Console.WriteLine(result);
            }
        }

        private static int theLoveLetterMystery(string s)
        {
            int count = 0;
            for (int i = 0, k = s.Length - 1; i < s.Length / 2; i++, k--)
            {
                int num1 = Convert.ToInt32(s[i]);
                int num2 = Convert.ToInt32(s[k]);
                count += Math.Abs(num1 - num2);
            }

            return count;
        }
    }
}