using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Missing_Numbers
{
    internal class Program
    {
        // link - https://www.hackerrank.com/challenges/missing-numbers/problem
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int m = Convert.ToInt32(Console.ReadLine());

            int[] brr = Array.ConvertAll(Console.ReadLine().Split(' '), brrTemp => Convert.ToInt32(brrTemp))
            ;
            int[] result = missingNumbers(arr, brr);

            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] missingNumbers(int[] arr, int[] brr)
        {
            int[] idxs = new int[brr.Max() + 1];
            for (int i = 0; i < brr.Length; i++)
            {
                idxs[brr[i]]++;
                if (i < arr.Length) idxs[arr[i]]--;
            }

            return idxs.Select((val, idx) => new { idx, val })
                       .Where(x => x.val > 0)
                       .Select(x => x.idx)
                       .ToArray();
        }
    }
}