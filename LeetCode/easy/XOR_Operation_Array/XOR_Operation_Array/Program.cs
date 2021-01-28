using System;

namespace XOR_Operation_Array
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(XorOperation(5, 0));
            Console.WriteLine(XorOperation(4, 3));
            Console.WriteLine(XorOperation(1, 7));
            Console.WriteLine(XorOperation(10, 5));
        }

        public static int XorOperation(int n, int start)
        {
            // ONLINE SOLUTION
            int num = start;
            for (int i = 1; i < n; i++)
                num ^= (start + 2 * i);

            // MY SOLUTION
            //if (n <= 1) return start;

            //int[] arr = new int[n];
            //int num = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    arr[i] = start + 2 * i;
            //    if (i == 1)
            //        num = arr[1] ^ arr[0];
            //    else if (i > 1)
            //        num ^= arr[i];
            //}

            return num;
        }
    }
}