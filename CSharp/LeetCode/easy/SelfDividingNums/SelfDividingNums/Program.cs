using System;
using System.Collections.Generic;

namespace SelfDividingNums
{
    // https://leetcode.com/problems/self-dividing-numbers/submissions/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(15 );
        }

        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            var list = new List<int>();
            for (int i = left; i <= right; i++)
            {
                bool flag = true;
                foreach (char ch in i.ToString())
                {
                    if (ch == '0')
                    {
                        flag = false;
                        break;
                    }
                    if (i % int.Parse(ch.ToString()) != 0)
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag) list.Add(i);
            }

            return list;
        }
    }
}
