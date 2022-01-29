// https://leetcode.com/problems/remove-nth-node-from-end-of-list/

using System;

namespace RemoveNthNode
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var list = new LinkedList();
            list.AddFirst(5, 4, 3, 2, 1);
            list.Print();
            Console.WriteLine();

            list.RemoveNthFromEnd(4);
            list.Print();
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }

        public Node(int val)
        {
            Value = val;
        }
    }


    public class LinkedList
    {
        public Node Head { get; set; }
        public int Count { get; set; } = 0;

        public void RemoveNthFromEnd(int n)
        {
            var current = Head;
            int target = Count - n;

            if (target == 1)
                Head = Head.Next;
            else
            {
                while (target > 1)
                {
                    target--;
                    current = current.Next;
                }

                current.Next = current.Next.Next;
            }

            Count--;
        }

        public void AddFirst(int val)
        {
            Count++;
            var node = new Node(val);
            node.Next = Head;
            Head = node;
        }

        public void AddFirst(params int[] values)
        {
            foreach (int val in values) AddFirst(val);
        }

        public void Print()
        {
            var current = Head;
            while (current != null)
            {
                Console.Write(current.Value + " - ");
                current = current.Next;
            }

            Console.WriteLine();
        }
    }
}