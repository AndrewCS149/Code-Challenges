using System;
using System.Linq;

namespace Day14_Scope
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/30-scope/problem
        private static void Main(string[] args)
        {
            Convert.ToInt32(Console.ReadLine());

            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            Difference d = new Difference(a);

            d.computeDifference();

            Console.Write(d.maximumDifference);
        }
    }

    internal class Difference
    {
        private int[] elements;
        public int maximumDifference;

        public Difference(int[] elems)
        {
            elements = elems;
        }

        public void computeDifference()
        {
            maximumDifference = elements.Max() - elements.Min();
        }
    }
}