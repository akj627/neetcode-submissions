class Solution:

    def encode(self, strs: List[str]) -> str:
        enc = ""
        for s in strs:
            enc += f"{len(s)}#{s}" # 5#Hello5#World
        print(enc)
        return enc

    def decode(self, s: str) -> List[str]:
        num = ""
        cpos = 0
        decLen = 0
        ret = []
        while (cpos < len(s)):
            if s[cpos] == "#":
                decLen = int(num)
                #print (f"decLen {decLen}")
                selem = ""
                for i in range(0, decLen):
                    cpos += 1
                    selem += s[cpos]
                #print (f"selem {selem}")
                ret.append(selem)
                num = ""
            else:
                num += s[cpos]
            cpos += 1
            #print (f"num {num}")
        return ret