class Solution:
    def minRemoveToMakeValid(self, s: str) -> str:
        cnt = 0
        res = []

        for c in s:
            if c == ")":
                if cnt <= 0:
                    continue;
                cnt -= 1
            elif c == "(":
                cnt += 1
                        
            res.append(c)

        filtered = []
        for c in res[::-1]:
            if c == "(" and cnt > 0:
                cnt -= 1
            else:
                filtered.append(c)
        return "".join(filtered[::-1])