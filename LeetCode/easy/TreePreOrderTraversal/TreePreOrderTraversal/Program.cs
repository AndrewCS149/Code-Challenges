using System;
using System.Collections.Generic;

namespace TreePreOrderTraversal
{
    // https://leetcode.com/problems/n-ary-tree-preorder-traversal/submissions/
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public class Node
        {
            public int val;
            public IList<Node> children;

            public Node()
            {
            }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, IList<Node> _children)
            {
                val = _val;
                children = _children;
            }
        }

        public IList<int> Preorder(Node root)
        {
            var list = new List<int>();
            return root == null ? list : Preorder(root, list);
        }

        private static IList<int> Preorder(Node root, IList<int> list)
        {
            list.Add(root.val);

            if (root.children != null)
            {
                foreach (var n in root.children)
                    Preorder(n, list);
            }

            return list;
        }
    }
}