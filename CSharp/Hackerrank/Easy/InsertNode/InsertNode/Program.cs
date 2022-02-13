using System;
using System.IO;

namespace InsertNode
{
    public class Program
    {
        // link - https://www.hackerrank.com/challenges/insert-a-node-at-a-specific-position-in-a-linked-list/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=linked-lists
        private static void Main(string[] args)
        {
            SinglyLinkedList llist = new SinglyLinkedList();

            int llistCount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llistCount; i++)
            {
                int llistItem = Convert.ToInt32(Console.ReadLine());
                llist.InsertNode(llistItem);
            }

            int data = Convert.ToInt32(Console.ReadLine());

            int position = Convert.ToInt32(Console.ReadLine());

            SinglyLinkedListNode llist_head = insertNodeAtPosition(llist.head, data, position);

            PrintSinglyLinkedList(llist_head, " ");
        }

        private static SinglyLinkedListNode insertNodeAtPosition(SinglyLinkedListNode head, int data, int position)
        {
            var newNode = new SinglyLinkedListNode(data);

            if (position == 0)
            {
                newNode.next = head;
                return newNode;
            }

            // ONLINE SOLUTION
            var cur = head;
            int idx = 1;
            while (idx++ != position)
                cur = cur.next;

            newNode.next = cur.next;
            cur.next = newNode;
            return head;

            // MY SOLUTION
            //var trail = head;
            //var lead = head.next;
            //int idx = 1;
            //while (lead != null)
            //{
            //    if (idx == position)
            //    {
            //        newNode.next = lead;
            //        trail.next = newNode;
            //        break;
            //    }

            //    idx++;
            //    trail = trail.next;
            //    lead = lead.next;
            //}
            //return head;
        }

        private static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep)
        {
            while (node != null)
            {
                Console.Write(node.data);

                node = node.next;

                if (node != null)
                {
                    Console.Write(sep);
                }
            }
        }
    }

    public class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    public class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }
}