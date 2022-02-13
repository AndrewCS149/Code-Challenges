using System;

namespace MergeLists
{
    // link - https://leetcode.com/problems/merge-in-between-linked-lists/submissions/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public ListNode MergeInBetween(ListNode list1, int a, int b, ListNode list2)
        {
            var cur1 = list1;
            var cur2 = list2;
            var tmpA = new ListNode();
            var tmpB = new ListNode();

            int idx = 0;
            while (cur1.next != null)
            {
                if (idx + 1 == a)
                    tmpA = cur1;

                if (idx == b)
                    tmpB = cur1;

                cur1 = cur1.next;
                idx++;
            }

            while (cur2.next != null)
                cur2 = cur2.next;

            cur2.next = tmpB.next;
            tmpA.next = list2;

            return list1;
        }

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
    }
}