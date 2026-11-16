class Solution:
    def firstUniqChar(self, s: str) -> int:
    
        set = [0] * 26

        for c in s:
            set[ord(c) - ord('a')] += 1

        for i, c in enumerate(s):
            if set[ord(c) - ord('a')] == 1:
                return i

        return -1
        