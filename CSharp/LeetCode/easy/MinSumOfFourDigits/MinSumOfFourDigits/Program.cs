// https://leetcode.com/problems/minimum-sum-of-four-digit-number-after-splitting-digits/

using System;

namespace MinSumOfFourDigits
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(MinimumSum(2932));
        }


        public static int MinimumSum(int num)
        {
            char[] chars = num.ToString().ToCharArray();
            Array.Sort(chars);
            return int.Parse("" + chars[0] + chars[2]) + int.Parse("" + chars[1] + chars[3]);
        }
    }
}
