using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HackerrankInAString
{
    // easy
    // link to challenge - https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem
    internal class Program
    {
        private static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string s = Console.ReadLine();

                string result = hackerrankInString(s);
                Console.WriteLine(result);
            }
        }

        private static string hackerrankInString(string s)
        {
            // MY SOLUTION
            Stopwatch watch = new Stopwatch();
            watch.Start();
            string str = "hackerrank";
            string newStr = "";
            int idx = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (newStr == str) break;
                if (s[i] == str[idx])
                {
                    newStr += s[i];
                    idx++;
                }
            }
            return newStr == str ? "YES" : "NO";

            // ONLINE SOLUTION
            //var queue = new Queue<char>("hackerrank".ToCharArray());

            //foreach (char ch in s)
            //{
            //    if (ch == queue.Peek()) queue.Dequeue();
            //    if (queue.Count == 0)
            //    {
            //        Console.WriteLine($"RUNTIME: {watch.ElapsedMilliseconds}");

            //        return "YES";
            //    }
            //}
            watch.Stop();
            Console.WriteLine($"RUNTIME: {watch.ElapsedMilliseconds}");
            //return "NO";
        }
    }
}