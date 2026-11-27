class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        dn = {}

        for i in range(len(nums)):
            if nums[i] in dn.keys():
                return [dn[nums[i]], i]
            dn[target - nums[i]] = i
        