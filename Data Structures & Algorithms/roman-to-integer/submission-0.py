class Solution:
    def romanToInt(self, s: str) -> int:
        sym = {'I' : 1, 'V' : 5,
                'X' : 10, 'L' : 50,
                'C' : 100, 'D' : 500,
                'M' : 1000}

        res = sym.get(s[0], 0)

        i = 1

        while i < len(s):

            prev, curr = s[i - 1], s[i]
            
            i += 1
            if ((prev == 'I' and curr == 'V') or
                (prev == 'I' and curr == 'X') or
                (prev == 'X' and curr == 'L') or
                (prev == 'X' and curr == 'C') or
                (prev == 'C' and curr == 'D') or
                (prev == 'C' and curr == 'M')):
                res += sym.get(curr, 0) - 2 * sym.get(prev, 0)
                continue

            res += sym.get(curr, 0)

        return res

