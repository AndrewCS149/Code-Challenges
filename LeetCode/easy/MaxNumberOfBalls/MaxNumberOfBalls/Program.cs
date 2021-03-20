using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxNumberOfBalls
{
    //https://leetcode.com/problems/maximum-number-of-balls-in-a-box/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(CountBalls(5, 15));
        }

        public static int CountBalls(int lowLimit, int highLimit)
        {
            var dict = new Dictionary<int, int>();
            for (int i = lowLimit; i <= highLimit; i++)
            {
                int tmp = i;
                int sum = 0;
                while (tmp > 0)
                {
                    int last = tmp % 10;
                    sum += last;
                    tmp /= 10;
                }

                if (dict.ContainsKey(sum))
                    dict[sum] = dict[sum] + 1;
                else
                    dict.Add(sum, 1);
            }

            return dict.Select(x => x.Key).Max();
        }
    }
}