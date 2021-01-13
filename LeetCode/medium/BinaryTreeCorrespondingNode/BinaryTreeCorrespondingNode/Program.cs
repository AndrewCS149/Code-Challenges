using System;

namespace BinaryTreeCorrespondingNode
{
    internal class Program
    {
        // medium
        // link to challenge - https://leetcode.com/problems/find-a-corresponding-node-of-a-binary-tree-in-a-clone-of-that-tree/
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // NOT MY SOLUTION
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            if (original == null || original == target) return cloned;

            TreeNode node = GetTargetCopy(original.left, cloned.left, target);

            return node != null ? node : GetTargetCopy(original.right, cloned.right, target);
        }
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int x)
    {
        val = x;
    }
}