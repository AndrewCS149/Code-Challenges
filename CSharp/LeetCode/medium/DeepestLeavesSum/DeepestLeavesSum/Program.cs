// https://leetcode.com/problems/deepest-leaves-sum/

namespace DeepestLeavesSum
{
    class Program
    {
        private static void Main(string[] args)
        {
            var root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.left.left.left = new TreeNode(7);

            root.right = new TreeNode(3);
            root.right.right = new TreeNode(6);
            root.right.right.right = new TreeNode(8);

            var sum = Solution(root);
        }

        static int Solution(TreeNode root)
        {
            if (root == null) return 0;

            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int sum = 0;

            while (queue.Count > 0)
            {
                sum = 0;
                int count = queue.Count;
                for (int i = 0; i < count; i++)
                {
                    var first = queue.Dequeue();
                    sum += first.val;

                    if (first.left != null)
                        queue.Enqueue(first.left);

                    if (first.right != null)
                        queue.Enqueue(first.right);
                }
            }

            return sum;
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
