class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        profit = 0
        minPrice = prices[0]

        for i, p in enumerate(prices):
            minPrice = min(minPrice, p)

            profit = max(profit, p - minPrice)
        return profit