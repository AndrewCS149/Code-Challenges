// https://leetcode.com/problems/binary-search-tree-to-greater-sum-tree/

namespace BSTtoSumTree
{
    class Program
    {
        private static void Main(string[] args)
        {
            var root = new TreeNode(4);
            root.left = new TreeNode(1);
            root.left.left = new TreeNode(0);
            root.left.right = new TreeNode(2);
            root.left.right.right = new TreeNode(3);

            root.right = new TreeNode(6);
            root.right.left = new TreeNode(5);
            root.right.right = new TreeNode(7);
            root.right.right.right = new TreeNode(8);

            root = BstToGst(root);

            int sum = Sum(root);
            Console.WriteLine(sum);
        }

        //public static TreeNode BstToGst(TreeNode root)
        //{
        //    if (root == null)
        //        return null;

        //    int sum = Sum(root);
        //    root = BstToGst(root, sum);

        //    return root;
        //}

        //private static TreeNode BstToGst(TreeNode root, int sum)
        //{
        //    if (root.left != null)
        //    {
        //        BstToGst(root.left, sum);
        //    }

        //    int tmp = root.val;
        //    root.val = sum;
        //    sum -= tmp;

        //    if (root.right != null)
        //    {
        //        BstToGst(root.right, sum);
        //    }

        //    return root;
        //}

        //public static int Sum(TreeNode root)
        //{
        //    int sum = 0;

        //    if (root == null)
        //        return sum;

        //    var stack = new Stack<TreeNode>();
        //    stack.Push(root);
        //    while (stack.Count > 0)
        //    {
        //        var top = stack.Pop();
        //        sum += top.val;

        //        if (top.right != null)
        //            stack.Push(top.right);

        //        if (top.left != null)
        //            stack.Push(top.left);
        //    }

        //    return sum;
        //}

    }

    public class TreeNode
    {
        private static int sum = 0;
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        // ONILNE SOLUTION
        public static TreeNode BstToGst(TreeNode root)
        {
            if (root == null)
                return null;

            BstToGst(root.right);
            root.val += sum;
            sum = root.val;
            BstToGst(root.left);
            return root;
        }
    }
}