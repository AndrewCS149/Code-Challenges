using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MigratoryBirds
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/migratory-birds/problem
        private static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            Console.WriteLine(result);
        }

        // SOLUTION DERIVED FROM DISCUSSION POSTS
        private static int migratoryBirds(List<int> arr)
        {
            int[] ary = new int[arr.Count];
            for (int i = 0; i < arr.Count; i++)
                ary[arr[i]]++;

            int max = 0, maxPos = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                if (ary[i] > max)
                {
                    max = ary[i];
                    maxPos = i;
                }
            }
            return maxPos;
        }
    }
}