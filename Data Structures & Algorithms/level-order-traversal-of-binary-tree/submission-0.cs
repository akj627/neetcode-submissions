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
    public List<List<int>> LevelOrder(TreeNode root) {
        var qu = new Queue<TreeNode>();
        var res = new List<List<int>>();

        if (root == null)
            return res;
        
        qu.Enqueue(root);

        while (qu.Count > 0)
        {
            var qLen = qu.Count;
            var resInner = new List<int>();

            for(var i = 0; i < qLen;i++)
            {
                var node = qu.Dequeue();
                if (node.left != null)
                    qu.Enqueue(node.left);
                if (node.right != null)
                    qu.Enqueue(node.right);
                resInner.Add(node.val);
            }
            res.Add(resInner);
        }

        return res;
    }
}
