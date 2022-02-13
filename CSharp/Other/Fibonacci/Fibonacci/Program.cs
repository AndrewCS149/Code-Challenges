using System;

namespace Fibonacci
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Fib2(6));
            Console.WriteLine(Fib(6));

        }

        private static long Fib(long n)
        {
            if (n <= 2) return 1;
            return Fib(n - 1) + Fib(n - 2);
        }

        private static long Fib2(long n, Dictionary<long, long> map = null)
        {
            if (map == null)
                map = new Dictionary<long, long>();

            if (n <= 2) return 1;
            if (map.ContainsKey(n)) return map[n];

            map[n] = Fib2(n - 1, map) + Fib2(n - 2, map);

            return map[n];
        }
    }
}

/*
 
 1  1  2  3  5  8  13
 
 1  2  3  4  5  6  7
 */
