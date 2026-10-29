class Solution:
    def minRemoveToMakeValid(self, s: str) -> str:
        from collections import deque
        cnt = 0
        res = []
        #
        for c in s:
            if c == ')' and cnt == 0:
                continue
            if c == '(':
                cnt += 1
            elif c == ')' and cnt > 0:
                cnt -= 1
            res.append(c)

        if cnt > 0:
            for i in range(len(res) - 1, -1, -1):
                if res[i] == '(':
                    del res[i]
                    cnt -= 1
                    if cnt == 0:
                        break
        
        return "".join(res)
