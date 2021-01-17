using System;
using System.Collections.Generic;

namespace Linked_List
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SinglyLinkedList<int> sll = new SinglyLinkedList<int>();

            sll.AddLast(4, 5, 4, 3, 3, 3, 1, 2, 4);
            sll.Print();

            var lists = sll.Partition(3);

            lists[0].Print();
            Console.WriteLine(lists[0].Count);
            lists[1].Print();
            Console.WriteLine(lists[1].Count);
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

        /// <summary>
        /// Partitions the list into two linked list where all elements less than 'val' will be in the first list
        /// and all element greater than or equal to 'val' will be in the second list
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public SinglyLinkedList<int>[] Partition(int val)
        {
            if (Head == null) return default;

            var listOne = new SinglyLinkedList<int>();
            var listTwo = new SinglyLinkedList<int>();

            var current = Head;
            while (current != null)
            {
                if (!int.TryParse(current.Val.ToString(), out int num))
                    throw new InvalidCastException("Cannot convert type to int.");

                if (num < val) listOne.AddLast(num);
                else listTwo.AddLast(num);

                current = current.Next;
            }

            return new SinglyLinkedList<int>[] { listOne, listTwo };
        }

        public void DeleteMiddleNode(T val)
        {
            if (Count <= 2) return;

            var lead = Head.Next;
            var trail = Head;
            while (lead != null)
            {
                if (lead.Val.Equals(val))
                {
                    Count--;
                    lead = lead.Next;
                    trail.Next = lead;
                    return;
                }
                lead = lead.Next;
                trail = trail.Next;
            }
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
                    lead = lead.Next;
                    trail.Next = lead;
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