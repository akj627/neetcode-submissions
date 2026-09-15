class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        sdict = {}

        if len(s) != len(t):
            return False

        for c in s:
            sdict[c] = sdict.get(c, 0) + 1

        for ch in t:
            if ch not in sdict or sdict[ch] == 0:
                return False
            sdict[ch] = sdict[ch] - 1

        return True
