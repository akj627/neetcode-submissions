# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right

class Solution:
    def rightSideView(self, root: Optional[TreeNode]) -> List[int]:
        
        res = []

        if root is None:
            return res

        qu = deque([root])

        while qu:
            lq = len(qu)

            for i in range(lq):#2
                curr = qu.popleft()

                if i == lq - 1:
                    res.append(curr.val)

                if curr.left:
                    qu.append(curr.left)

                if curr.right:
                    qu.append(curr.right)

        return res

