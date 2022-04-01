// https://www.codewars.com/kata/52597aa56021e91c93000cb0/train/csharp

using System;

namespace MoveZeroesToEnd
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var res1 = MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 });
            foreach (var i in res1) Console.Write(i + " ");
        }

        public static int[] MoveZeroes(int[] arr)
        {
            //var result = arr.ToList();
            //var zeroes = result.FindAll(x => x == 0);
            //result.RemoveAll(x => x == 0);
            //result.AddRange(zeroes);
            //return result.ToArray();

            // online solution
            return arr.OrderBy(x => x == 0).ToArray();
        }
    }
}
