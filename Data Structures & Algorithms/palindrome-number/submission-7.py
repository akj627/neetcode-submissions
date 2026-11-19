class Solution:
    def isPalindrome(self, x: int) -> bool:
        if x < 0 or (x % 10 == 0 and x != 0):
            return False
        # 121 => 3 *100 + 2* 10 + 1
        reversedx = 0
        while reversedx < x:
            reversedx = reversedx * 10 + x % 10 # 0 1
            x = x // 10 # 1 0

        return reversedx == x or reversedx // 10 == x