using System;

namespace Day20_BST
{
    internal class Program
    {
        // easy
        // link to challenge - https://www.hackerrank.com/challenges/30-binary-search-trees/problem?utm_campaign=30_days_of_code_continuous&utm_medium=email&utm_source=daily_reminder
        private static void Main(string[] args)
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);
        }

        private static int getHeight(Node root)
        {
            if (root == null) return -1;

            int leftDepth = getHeight(root.left);
            int rightDepth = getHeight(root.right);

            if (leftDepth > rightDepth) return ++leftDepth;
            else return ++rightDepth;
        }

        private static int getHeight(Node root, int count)
        {
            Console.WriteLine(root.data);

            if (root.left != null)
            {
                getHeight(root.left);
                count++;
            }
            if (root.right != null)
            {
                getHeight(root.right);
                count++;
            }

            return count;
        }

        private static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
    }

    internal class Node
    {
        public Node left, right;
        public int data;

        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }
}