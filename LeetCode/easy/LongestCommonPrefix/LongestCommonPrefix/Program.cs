using System;
using System.Linq;

namespace LongestCommonPrefix
{
    internal class Program
    {
        // https://leetcode.com/explore/featured/card/top-interview-questions-easy/127/strings/887/
        private static void Main(string[] args)
        {
            string[] arr = { "flower", "flow", "flight" };
            Console.WriteLine(LongestCommonPrefix(arr));
        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string pre = "";
            strs = strs.OrderBy(x => x.Length).ToArray();
            pre += strs[0][0];

            for (int i = 0; i < strs[0].Length - 1; i++)
            {
                pre += strs[0][i + 1];

                for (int j = 1; j < strs.Length; j++)
                {
                    string tmp = strs[j].Substring(0, pre.Length);

                    if (pre != tmp)
                        return i < 1 ? "" : pre.Substring(0, pre.Length - 1);
                }
            }

            return pre;
        }
    }
}