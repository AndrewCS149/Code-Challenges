using System;
using System.Linq;
using System.Collections.Generic;

namespace MinimumDistances
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
            ;
            int result = minimumDistances(a);

            Console.WriteLine(result);
        }

        private static int minimumDistances(int[] a)
        {
            List<int> minDistances = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                int min = 0;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        int diff = j - i;
                        if (diff < min || min == 0)
                        {
                            min = diff;
                            minDistances.Add(min);
                        }
                    }
                }
            }

            return minDistances.Count > 0 ? minDistances.Min() : -1;
        }
    }
}