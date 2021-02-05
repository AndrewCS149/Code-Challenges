using System;

namespace StringConvert2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(ConvertToString(255));
            Console.WriteLine(ConvertToString(5));
            Console.WriteLine(ConvertToString(2556));
            Console.WriteLine(ConvertToString(2558895));
        }

        public static char Units(int num)
        {
            char[] unitsMap = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            return unitsMap[num];
        }

        public static string ConvertToString(int num)
        {
            string str = "";

            if (num / 1000000000 > 0)
            {
                str += ConvertToString(num / 1000000000);
                num %= 1000000000;
            }

            if (num / 1000000 > 0)
            {
                str += ConvertToString(num / 1000000);
                num %= 1000000;
            }

            if (num / 1000 > 0)
            {
                str += ConvertToString(num / 1000);
                num %= 1000;
            }

            if (num / 100 > 0)
            {
                str += ConvertToString(num / 100);
                num %= 100;
            }

            if (num / 10 > 0)
            {
                str += ConvertToString(num / 10);
                num %= 10;
            }

            str += Units(num);
            return str;
        }
    }
}