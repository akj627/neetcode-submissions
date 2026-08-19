class Solution:
    def calculate(self, s: str) -> int:
        cur = prev = res = 0

        i = 0
        curr_char = '+'

        while i < len(s):

            if (s[i].isdigit()):
                while i < len(s) and s[i].isdigit():
                    cur = cur * 10 + int(s[i])
                    i += 1
                i -= 1

                if curr_char == '+':
                    res += cur
                    prev = cur
                elif curr_char == '-':
                    res -= cur
                    prev = -cur
                elif curr_char == '*':
                    res -= prev

                    res += prev * cur
                    prev = prev * cur
                else:
                    res -= prev
                    res += int (prev/cur)
                    prev = int (prev/cur)

                cur = 0
            elif s[i] != ' ':
                curr_char = s[i]

            i += 1

        return res
        