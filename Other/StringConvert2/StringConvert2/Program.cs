using System;

namespace StringConvert2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(StrToNum("55"));
            Console.WriteLine(StrToNum("10052"));
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

        public static int StrToNum(string str)
        {
            int num = 0;

            foreach (char ch in str)
            {
                int tmp = ConvertUnit(ch);
                num = num * 10 + tmp;
            }

            return num;
        }

        public static int ConvertUnit(char ch)
        {
            switch (ch)
            {
                case '1': return 1;
                case '2': return 2;
                case '3': return 3;
                case '4': return 4;
                case '5': return 5;
                case '6': return 6;
                case '7': return 7;
                case '8': return 8;
                case '9': return 9;
                default: return 0;
            }
        }
    }
}