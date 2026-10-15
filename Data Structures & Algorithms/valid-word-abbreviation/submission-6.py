class Solution:
    def validWordAbbreviation(self, word: str, abbr: str) -> bool:
        i, j = 0,0
        while i < len(word) and j < len(abbr):
            if word[i] == abbr[j]:
                i, j = i + 1, j + 1
            elif abbr[j].isalpha() or abbr[j] == "0":
                return False
            else:
                num = 0
                mult = 1
                while j < len(abbr) and not abbr[j].isalpha():
                    num = mult * num + int(abbr[j])
                    mult *= 10
                    j += 1
                i += num
        if i == len(word) and j == len(abbr):
            return True
        return False
        '''a4 4,
        0,0 1,1 1,2 1,3 
        1,1
        5,2
        num, mult, i, j = 1, 10, 0, 1
        12, 100, 0, 2
        12, 100, 12, 2






        ''' 
