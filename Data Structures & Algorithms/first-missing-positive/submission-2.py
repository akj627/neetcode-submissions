class Solution:
    def firstMissingPositive(self, nums: List[int]) -> int:

        for i in range (len(nums)):
            if nums[i] < 0:
                nums[i] = 0

        for i in range (len(nums)):
            modi = abs(nums[i]) - 1
            if modi >= 0 and modi < len(nums):
                if nums[modi] == 0:
                    nums[modi] = - 1 - len(nums)
                else:
                    nums[modi] = - abs(nums[modi])

        for i in range (len(nums)):
            if nums[i] >= 0:
                return i + 1

        return len(nums) + 1

        