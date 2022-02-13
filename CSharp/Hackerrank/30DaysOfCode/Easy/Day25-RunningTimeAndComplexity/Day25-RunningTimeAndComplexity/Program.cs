using System;

namespace Day25_RunningTimeAndComplexity
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/30-running-time-and-complexity/problem?utm_campaign=30_days_of_code_continuous&utm_medium=email&utm_source=daily_reminder
        private static void Main(string[] args)
        {
            //int count = int.Parse(Console.ReadLine());
            //int[] nums = new int[count];

            //for (int i = 0; i < count; i++)
            //    nums[i] = int.Parse(Console.ReadLine());

            //foreach (var num in nums)
            //{
            //    bool isPrime = true;
            //    if (num == 1) isPrime = false;
            //    for (int i = 2; i < Math.Sqrt(num); i++)
            //    {
            //        if (num % i == 0)
            //        {
            //            isPrime = false;
            //            break;
            //        }
            //    }
            //    string str = isPrime ? "Prime" : "Not prime";
            //    Console.WriteLine(str);
            //}

            // NOT MY SOLUTION
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                for (int j = 2; j <= num / j; j++)
                    if (num % j == 0) num = 1;

                string output = num == 1 ? "Not prime" : "Prime";
                Console.WriteLine(output);
            }
        }
    }
}