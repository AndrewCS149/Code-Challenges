using System;
using System.Collections.Generic;

namespace Linked_List
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SinglyLinkedList<int> sll = new SinglyLinkedList<int>();

            sll.AddLast(4, 5, 4, 3, 1, 2, 4);
            sll.Print();
            Console.WriteLine(sll.KthFromLast(1));
            Console.WriteLine();
        }
    }

    // SINGLY LINKED LIST
    public class SLLNode<T>
    {
        public SLLNode<T> Next { get; set; }
        public T Val { get; set; }

        public SLLNode(T val)
        {
            Val = val;
        }
    }

    public class SinglyLinkedList<T>
    {
        public int Count { get; set; }
        public SLLNode<T> Head { get; set; }

        public SinglyLinkedList(T val)
        {
            Head.Val = val;
            Count = 1;
        }

        public SinglyLinkedList()
        {
            Count = 0;
        }

        public void Print()
        {
            if (Head == null) return;

            var current = Head;
            while (current != null)
            {
                Console.Write(current.Val + " - ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public T KthFromLast(int target)
        {
            if (Head == null) return default(T);

            if (target < 1 || target > Count)
                throw new ArgumentOutOfRangeException("target can not be greater than list count or less than zero");

            var current = Head;
            int idx = 0;
            while (current != null)
            {
                if (target == Count - idx)
                    return current.Val;

                current = current.Next;
                idx++;
            }

            // will not be hit
            return default(T);
        }

        public void RemoveDupes()
        {
            if (Count <= 1) return;

            var set = new HashSet<T>();
            set.Add(Head.Val);
            var lead = Head.Next;
            var trail = Head;

            while (lead != null)
            {
                if (!set.Add(lead.Val))
                {
                    var tmp = lead.Next;
                    trail.Next = tmp;
                    lead = tmp;
                    Count--;
                }
                else
                {
                    lead = lead.Next;
                    trail = trail.Next;
                }
            }
        }

        public void AddLast(params T[] vals)
        {
            Array.ForEach(vals, x => AddLast(x));
        }

        public void AddLast(T val)
        {
            Count++;
            var newNode = new SLLNode<T>(val);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            var current = Head;
            while (current.Next != null)
                current = current.Next;

            current.Next = newNode;
        }

        public void AddFirst(params T[] vals)
        {
            Array.ForEach(vals, x => AddFirst(x));
        }

        public void AddFirst(T val)
        {
            Count++;
            var newNode = new SLLNode<T>(val);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            var tmp = Head;
            Head = newNode;
            Head.Next = tmp;
        }
    }

    // DOUBLY LINKED LIST
    public class DLLNode<T>
    {
        public DLLNode<T> Next { get; set; }
        public DLLNode<T> Prev { get; set; }

        public T Val { get; set; }

        public DLLNode(T val)
        {
            Val = val;
        }
    }

    public class DoublyLinkedList<T>
    {
        public int Count { get; set; }
        public DLLNode<T> Head { get; set; }

        public DoublyLinkedList(T val)
        {
            Head.Val = val;
            Count = 1;
        }

        public DoublyLinkedList()
        {
            Count = 0;
        }
    }
}