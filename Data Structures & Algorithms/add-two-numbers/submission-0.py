# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def addTwoNumbers(self, l1: Optional[ListNode], l2: Optional[ListNode]) -> Optional[ListNode]:
#[9,9,9] + [1] → [0,0,0,1]
        head = l3 = ListNode()
        carry = 0
        while l1 or l2:
            sum = 0
            if l1:
                sum += l1.val
                l1 = l1.next
            if l2:
                sum += l2.val
                l2 = l2.next
            sum += carry
            carry = sum // 10
            l3.next = ListNode(sum % 10)
            l3 = l3.next

        if carry > 0:
            l3.next = ListNode(carry)

        return head.next

