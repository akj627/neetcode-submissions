class Solution:
    def isPalindrome(self, x: int) -> bool:
        if x < 0:
            return False
        num = x
        # 121 => 3 *100 + 2* 10 + 1
        reversedx = 0
        while x > 0:
            reversedx = reversedx * 10 + x % 10 # 3
            x = x // 10 # 12

        return reversedx == num