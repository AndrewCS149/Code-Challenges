using System;
using System.Collections.Generic;

namespace GreedyFlorist
{
    internal class Program
    {
        // medium
        // Link to challenge - https://www.hackerrank.com/challenges/greedy-florist/problem
        private static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
            ;
            int minimumCost = getMinimumCost(k, c);

            Console.WriteLine(minimumCost);
        }

        private static int getMinimumCost(int k, int[] c)
        {
            // SOLUTION FROM ONLINE FORUM
            int minCost = 0, tempCount = 0, prevPurchase = 0;
            Array.Sort(c);

            if (k >= c.Length)
            {
                for (int i = 0; i < c.Length; i++)
                {
                    minCost += c[i];
                }
            }
            else
            {
                for (int i = c.Length - 1; i >= 0; i--)
                {
                    if (tempCount == k)
                    {
                        tempCount = 0;
                        prevPurchase++;
                    }
                    minCost += (prevPurchase + 1) * c[i];
                    tempCount++;
                }
            }
            return minCost;

            //int idx1 = 0, minCost = 0;
            //List<int> list = new List<int>();
            //list.AddRange(c);
            //list.Sort();
            //list.Reverse();
            //int counter = 1;
            //for (int i = c.Length - 1; i >= 0; i--, idx1++)
            //{
            //    if (idx1 > k)
            //    {
            //        int num = (counter) * list[i];
            //        minCost += num;
            //    }
            //    else
            //    {
            //        minCost += list[i];
            //    }
            //    if (i > counter * k) counter++;
            //}

            //return minCost;
        }
    }
}