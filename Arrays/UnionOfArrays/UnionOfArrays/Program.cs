// https://practice.geeksforgeeks.org/problems/union-of-two-arrays3538/1

using System;

namespace UnionOfArrays
{
    public class Program
    {
        private static void Main(string[] args)
        {

        }

        private static int DoUnion(int[] a, int[] b)
        {
            var set = new HashSet<int>();

            Array.ForEach(a, num => set.Add(num));
            Array.ForEach(b, num => set.Add(num));

            return set.Count;
        }
    }
}
