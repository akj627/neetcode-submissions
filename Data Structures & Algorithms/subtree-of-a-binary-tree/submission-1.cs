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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if (subRoot == null)
            return true;
        if (root == null)
            return false;

        if (IsSametree(root, subRoot))
            return true;
        
        return (IsSubtree(root.left, subRoot) || IsSubtree(root.right, subRoot));
    }

    private bool IsSametree(TreeNode p, TreeNode q) {
        if (p == null && q == null)
            return true;
        
        if (p == null || q == null)
            return false;

        if (p.val != q.val)
            return false;

        return (IsSametree(p.left, q.left) && IsSametree(p.right, q.right));        
    }

//     private bool ContainsTree(TreeNode root, TreeNode subRoot) {
//     if (subRoot == null)
//         return true;  // matched all of subRoot
//     if (root == null)
//         return false; // ran out of main tree

//     if (root.val == subRoot.val)
//         return ContainsTree(root.left, subRoot.left) 
//             && ContainsTree(root.right, subRoot.right);

//     // value mismatch — try going deeper in main tree
//     return ContainsTree(root.left, subRoot) 
//         || ContainsTree(root.right, subRoot);
// }
}
