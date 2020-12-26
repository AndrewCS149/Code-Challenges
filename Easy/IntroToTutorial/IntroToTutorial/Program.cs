using System;

namespace IntroToTutorial
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/tutorial-intro/problem
        private static void Main(string[] args)
        {
            int V = Convert.ToInt32(Console.ReadLine());

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = introTutorial(V, arr);

            Console.WriteLine(result);
        }

        private static int introTutorial(int V, int[] arr)
        {
            return Array.IndexOf(arr, V);
        }
    }
}