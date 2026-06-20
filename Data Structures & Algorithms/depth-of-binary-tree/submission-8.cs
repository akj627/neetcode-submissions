/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int MaxDepth(TreeNode root) {

        if (root == null)
            return 0;

        /*return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));//
        */
        var qu = new Queue<TreeNode>();
        var sum = 0;
        qu.Enqueue(root);

        while (qu.Count > 0)
        {
            var qLen = qu.Count;
            for (var q = 0;q < qLen;q++)
            {
                var node = qu.Dequeue();
                
                if (node.left != null)
                    qu.Enqueue(node.left);
                if (node.right != null)
                    qu.Enqueue(node.right);
            }
            sum++;
        }

        return sum;
    }
}
