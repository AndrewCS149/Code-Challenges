using System;
using System.Threading;

namespace TimeConversion
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/time-conversion/problem
        private static void Main(string[] args)
        {
            string s = Console.ReadLine();

            string result = timeConversion(s);
            Console.WriteLine(result);
        }

        private static string timeConversion(string s)
        {
            // BRUTE FORCE(ish)
            //int hours = Int32.Parse(s.Substring(0, 2));
            //string militaryTime;
            //bool morning = false;
            //if (s.Substring(s.Length - 2).ToUpper() == "AM")
            //    morning = true;

            //if (morning == true)
            //{
            //    if (hours == 12)
            //        hours = 0;

            //    if (hours < 10)
            //        militaryTime = "0" + hours.ToString() + s.Substring(2, s.Length - 4);
            //    else
            //        militaryTime = hours.ToString() + s.Substring(2, s.Length - 4);
            //}
            //else
            //{
            //    if (hours == 12)
            //        hours = 12;
            //    else
            //        hours = 24 - (12 - hours);

            //    militaryTime = hours.ToString() + s.Substring(2, s.Length - 4);
            //}

            // SIMPLER SOLUTION
            DateTime militaryTime = DateTime.Parse(s.Insert(s.Length - 2, " "));
            return militaryTime.ToString("HH:mm:ss");
        }
    }
}