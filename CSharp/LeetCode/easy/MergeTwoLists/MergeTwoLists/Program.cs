//https://leetcode.com/problems/merge-two-sorted-lists/

using System;

namespace MergeTwoLists
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var list1 = new ListNode(1);
            list1.next = new ListNode(2);
            list1.next.next = new ListNode(4);

            var list2 = new ListNode(1);
            list2.next = new ListNode(3);
            list2.next.next = new ListNode(4);

            var mergelists = MergeTwoLists(list1, list2);
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 == null)
                return null;

            ListNode result = new ListNode();
            ListNode tmp = result;

            ListNode cur1 = list1;
            ListNode cur2 = list2;
            while (cur1 != null || cur2 != null)
            {
                if (cur1 == null)
                {
                    result.val = cur2.val;
                    cur2 = cur2.next;
                }
                else if (cur2 == null)
                {
                    result.val = cur1.val;
                    cur1 = cur1.next;
                }
                else
                {
                    if (cur1.val <= cur2.val)
                    {
                        result.val = cur1.val;
                        cur1 = cur1.next;
                    }
                    else
                    {
                        result.val = cur2.val;
                        cur2 = cur2.next;
                    }
                }

                if (cur1 == null && cur2 == null)
                    break;

                result.next = new ListNode();
                result = result.next;
            }

            return tmp;
        }
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