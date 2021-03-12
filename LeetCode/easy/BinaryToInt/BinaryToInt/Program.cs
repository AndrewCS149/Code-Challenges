using System;
using System.Linq;

namespace BinaryToInt
{
    // link - https://leetcode.com/problems/convert-binary-number-in-a-linked-list-to-integer/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToInt32("10111010", 2));
        }

        /*

          128  64  32  16  8  4  2  1
           1    0   1   1  1  0  1  0   =
         */

        public class ListNode
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public int GetDecimalValue(ListNode head)
        {
            string binaryStr = "";
            while (head != null)
            {
                binaryStr += head.val.ToString();
                head = head.next;
            }

            return Convert.ToInt32(binaryStr, 2);
        }

        public static int BinaryToInteger(int binary)
        {
            int num = 0;
            int weight = 1;

            while (binary != 0)
            {
                int rem = binary % 10;
                num += rem * weight;
                binary /= 10;
                weight *= 2;
            }

            return num;
        }
    }
}