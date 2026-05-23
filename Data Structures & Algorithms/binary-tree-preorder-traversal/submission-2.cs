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
    public List<int> PreorderTraversal(TreeNode root) {
        var stk = new Stack<TreeNode>();
        var res = new List<int>();
        var curr = root;

        while (stk.Count() > 0 || curr != null)
        {
            if (curr != null)
            {
                res.Add(curr.val);
                stk.Push(curr.right);
                curr = curr.left;
            }
            else
                curr = stk.Pop();
        }

        return res;
    }
}