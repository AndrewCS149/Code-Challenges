// https://leetcode.com/problems/print-immutable-linked-list-in-reverse/

using System;

namespace ReversePrintList
{
    public class Program
    {
        private static void Main(string[] args)
        {

        }

        public void PrintLinkedListInReverse(ImmutableListNode head)
        {
            var list = new List<ImmutableListNode>();

            var current = head;
            while (current != null)
            {
                list.Insert(0, current);
                current.GetNext();
            }

            foreach (var node in list)
                node.PrintValue();
        }
    }

    class ImmutableListNode
    {
        public void PrintValue(); // print the value of this node.
        public ImmutableListNode GetNext(); // return the next node.
    }
}
