using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCakeCandles
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/birthday-cake-candles/problem?h_r=next-challenge&h_v=zen
        private static void Main(string[] args)
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = birthdayCakeCandles(candles);
        }

        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles[0];
            int count = 0;
            foreach (int num in candles)
                if (num > max) max = num;

            foreach (int num in candles)
                if (num == max) count++;

            return count;
        }
    }
}