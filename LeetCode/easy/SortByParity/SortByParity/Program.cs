using System;

namespace SortByParity
{
    // https://leetcode.com/problems/sort-array-by-parity/submissions/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] SortArrayByParity(int[] A)
        {
            // var list = new List<int>();
            // list.AddRange(A.Select(x => x).Where(x => x % 2 == 0).ToArray());
            // list.AddRange(A.Select(x => x).Where(x => x % 2 == 1).ToArray());
            // return list.ToArray();

            int[] arr = new int[A.Length];
            int even = 0, odd = 1;
            foreach (int n in A)
            {
                if (n % 2 == 0)
                    arr[even++] = n;
                else
                    arr[A.Length - odd++] = n;
            }

            return arr;
        }
    }
}