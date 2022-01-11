//https://leetcode.com/problems/sum-of-nodes-with-even-valued-grandparent/

namespace SumofEvenValuedGrandparents
{
    class Program
    {

        public int SumEvenGrandparent(TreeNode root)
        {
            int sum = 0;

            if (root == null)
                return sum;

            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                var top = stack.Pop();

                if (top.right != null)
                {
                    if (top.val % 2 == 0 && top.right.left != null)
                        sum += top.right.left.val;

                    if (top.val % 2 == 0 && top.right.right != null)
                        sum += top.right.right.val;

                    stack.Push(top.right);
                }

                if (top.left != null)
                {
                    if (top.val % 2 == 0 && top.left.left != null)
                        sum += top.left.left.val;

                    if (top.val % 2 == 0 && top.left.right != null)
                        sum += top.left.right.val;

                    stack.Push(top.left);
                }
            }

            return sum;
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