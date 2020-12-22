using System;

namespace FairRotations
{
    // easy
    // link to challenge - https://www.hackerrank.com/challenges/fair-rations/problem
    internal class Program
    {
        private static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());

            int[] B = Array.ConvertAll(Console.ReadLine().Split(' '), BTemp => Convert.ToInt32(BTemp))
            ;
            int result = fairRations(B);

            Console.WriteLine(result);
        }

        // SOLUTION DERIVED FROM ONLINE DISCUSSION
        private static int fairRations(int[] B)
        {
            int count = 0;
            int sum = 0;
            Array.ForEach(B, x => sum += x);
            if (sum % 2 == 1)
            {
                Console.WriteLine("NO");
                return default;
            }
            else
            {
                for (int i = 0; i < B.Length; i++)
                {
                    if (B[i] % 2 != 0)
                    {
                        B[i] = B[i] + 1;
                        B[i + 1] = B[i + 1] + 1;
                        count += 2;
                    }
                }
            }
            return count;
        }
    }
}