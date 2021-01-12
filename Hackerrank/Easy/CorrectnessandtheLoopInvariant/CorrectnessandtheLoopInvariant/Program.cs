using System;
using System.Linq;

namespace CorrectnessandtheLoopInvariant
{
    internal class Program
    {
        // Easy
        // link to challenge - https://www.hackerrank.com/challenges/correctness-invariant/problem
        private static void Main(string[] args)
        {
            Console.ReadLine();
            int[] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
            insertionSort(_ar);
        }

        public static void insertionSort(int[] A)
        {
            var j = 0;
            for (var i = 0; i < A.Length; i++)
            {
                var value = A[i];
                j = i - 1;
                while (j > 0 && value < A[j])
                {
                    A[j + 1] = A[j];
                    j = j - 1;
                }
                A[j + 1] = value;
            }
            Console.WriteLine(string.Join(" ", A));
        }
    }
}