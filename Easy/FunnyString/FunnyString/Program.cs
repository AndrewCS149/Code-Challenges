using System;
using static System.Convert;
using static System.Math;
using System.Text;

namespace FunnyString
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/funny-string/problem
        private static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                string result = funnyString(s);

                Console.WriteLine(result);
            }
        }

        private static string funnyString(string s)
        {
            var arr1 = new int[s.Length - 1];
            var arr2 = new int[s.Length - 1];
            for (int i = 0, k = s.Length - 1; i < s.Length - 1; i++, k--)
            {
                int num1 = ToInt32(s[i]);
                int num2 = ToInt32(s[i + 1]);
                arr1[i] = Abs(num1 - num2);

                int num3 = ToInt32(s[k]);
                int num4 = ToInt32(s[k - 1]);
                arr2[i] = Abs(num3 - num4);

                if (arr1[i] != arr2[i]) return "Not Funny";
            }

            return "Funny";
        }
    }
}