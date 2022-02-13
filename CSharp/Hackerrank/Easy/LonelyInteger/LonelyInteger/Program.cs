using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace LonelyInteger
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/lonely-integer/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;

            Console.WriteLine(lonelyinteger(a));
        }

        private static int lonelyinteger(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                bool flag = true;
                for (int k = 0; k < a.Length; k++)
                    if (a[i] == a[k] && i != k) flag = false;

                if (flag) return a[i];
            }
            return -1;
        }
    }
}