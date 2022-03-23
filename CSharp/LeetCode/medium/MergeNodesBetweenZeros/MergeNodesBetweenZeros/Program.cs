// https://leetcode.com/problems/merge-nodes-in-between-zeros/

using System;

  namespace MergeNodesBetweenZeros
  {
      public class Program 
      {
          private static void Main(string[] args) 
          {
			var head = new ListNode(0);
			head.next = new ListNode(3);
			head.next.next = new ListNode(1);
			head.next.next.next = new ListNode(0);
			head.next.next.next.next = new ListNode(4);
			head.next.next.next.next.next = new ListNode(5);
			head.next.next.next.next.next.next = new ListNode(2);
			head.next.next.next.next.next.next.next = new ListNode(0);									

			var result = MergeNodes(head);

			while(result != null) 
			{
				Console.Write(result.val + " -> ");
				result = result.next;
			}
          }


			/*



				          11
				0 -> 4 -> 2 -> 0
				          ^
	
			*/
          public static ListNode MergeNodes(ListNode head) 
          {
          	if(head == null) return null;

          	int sum = 0;
          	var prev = head;
          	var cur = head.next;
          	while(cur != null) 
          	{
          	
          		sum += cur.val;

				if(cur.val == 0) 
				{
					cur.val = sum;
					sum = 0;
					cur = cur.next;
					prev = prev.next;
				}
				else 
				{
					cur = cur.next;
					prev.next = cur;
				}
          	}

          	return head.next;
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
