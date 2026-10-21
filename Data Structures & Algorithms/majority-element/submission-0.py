class Solution:
    def majorityElement(self, nums: List[int]) -> int:
        dict = {}

        n = len(nums) // 2

        for i in nums:
            if i in dict:
                dict[i] = dict[i] + 1
            else:
                dict[i] = 1
            if dict[i] > n:
                return i

        return -1

