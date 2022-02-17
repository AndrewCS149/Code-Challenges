// https://leetcode.com/problems/binary-tree-paths/

using System;

namespace BinaryTreePaths
{
    public class Program
    {
        private static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.right = new TreeNode(5);
            root.right = new TreeNode(3);

            var result = BinaryTreePaths1(root);
            foreach (var str in result)
            {
                Console.Write(str + " ");
            }

        }
        public static IList<string> BinaryTreePaths1(TreeNode root, List<string> result = null, string path = "")
        {
            if (result == null)
                result = new List<string>();

            if (root == null)
                return result;

            path += root.val.ToString();

            if (root.left != null || root.right != null)
                path += "->";

            if (root.left == null && root.right == null)
                result.Add(path);

            if (root.left != null)
                BinaryTreePaths1(root.left, result, path);

            if (root.right != null)
                BinaryTreePaths1(root.right, result, path);

            return result;
        }

        public static IList<string> BinaryTreePaths2(TreeNode root)
        {
            List<string> result = new List<string>();

            if (root == null)
                return result;

            BinaryTreePathsRecurse(root, result, "");
            return result;
        }

        public static void BinaryTreePathsRecurse(TreeNode root, List<string> result, string path)
        {
            path += root.val.ToString();

            if (root.left != null || root.right != null)
                path += "->";

            if (root.left != null)
                BinaryTreePathsRecurse(root.left, result, path);

            if (root.right != null)
                BinaryTreePathsRecurse(root.right, result, path);

            if (root.left == null && root.right == null)
                result.Add(path);
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
