class Solution:
    def isPalindrome(self, x: int) -> bool:
        if x < 0:
            return False
        
        original = x
        reversed_num = 0
        
        while x > 0:
            reversed_num = reversed_num * 10 + x % 10 # 3, 32, 321
            x //= 10 # 12, 1, 0
            
        return original == reversed_num
        
class Solution2:
    def isPalindrome(self, x: int) -> bool:
        lst = []

        if x < 0:
            return False
        while x != 0:
            lst.append(x % 10) # 3, 2, 1
            x = x // 10# 12, 1, 0
        l, r = 0, len(lst) - 1

        while l < r:
            if lst[l] != lst[r]:
                return False
            l, r = l + 1, r - 1

        return True