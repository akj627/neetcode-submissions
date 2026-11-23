class Solution:
    def isPalindrome(self, s: str) -> bool:
        l = 0
        r = len(s) - 1
        while l < r:
            while l < r and not self.isAlpha(s[l]):
                l += 1
            while l < r and not self.isAlpha(s[r]):
                r -= 1
            if s[l].lower() != s[r].lower():
                return False
            l += 1
            r -= 1
        return True

    @staticmethod
    def isAlpha(c):
        if ((ord(c) >= ord('a') and ord(c) <= ord('z')) or 
            (ord(c) >= ord('A') and ord(c) <= ord('Z')) or
            (ord(c) >= ord('0') and ord(c) <= ord('9'))):
            return True

        return False