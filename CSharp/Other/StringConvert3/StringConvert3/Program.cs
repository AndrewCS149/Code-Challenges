using System;

namespace StringConvert3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(StringToNum("1255789"));
        }

        public static int StringToNum(string str)
        {
            int num = 0;

            foreach (char ch in str)
            {
                char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                int tmp = Array.IndexOf(arr, ch);
                num = num * 10 + tmp;
            }

            return num;
        }

        public static string NumToString(int num)
        {
            string word = "";

            if (num / 1000000000 > 0)
            {
                word += NumToString(num / 1000000000);
                num %= 1000000000;
            }
            if (num / 1000000 > 0)
            {
                word += NumToString(num / 1000000);
                num %= 1000000;
            }
            if (num / 1000 > 0)
            {
                word += NumToString(num / 1000);
                num %= 1000;
            }
            if (num / 100 > 0)
            {
                word += NumToString(num / 100);
                num %= 100;
            }
            if (num / 10 > 0)
            {
                word += NumToString(num / 10);
                num %= 10;
            }

            string[] units = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            word += units[num];

            return word;
        }
    }
}