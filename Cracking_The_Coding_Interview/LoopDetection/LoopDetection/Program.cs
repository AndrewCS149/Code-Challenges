using System;

namespace LoopDetection
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Node node1 = new Node('A');
            node1.Next = new Node('B');
            node1.Next.Next = new Node('C');
            node1.Next.Next.Next = new Node('D');
            node1.Next.Next.Next.Next = new Node('E');
            node1.Next.Next.Next.Next.Next = new Node('F');
            node1.Next.Next.Next.Next.Next.Next = node1.Next.Next;


            Console.WriteLine(DetectLoop2(node1).Value);
        }

        // does not tell me the start of the loop
        public static Node DetectLoop2(Node node)
        {
            if (node == null || node.Next == null) return null;

            var fast = node.Next;
            var slow = node;

            while (fast != null && slow != null)
            {
                if (slow == fast)
                    return slow;

                slow = slow.Next;
                fast = fast.Next.Next;
            }

            return null;
        }

        public static Node DetectLoop(Node node)
        {
            if (node == null) return null;

            var set = new HashSet<Node>();
            var current = node;
            while (current != null)
            {
                if (!set.Add(current))
                    return current;

                current = current.Next;
            }

            return null;
        }
    }

    public class Node
    {
        public char Value { get; set; }
        public Node Next { get; set; }
        public Node(char val)
        {
            Value = val;
        }
    }
}
