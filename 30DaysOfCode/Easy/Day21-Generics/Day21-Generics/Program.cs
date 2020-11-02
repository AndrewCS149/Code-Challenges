using System;

namespace Day21_Generics
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/30-generics/problem?utm_campaign=30_days_of_code_continuous&utm_medium=email&utm_source=daily_reminder
        private static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            n = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                stringArray[i] = Console.ReadLine();
            }

            PrintArray<Int32>(intArray);
            PrintArray<String>(stringArray);
        }

        public static void PrintArray<T>(T[] values)
        {
            Array.ForEach(values, x => Console.WriteLine(x));
        }
    }
}