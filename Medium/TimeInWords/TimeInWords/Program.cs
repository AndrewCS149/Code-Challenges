using System;

namespace TimeInWords
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int h = Convert.ToInt32(Console.ReadLine());

            int m = Convert.ToInt32(Console.ReadLine());

            string result = timeInWords(h, m);

            Console.WriteLine(result);
        }

        private static string timeInWords(int h, int m)
        {
            string min;
            string hr;
            string time = "";

            if (m == 00)
                time = $"{TimeStr(h)} o' clock";
            else if (h == 12)
            {
            }
            else if (m <= 30)
            {
                if (m < 20)
                    min = TimeStr(m);
                else
                    min = TensPlace(m);
                hr = TimeStr(h);

                if (min == "one")
                    time = $"{min} minute past {hr}";
                else if (min == "fifteen")
                    time = $"quarter past {hr}";
                else if (m == 30)
                    time = $"half past {hr}";
                else
                    time = $"{min} minutes past {hr}";
            }
            else
            {
                m = 60 - m;
                if (m < 20)
                    min = TimeStr(m);
                else
                    min = TensPlace(m);
                hr = TimeStr(h + 1);

                if (min == "one")
                    time = $"{min} minute to {hr}";
                else if (min == "fifteen")
                    time = $"quarter to {hr}";
                else
                    time = $"{min} minutes to {hr}";
            }

            return time;
        }

        private static string TensPlace(int min)
        {
            string time = "";

            // grab first digit
            int first = min;
            while (first >= 10)
                first /= 10;

            // grab last digit
            int last = min % 10;

            if (first == 2) time += "twenty";
            if (last != 0) time += $" {TimeStr(last)}";
            else
                time = TimeStr(min);

            return time;
        }

        private static string TimeStr(int hr)
        {
            string time = "";
            switch (hr)
            {
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                case 10: return "ten";
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "thirteen";
                case 14: return "fourteen";
                case 15: return "fifteen";
                case 16: return "sixteen";
                case 17: return "seventeen";
                case 18: return "eighteen";
                case 19: return "nineteen";
            }
            return time;
        }
    }
}