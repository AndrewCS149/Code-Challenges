using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace SaveThePrisoner
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/save-the-prisoner/problem
        private static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nms = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nms[0]);

                int m = Convert.ToInt32(nms[1]);

                int s = Convert.ToInt32(nms[2]);

                int result = saveThePrisoner(n, m, s);

                Console.WriteLine(result);
            }
        }

        /*
        input -> 5 2 1
        output -> 2

        input -> 5 2 2
        output -> 3

        edge cases:
            - zero candies
            - Always more than 0 prisoners
            - only one prisoner
            - only one candy
        */

        private static int saveThePrisoner(int n, int m, int s)
        {
            //int tempS = s;
            //for (int i = tempS; i < m + tempS; i++)
            //{
            //    if (s >= n)
            //    {
            //        s = 1;
            //    }
            //    else
            //    {
            //        s++;
            //    }
            //}

            // Not my solution
            return ((m - 1) + (s - 1)) % n + 1;
        }
    }
}