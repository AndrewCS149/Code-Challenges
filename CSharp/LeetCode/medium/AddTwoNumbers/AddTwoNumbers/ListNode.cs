using System.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode AddNumbers(ListNode l1, ListNode l2)
        {
            BigInteger sumL1 = CombineList(l1);
            BigInteger sumL2 = CombineList(l2);
            string sum = (sumL1 + sumL2).ToString();

            ListNode newNode = new ListNode();
            ListNode current = newNode;
            for (int i = sum.Length - 1; i >= 0; i--)
            {
                current.val = int.Parse(sum[i].ToString());

                if (i == 0) break;

                current.next = new ListNode();
                current = current.next;
            }

            return newNode;
        }

        public static void Print(ListNode node)
        {
            ListNode current = node;
            while (current != null)
            {
                Console.Write(current.val + " - ");
                current = current.next;
            }
            Console.WriteLine();
        }

        private static BigInteger CombineList(ListNode node)
        {
            string sum = "";
            ListNode current = node;
            while (current != null)
            {
                sum += (current.val.ToString());
                current = current.next;
            }

            char[] arr = sum.ToCharArray();
            Array.Reverse(arr);
            string sumStr = new string(arr);

            return BigInteger.Parse(sumStr);
        }
    }
}

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {

    }
}
*/