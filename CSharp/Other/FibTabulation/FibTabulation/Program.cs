using System;

namespace FibTabulation
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(FibTab(8));
            Console.WriteLine(FibTab(50));
        }

        public static long FibTab(int n)
        {
            long[] table = new long[n + 1];
            table[0] = 0;
            table[1] = 1;

            for (int i = 2; i < table.Length; i++)
                table[i] = table[i - 2] + table[i - 1];

            return table[table.Length - 1];
        }
    }
}
