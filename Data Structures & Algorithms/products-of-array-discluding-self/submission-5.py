class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        # 1    1   2   8   24
        # 48  48   24  6    1

        # 48 24 12 8

        suffix = 1
        res = [1] * len(nums)
        for i in range(1, len(nums)):
            res[i] = res[i - 1] *  nums[i - 1]
        for i in range(len(nums) - 2, - 1, -1):
            suffix *= nums[i+1]
            res[i] = res[i] * suffix
        return res