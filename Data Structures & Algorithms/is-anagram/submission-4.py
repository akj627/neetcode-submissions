class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False

        dict = {}

        for c in s:
            dict[c] = dict.get(c, 0) + 1
        #r = 0, a = 0, c = 0, e = 0
        for c in t:
            if ((c not in dict.keys()) or dict[c] == 0):
                return False

            dict[c] -= 1

        return True

        

        