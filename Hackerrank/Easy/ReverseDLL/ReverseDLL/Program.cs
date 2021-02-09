using System;

namespace ReverseDLL
{
    internal class Program
    {
        // link - https://www.hackerrank.com/challenges/reverse-a-doubly-linked-list/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=linked-lists
        private static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                DoublyLinkedList llist = new DoublyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                DoublyLinkedListNode llist1 = reverse(llist.head);

                PrintDoublyLinkedList(llist1, " ");
            }
        }

        private static DoublyLinkedListNode reverse(DoublyLinkedListNode head)
        {
            if (head == null || head.next == null)
                return head;

            // ONLINE SOLUTION WITHOUT USING EXTRA SPACE
            var cur = head;
            var prev = head.prev;
            while (cur != null)
            {
                var next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
            }
            return prev;

            // MY SOLUTION - NEW LINKED LIST
            //var newDLL = new DoublyLinkedList();

            //// get last node
            //var cur = head;
            //while (cur.next != null)
            //    cur = cur.next;

            //while (cur != null)
            //{
            //    newDLL.InsertNode(cur.data);
            //    cur = cur.prev;
            //}

            //return newDLL.head;
        }

        private static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep)
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

    internal class DoublyLinkedListNode
    {
        public int data;
        public DoublyLinkedListNode next;
        public DoublyLinkedListNode prev;

        public DoublyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
            this.prev = null;
        }
    }

    internal class DoublyLinkedList
    {
        public DoublyLinkedListNode head;
        public DoublyLinkedListNode tail;

        public DoublyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
                node.prev = this.tail;
            }

            this.tail = node;
        }
    }
}