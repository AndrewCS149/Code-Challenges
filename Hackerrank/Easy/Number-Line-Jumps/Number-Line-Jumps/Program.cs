using System;

namespace Number_Line_Jumps
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/kangaroo/problem
        private static void Main(string[] args)
        {
            string[] x1V1X2V2 = Console.ReadLine().Split(' ');

            int x1 = Convert.ToInt32(x1V1X2V2[0]);

            int v1 = Convert.ToInt32(x1V1X2V2[1]);

            int x2 = Convert.ToInt32(x1V1X2V2[2]);

            int v2 = Convert.ToInt32(x1V1X2V2[3]);

            string result = kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);
        }

        private static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if ((x1 < x2 && v1 < v2)
                || (x1 > x2 && v1 > v2)
                || (x1 != x2 && v1 == v2))
            {
                return "NO";
            }
            else if ((x1 - x2) % (v2 - v1) == 0) return "YES";
            return "NO";
        }
    }
}