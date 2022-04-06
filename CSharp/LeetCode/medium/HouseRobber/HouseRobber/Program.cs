
// https://leetcode.com/problems/house-robber/

using System;

namespace HouseRobber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Rob(new int[] { 1, 2, 3, 1 }));
            Console.WriteLine(Rob(new int[] { 2, 7, 9, 3, 1 }));
            Console.WriteLine(Rob(new int[] { 1, 3, 1 }));
            Console.WriteLine(Rob(new int[] { 1, 1, 1, 1 }));
            Console.WriteLine(Rob(new int[] { 183, 219, 57, 193, 94, 233, 202, 154, 65, 240, 97, 234, 100, 249, 186, 66, 90, 238, 168, 128, 177, 235, 50, 81, 185, 165, 217, 207, 88, 80, 112, 78, 135, 62, 228, 247, 211 }));

        }

        // TOo SLOW!!! Cant figure out how to memo it
        public static int Rob(int[] nums)
        {
            var listNums = nums.ToList();
            if (listNums.Count == 0) return 0;
            else if (listNums.Count <= 2) return listNums.Max();

            int totalCash = 0;
            for (int i = 0; i < listNums.Count; i++)
            {
                int tmpCash = 0;

                var tmpList = new List<int>(listNums);

                tmpCash += tmpList[i];
                if (i + 1 < tmpList.Count) tmpList.RemoveAt(i + 1);
                tmpList.RemoveAt(i);
                if (i - 1 >= 0) tmpList.RemoveAt(i - 1);
                tmpCash += Rob(tmpList.ToArray());

                if (tmpCash > totalCash) totalCash = tmpCash;
            }

            return totalCash;
        }
    }
}
