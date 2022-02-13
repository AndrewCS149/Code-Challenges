using System;

namespace LisasWorkbook
{
    // easy
    // link to challenge - https://www.hackerrank.com/challenges/lisa-workbook/problem
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            int result = workbook(n, k, arr);
        }

        // ANSWER DERIVED FROM ONLINE DISCUSSION
        private static int workbook(int n, int k, int[] arr)
        {
            int count = 0;
            int page = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j <= arr[i]; j++)
                {
                    if (page == j) count++;
                    if (j % k == 0) page++;
                }
            }
            return count;
        }
    }
}