class Solution:
    def maxArea(self, heights: List[int]) -> int:
        l, r = 0, len(heights) - 1
        area = 0

        while l < r:
            diff = heights[l] - heights[r]
            area = max(area, (r - l) * min(heights[l], heights[r]))#5,
            if diff < 0:
                l += 1
            else:
                r -= 1

        return area