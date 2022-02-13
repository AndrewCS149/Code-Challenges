using System;

namespace StringConvert
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(StrConvert("5"));
            Console.WriteLine(StrConvert("15"));
            Console.WriteLine(StrConvert("25"));
            Console.WriteLine(StrConvert("125"));
            Console.WriteLine(StrConvert("1250"));
            Console.WriteLine(StrConvert("12500"));
        }

        public static int StrConvert(string str)
        {
            int num = 0;
            for (int i = 0; i < str.Length; i++)
                num = num * 10 + UnitConvert(str[i]);

            return num;
        }

        private static int UnitConvert(char str)
        {
            char[] unitMap = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            return Array.IndexOf(unitMap, str);
        }
    }
}