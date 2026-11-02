class Solution:
    def heightChecker(self, heights: List[int]) -> int:
        sh = sorted(heights)
        cnt = 0
        for i, h in enumerate(heights):
            if sh[i] != h:
                cnt += 1

        return cnt