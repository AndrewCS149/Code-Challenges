using System;
using System.Collections.Generic;
using System.Linq;

namespace Decompress_RLE_List
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = DecompressRLEList(new int[] { 1, 2, 3, 4 });
            Array.ForEach(arr, x => Console.Write(x));
        }

        public static int[] DecompressRLEList(int[] nums)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < nums.Length; i += 2)
            {
                for (int k = 0; k < nums[i]; k++)
                    list.Add(nums[i + 1]);
            }
            return list.ToArray();
        }
    }
}