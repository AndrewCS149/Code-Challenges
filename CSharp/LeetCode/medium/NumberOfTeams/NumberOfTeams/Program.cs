using System;

namespace NumberOfTeams
{
    // link - https://leetcode.com/problems/count-number-of-teams/
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 3, 4, 1 };
            Console.WriteLine(numTeams(arr));
        }

        public static int numTeams(int[] arr)
        {
            // not my solution

            int n = arr.Length;
            int[] small = new int[n];
            int[] large = new int[n];

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] < arr[j])
                        large[i]++;
                    else
                        small[i]++;
                }
            }

            int count = 0;
            for (int i = n - 3; i >= 0; i--)
            {
                for (int j = i + 1; j < n - 1; j++)
                {
                    if (arr[i] < arr[j])
                        count += large[j];
                    else
                        count += small[j];
                }
            }
            return count;
        }
    }
}
