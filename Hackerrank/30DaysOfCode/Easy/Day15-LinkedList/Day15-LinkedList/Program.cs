using System;

namespace Day15_LinkedList
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/30-linked-list/problem
        private static void Main(string[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }

        public static Node insert(Node head, int data)
        {
            Node newNode = new Node(data);

            if (head == null) head = newNode;
            else
            {
                Node current = head;
                while (current.next != null)
                    current = current.next;

                current.next = newNode;
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

    public class Node
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