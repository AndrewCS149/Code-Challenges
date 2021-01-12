using System;
using System.Security.Cryptography.X509Certificates;

namespace AngryProfessor
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/angry-professor/problem
        private static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
                ;
                string result = angryProfessor(k, a);
                Console.WriteLine(result);
            }
        }

        /*
        input -> 3, 2
                 -1, -1, 2
        output -> "NO"
        */

        // Complete the angryProfessor function below.
        private static string angryProfessor(int k, int[] a)
        {
            int max = 0;
            Array.ForEach(a, x => { if (x < 0) max++; });

            return max < k ? "YES" : "NO";
        }
    }
}