using System;
using System.Linq;

namespace PlusMinus
{
    internal class Program
    {
        // link to challenge - https://www.hackerrank.com/challenges/plus-minus/problem?h_r=next-challenge&h_v=zen&h_r=next-challenge&h_v=zen
        private static void Main(string[] args)
        {
            plusMinus(new int[] { 1, 1, 0, -1, -1 });
        }

        private static void plusMinus(int[] arr)
        {
            decimal pos = 0, neg = 0, zero = 0, len = 0;
            foreach (int num in arr)
            {
                if (num < 0) neg++;
                else if (num > 0) pos++;
                else zero++;

                len++;
            }
            Console.WriteLine(string.Format("{0:N6}", pos / len));
            Console.WriteLine(string.Format("{0:N6}", neg / len));
            Console.WriteLine(string.Format("{0:N6}", zero / len));
        }
    }
}