// https://leetcode.com/problems/maximum-twin-sum-of-a-linked-list/

namespace MaxTwinSum
{
    class Program
    {
        private static void Main(string[] args)
        {
            var head = new ListNode(5);
            head = Add(head, 4);
            head = Add(head, 2);
            head = Add(head, 1);

            Print(head);
            int sum = PairSum(head);

        }

        public static int PairSum(ListNode head)
        {
            if (head == null)
                return 0;

            List<int> values = new List<int>();
            var current = head;
            while (current != null)
            {
                values.Add(current.val);
                current = current.next;
            }

            int sum = 0;
            for (int i = 0; i < values.Count / 2; i++)
            {
                int tmpSum = values[i] + values[values.Count - i - 1];

                if (tmpSum > sum)
                    sum = tmpSum;
            }

            return sum;
        }
        public static ListNode Add(ListNode head, int value)
        {
            var newNode = new ListNode(value);

            if (head == null)
            {
                head = newNode;
                return head;
            }

            var current = head;
            while (current.next != null)
                current = current.next;

            current.next = newNode;
            return head;
        }

        public static void Print(ListNode head)
        {
            if (head == null)
                return;

            var cur = head;
            while (cur != null)
            {
                Console.Write(cur.val + " - ");
                cur = cur.next;
            }

            Console.WriteLine();
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }

        }
    }
}