// https://practice.geeksforgeeks.org/problems/move-all-negative-elements-to-end1813/1

using System;

namespace MoveNegElements
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] test = new int[] { 1, -1, 3, 2, -7, -5, 11, 6 };
            Array.ForEach(SegregateElements(test), n => Console.Write(n + " "));

            Console.WriteLine();

            int[] test2 = new int[] { -5, 7, -3, -4, 9, 10, -1, 11 };
            Array.ForEach(SegregateElements(test2), n => Console.Write(n + " "));
        }

        private static int[] SegregateElements(int[] arr)
        {

            // in place (takes too long)
            //int negs = 0;
            //for (int i = 0; i < arr.Length - negs; i++)
            //{
            //    if (arr[i] < 0)
            //    {
            //        negs++;
            //        int tmp = arr[i];

            //        for (int j = i; j < arr.Length - 1; j++)
            //            arr[j] = arr[j + 1];

            //        arr[arr.Length - 1] = tmp;
            //        i--;
            //    }
            //}

            //return arr;

            // using a list (single for loop)
            var result = new List<int>();

            int positives = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    result.Add(arr[i]);
                else
                    result.Insert(positives++, arr[i]);
            }

            return result.ToArray();
        }
    }
}
