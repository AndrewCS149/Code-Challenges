using System;

namespace AppleAndOrange
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/apple-and-orange/problem
        private static void Main(string[] args)
        {
            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp));

            countApplesAndOranges(s, t, a, b, apples, oranges);
        }

        private static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
        {
            int appleCount = 0, orangeCount = 0;

            foreach (int apple in apples)
                if (a + apple >= s && a + apple <= t) appleCount++;

            foreach (int orange in oranges)
                if (b + orange <= t && b + orange >= s) orangeCount++;

            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }
    }
}