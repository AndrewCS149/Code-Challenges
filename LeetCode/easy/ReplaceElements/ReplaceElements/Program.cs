using System;
using System.Linq;

namespace ReplaceElements
{
    // https://leetcode.com/problems/replace-elements-with-greatest-element-on-right-side/
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = { 17, 18, 5, 4, 6, 1 };
            int[] newArr = ReplaceElements(arr);
            Array.ForEach(newArr, x => Console.Write(x + ", "));
        }

        //[18,6,6,6,1,-1]
        public static int[] ReplaceElements(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int max = 0;
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[j] > max) max = arr[j];
                arr[i] = max;
            }

            arr[arr.Length - 1] = -1;
            return arr;

            // VERY SLOW
            //arr[arr.Length - 1] = -1;

            //for (int i = 1; i < arr.Length; i++)
            //    arr[i - 1] = arr.Skip(i).Take(arr.Length - i).Max();

            //arr[arr.Length - 1] = -1;
            //return arr;
        }
    }
}