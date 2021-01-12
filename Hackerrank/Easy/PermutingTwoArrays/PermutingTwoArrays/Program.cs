using System;

namespace PermutingTwoArrays
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/two-arrays/problem?h_r=internal-search
        private static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int[] A = Array.ConvertAll(Console.ReadLine().Split(' '), ATemp => Convert.ToInt32(ATemp))
                ;

                int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), BTemp => Convert.ToInt32(BTemp))
                ;
                string result = twoArrays(k, A, B);

                Console.WriteLine(result);
            }
        }

        private static string twoArrays(int k, int[] A, int[] B)
        {
            Array.Sort(A);
            Array.Sort(B);

            int count = 0;
            for (int i = 0; i < A.Length; i++)
                if (A[i] + B[A.Length - (1 + i)] >= k) count++;

            return count == A.Length ? "YES" : "NO";
        }
    }
}