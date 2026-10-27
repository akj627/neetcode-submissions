class Solution:
    def findMaxConsecutiveOnes(self, nums: List[int]) -> int:
        cnt = 0
        sum = 0

        for i in nums:
            if i == 0:
                sum = max(sum, cnt)
                cnt = 0
            else:
                cnt += 1
        
        sum = max(sum, cnt)
        return sum