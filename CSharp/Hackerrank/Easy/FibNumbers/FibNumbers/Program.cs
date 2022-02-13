using System;

namespace FibNumbers
{
    // link - https://www.hackerrank.com/challenges/ctci-fibonacci-numbers/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=recursion-backtracking
    class Program
    {
        public static int Fibonacci(int n)
        {
            return n <= 2 ? 1 : Fibonacci(n - 1) + Fibonacci(n - 2);
        }


        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fibonacci(n));
        }
    }
}
