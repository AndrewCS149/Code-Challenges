using System;

namespace Intersection
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Node node = new Node(4);
            node.Next = new Node(5);
            node.Next.Next = new Node(8);
            node.Next.Next.Next = new Node(2);

            Node node2 = node.Next.Next;

            Console.WriteLine(IntersectingNode(node, node2).Value);

        }

        public static Node IntersectingNode(Node node1, Node node2)
        {
            if (node1 == null || node2 == null) return null;

            var set = new HashSet<Node>();
            Node current = node1;
            while (current != null)
            {
                set.Add(current);
                current = current.Next;
            }

            current = node2;
            while (current != null)
            {
                if (set.Contains(current))
                    return current;
            }

            return null;
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
}
