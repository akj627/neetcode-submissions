# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def isValidBST(self, root: Optional[TreeNode]) -> bool:
        lstBst = []

        def inOrder(curr):
            if not curr:
                return
            
            inOrder(curr.left)
            lstBst.append(curr.val)
            inOrder(curr.right)

        inOrder (root)

        for i in range (1, len(lstBst)):
            if lstBst[i - 1] >= lstBst[i]:
                return False
        
        return True
        
'''        curr = root
        
        def isBST (curr) -> bool:            
            if curr.left:
                if curr.val < curr.left.val:
                    return False
                return isBST (curr.left)

            if curr.right:
                if curr.val > curr.right.val:
                    return False
                return isBST (curr.right)

            return True
        return isBST (curr)
'''