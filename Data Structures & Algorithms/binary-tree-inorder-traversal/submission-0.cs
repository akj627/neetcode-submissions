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
    public List<int> InorderTraversal(TreeNode root) {
        var stk = new Stack<TreeNode>();
        var curr = root;
        var res = new List<int>();

        while (curr != null || stk.Count > 0)
        {
            while (curr != null)
            {
                stk.Push(curr);
                curr = curr.left;
            }
            curr = stk.Pop();
            res.Add(curr.val);
            curr = curr.right;
        }

        return res;
    }
}