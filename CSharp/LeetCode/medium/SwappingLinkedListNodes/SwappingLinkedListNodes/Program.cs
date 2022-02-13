using System;
using System.Collections.Generic;

namespace SwappingLinkedListNodes
{
    // https://leetcode.com/problems/swapping-nodes-in-a-linked-list/submissions/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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

        public ListNode SwapNodes(ListNode head, int k)
        {
            var list = new List<int>();

            var cur = head;
            while (cur != null)
            {
                list.Add(cur.val);
                cur = cur.next;
            }

            int tmp = list[k - 1];
            list[k - 1] = list[list.Count - k];
            list[list.Count - k] = tmp;

            cur = head;
            foreach (int n in list)
            {
                cur.val = n;
                cur = cur.next;
            }

            return head;
        }
    }
}