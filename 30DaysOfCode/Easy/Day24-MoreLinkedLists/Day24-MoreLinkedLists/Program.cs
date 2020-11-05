using System;
using System.Collections.Generic;

namespace Day24_MoreLinkedLists
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/30-linked-list-deletion/problem?utm_campaign=30_days_of_code_continuous&utm_medium=email&utm_source=daily_reminder
        private static void Main(string[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }

        /*
        input ->  4 - 4 - 3 - 4- 5 - 6
        output -> 4 - 3 - 5 - 6

        edge cases:
            - null head
        */

        public static Node removeDuplicates(Node head)
        {
            if (head == null || head.next == null) return head;

            HashSet<int> set = new HashSet<int>();
            Node current = head;
            Node lead = head.next;

            set.Add(head.data);

            while (lead != null)
            {
                if (!set.Add(lead.data))
                {
                    current.next = lead.next;
                    lead = current.next;
                }
                else
                {
                    current = current.next;
                    lead = lead.next;
                }
            }

            return head;
        }

        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);

            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;
            }
            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }

    internal class Node
    {
        public int data;
        public Node next;

        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
}