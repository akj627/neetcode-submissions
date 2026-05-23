# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def preorderTraversal(self, root: Optional[TreeNode]) -> List[int]:
        curr, stk = root, []
        res = []

        while curr or stk:
            if curr:
                res.append (curr.val)
                stk.append (curr.right)
                curr = curr.left
            else:
                curr = stk.pop()
                if curr :
                    res.append (curr.val)
                    stk.append (curr.right)
                    curr = curr.left

        return res
        