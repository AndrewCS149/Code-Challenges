// https://leetcode.com/problems/combination-sum/

using System;
using System.Diagnostics;

namespace CombinationSum
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Print(new int[] { 2, 3, 6, 7 }, 7);
            //Print(new int[] { 2, 3, 5 }, 8);
            //Print(new int[] { 10, 25 }, 400);
        }


        public static void Print(int[] candidates, int target)
        {
            var w = new Stopwatch();

            w.Start();
            var lists = CombSum(candidates, target);
            w.Stop();

            foreach (var list in lists)
            {
                foreach (var num in list) Console.Write(num + " ");
                Console.WriteLine();
            }

            Console.WriteLine("TIME: " + w.ElapsedMilliseconds);
            Console.WriteLine();
        }


        // online solution
        public static IList<IList<int>> CombSum(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            CombSum(candidates, target, result, new List<int>(), 0);
            return result;
        }

        public static void CombSum(int[] candidates, int target, List<IList<int>> result, List<int> tmpList, int idx)
        {
            if (target < 0) return;
            if (target == 0) result.Add(new List<int>(tmpList));
            else
            {
                for (int i = idx; i < candidates.Length; i++)
                {
                    tmpList.Add(candidates[i]);
                    CombSum(candidates, target - candidates[i], result, tmpList, i);
                    tmpList.RemoveAt(tmpList.Count - 1);
                }
            }
        }









        // TOO SLOW! Cant figure out how to memo it
        public static List<List<int>> CombinationSum(int[] candidates, int target)
        {
            if (target == 0)
            {
                var tmp = new List<List<int>>();
                tmp.Add(new List<int>());
                return tmp;
            }
            if (target < 0) return null;

            var result = new List<List<int>>();
            foreach (int num in candidates)
            {
                List<List<int>> remainder = CombinationSum(candidates, target - num);
                if (remainder != null)
                {
                    var tmp = new List<List<int>>();

                    foreach (var list in remainder)
                    {
                        var t = list;
                        t.Add(num);
                        t.Sort();
                        tmp.Add(t);
                    }

                    foreach (var list in tmp)
                    {
                        if (!result.Any(c => c.SequenceEqual(list)))
                            result.Add(list);
                    }
                }
            }

            return result;
        }
    }
}
