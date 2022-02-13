using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RomanToInt
{
    // link - https://leetcode.com/problems/roman-to-integer/
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Console.WriteLine(RomanToInt("III"));
            //Console.WriteLine(RomanToInt("IV"));
            //Console.WriteLine(RomanToInt("IX"));
            //Console.WriteLine(RomanToInt("LVIII"));
            Console.WriteLine(RomanToInt("MDCXCV"));
        }

        /*
         I  -  1
         V  -  5
         X  -  10
         L  -  50
         C  -  100
         D  -  500
         M  -  1000

         */

        public static int RomanToInt(string s)
        {
            var values = new Dictionary<char, int>()
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 }
            };

            int num = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 >= s.Length)
                {
                    num += values[s[i]];
                    break;
                }

                int tmp1 = values[s[i]];
                int tmp2 = values[s[i + 1]];

                if (tmp2 > tmp1)
                {
                    num += tmp2 - tmp1;
                    i++;
                }
                else
                    num += tmp1;
            }

            return num;
        }
    }
}