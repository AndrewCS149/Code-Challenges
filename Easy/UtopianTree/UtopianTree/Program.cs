using System;

namespace UtopianTree
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/utopian-tree/problem
        private static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                int result = utopianTree(n);

                Console.WriteLine(result);
            }
        }

        private static int utopianTree(int n)
        {
            int height = 1;
            bool spring = true;
            for (int i = 0; i < n; i++)
            {
                height = spring ? height * 2 : ++height;
                spring = spring ? false : true;
            }

            return height;
        }
    }
}