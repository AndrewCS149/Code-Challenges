// https://leetcode.com/problems/integer-to-roman/
using System;

namespace IntToRoman
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(IntToRoman3(3000));
            Console.WriteLine(IntToRoman3(1994));
            Console.WriteLine(IntToRoman3(58));

            Console.WriteLine();

            Console.WriteLine(IntToRoman2(3000));
            Console.WriteLine(IntToRoman2(1994));
            Console.WriteLine(IntToRoman2(58));
        }

        public static string IntToRoman3(int num)
        {
            string result = "";
            var map = new Dictionary<string, int>()
            {
                {"M", 1000},{"D", 500 },{"C", 100 },
                {"L", 50 },{"X", 10 },{"V", 5 },
                {"I", 1 }
            };

            while (num > 0)
            {
                string tmp;
                bool oddNumeral = false;
                if (num >= 1000)
                {
                    tmp = "M";
                }
                else if (num >= 500)
                {
                    if (1000 - num <= 100)
                    {
                        tmp = "CM";
                        oddNumeral = true;
                    }
                    else
                        tmp = "D";
                }
                else if (num >= 100)
                {
                    if (500 - num <= 100)
                    {
                        tmp = "CD";
                        oddNumeral = true;
                    }
                    else
                        tmp = "C";
                }
                else if (num >= 50)
                {
                    if (100 - num <= 10)
                    {
                        tmp = "XC";
                        oddNumeral = true;
                    }
                    else
                        tmp = "L";
                }
                else if (num >= 10)
                {
                    if (10 - num <= 10)
                    {
                        tmp = "XL";
                        oddNumeral = true;
                    }
                    else
                        tmp = "X";
                }
                else if (num >= 5)
                {
                    if (10 - num <= 1)
                    {
                        tmp = "IX";
                        oddNumeral = true;
                    }
                    else
                        tmp = "V";
                }
                else if (num == 4)
                {
                    tmp = "IV";
                    oddNumeral = true;
                }
                else tmp = "I";

                result += tmp;

                if (oddNumeral)
                    num -= (map[tmp[1].ToString()] - map[tmp[0].ToString()]);
                else
                    num -= map[tmp];
            }

            return result;
        }

        public static string IntToRoman2(int num)
        {
            string result = "";
            var map = new Dictionary<string, int>()
            {
                {"M", 1000},  {"CM", 900 }, {"D", 500 },
                {"CD", 400 }, {"C", 100 },  {"XC", 90 },
                {"L", 50 },   {"XL", 40 },  {"X", 10 },
                {"IX", 9 },   {"V", 5 },    {"IV", 4 },
                {"I", 1 }
            };

            while (num > 0)
            {
                string tmp;
                if (num >= 1000) tmp = "M";
                else if (num >= 900) tmp = "CM";
                else if (num >= 500) tmp = "D";
                else if (num >= 400) tmp = "CD";
                else if (num >= 100) tmp = "C";
                else if (num >= 90) tmp = "XC";
                else if (num >= 50) tmp = "L";
                else if (num >= 40) tmp = "XL";
                else if (num >= 10) tmp = "X";
                else if (num >= 9) tmp = "IX";
                else if (num >= 5) tmp = "V";
                else if (num >= 4) tmp = "IV";
                else tmp = "I";

                result += tmp;
                num -= map[tmp];
            }

            return result;
        }

        public static string IntToRoman(int num)
        {
            string str = "";

            if (num >= 1000)
            {
                int rem = num / 1000;
                str += string.Concat(Enumerable.Repeat("M", 1 * rem));
                str += IntToRoman(num % 1000);
            }
            else if (num >= 900)
            {
                int rem = num / 900;
                str += string.Concat(Enumerable.Repeat("CM", 1 * rem));
                str += IntToRoman(num % 900);
            }
            else if (num >= 500)
            {
                int rem = num / 500;
                str += string.Concat(Enumerable.Repeat("D", 1 * rem));
                str += IntToRoman(num % 500);
            }
            else if (num >= 400)
            {
                int rem = num / 400;
                str += string.Concat(Enumerable.Repeat("CD", 1 * rem));
                str += IntToRoman(num % 400);
            }
            else if (num >= 100)
            {
                int rem = num / 100;
                str += string.Concat(Enumerable.Repeat("C", 1 * rem));
                str += IntToRoman(num % 100);
            }
            else if (num >= 90)
            {
                int rem = num / 90;
                str += string.Concat(Enumerable.Repeat("XC", 1 * rem));
                str += IntToRoman(num % 90);
            }
            else if (num >= 50)
            {
                int rem = num / 50;
                str += string.Concat(Enumerable.Repeat("L", 1 * rem));
                str += IntToRoman(num % 50);
            }
            else if (num >= 40)
            {
                int rem = num / 40;
                str += string.Concat(Enumerable.Repeat("XL", 1 * rem));
                str += IntToRoman(num % 40);
            }
            else if (num >= 10)
            {
                int rem = num / 10;
                str += string.Concat(Enumerable.Repeat("X", 1 * rem));
                str += IntToRoman(num % 10);
            }
            else if (num >= 9)
            {
                int rem = num / 9;
                str += string.Concat(Enumerable.Repeat("IX", 1 * rem));
                str += IntToRoman(num % 9);
            }
            else if (num >= 5)
            {
                int rem = num / 5;
                str += string.Concat(Enumerable.Repeat("V", 1 * rem));
                str += IntToRoman(num % 5);
            }
            else if (num >= 4)
            {
                int rem = num / 4;
                str += string.Concat(Enumerable.Repeat("IV", 1 * rem));
                str += IntToRoman(num % 4);
            }
            else
            {
                string[] map = { "", "I", "II", "III" };
                str += map[num];
            }

            return str;
        }
    }
}
