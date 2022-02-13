using static AddTwoNumbers.SinglyLinkedList;
using static AddTwoNumbers.ListNode;

namespace AddTwoNumbers
{
    class Program
    {
        private static void Main(string[] args)
        {
            ListNode L1 = new ListNode(2);
            L1.next = new ListNode(4);
            L1.next.next = new ListNode(3);

            ListNode L2 = new ListNode(5);
            L2.next = new ListNode(6);
            L2.next.next = new ListNode(4);

            ListNode result = AddNumbers(L1, L2);
            Print(result);
        }
    }
}