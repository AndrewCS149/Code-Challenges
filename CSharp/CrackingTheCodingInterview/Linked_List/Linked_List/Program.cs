using System;
using System.Collections.Generic;

namespace Linked_List
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sll = new SinglyLinkedList<int>();
            var sll2 = new SinglyLinkedList<int>();
            var sll3 = new SinglyLinkedList<char>();
            sll3.AddFirst('r', 'a', 'c', 'e', 'c', 'a', 'r');

            sll.AddFirst(5, 4, 3, 5, 5);

            Console.WriteLine(sll.IsPalindrome());
            Console.WriteLine(sll3.IsPalindrome());
            Console.WriteLine(sll3.ConvertToString());
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

        public bool IsPalindrome()
        {
            if (Head == null) return true;

            string str = ConvertToString();

            for (int i = 0; i < str.Length / 2; i++)
                if (str[i] != str[str.Length - (i + 1)]) return false;

            return true;
        }

        public string ConvertToString()
        {
            string str = "";

            var current = Head;
            while (current != null)
            {
                str = str.Insert(str.Length, current.Val.ToString());
                current = current.Next;
            }

            return str;
        }

        public static SinglyLinkedList<int> SumList(SinglyLinkedList<int> list1, SinglyLinkedList<int> list2)
        {
            string sum = "";
            var list1Current = list1.Head;
            var list2Current = list2.Head;

            int tens = 0;
            while (list1Current != null)
            {
                int tmpSum = list1Current.Val + list2Current.Val + tens;

                if (list1Current.Next == null)
                {
                    sum += tmpSum;
                    break;
                }
                else if (tmpSum / 10 > 0)
                {
                    tens = tmpSum / 10;
                    tmpSum %= 10;
                }
                else
                    tens = 0;

                sum += tmpSum;

                list1Current = list1Current.Next;
                list2Current = list2Current.Next;
            }

            int total = int.Parse(sum);
            var sumList = new SinglyLinkedList<int>();
            while (total > 0)
            {
                sumList.AddFirst(total % 10);
                total /= 10;
            }

            return sumList;

            //int sum1 = 0, sum2 = 0;

            //var list1Current = list1.Head;
            //var list2Current = list2.Head;

            //while (list1Current != null)
            //{
            //    sum1 = sum1 * 10 + list1Current.Val;
            //    list1Current = list1Current.Next;
            //}

            //while (list2Current != null)
            //{
            //    sum2 = sum2 * 10 + list2Current.Val;
            //    list2Current = list2Current.Next;
            //}

            //int sum1Rev = 0; int sum2Rev = 0;

            //while (sum1 > 0)
            //{
            //    sum1Rev = sum1Rev * 10 + (sum1 % 10);
            //    sum1 /= 10;
            //}

            //while (sum2 > 0)
            //{
            //    sum2Rev = sum2Rev * 10 + (sum2 % 10);
            //    sum2 /= 10;
            //}

            //int total = sum1Rev + sum2Rev;
            //var sumList = new SinglyLinkedList<int>();

            //while (total > 0)
            //{
            //    sumList.AddLast(total % 10);
            //    total /= 10;
            //}

            //return sumList;
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