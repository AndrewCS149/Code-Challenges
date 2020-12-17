using System;

namespace SequenceEquation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp))
            ;
            int[] result = permutationEquation(p);

            Console.WriteLine(result);
        }

        private static int[] permutationEquation(int[] p)
        {
            int[] arr = new int[p.Length];
            for (int i = 1; i <= p.Length; i++)
            {
                int idx = Array.IndexOf(p, i) + 1;
                arr[i - 1] = Array.IndexOf(p, idx);
            }
            return arr;
        }
    }
}