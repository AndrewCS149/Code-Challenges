//https://www.codewars.com/kata/523f5d21c841566fde000009/train/csharp

using System.Collections.Generic;
namespace ArrayDiff
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var res1 = ArrayDiff(new int[] { 1, 2 }, new int[] { 1 });
            var res2 = ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 });
            var res3 = ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 });
            var res4 = ArrayDiff(new int[] { 1, 2, 2 }, new int[] { });
            var res5 = ArrayDiff(new int[] { }, new int[] { 1, 2 });
            var res6 = ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 });


        }

        public static int[] ArrayDiff(int[] a, int[] b)
        {
            var result = new List<int>();

            foreach (int n in a)
                if (!b.Contains(n))
                    result.Add(n);

            return result.ToArray();
        }
    }
}
