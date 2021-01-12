using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;

namespace DiagonalDifference
{
    internal class Program
    {
        // link to challenge - https://www.hackerrank.com/challenges/diagonal-difference/problem?h_r=next-challenge&h_v=zen
        private static void Main(string[] args)
        {
            int[] s1 = { 1, 2, 3 };
            int[] s2 = { 4, 5, 6 };
            int[] s3 = { 9, 8, 9 };
            List<List<int>> m = new List<List<int>>();
            m.Add(s1.ToList<int>());
            m.Add(s2.ToList<int>());
            m.Add(s3.ToList<int>());

            Console.WriteLine(diagonalDifference(m));
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int diagSum1 = 0;
            int diagSum2 = 0;

            for (int i = 0, j = arr.Count - 1; i < arr.Count; i++, j--)
            {
                diagSum1 += arr[i][i];
                diagSum2 += arr[i][j];
            }
            return Math.Abs(diagSum1 - diagSum2);
        }
    }
}