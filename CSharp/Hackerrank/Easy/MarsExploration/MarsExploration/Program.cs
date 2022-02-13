using System;

namespace MarsExploration
{
    // easy
    // link to challenge - https://www.hackerrank.com/challenges/mars-exploration/problem
    internal class Program
    {
        private static void Main(string[] args)
        {
            string s = Console.ReadLine();

            int result = marsExploration(s);

            Console.WriteLine(result);
        }

        private static int marsExploration(string s)
        {
            int count = 0;
            string str = "SOS";
            for (int i = 0; i < s.Length; i++)
            {
                // MY SOLUTION
                //if (i == str.Length) str += "SOS";
                //if (s[i] != str[i]) count++;

                // ONLINE DISCUSSION SOLUTION
                if (s[i] != str[i % 3]) count++;
            }
            return count;
        }
    }
}