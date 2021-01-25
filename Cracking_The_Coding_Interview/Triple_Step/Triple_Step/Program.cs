using System;
using System.Diagnostics;

namespace Triple_Step
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int result = TripleStep(35);
            watch.Stop();
            Console.WriteLine($"Recursive : {result}. Runtime : {watch.ElapsedMilliseconds} ms.");

            watch.Reset();
            Console.WriteLine();

            watch.Start();
            int result2 = TripleStepIterative(35);
            watch.Stop();
            Console.WriteLine($"Iterative: {result2}. Runtime: {watch.ElapsedMilliseconds} ms.");
        }

        public static int TripleStep(int steps)
        {
            if (steps < 0) return 0;
            if (steps == 0 || steps == 1) return 1;

            return TripleStep(steps - 1) + TripleStep(steps - 2) + TripleStep(steps - 3);
        }

        public static int TripleStepIterative(int steps)
        {
            int[] arr = new int[steps + 1];
            arr[0] = 1;
            arr[1] = 1;
            arr[2] = 2;
            for (int i = 3; i <= steps; i++)
                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];

            return arr[steps];
        }
    }
}