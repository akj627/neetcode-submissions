class Solution:
    def isPalindrome(self, x: int) -> bool:
        lst = []

        if x < 0:
            return False
        while x != 0:
            lst.append(x % 10) # 3, 2, 1
            print(x % 10)
            x = x // 10# 12, 1, 0
        l, r = 0, len(lst) - 1

        while l < r:
            if lst[l] != lst[r]:
                return False
            l, r = l + 1, r - 1

        return True