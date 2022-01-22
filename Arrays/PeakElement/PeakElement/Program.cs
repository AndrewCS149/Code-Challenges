using System;

namespace PeakElement
{
    // https://practice.geeksforgeeks.org/problems/peak-element/1

    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(PeakElementResult(new int[] { 1, 2, 3 }));
            Console.WriteLine(PeakElementResult(new int[] { 15 }));

        }

        private static int PeakElementResult(int[] arr)
        {
            // check first element or if array is of size 1
            if (arr.Length == 1 || arr[0] >= arr[1])
                return 0;

            // check middle elements
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] >= arr[i - 1] && arr[i] >= arr[i + 1])
                    return i;
            }

            // check last element
            if (arr[arr.Length - 1] >= arr[arr.Length - 2])
                return arr.Length - 1;

            return -1;
        }
    }
}
