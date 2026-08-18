class Solution:
    def isValid(self, s: str) -> bool:
        charP = {")":"(",
        "}":"{",
        "]":"["
        }
        
        stk = []

        for c in s:
            if c in charP:
                if stk and stk[-1] == charP[c]:
                    stk.pop()
                else:
                    return False
            else:
                stk.append(c)
            
        if stk:
            return False
        else:
            return True

