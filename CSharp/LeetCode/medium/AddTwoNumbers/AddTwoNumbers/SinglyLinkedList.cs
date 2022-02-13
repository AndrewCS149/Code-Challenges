using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers
{
    public class SinglyLinkedList
    {
        public Node Head { get; set; }

        public static SinglyLinkedList SumOfTwoLists(SinglyLinkedList list1, SinglyLinkedList list2)
        {
            int num1 = int.Parse(list1.Combine());
            int num2 = int.Parse(list2.Combine());

            string sum = (num1 + num2).ToString();

            var newList = new SinglyLinkedList();
            for (int i = sum.Length - 1; i >= 0; i--)
                newList.AddFirst(int.Parse(sum[i].ToString()));

            return newList;
        }

        private string Combine()
        {
            if (Head == null) return "";
            string str = "";

            Node current = Head;
            while (current != null)
            {
                str += current.Value.ToString();
                current = current.Next;
            }

            return str;
        }

        public void Print()
        {
            if (Head == null) return;

            Node current = Head;
            while (current != null)
            {
                Console.Write(current.Value + " - ");
                current = current.Next;
            }

            Console.WriteLine();
        }
        public void AddFirst(int value)
        {
            Node newNode = new Node(value);

            if (Head == null)
                Head = newNode;
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }
    }
}
