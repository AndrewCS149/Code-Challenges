using System;
using System.Diagnostics;
using System.Numerics;

namespace Recursive_Multiply
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(PrintNum(0));
            Console.WriteLine(PrintNum(2));
            Console.WriteLine(PrintNum(25));
            Console.WriteLine(PrintNum(125));
            Console.WriteLine(PrintNum(1125));
            Console.WriteLine(PrintNum(10125));
            Console.WriteLine(PrintNum(125455));
            Console.WriteLine(PrintNum(1025250));
            Console.WriteLine(PrintNum(1025250000));
        }

        public static long RecursiveMultiply(int a, int b)
        {
            if (b == 0) return 0;
            return a + RecursiveMultiply(a, --b);
        }

        public static long RunningSum(long[] n)
        {
            return RunningSum(n, 0);
        }

        public static long RunningSum(long[] n, long counter)
        {
            if (counter == n.Length - 1) return n[n.Length - 1];
            return n[counter] + RunningSum(n, ++counter);
        }

        public static BigInteger Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }

        public static BigInteger FactorialIterative(int n)
        {
            BigInteger factorial = 1;
            for (int i = 2; i <= n; i++)
                factorial *= i;

            return factorial;
        }

        public static long FibRecursive(int n)
        {
            if (n == 1 || n == 0) return n;
            return FibRecursive(n - 1) + FibRecursive(n - 2);
        }

        public static long FibIterative(int n)
        {
            int[] arr = new int[n];
            arr[0] = 1; arr[1] = 1;

            for (int i = 2; i < n; i++)
                arr[i] = arr[i - 1] + arr[i - 2];

            return arr[n - 1];
        }

        public static long SumOfNumsRecursive(int n)
        {
            return n == 1 ? 1 : n + SumOfNumsRecursive(--n);
        }

        public static long SumOfNumsIterative(int n)
        {
            long sum = 0;
            for (int i = 1; i <= n; i++)
                sum += i;

            return sum;
        }

        public static string PrintNum(int num)
        {
            if (num == 0) return "zero";

            string word = "";
            if (num < 0)
                word += "minus " + PrintNum(num / 10);

            if (num / 1000000000 > 0)
            {
                word += PrintNum(num / 1000000000) + " billion ";
                num %= 1000000000;
            }
            if (num / 1000000 > 0)
            {
                word += PrintNum(num / 1000000) + " million ";
                num %= 1000000;
            }
            if (num / 1000 > 0)
            {
                word += PrintNum(num / 1000) + " thousand ";
                num %= 1000;
            }
            if (num / 100 > 0)
            {
                word += PrintNum(num / 100) + " hundred ";
                num %= 100;
            }
            if (num > 0)
            {
                if (word != "")
                    word += "and ";

                string[] units = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                string[] tens = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (num < 20)
                    word += units[num];
                else
                {
                    word += tens[num / 10];
                    if (num % 10 > 0)
                        word += " " + units[num % 10];
                }
            }
            return word;
        }
    }
}