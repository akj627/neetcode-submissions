class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        min = 101
        diff = 0
        for p in prices:
            if p < min:
                min = p
            diff = max(diff, p - min)
        
        return diff