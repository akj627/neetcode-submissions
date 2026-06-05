class Solution:
    def missingNumber(self, nums: List[int]) -> int:
        xored = len(nums)

        for i, num in enumerate(nums):
            xored = xored ^ i ^ nums[i]
        
        return xored
        